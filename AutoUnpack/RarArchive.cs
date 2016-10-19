using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpCompress.Common;
using SharpCompress.Readers;
using SharpCompress.Readers.Rar;

namespace AutoUnpack
{
    public class RarArchive
    {
        public RarArchive(IEnumerable<string> archiveFiles)
        {
            ArchiveFiles = archiveFiles;
        }

        public IEnumerable<string> ArchiveFiles { get; set; }

        public void UnpackAll(UnpackOptions options = null)
        {
            options = options ?? new UnpackOptions();

            if (!ArchiveFiles.Any())
                return;

            options.DestinationDirectory = string.IsNullOrWhiteSpace(options.DestinationDirectory)
                ? Path.GetDirectoryName(ArchiveFiles.First())
                : options.DestinationDirectory;

            var fileStream = ArchiveFiles
                .Select(File.OpenRead)
                .ToList();

            using (var reader = RarReader.Open(fileStream))
            {
                reader.CompressedBytesRead += CompressedBytesRead;
                reader.EntryExtractionBegin += EntryExtractionBegin;
                reader.EntryExtractionEnd += EntryExtractionEnd;
                reader.FilePartExtractionBegin += FilePartExtractionBegin;

                reader.WriteAllToDirectory(options.DestinationDirectory, new ExtractionOptions
                {
                    ExtractFullPath = true,
                    Overwrite = options.Overwrite
                });

                if (options.DeleteArchiveOnSuccess)
                {
                    foreach (var file in ArchiveFiles)
                        File.Delete(file);
                }

                foreach (var stream in fileStream)
                {
                    stream.Close();
                    stream.Dispose();
                }
            }
        }

        public event EventHandler<CompressedBytesReadEventArgs> CompressedBytesRead;
        public event EventHandler<ReaderExtractionEventArgs<IEntry>> EntryExtractionBegin;
        public event EventHandler<ReaderExtractionEventArgs<IEntry>> EntryExtractionEnd;
        public event EventHandler<FilePartExtractionBeginEventArgs> FilePartExtractionBegin;

        public class UnpackOptions
        {
            public string DestinationDirectory { get; set; }
            public bool Overwrite { get; set; } = true;
            public bool DeleteArchiveOnSuccess { get; set; } = true;
        }
    }
}