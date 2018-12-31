using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace PickIT
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        string url = "http://maksat.coldciderstudios.com/cars";
        static string token1 = "";
        static string username1 = "maks";

        public bool POST_LOGIN()
        {
            var client = new RestClient(url + "/index.php");
            var request = new RestRequest(Method.POST);

            if (username_txt.Text != "" && password_txt.Text != "")
            {
                request.AddParameter("action", "login");
                request.AddParameter("username", username_txt.Text);
                request.AddParameter("password", password_txt.Text);

                Responce resp = JsonConvert.DeserializeObject<Responce>(client.Execute(request).Content);

                MessageBox.Show("Status code: " + resp.status_code + "\n" + resp.message);
                if (resp.token != "")
                {
                    token1 = resp.token;
                    username1 = username_txt.Text;
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Username or Password field is empty!");
                return false;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POST_LOGIN();
            if (POST_LOGIN())
            {
                Application.EnableVisualStyles();
                ExerciseEngine en = new ExerciseEngine();
                this.Hide();
                en.ShowDialog();
                this.Close();
            }
        }

    }
}