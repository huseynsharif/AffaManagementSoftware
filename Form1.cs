using AffaManagementSoftware.business;
using AffaManagementSoftware.entities;
using System;
using System.Windows.Forms;

namespace AffaManagementSoftware
{
    public partial class Form1 : Form
    {

        private readonly UserManager userManager;


        public Form1()
        {
            InitializeComponent();

            userManager = new UserManager(
                    new utils.DbHelper()
                );
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User(
                    tb_username.Text,
                    tb_password.Text
                );

            if (userManager.Login(user))
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.FormClosed += (s, args) => this.Close();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }

    }
}
