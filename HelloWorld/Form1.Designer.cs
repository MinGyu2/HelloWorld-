namespace HelloWorld {
    partial class Form1 {
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
            this.btClick = new System.Windows.Forms.Button();
            this.lbhello = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btClick
            // 
            this.btClick.Location = new System.Drawing.Point(239, 165);
            this.btClick.Name = "btClick";
            this.btClick.Size = new System.Drawing.Size(306, 97);
            this.btClick.TabIndex = 0;
            this.btClick.Text = "버튼1";
            this.btClick.UseVisualStyleBackColor = true;
            this.btClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbhello
            // 
            this.lbhello.AutoSize = true;
            this.lbhello.Location = new System.Drawing.Point(237, 126);
            this.lbhello.Name = "lbhello";
            this.lbhello.Size = new System.Drawing.Size(38, 12);
            this.lbhello.TabIndex = 1;
            this.lbhello.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 21);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbhello);
            this.Controls.Add(this.btClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClick;
        private System.Windows.Forms.Label lbhello;
        private System.Windows.Forms.TextBox textBox1;
    }
}

