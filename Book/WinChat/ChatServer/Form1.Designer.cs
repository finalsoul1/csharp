namespace ChatServer
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
            this.cmd_Start = new System.Windows.Forms.Button();
            this.Ibl_Message = new System.Windows.Forms.Label();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_Start
            // 
            this.cmd_Start.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmd_Start.Location = new System.Drawing.Point(24, 18);
            this.cmd_Start.Name = "cmd_Start";
            this.cmd_Start.Size = new System.Drawing.Size(131, 63);
            this.cmd_Start.TabIndex = 0;
            this.cmd_Start.Text = "Server Start";
            this.cmd_Start.UseVisualStyleBackColor = true;
            this.cmd_Start.Click += new System.EventHandler(this.cmd_Start_Click);
            // 
            // Ibl_Message
            // 
            this.Ibl_Message.AutoSize = true;
            this.Ibl_Message.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ibl_Message.Location = new System.Drawing.Point(186, 39);
            this.Ibl_Message.Name = "Ibl_Message";
            this.Ibl_Message.Size = new System.Drawing.Size(77, 16);
            this.Ibl_Message.TabIndex = 1;
            this.Ibl_Message.Tag = "Stop";
            this.Ibl_Message.Text = "서버 닫힘";
            // 
            // txt_Chat
            // 
            this.txt_Chat.Location = new System.Drawing.Point(26, 118);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Chat.Size = new System.Drawing.Size(391, 200);
            this.txt_Chat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "0명 참가중";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(444, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.Ibl_Message);
            this.Controls.Add(this.cmd_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Start;
        private System.Windows.Forms.Label Ibl_Message;
        private System.Windows.Forms.TextBox txt_Chat;
        private System.Windows.Forms.Label label1;
    }
}

