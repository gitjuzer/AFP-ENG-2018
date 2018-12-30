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
        public ExerciseEngine(/*string Exercise*/)
        {
            InitializeComponent();
            int folder;
            folder = rnd.Next(0, 4);

            p1.ImageLocation = "imgfolder/ex1/correct.jpg";

            p1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void cmd_submite_Click(object sender, EventArgs e)
        {

        }
    }
}
