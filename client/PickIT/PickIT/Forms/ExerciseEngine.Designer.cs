namespace PickIT
{
    partial class ExerciseEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseEngine));
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.lbl_Ex = new System.Windows.Forms.Label();
            this.cmd_submite = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(48, 163);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(200, 100);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(287, 163);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(200, 100);
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(523, 163);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(200, 100);
            this.p3.TabIndex = 2;
            this.p3.TabStop = false;
            // 
            // lbl_Ex
            // 
            this.lbl_Ex.AutoSize = true;
            this.lbl_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ex.Location = new System.Drawing.Point(101, 58);
            this.lbl_Ex.Name = "lbl_Ex";
            this.lbl_Ex.Size = new System.Drawing.Size(121, 29);
            this.lbl_Ex.TabIndex = 3;
            this.lbl_Ex.Text = "Example!";
            // 
            // cmd_submite
            // 
            this.cmd_submite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_submite.Location = new System.Drawing.Point(329, 326);
            this.cmd_submite.Name = "cmd_submite";
            this.cmd_submite.Size = new System.Drawing.Size(91, 37);
            this.cmd_submite.TabIndex = 4;
            this.cmd_submite.Text = "submite";
            this.cmd_submite.UseVisualStyleBackColor = true;
            this.cmd_submite.Click += new System.EventHandler(this.cmd_submite_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(89, 270);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "First choice";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(329, 269);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(131, 21);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Seconed choice";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(561, 270);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(108, 21);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Third choice";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // ExerciseEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 478);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmd_submite);
            this.Controls.Add(this.lbl_Ex);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "ExerciseEngine";
            this.Text = "ExerciseEngine";
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Label lbl_Ex;
        private System.Windows.Forms.Button cmd_submite;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}