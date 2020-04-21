namespace ChamSocVaGuiXe
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account Login";
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.Location = new System.Drawing.Point(147, 170);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(213, 29);
            this.txbPassWord.TabIndex = 14;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(147, 118);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(213, 29);
            this.txbUserName.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChamSocVaGuiXe.Properties.Resources.User_Login_Image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.Location = new System.Drawing.Point(20, 173);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(106, 24);
            this.lblPassWord.TabIndex = 11;
            this.lblPassWord.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(13, 118);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(111, 24);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "Username:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btLogin.FlatAppearance.BorderSize = 2;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(67, 218);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(85, 45);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(398, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPassWord);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btLogin;
    }
}

