using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutoUnpack
{
    public class SfvFile
    {
        public SfvFile(string filepath)
        {
            Filepath = filepath;
            Name = Path.GetFileNameWithoutExtension(filepath);
            SfvData = File.ReadAllLines(filepath);

            foreach (var fileRow in SfvData)
            {
                var fileInfo = fileRow.Split(' ');
                if (fileInfo.Length >= 2)
                    Files.Add(new FileToVerify
                    {
                        Path = $@"{Path.GetDirectoryName(filepath)}\{fileInfo[0]}",
                        Checksum = fileInfo[1]
                    });
            }

            Files = Files.OrderByDescending(f => f.Path.EndsWith(".rar")).ThenBy(f => f.Path).ToList();
        }

        private string[] SfvData { get; }

        public bool Hidden { get; set; }
        public string Filepath { get; set; }
        public string Name { get; set; }
        public List<FileToVerify> Files { get; set; } = new List<FileToVerify>();
        public bool AllFilesOk => Files.All(f => f.IsOk());

        public class FileToVerify
        {
            public string Path { get; set; }
            public string Checksum { get; set; }
            public FileInfo Info => new FileInfo(Path);

            public bool IsOk()
            {
                return File.Exists(Path);
            }
        }
    }
}