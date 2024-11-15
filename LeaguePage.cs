using AffaManagementSoftware.business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace AffaManagementSoftware
{
    public partial class LeaguePage : Form
    {

        private readonly GameManager gameManager;
        Dictionary<string, int> clubScores;

        public LeaguePage()
        {
            InitializeComponent();
            gameManager = new GameManager(
                    new utils.DbHelper()        
            );
        }

        private void LeaguePage_Load(object sender, EventArgs e)
        {

            clubScores = CalculateClubScores(
                    gameManager.GetAll()
            );

            DataTable dgv_report = new DataTable();
            dgv_report.Columns.Add("Club Name", typeof(string));
            dgv_report.Columns.Add("Score", typeof(int));

            foreach (var club in clubScores)
            {
                dgv_report.Rows.Add(club.Key, club.Value);
            }

            DataGridView dataGridView = new DataGridView
            {
                DataSource = dgv_report,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(dataGridView);
        }


        private Dictionary<string, int> CalculateClubScores(DataTable dataTable)
        {
            Dictionary<string, int> clubScores = new Dictionary<string, int>();

            foreach (DataRow row in dataTable.Rows)
            {
                string club1Name = row["club1"].ToString();
                string club2Name = row["club2"].ToString();
                int score1 = Convert.ToInt32(row["score1"]);
                int score2 = Convert.ToInt32(row["score2"]);

                if (!clubScores.ContainsKey(club1Name)) clubScores[club1Name] = 0;
                if (!clubScores.ContainsKey(club2Name)) clubScores[club2Name] = 0;

                if (score1 > score2)
                {
                    clubScores[club1Name] += 3; // Win for club1
                    clubScores[club2Name] += 1; // Loss for club2
                }
                else if (score1 < score2)
                {
                    clubScores[club1Name] += 1; // Loss for club1
                    clubScores[club2Name] += 3; // Win for club2
                }
                else
                {
                    clubScores[club1Name] += 2; // Draw
                    clubScores[club2Name] += 2; // Draw
                }
            }
            return clubScores;
        }






    private void ExportToExcel(Dictionary<string, int> clubScores)
    {
        Excel.Application excelApp = new Excel.Application();
        excelApp.Workbooks.Add();
        Excel._Worksheet workSheet = excelApp.ActiveSheet;

        workSheet.Cells[1, "A"] = "Komanda Adı";
        workSheet.Cells[1, "B"] = "Xal";

        int row = 2;
        foreach (var club in clubScores)
        {
            workSheet.Cells[row, "A"] = club.Key;
            workSheet.Cells[row, "B"] = club.Value;
            row++;
        }

        //var saveFileDialog = new SaveFileDialog
        //{
        //    Filter = "Excel Files|*.xlsx;*.xls",
        //    Title = "Excel Faylı Kimi Saxla"
        //};

        //if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //{
        //    workSheet.SaveAs(saveFileDialog.FileName);
        //    MessageBox.Show("Məlumat uğurla Excel faylına ixrac edildi.", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        excelApp.Quit();
    }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToExcel(clubScores);
        }
    }
}
