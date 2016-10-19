using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUnpack
{
    public partial class FormMain : Form
    {
        private const string FoldersSettingsFile = "folders.txt";
        private const string IgnoreSettingsFile = "ignore.txt";

        private readonly List<string> _ignoreEndings = new List<string>();
        private List<SfvFile> _sfvFiles;

        private bool _working;

        public FormMain()
        {
            InitializeComponent();
        }

        private List<SfvFile> ValidSfvFile
        {
            get
            {
                return
                    _sfvFiles.Where(
                            sf =>
                                !sf.Hidden && (sf.Files.Count > 0) &&
                                !_ignoreEndings.Any(i => sf.Filepath.EndsWith(i)))
                        .ToList();
            }
        }

        private bool Working
        {
            get { return _working; }
            set
            {
                _working = value;
                btnScan.Enabled = !value;
                btnUnpack.Enabled = !value;
            }
        }

        public void UpdateIgnoreEndings()
        {
            _ignoreEndings.Clear();
            foreach (string lbIgnoreItem in lbIgnore.Items)
                _ignoreEndings.Add(lbIgnoreItem);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (Working)
                return;

            Working = true;

            Task.Run(() =>
            {
                SetStatusSafe("Scanning folders...");
                _sfvFiles = new List<SfvFile>();
                foreach (string folderPath in lstFolders.Items)
                    _sfvFiles.AddRange(
                        Directory.GetFiles(folderPath, "*.sfv",
                                chkScanSubdirs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                            .Select(s => new SfvFile(s)));

                if (lstFolders.InvokeRequired)
                    lstFolders.Invoke(new Action(() =>
                    {
                        ListSfvFiles();
                        Working = false;
                    }));
                else
                {
                    ListSfvFiles();
                    Working = false;
                }


                SetStatusSafe("Done");
            });
        }

        public void ListSfvFiles()
        {
            var files = ValidSfvFile;
            pbScan.Maximum = files.Count;
            pbScan.Value = 0;

            pbUnpack.Maximum = files.Count;
            pbUnpack.Value = 0;

            tvFiles.Nodes.Clear();
            foreach (var sfvFile in files)
            {
                var treeNode = new TreeNode
                {
                    Name = sfvFile.Filepath,
                    Text = sfvFile.Name,
                    Tag = sfvFile,
                    ForeColor = sfvFile.AllFilesOk ? Color.DarkGreen : Color.DarkRed
                };

                treeNode.Nodes.AddRange(
                    sfvFile.Files.Select(
                        f => new TreeNode(f.Path)
                        {
                            ForeColor = f.IsOk() ? Color.DarkGreen : Color.DarkRed
                        }).ToArray());

                tvFiles.Nodes.Add(treeNode);
                pbScan.Value++;
            }
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            if (Working)
                return;

            Working = true;

            Task.Run(() =>
            {
                var rowCount = 1;
                var validSflFiles = ValidSfvFile;
                foreach (var sfvFile in validSflFiles)
                    try
                    {
                        if (!sfvFile.AllFilesOk)
                            continue;

                        Log($"[{rowCount++}/{validSflFiles.Count}] Working {sfvFile.Name} ");


                        var totalSize = sfvFile.Files.Sum(f => f.Info.Length);

                        var rarArchive = new RarArchive(sfvFile.Files.Select(f => f.Path));

                        rarArchive.CompressedBytesRead += (o, args) =>
                        {
                            var percent = args.CompressedBytesRead/(decimal) totalSize*100;
                            SetStatusSafe($"Unpacking {sfvFile.Name} ...", (int) percent);
                        };

                        rarArchive.UnpackAll(new RarArchive.UnpackOptions
                        {
                            DeleteArchiveOnSuccess = chkUnpackDelete.Checked
                        });

                        if (chkUnpackDelete.Checked)
                        {
                            File.Delete(sfvFile.Filepath);
                            Log(" ... deleted!", true);
                        }
                        else
                        {
                            Log(" ... done!", true);
                        }

                        sfvFile.Hidden = true;
                    }
                    catch (Exception ex)
                    {
                        Log($"Un expected error: {ex.Message}");
                    }
                    finally
                    {
                        if (pbUnpack.InvokeRequired)
                            pbUnpack.Invoke(new Action(() => pbUnpack.Value++));
                        else
                            pbUnpack.Value++;
                    }

                SetStatusSafe($"Done unpacking");

                if (lstFolders.InvokeRequired)
                    lstFolders.Invoke(new Action(ListSfvFiles));
                else
                    ListSfvFiles();

                if (InvokeRequired)
                    Invoke(new Action(() => { Working = false; }));
                else
                    Working = false;
            });
        }

        public void Log(string message, bool append = false)
        {
            if (lbLog.InvokeRequired)
                Invoke(new Action(() =>
                {
                    if (append) lbLog.Items[lbLog.Items.Count - 1] += message;
                    else lbLog.Items.Add(message);
                }));
            else
            {
                if (append) lbLog.Items[lbLog.Items.Count - 1] += message;
                else lbLog.Items.Add(message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDefaultProfile();
        }

        private void lstFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsRemoveFolder.Enabled = lstFolders.SelectedItems.Count > 0;
        }

        private void lbIgnore_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsRemoveIgnore.Enabled = lbIgnore.SelectedItems.Count > 0;
        }

        private void tsAddFolder_Click(object sender, EventArgs e)
        {
            if ((fbdSelectBase.ShowDialog() == DialogResult.OK) &&
                !lstFolders.Items.Contains(fbdSelectBase.SelectedPath))
                lstFolders.Items.Add(fbdSelectBase.SelectedPath);
        }

        private void tsAddIgnore_Click(object sender, EventArgs e)
        {
            var frmInput = new FormInput();
            if ((frmInput.ShowDialog() == DialogResult.OK) && !lbIgnore.Items.Contains(frmInput.Value))
                lbIgnore.Items.Add(frmInput.Value);

            UpdateIgnoreEndings();
        }

        private void tsRemoveIgnore_Click(object sender, EventArgs e)
        {
            lbIgnore.Items.Remove(lbIgnore.SelectedItem);
            UpdateIgnoreEndings();
        }

        private void tsRemoveFolder_Click(object sender, EventArgs e)
        {
            lstFolders.Items.Remove(lstFolders.SelectedItem);
        }

        private void btnSaveDefault_Click(object sender, EventArgs e)
        {
            SaveDefaultProfile();
        }

        public void LoadDefaultProfile()
        {
            lstFolders.Items.Clear();
            if (File.Exists(FoldersSettingsFile))
                lstFolders.Items.AddRange(File.ReadAllLines(FoldersSettingsFile));

            lbIgnore.Items.Clear();
            if (File.Exists(IgnoreSettingsFile))
                lbIgnore.Items.AddRange(File.ReadAllLines(IgnoreSettingsFile));

            UpdateIgnoreEndings();
        }

        public void SaveDefaultProfile()
        {
            File.WriteAllLines(IgnoreSettingsFile, lbIgnore.Items.Cast<string>());
            File.WriteAllLines(FoldersSettingsFile, lstFolders.Items.Cast<string>());
        }

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            LoadDefaultProfile();
        }

        #region Set Status

        public void SetStatus(string message, int value = 100, int maxValue = 100)
        {
            tssArchiveProgress.Text = message;
            pbArchiveProgress.Value = value;
            pbArchiveProgress.Maximum = maxValue;
        }

        public void SetStatusSafe(string message, int value = 100, int maxValue = 100)
        {
            if (ssMain.InvokeRequired)
                ssMain.Invoke(new Action(() => { SetStatus(message, value, maxValue); }));
            else
                SetStatus(message, value, maxValue);
        }

        #endregion
    }
}