using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F3KoreanPatcher {
    static class Program {
        private static string dataPath = $"{Application.StartupPath}\\KoreanData\\fomm\\fomm.exe";


        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (CheckFileExists(dataPath)) {
                Application.Run(new MainForm());
            }
            else {
                MessageBox.Show("KoreanData 폴더가 존재하지 않습니다. \r\nPatcher를 다시 다운로드 하십시오.", "데이터 오류");
                Environment.Exit(0);
            }
        }

        private static bool CheckFileExists(string path) {
            string strFile = path;
            FileInfo fileInfo = new FileInfo(strFile);

            if (fileInfo.Exists) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
