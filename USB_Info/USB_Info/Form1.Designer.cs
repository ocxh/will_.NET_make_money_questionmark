namespace USB_Info
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_prt = new System.Windows.Forms.Button();
            this.lb_Info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_prt
            // 
            this.btn_prt.Location = new System.Drawing.Point(304, 367);
            this.btn_prt.Name = "btn_prt";
            this.btn_prt.Size = new System.Drawing.Size(177, 45);
            this.btn_prt.TabIndex = 0;
            this.btn_prt.Text = "prt Info";
            this.btn_prt.UseVisualStyleBackColor = true;
            this.btn_prt.Click += new System.EventHandler(this.btn_prt_Click_1);
            // 
            // lb_Info
            // 
            this.lb_Info.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Info.FormattingEnabled = true;
            this.lb_Info.ItemHeight = 12;
            this.lb_Info.Location = new System.Drawing.Point(170, 81);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(452, 220);
            this.lb_Info.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.btn_prt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_prt;
        private System.Windows.Forms.ListBox lb_Info;
    }
}

