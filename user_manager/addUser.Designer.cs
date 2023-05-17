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
            lblStraße = new Label();
            cboStraße = new ComboBox();
            cboAbteilung = new ComboBox();
            btnOK = new Button();
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
            // 
            // lblStraße
            // 
            lblStraße.AutoSize = true;
            lblStraße.Location = new Point(25, 225);
            lblStraße.Name = "lblStraße";
            lblStraße.Size = new Size(40, 15);
            lblStraße.TabIndex = 8;
            lblStraße.Text = "Straße";
            // 
            // cboStraße
            // 
            cboStraße.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStraße.FormattingEnabled = true;
            cboStraße.Items.AddRange(new object[] { "Oberer Achdamm 22", "Schäfferhofstraße 15" });
            cboStraße.Location = new Point(25, 243);
            cboStraße.Name = "cboStraße";
            cboStraße.Size = new Size(159, 23);
            cboStraße.TabIndex = 9;
            cboStraße.SelectedIndexChanged += cboStraße_SelectedIndexChanged;
            // 
            // cboAbteilung
            // 
            cboAbteilung.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAbteilung.FormattingEnabled = true;
            cboAbteilung.Items.AddRange(new object[] { "Außendienst", "Buchhaltung", "Digitale Innovation und IT", "Entwicklung", "HR", "IPC", "IT" });
            cboAbteilung.Location = new Point(25, 189);
            cboAbteilung.Name = "cboAbteilung";
            cboAbteilung.Size = new Size(159, 23);
            cboAbteilung.TabIndex = 10;
            cboAbteilung.SelectedIndexChanged += cboAbteilung_SelectedIndexChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(139, 318);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(233, 43);
            btnOK.TabIndex = 11;
            btnOK.Text = "User Erstellen";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 398);
            Controls.Add(btnOK);
            Controls.Add(cboAbteilung);
            Controls.Add(cboStraße);
            Controls.Add(lblStraße);
            Controls.Add(lblAbteilung);
            Controls.Add(txtJobtitel);
            Controls.Add(lblJobtitel);
            Controls.Add(txtNachname);
            Controls.Add(lblNachname);
            Controls.Add(txtVorname);
            Controls.Add(lblVorname);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Label lblStraße;
        private ComboBox cboStraße;
        private ComboBox cboAbteilung;
        private Button btnOK;
    }
}