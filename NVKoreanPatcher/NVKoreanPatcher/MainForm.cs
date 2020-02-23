using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NVKoreanPatcher {
    public partial class MainForm : Form {
        string gameName = "FallOut - New Vegas";
        string defalutSteamLibrary = @"C:\Program Files (x86)\Steam\steamapps\common\Fallout New Vegas";
        string fileName = "\\FalloutNV.exe";
        private string dataPath = $"{Application.StartupPath}\\KoreanData\\";

        public MainForm() {
            InitializeComponent();
        }

        private void btn_dirFInd_Click(object sender, EventArgs e) {
            using (var fb = new FolderBrowserDialog()) {
                DialogResult result = fb.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath)) {
                    if (CheckFileExists(fb.SelectedPath)) {
                        MessageBox.Show($"{gameName} 파일이 존재합니다. 한글 패치를 실행하여 주십시오.", "한글 패치 가능");
                    }
                    else {
                        MessageBox.Show($"{gameName} 파일이 존재하지 않습니다. 정확한 게임 디렉토리를 선택하여 주십시오.", "정확한 디렉토리 선택");
                        return;
                    }

                    text_dirctory.Text = fb.SelectedPath;
                    btn_startLocalization.Enabled = true;

                }
            }
        }

        private void btn_defaultLocation_Click(object sender, EventArgs e) {
            string df = defalutSteamLibrary;
            if (CheckFileExists(df)) {
                MessageBox.Show($"{gameName} 실행 파일이 존재합니다. 한글 패치를 실행하여 주십시오.", "한글 패치 가능");
            }
            else {
                MessageBox.Show($"{gameName} 실행 파일이 존재하지 않습니다. \r\n정확한 게임 디렉토리를 선택하여 주십시오.", "정확한 디렉토리 선택");
                return;
            }

            text_dirctory.Text = df;
            btn_startLocalization.Enabled = true;
        }

        private void btn_startLocalization_Click(object sender, EventArgs e) {
            if (CopyFolder(dataPath, text_dirctory.Text)) {
                MessageBox.Show($"{gameName} 한글 패치가 완료되었습니다.", "한글 패치 완료");
            }
            else {
                MessageBox.Show($"{gameName} 한글 패치가 실패하였습니다.", "한글 패치 실패");
            }
        }

        private void btn_homepage_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://mos6502.tistory.com/");
        }

        private bool CheckDirectory(string path) {
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists) {
                return true;
            }
            else {
                return false;
            }
        }

        private bool CheckFileExists(string path) {
            string strFile = path + fileName;
            FileInfo fileInfo = new FileInfo(strFile);

            if (fileInfo.Exists) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool CopyFolder(string sourceFolder, string destFolder) {
            try {
                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);

                string[] files = Directory.GetFiles(sourceFolder);
                string[] folders = Directory.GetDirectories(sourceFolder);

                foreach (string file in files) {
                    string name = Path.GetFileName(file);
                    string dest = Path.Combine(destFolder, name);
                    File.Copy(file, dest, true);
                }

                foreach (string folder in folders) {
                    string name = Path.GetFileName(folder);
                    string dest = Path.Combine(destFolder, name);
                    CopyFolder(folder, dest);
                }
                return true;
            }
            catch (Exception ex) {
                return false;
            }

        }
    }
}
