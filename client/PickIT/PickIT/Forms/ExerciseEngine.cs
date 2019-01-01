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
        public int folder;
        public ExerciseEngine()
        {
            InitializeComponent();
            addImages();

        }

        private void addImages()
        {

            folder = rnd.Next(1, 5);
            p1.ImageLocation = "../../imgfolder/ex" + folder + "/1.jpg";
            p2.ImageLocation = "../../imgfolder/ex" + folder + "/2.jpg";
            p3.ImageLocation = "../../imgfolder/ex" + folder + "/3.jpg";
            p4.ImageLocation = "../../imgfolder/ex" + folder + "/4.jpg";
            p1.SizeMode = PictureBoxSizeMode.Zoom;
            p2.SizeMode = PictureBoxSizeMode.Zoom;
            p3.SizeMode = PictureBoxSizeMode.Zoom;
            p4.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private bool Check()
        {
            switch (folder)
            {
                case 1:
                if ((checkBox1.CheckState == CheckState.Checked) &&
                    (checkBox2.CheckState == CheckState.Unchecked) &&
                    (checkBox3.CheckState == CheckState.Unchecked) &&
                    (checkBox4.CheckState == CheckState.Unchecked))
                    {
                        MessageBox.Show("Answer is correct!");
                        return true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The answer is surprisingly incorrect!");
                        checkBox1.CheckState = CheckState.Unchecked;
                        checkBox2.CheckState = CheckState.Unchecked;
                        checkBox3.CheckState = CheckState.Unchecked;
                        checkBox4.CheckState = CheckState.Unchecked;
                        return false;
                        break;
                    }

                case 2:
                    if ((checkBox1.CheckState == CheckState.Unchecked) &&
                  (checkBox2.CheckState == CheckState.Checked) &&
                  (checkBox3.CheckState == CheckState.Unchecked) &&
                  (checkBox4.CheckState == CheckState.Unchecked))
                    {
                        MessageBox.Show("Answer is correct!");
                        return true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The answer is surprisingly incorrect!");
                        checkBox1.CheckState = CheckState.Unchecked;
                        checkBox2.CheckState = CheckState.Unchecked;
                        checkBox3.CheckState = CheckState.Unchecked;
                        checkBox4.CheckState = CheckState.Unchecked;
                        return false;
                        break;
                    }

                case 3:
                    if ((checkBox1.CheckState == CheckState.Unchecked) &&
                   (checkBox2.CheckState == CheckState.Unchecked) &&
                   (checkBox3.CheckState == CheckState.Checked) &&
                   (checkBox4.CheckState == CheckState.Unchecked))
                    {
                        MessageBox.Show("Answer is correct!");
                        return true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The answer is surprisingly incorrect!");
                        checkBox1.CheckState = CheckState.Unchecked;
                        checkBox2.CheckState = CheckState.Unchecked;
                        checkBox3.CheckState = CheckState.Unchecked;
                        checkBox4.CheckState = CheckState.Unchecked;
                        return false;
                        break;
                    }

                case 4:
                    if ((checkBox1.CheckState == CheckState.Unchecked) &&
                   (checkBox2.CheckState == CheckState.Unchecked) &&
                   (checkBox3.CheckState == CheckState.Unchecked) &&
                   (checkBox4.CheckState == CheckState.Checked))
                    {
                        MessageBox.Show("Answer is correct!");
                        return true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The answer is surprisingly incorrect!");
                        checkBox1.CheckState = CheckState.Unchecked;
                        checkBox2.CheckState = CheckState.Unchecked;
                        checkBox3.CheckState = CheckState.Unchecked;
                        checkBox4.CheckState = CheckState.Unchecked;
                        return false;
                        break;
                    }


                default:
                    return false;
                    break;
            }
        }


        private void cmd_submite_Click(object sender, EventArgs e)
        {
            Check();
            if (Check())
            {
                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
            }

        }

        private void cmd_newEx_Click(object sender, EventArgs e)
        {
            addImages();
        }
    }
}
