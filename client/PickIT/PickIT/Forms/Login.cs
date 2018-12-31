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

//dear windows users add Newtonsoft and 2 textboxes to Login form: username_txt and password_txt
namespace PickIT
{
    class Responce
    {   
        public string status_code { get; set; }
        public string message { get; set; }
        public string token { get; set; }
    }
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string url = "http://maksat.coldciderstudios.com/cars";
        static string token1 = "";
        static string username1 = "";

//change button names or add them and call POST_LOGIN(); in button click
//write existing textbox names instead of mine
        private void login_btn_Click(object sender, EventArgs e)
        {
            POST_LOGIN();
        }

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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_loginGetEx_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("example.com");
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("username", lbl_loginUsername.Text);
            request.AddParameter("password", lbl_loginPassword.Text);
            string content = client.Execute(request).Content;
            if (content == string.Empty)
            {
                return;
            }
        }
    }
}
