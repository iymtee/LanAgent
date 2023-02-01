namespace Сервер
{
    partial class FrmDetable2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxProcess = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblNetName = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxDrive = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbcScr = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcScr)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbxProcess);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblUserName);
            this.tabPage1.Controls.Add(this.lblNetName);
            this.tabPage1.Controls.Add(this.lblIp);
            this.tabPage1.Controls.Add(this.lblDateTime);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общая информация и список процессов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbxProcess
            // 
            this.tbxProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxProcess.Location = new System.Drawing.Point(445, 51);
            this.tbxProcess.Multiline = true;
            this.tbxProcess.Name = "tbxProcess";
            this.tbxProcess.ReadOnly = true;
            this.tbxProcess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxProcess.Size = new System.Drawing.Size(336, 362);
            this.tbxProcess.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Список процессов:";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.LawnGreen;
            this.lblUserName.Location = new System.Drawing.Point(161, 137);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(258, 23);
            this.lblUserName.TabIndex = 7;
            // 
            // lblNetName
            // 
            this.lblNetName.BackColor = System.Drawing.Color.LawnGreen;
            this.lblNetName.Location = new System.Drawing.Point(123, 92);
            this.lblNetName.Name = "lblNetName";
            this.lblNetName.Size = new System.Drawing.Size(296, 23);
            this.lblNetName.TabIndex = 6;
            // 
            // lblIp
            // 
            this.lblIp.BackColor = System.Drawing.Color.LawnGreen;
            this.lblIp.Location = new System.Drawing.Point(161, 54);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(258, 23);
            this.lblIp.TabIndex = 5;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.LawnGreen;
            this.lblDateTime.Location = new System.Drawing.Point(246, 17);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(173, 23);
            this.lblDateTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сетевое имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP - адрес клиента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата и время отправки данных:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxDrive);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Информация о дисках";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxDrive
            // 
            this.tbxDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDrive.Location = new System.Drawing.Point(3, 3);
            this.tbxDrive.Multiline = true;
            this.tbxDrive.Name = "tbxDrive";
            this.tbxDrive.ReadOnly = true;
            this.tbxDrive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxDrive.Size = new System.Drawing.Size(786, 415);
            this.tbxDrive.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pbcScr);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Снимок экрана";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbcScr
            // 
            this.pbcScr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbcScr.Location = new System.Drawing.Point(3, 3);
            this.pbcScr.Name = "pbcScr";
            this.pbcScr.Size = new System.Drawing.Size(786, 415);
            this.pbcScr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcScr.TabIndex = 0;
            this.pbcScr.TabStop = false;
            // 
            // FrmDetable2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDetable2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детальная информация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetable2_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcScr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TextBox tbxProcess;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label lblNetName;
        public System.Windows.Forms.Label lblIp;
        public System.Windows.Forms.Label lblDateTime;
        public System.Windows.Forms.TextBox tbxDrive;
        public System.Windows.Forms.PictureBox pbcScr;
    }
}