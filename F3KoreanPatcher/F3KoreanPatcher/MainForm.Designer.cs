namespace F3KoreanPatcher {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.text_dirctory = new System.Windows.Forms.TextBox();
            this.btn_dirFInd = new System.Windows.Forms.Button();
            this.btn_copyData = new System.Windows.Forms.Button();
            this.btn_defaultLocation = new System.Windows.Forms.Button();
            this.btn_homepage = new System.Windows.Forms.Button();
            this.btn_settingINI = new System.Windows.Forms.Button();
            this.btn_fommExecute = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "파일 경로 (Fallout3 폴더의 경로)";
            // 
            // text_dirctory
            // 
            this.text_dirctory.Location = new System.Drawing.Point(12, 162);
            this.text_dirctory.Name = "text_dirctory";
            this.text_dirctory.ReadOnly = true;
            this.text_dirctory.Size = new System.Drawing.Size(356, 21);
            this.text_dirctory.TabIndex = 2;
            // 
            // btn_dirFInd
            // 
            this.btn_dirFInd.Location = new System.Drawing.Point(374, 161);
            this.btn_dirFInd.Name = "btn_dirFInd";
            this.btn_dirFInd.Size = new System.Drawing.Size(65, 23);
            this.btn_dirFInd.TabIndex = 3;
            this.btn_dirFInd.Text = "찾기";
            this.btn_dirFInd.UseVisualStyleBackColor = true;
            this.btn_dirFInd.Click += new System.EventHandler(this.btn_dirFInd_Click);
            // 
            // btn_copyData
            // 
            this.btn_copyData.Enabled = false;
            this.btn_copyData.Location = new System.Drawing.Point(12, 196);
            this.btn_copyData.Name = "btn_copyData";
            this.btn_copyData.Size = new System.Drawing.Size(426, 42);
            this.btn_copyData.TabIndex = 4;
            this.btn_copyData.Text = "1. 한글 패치 데이터 복사 및 FALLOUT.INI 파일 수정";
            this.btn_copyData.UseVisualStyleBackColor = true;
            this.btn_copyData.Click += new System.EventHandler(this.btn_copyData_Click);
            // 
            // btn_defaultLocation
            // 
            this.btn_defaultLocation.Location = new System.Drawing.Point(296, 131);
            this.btn_defaultLocation.Name = "btn_defaultLocation";
            this.btn_defaultLocation.Size = new System.Drawing.Size(143, 24);
            this.btn_defaultLocation.TabIndex = 5;
            this.btn_defaultLocation.Text = "스팀 기본 경로 탐색";
            this.btn_defaultLocation.UseVisualStyleBackColor = true;
            this.btn_defaultLocation.Click += new System.EventHandler(this.btn_defaultLocation_Click);
            // 
            // btn_homepage
            // 
            this.btn_homepage.Location = new System.Drawing.Point(17, 97);
            this.btn_homepage.Name = "btn_homepage";
            this.btn_homepage.Size = new System.Drawing.Size(78, 23);
            this.btn_homepage.TabIndex = 6;
            this.btn_homepage.Text = "홈페이지";
            this.btn_homepage.UseVisualStyleBackColor = true;
            this.btn_homepage.Click += new System.EventHandler(this.btn_homepage_Click);
            // 
            // btn_settingINI
            // 
            this.btn_settingINI.Enabled = false;
            this.btn_settingINI.Location = new System.Drawing.Point(12, 244);
            this.btn_settingINI.Name = "btn_settingINI";
            this.btn_settingINI.Size = new System.Drawing.Size(426, 42);
            this.btn_settingINI.TabIndex = 7;
            this.btn_settingINI.Text = "2. bInvalidateOlderFiles 수정";
            this.btn_settingINI.UseVisualStyleBackColor = true;
            this.btn_settingINI.Visible = false;
            this.btn_settingINI.Click += new System.EventHandler(this.btn_settingINI_Click);
            // 
            // btn_fommExecute
            // 
            this.btn_fommExecute.Enabled = false;
            this.btn_fommExecute.Location = new System.Drawing.Point(12, 244);
            this.btn_fommExecute.Name = "btn_fommExecute";
            this.btn_fommExecute.Size = new System.Drawing.Size(426, 42);
            this.btn_fommExecute.TabIndex = 9;
            this.btn_fommExecute.Text = "2. FOMM 실행";
            this.btn_fommExecute.UseVisualStyleBackColor = true;
            this.btn_fommExecute.Click += new System.EventHandler(this.btn_fommExecute_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F3KoreanPatcher.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 295);
            this.Controls.Add(this.btn_fommExecute);
            this.Controls.Add(this.btn_settingINI);
            this.Controls.Add(this.btn_homepage);
            this.Controls.Add(this.btn_defaultLocation);
            this.Controls.Add(this.btn_copyData);
            this.Controls.Add(this.btn_dirFInd);
            this.Controls.Add(this.text_dirctory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fallout 3 Korean Patcher V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_dirctory;
        private System.Windows.Forms.Button btn_dirFInd;
        private System.Windows.Forms.Button btn_copyData;
        private System.Windows.Forms.Button btn_defaultLocation;
        private System.Windows.Forms.Button btn_homepage;
        private System.Windows.Forms.Button btn_settingINI;
        private System.Windows.Forms.Button btn_fommExecute;
    }
}

