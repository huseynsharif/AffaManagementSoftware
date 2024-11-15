using AffaManagementSoftware.business;
using AffaManagementSoftware.entities;
using AffaManagementSoftware.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffaManagementSoftware
{
    public partial class GamesPage : Form
    {
        private readonly ClubManager clubManager;
        private readonly GameManager gameManager;

        private bool isEditing = false;


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
            date_time.CustomFormat = "hh:mm dd/MM/yyyy";

            // Init Clubs ComboBox

            var list1 = clubManager.GetAll();
            var list2 = clubManager.GetAll();

            cb_club1.DataSource = list1;
            cb_club2.DataSource = list2;

            cb_club1.DisplayMember = "name";
            cb_club2.DisplayMember = "name";

            cb_club1.ValueMember = "id";
            cb_club2.ValueMember = "id";


            refreshTable();

        }

        private void refreshTable()
        {
            dgw_games.DataSource = gameManager.GetAll();
            dgw_games.Columns["id"].Visible = false;

            dgw_games.Columns["club1"].HeaderText = "Klub 1";
            dgw_games.Columns["club2"].HeaderText = "Klub 2";
            dgw_games.Columns["score1"].HeaderText = "Qol 1";
            dgw_games.Columns["score2"].HeaderText = "Qol 2";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (isEditing)
            {
                int id = int.Parse(dgw_games.Rows[dgw_games.SelectedRows[0].Index].Cells["id"].Value.ToString());

                Game g = new Game(id, int.Parse(tb_score1.Text), int.Parse(tb_score2.Text));
                gameManager.Update(g);
            }
            else
            {
                var c1 = int.Parse(cb_club1.SelectedValue.ToString());
                var c2 = int.Parse(cb_club2.SelectedValue.ToString());

                Club selectedClub1 = new Club(c1);
                Club selectedClub2 = new Club(c2);

                Game game = new Game(
                        selectedClub1,
                        selectedClub2,
                        int.Parse(tb_score1.Text),
                        int.Parse(tb_score2.Text),
                        date_time.Value
                    );

                gameManager.AddGame(game);

                MessageBox.Show("Save olundu.");
            }
            refreshTable();
        }

        private void btn_edit_Click(object sender, EventArgs e)            
        {

            var score1 = dgw_games.Rows[dgw_games.SelectedRows[0].Index].Cells["score1"].Value;
            var score2 = dgw_games.Rows[dgw_games.SelectedRows[0].Index].Cells["score2"].Value;
            //var selectedGame = dgw_games.Rows[dgw_games.SelectedRows[0].Index].DataBoundItem as Game;
            tb_score1.Text = score1.ToString();
            tb_score2.Text = score2.ToString();

            isEditing = true;
        }

       
    }
}
