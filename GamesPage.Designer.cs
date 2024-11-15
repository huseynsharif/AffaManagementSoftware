namespace AffaManagementSoftware
{
    partial class GamesPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_score2 = new System.Windows.Forms.TextBox();
            this.tb_score1 = new System.Windows.Forms.TextBox();
            this.cb_club1 = new System.Windows.Forms.ComboBox();
            this.cb_club2 = new System.Windows.Forms.ComboBox();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(708, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_score2
            // 
            this.tb_score2.Location = new System.Drawing.Point(256, 75);
            this.tb_score2.Name = "tb_score2";
            this.tb_score2.Size = new System.Drawing.Size(41, 21);
            this.tb_score2.TabIndex = 1;
            // 
            // tb_score1
            // 
            this.tb_score1.Location = new System.Drawing.Point(122, 75);
            this.tb_score1.Name = "tb_score1";
            this.tb_score1.Size = new System.Drawing.Size(45, 21);
            this.tb_score1.TabIndex = 2;
            // 
            // cb_club1
            // 
            this.cb_club1.FormattingEnabled = true;
            this.cb_club1.Location = new System.Drawing.Point(80, 33);
            this.cb_club1.Name = "cb_club1";
            this.cb_club1.Size = new System.Drawing.Size(121, 20);
            this.cb_club1.TabIndex = 3;
            // 
            // cb_club2
            // 
            this.cb_club2.FormattingEnabled = true;
            this.cb_club2.Location = new System.Drawing.Point(218, 33);
            this.cb_club2.Name = "cb_club2";
            this.cb_club2.Size = new System.Drawing.Size(121, 20);
            this.cb_club2.TabIndex = 4;
            // 
            // date_time
            // 
            this.date_time.Location = new System.Drawing.Point(369, 33);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(180, 21);
            this.date_time.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_add.Location = new System.Drawing.Point(369, 75);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Oyun əlavə et";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_edit.Location = new System.Drawing.Point(494, 75);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Nəticə Daxil et";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // GamesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.cb_club2);
            this.Controls.Add(this.cb_club1);
            this.Controls.Add(this.tb_score1);
            this.Controls.Add(this.tb_score2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GamesPage";
            this.Text = "GamesPage";
            this.Load += new System.EventHandler(this.GamesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_score2;
        private System.Windows.Forms.TextBox tb_score1;
        private System.Windows.Forms.ComboBox cb_club1;
        private System.Windows.Forms.ComboBox cb_club2;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
    }
}