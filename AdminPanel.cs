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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_clubs_Click(object sender, EventArgs e)
        {
            ClubsPage clubsPage = new ClubsPage();
            clubsPage.Show();
        }

        private void btn_games_Click(object sender, EventArgs e)
        {
            GamesPage gamesPage = new GamesPage();
            gamesPage.Show();
        }
    }
}
