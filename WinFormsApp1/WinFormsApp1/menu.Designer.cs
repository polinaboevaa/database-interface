namespace WinFormsApp1
{
    partial class start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            players = new Button();
            comands = new Button();
            clubs = new Button();
            SuspendLayout();
            // 
            // players
            // 
            players.BackColor = Color.Olive;
            players.FlatAppearance.BorderColor = Color.Yellow;
            players.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            players.ForeColor = SystemColors.ButtonFace;
            players.Location = new Point(59, 595);
            players.Name = "players";
            players.Size = new Size(286, 101);
            players.TabIndex = 0;
            players.Text = "Футболисты";
            players.UseVisualStyleBackColor = false;
            players.Click += this.players_Click;
            // 
            // comands
            // 
            comands.BackColor = Color.Olive;
            comands.FlatAppearance.BorderColor = Color.Yellow;
            comands.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comands.ForeColor = SystemColors.ButtonFace;
            comands.Location = new Point(479, 595);
            comands.Name = "comands";
            comands.Size = new Size(286, 101);
            comands.TabIndex = 1;
            comands.Text = "Команды";
            comands.UseVisualStyleBackColor = false;
            comands.Click += this.comands_Click;
            // 
            // clubs
            // 
            clubs.BackColor = Color.Olive;
            clubs.FlatAppearance.BorderColor = Color.Yellow;
            clubs.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            clubs.ForeColor = SystemColors.ButtonFace;
            clubs.Location = new Point(881, 595);
            clubs.Name = "clubs";
            clubs.Size = new Size(286, 101);
            clubs.TabIndex = 2;
            clubs.Text = "Клубы";
            clubs.UseVisualStyleBackColor = false;
            clubs.Click += clubs_Click;
            // 
            // start
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1221, 832);
            Controls.Add(clubs);
            Controls.Add(comands);
            Controls.Add(players);
            Name = "start";
            Text = "футбольный_клуб";
            Load += футбольный_клуб_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button players;
        private Button comands;
        private Button clubs;
    }
}
