using AffaManagementSoftware.business;
using AffaManagementSoftware.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffaManagementSoftware
{
    public partial class ClubsPage : Form
    {

        private readonly ClubManager clubManager;

        public ClubsPage()
        {
            InitializeComponent();
            clubManager = new ClubManager(
                    new utils.DbHelper()
                );
        }

        private void ClubsPage_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Club club = new Club(tb_name.Text);
            clubManager.AddClub(club);
            MessageBox.Show("Yeni klub əlavə edildi.");

            refreshTable();
        }

        private void refreshTable()
        {
            dgw_clubs.DataSource = clubManager.GetAll();
            dgw_clubs.Columns["name"].HeaderText = "Klub Adı";
            dgw_clubs.Columns["id"].Visible = false;
        }
    }
}
