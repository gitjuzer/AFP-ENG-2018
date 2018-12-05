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

namespace PickIT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
