using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F3KoreanPatcher {
    public partial class MainForm : Form {
        #region WIN32 DLL
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion

        string gameName = "Fallout 3";
        string defalutSteamLibrary = @"C:\Program Files (x86)\Steam\steamapps\common\Fallout 3";
        string fileName = "Fallout3.exe";
        private string dataPath = $"{Application.StartupPath}\\KoreanData\\";

        string fommLocation = "fomm\\fomm.exe";

        public MainForm() {
            InitializeComponent();
        }

        private void btn_dirFInd_Click(object sender, EventArgs e) {
            using (var fb = new FolderBrowserDialog()) {
                DialogResult result = fb.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath)) {
                    if (CheckFileExists(fb.SelectedPath, fileName)) {
                        MessageBox.Show($"{gameName} 파일이 존재합니다. 한글 패치를 실행하여 주십시오.", "한글 패치 가능");
                    }
                    else {
                        MessageBox.Show($"{gameName} 파일이 존재하지 않습니다. 정확한 게임 디렉토리를 선택하여 주십시오.", "정확한 디렉토리 선택");
                        return;
                    }

                    text_dirctory.Text = fb.SelectedPath;
                    btn_copyData.Enabled = true;

                }
            }
        }

        private void btn_defaultLocation_Click(object sender, EventArgs e) {
            string df = defalutSteamLibrary;
            if (CheckFileExists(df, fileName)) {
                MessageBox.Show($"{gameName} 실행 파일이 존재합니다. 한글 패치를 실행하여 주십시오.", "한글 패치 가능");
            }
            else {
                MessageBox.Show($"{gameName} 실행 파일이 존재하지 않습니다. \r\n정확한 게임 디렉토리를 선택하여 주십시오.", "정확한 디렉토리 선택");
                return;
            }

            text_dirctory.Text = df;
            btn_copyData.Enabled = true;
        }

        private void btn_copyData_Click(object sender, EventArgs e) {
            try {
                if (CopyFolder(dataPath, text_dirctory.Text)) {
                    btn_settingINI_Click(sender, e);
                    MessageBox.Show($"{gameName} 한글 패치 데이터 복사및 INI 파일 수정이 완료되었습니다.\r\n다음 단계로 진행하세요.", "한글 패치 데이터 복사 완료");
                    //btn_settingINI.Enabled = true;
                    btn_fommExecute.Enabled = true;
                }
                else {
                    MessageBox.Show($"{gameName} 한글 패치 데이터 복사가 실패하였습니다.", "한글 패치 데이터 복사 실패");
                    return;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"{gameName} 한글 패치 데이터 복사가 실패하였습니다. \r\n에러 원문 :\r\n{ex.Message}", "한글 패치 데이터 복사 실패");

            }
        }

        private void btn_homepage_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://mos6502.tistory.com/");
        }


        private void btn_settingINI_Click(object sender, EventArgs e) {
            string docDirctory = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\My Games\\Fallout3";
            string file = "FALLOUT.INI";
            try {
                if (CheckFileExists(docDirctory, file)) {
                    WritePrivateProfileString("Archive", "bInvalidateOlderFiles", "1", $"{docDirctory}\\{file}");
                   // MessageBox.Show("bInvalidateOlderFiles 값 변경에 성공하였습니다.\r\n다음 단계로 진행하세요.", "설정 적용 완료");
                    btn_fommExecute.Enabled = true;
                }
                else {
                    MessageBox.Show("데이터 경로에 FALLOUT.INI 파일이 존재하지 않습니다.\r\n게임을 최소 1회 이상 실행시켜야합니다.", "에러");
                    return;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "에러");
            }
        }

        private void btn_fommExecute_Click(object sender, EventArgs e) {
            string path = $"{text_dirctory.Text}\\{fommLocation}";
            try {
                RunProcess(path);
                MessageBox.Show("설정대로 하셨다면 한글 패치는 완료되었습니다.", "패치 완료");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "에러");
            }
        }

        #region Functions
        private bool CheckDirectory(string path) {
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists) {
                return true;
            }
            else {
                return false;
            }
        }

        private bool CheckFileExists(string path, string fileName) {
            string strFile = $"{path}\\{fileName}";
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

        private int RunProcess(string FileName, string Args = "") {
            try {
                Process p = new Process();

                p.StartInfo.FileName = FileName;
                p.StartInfo.Arguments = Args;

                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

                p.Start();
                p.WaitForExit();

                return p.ExitCode;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        #endregion


    }
}
