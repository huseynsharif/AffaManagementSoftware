using AffaManagementSoftware.business;
using AffaManagementSoftware.entities;
using AffaManagementSoftware.utils;
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
    public partial class GamesPage : Form
    {
        private readonly ClubManager clubManager;
        private readonly GameManager gameManager;

        public GamesPage()
        {
            InitializeComponent();

            DbHelper dbHelper = new DbHelper();

            clubManager = new ClubManager(dbHelper);
            gameManager = new GameManager(dbHelper);
        }

        private void GamesPage_Load(object sender, EventArgs e)
        {
            // Init dateTimePicker
            date_time.Format = DateTimePickerFormat.Custom;
            date_time.CustomFormat = "hh:mm dd/mm/yyyy";

            // Init Clubs ComboBox

            var list1 = clubManager.GetAll();
            var list2 = clubManager.GetAll();

            cb_club1.DataSource = list1;
            cb_club2.DataSource = list2;

            cb_club1.DisplayMember = "name";
            cb_club2.DisplayMember = "name";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Club selectedClub1 = cb_club1.SelectedItem as Club;
            Club selectedClub2 = cb_club2.SelectedItem as Club;

            Game game = new Game(
                    selectedClub1,
                    selectedClub2,
                    int.Parse(tb_score1.Text),
                    int.Parse(tb_score2.Text),
                    date_time.Value
                );

            gameManager.AddGame(game);

            MessageBox.Show("Oyun yaradıldı");
        }
    }
}
