namespace user_manager
{
    partial class mainBoard
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
            menuStrip1 = new MenuStrip();
            userVerwaltungToolStripMenuItem = new ToolStripMenuItem();
            userHinzufügenToolStripMenuItem = new ToolStripMenuItem();
            userÄndernToolStripMenuItem = new ToolStripMenuItem();
            userLöschenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { userVerwaltungToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userVerwaltungToolStripMenuItem
            // 
            userVerwaltungToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userHinzufügenToolStripMenuItem, userÄndernToolStripMenuItem, userLöschenToolStripMenuItem });
            userVerwaltungToolStripMenuItem.Name = "userVerwaltungToolStripMenuItem";
            userVerwaltungToolStripMenuItem.Size = new Size(104, 20);
            userVerwaltungToolStripMenuItem.Text = "User Verwaltung";
            // 
            // userHinzufügenToolStripMenuItem
            // 
            userHinzufügenToolStripMenuItem.Name = "userHinzufügenToolStripMenuItem";
            userHinzufügenToolStripMenuItem.Size = new Size(162, 22);
            userHinzufügenToolStripMenuItem.Text = "User Hinzufügen";
            userHinzufügenToolStripMenuItem.Click += userHinzufügenToolStripMenuItem_Click;
            // 
            // userÄndernToolStripMenuItem
            // 
            userÄndernToolStripMenuItem.Name = "userÄndernToolStripMenuItem";
            userÄndernToolStripMenuItem.Size = new Size(162, 22);
            userÄndernToolStripMenuItem.Text = "User Ändern";
            // 
            // userLöschenToolStripMenuItem
            // 
            userLöschenToolStripMenuItem.Name = "userLöschenToolStripMenuItem";
            userLöschenToolStripMenuItem.Size = new Size(162, 22);
            userLöschenToolStripMenuItem.Text = "User Löschen";
            // 
            // mainBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainBoard";
            Text = "User Manager";
            Load += mainBoard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userVerwaltungToolStripMenuItem;
        private ToolStripMenuItem userHinzufügenToolStripMenuItem;
        private ToolStripMenuItem userÄndernToolStripMenuItem;
        private ToolStripMenuItem userLöschenToolStripMenuItem;
    }
}