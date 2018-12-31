using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PickIT
{
    public partial class ExerciseEngine : Form
    {
        static Random rnd = new Random();
        public ExerciseEngine()
        {
            InitializeComponent();
            int folder;
            folder = rnd.Next(0, 4);

            p1.ImageLocation = "../../imgfolder/ex1/correct.jpg";
            p2.ImageLocation = "../../imgfolder/ex1/wrong_1.jpg";
            p3.ImageLocation = "../../imgfolder/ex1/wrong_2.jpg";
            p4.ImageLocation = "../../imgfolder/ex1/wrong_3.jpg";
           

            p1.SizeMode = PictureBoxSizeMode.Zoom;
            p2.SizeMode = PictureBoxSizeMode.Zoom;
            p3.SizeMode = PictureBoxSizeMode.Zoom;
            p4.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void addImages()
        {
            int folder;
            folder = rnd.Next(1, 5);
            p1.ImageLocation = "../../imgfolder/ex"+folder+"/correct.jpg";
            p2.ImageLocation = "../../imgfolder/ex"+folder+"/wrong_1.jpg";
            p3.ImageLocation = "../../imgfolder/ex"+folder+"/wrong_2.jpg";
            p4.ImageLocation = "../../imgfolder/ex"+folder+"/wrong_3.jpg";
        }

        private void Check()
        {
            if ((checkBox1.CheckState == CheckState.Checked) && 
                (checkBox2.CheckState != CheckState.Checked)&& 
                (checkBox3.CheckState != CheckState.Checked)&&
                (checkBox4.CheckState != CheckState.Checked))
                MessageBox.Show("Answer is correct!");
            else
                MessageBox.Show("Answer is incorrect");
        }
        

        private void cmd_submite_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void ExerciseEngine_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addImages();
        }
    }
}
