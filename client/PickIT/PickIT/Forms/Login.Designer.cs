namespace PickIT
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_loginUsername = new System.Windows.Forms.Label();
            this.lbl_loginPassword = new System.Windows.Forms.Label();
            this.btn_loginGetEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lbl_loginUsername
            // 
            this.lbl_loginUsername.AutoSize = true;
            this.lbl_loginUsername.Location = new System.Drawing.Point(67, 56);
            this.lbl_loginUsername.Name = "lbl_loginUsername";
            this.lbl_loginUsername.Size = new System.Drawing.Size(58, 13);
            this.lbl_loginUsername.TabIndex = 2;
            this.lbl_loginUsername.Text = "Username:";
            // 
            // lbl_loginPassword
            // 
            this.lbl_loginPassword.AutoSize = true;
            this.lbl_loginPassword.Location = new System.Drawing.Point(67, 101);
            this.lbl_loginPassword.Name = "lbl_loginPassword";
            this.lbl_loginPassword.Size = new System.Drawing.Size(56, 13);
            this.lbl_loginPassword.TabIndex = 3;
            this.lbl_loginPassword.Text = "Password:";
            // 
            // btn_loginGetEx
            // 
            this.btn_loginGetEx.Location = new System.Drawing.Point(70, 143);
            this.btn_loginGetEx.Name = "btn_loginGetEx";
            this.btn_loginGetEx.Size = new System.Drawing.Size(139, 46);
            this.btn_loginGetEx.TabIndex = 4;
            this.btn_loginGetEx.Text = "Login and Get exercise";
            this.btn_loginGetEx.UseVisualStyleBackColor = true;
            this.btn_loginGetEx.Click += new System.EventHandler(this.btn_loginGetEx_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_loginGetEx);
            this.Controls.Add(this.lbl_loginPassword);
            this.Controls.Add(this.lbl_loginUsername);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_loginUsername;
        private System.Windows.Forms.Label lbl_loginPassword;
        private System.Windows.Forms.Button btn_loginGetEx;
    }
}