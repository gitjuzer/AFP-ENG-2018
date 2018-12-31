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
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.lbl_Ex = new System.Windows.Forms.Label();
            this.cmd_submite = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(36, 132);
            this.p1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(150, 81);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(215, 132);
            this.p2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(150, 81);
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(392, 132);
            this.p3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(150, 81);
            this.p3.TabIndex = 2;
            this.p3.TabStop = false;
            // 
            // lbl_Ex
            // 
            this.lbl_Ex.AutoSize = true;
            this.lbl_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ex.Location = new System.Drawing.Point(331, 44);
            this.lbl_Ex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ex.Name = "lbl_Ex";
            this.lbl_Ex.Size = new System.Drawing.Size(98, 24);
            this.lbl_Ex.TabIndex = 3;
            this.lbl_Ex.Text = "Example!";
            // 
            // cmd_submite
            // 
            this.cmd_submite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_submite.Location = new System.Drawing.Point(335, 287);
            this.cmd_submite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmd_submite.Name = "cmd_submite";
            this.cmd_submite.Size = new System.Drawing.Size(68, 30);
            this.cmd_submite.TabIndex = 4;
            this.cmd_submite.Text = "submite";
            this.cmd_submite.UseVisualStyleBackColor = true;
            this.cmd_submite.Click += new System.EventHandler(this.cmd_submite_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 219);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "First choice";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(247, 219);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Seconed choice";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(421, 219);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Third choice";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(589, 132);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(124, 81);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p4.TabIndex = 8;
            this.p4.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(616, 219);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Fourth choice";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // ExerciseEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 388);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmd_submite);
            this.Controls.Add(this.lbl_Ex);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExerciseEngine";
            this.Text = "ExerciseEngine";
            this.Load += new System.EventHandler(this.ExerciseEngine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
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
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}