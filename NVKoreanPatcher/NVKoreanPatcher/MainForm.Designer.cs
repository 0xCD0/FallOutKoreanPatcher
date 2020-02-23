namespace NVKoreanPatcher {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_dirctory = new System.Windows.Forms.TextBox();
            this.btn_dirFInd = new System.Windows.Forms.Button();
            this.btn_startLocalization = new System.Windows.Forms.Button();
            this.btn_defaultLocation = new System.Windows.Forms.Button();
            this.btn_homepage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NVKoreanPatcher.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "파일 경로 (Fallout - New Vegas 폴더의 경로)";
            // 
            // text_dirctory
            // 
            this.text_dirctory.Location = new System.Drawing.Point(12, 188);
            this.text_dirctory.Name = "text_dirctory";
            this.text_dirctory.ReadOnly = true;
            this.text_dirctory.Size = new System.Drawing.Size(356, 21);
            this.text_dirctory.TabIndex = 2;
            // 
            // btn_dirFInd
            // 
            this.btn_dirFInd.Location = new System.Drawing.Point(374, 187);
            this.btn_dirFInd.Name = "btn_dirFInd";
            this.btn_dirFInd.Size = new System.Drawing.Size(65, 23);
            this.btn_dirFInd.TabIndex = 3;
            this.btn_dirFInd.Text = "찾기";
            this.btn_dirFInd.UseVisualStyleBackColor = true;
            this.btn_dirFInd.Click += new System.EventHandler(this.btn_dirFInd_Click);
            // 
            // btn_startLocalization
            // 
            this.btn_startLocalization.Enabled = false;
            this.btn_startLocalization.Location = new System.Drawing.Point(13, 222);
            this.btn_startLocalization.Name = "btn_startLocalization";
            this.btn_startLocalization.Size = new System.Drawing.Size(426, 42);
            this.btn_startLocalization.TabIndex = 4;
            this.btn_startLocalization.Text = "한글 패치 시작";
            this.btn_startLocalization.UseVisualStyleBackColor = true;
            this.btn_startLocalization.Click += new System.EventHandler(this.btn_startLocalization_Click);
            // 
            // btn_defaultLocation
            // 
            this.btn_defaultLocation.Location = new System.Drawing.Point(296, 157);
            this.btn_defaultLocation.Name = "btn_defaultLocation";
            this.btn_defaultLocation.Size = new System.Drawing.Size(143, 24);
            this.btn_defaultLocation.TabIndex = 5;
            this.btn_defaultLocation.Text = "스팀 기본 경로 탐색";
            this.btn_defaultLocation.UseVisualStyleBackColor = true;
            this.btn_defaultLocation.Click += new System.EventHandler(this.btn_defaultLocation_Click);
            // 
            // btn_homepage
            // 
            this.btn_homepage.Location = new System.Drawing.Point(357, 121);
            this.btn_homepage.Name = "btn_homepage";
            this.btn_homepage.Size = new System.Drawing.Size(78, 23);
            this.btn_homepage.TabIndex = 6;
            this.btn_homepage.Text = "홈페이지";
            this.btn_homepage.UseVisualStyleBackColor = true;
            this.btn_homepage.Click += new System.EventHandler(this.btn_homepage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 275);
            this.Controls.Add(this.btn_homepage);
            this.Controls.Add(this.btn_defaultLocation);
            this.Controls.Add(this.btn_startLocalization);
            this.Controls.Add(this.btn_dirFInd);
            this.Controls.Add(this.text_dirctory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Vegas Korean Patcher V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_dirctory;
        private System.Windows.Forms.Button btn_dirFInd;
        private System.Windows.Forms.Button btn_startLocalization;
        private System.Windows.Forms.Button btn_defaultLocation;
        private System.Windows.Forms.Button btn_homepage;
    }
}

