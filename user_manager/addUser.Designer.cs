namespace user_manager
{
    partial class addUser
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
            lblVorname = new Label();
            txtVorname = new TextBox();
            lblNachname = new Label();
            txtNachname = new TextBox();
            lblJobtitel = new Label();
            txtJobtitel = new TextBox();
            lblAbteilung = new Label();
            txtAbteilung = new TextBox();
            SuspendLayout();
            // 
            // lblVorname
            // 
            lblVorname.AutoSize = true;
            lblVorname.Location = new Point(25, 8);
            lblVorname.Name = "lblVorname";
            lblVorname.Size = new Size(54, 15);
            lblVorname.TabIndex = 0;
            lblVorname.Text = "Vorname";
            lblVorname.Click += lblVorname_Click;
            // 
            // txtVorname
            // 
            txtVorname.Location = new Point(25, 26);
            txtVorname.Name = "txtVorname";
            txtVorname.Size = new Size(159, 23);
            txtVorname.TabIndex = 1;
            txtVorname.TextChanged += txtVorname_TextChanged;
            // 
            // lblNachname
            // 
            lblNachname.AutoSize = true;
            lblNachname.Location = new Point(25, 62);
            lblNachname.Name = "lblNachname";
            lblNachname.Size = new Size(65, 15);
            lblNachname.TabIndex = 2;
            lblNachname.Text = "Nachname";
            lblNachname.Click += lblNachname_Click;
            // 
            // txtNachname
            // 
            txtNachname.Location = new Point(25, 80);
            txtNachname.Name = "txtNachname";
            txtNachname.Size = new Size(159, 23);
            txtNachname.TabIndex = 3;
            txtNachname.TextChanged += txtNachname_TextChanged;
            // 
            // lblJobtitel
            // 
            lblJobtitel.AutoSize = true;
            lblJobtitel.Location = new Point(25, 116);
            lblJobtitel.Name = "lblJobtitel";
            lblJobtitel.Size = new Size(45, 15);
            lblJobtitel.TabIndex = 4;
            lblJobtitel.Text = "Jobtitel";
            lblJobtitel.Click += lblJobtitel_Click;
            // 
            // txtJobtitel
            // 
            txtJobtitel.Location = new Point(25, 134);
            txtJobtitel.Name = "txtJobtitel";
            txtJobtitel.Size = new Size(159, 23);
            txtJobtitel.TabIndex = 5;
            txtJobtitel.TextChanged += txtJobtitel_TextChanged;
            // 
            // lblAbteilung
            // 
            lblAbteilung.AutoSize = true;
            lblAbteilung.Location = new Point(25, 171);
            lblAbteilung.Name = "lblAbteilung";
            lblAbteilung.Size = new Size(59, 15);
            lblAbteilung.TabIndex = 6;
            lblAbteilung.Text = "Abteilung";
            lblAbteilung.Click += lblAbteilung_Click;
            // 
            // txtAbteilung
            // 
            txtAbteilung.Location = new Point(25, 189);
            txtAbteilung.Name = "txtAbteilung";
            txtAbteilung.Size = new Size(159, 23);
            txtAbteilung.TabIndex = 7;
            txtAbteilung.TextChanged += txtAbteilung_TextChanged;
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAbteilung);
            Controls.Add(lblAbteilung);
            Controls.Add(txtJobtitel);
            Controls.Add(lblJobtitel);
            Controls.Add(txtNachname);
            Controls.Add(lblNachname);
            Controls.Add(txtVorname);
            Controls.Add(lblVorname);
            Name = "addUser";
            Text = "User Erstellen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVorname;
        private TextBox txtVorname;
        private Label lblNachname;
        private TextBox txtNachname;
        private Label lblJobtitel;
        private TextBox txtJobtitel;
        private Label lblAbteilung;
        private TextBox txtAbteilung;
    }
}