namespace user_manager
{
    partial class Form1
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
            SuspendLayout();
            // 
            // lblVorname
            // 
            lblVorname.AutoSize = true;
            lblVorname.Location = new Point(12, 9);
            lblVorname.Name = "lblVorname";
            lblVorname.Size = new Size(54, 15);
            lblVorname.TabIndex = 0;
            lblVorname.Text = "Vorname";
            lblVorname.Click += label1_Click;
            // 
            // txtVorname
            // 
            txtVorname.AccessibleName = "txtnachname";
            txtVorname.Location = new Point(12, 27);
            txtVorname.Name = "txtVorname";
            txtVorname.Size = new Size(192, 23);
            txtVorname.TabIndex = 1;
            txtVorname.TextChanged += textBox1_TextChanged;
            // 
            // lblNachname
            // 
            lblNachname.AutoSize = true;
            lblNachname.Location = new Point(12, 64);
            lblNachname.Name = "lblNachname";
            lblNachname.Size = new Size(65, 15);
            lblNachname.TabIndex = 2;
            lblNachname.Text = "Nachname";
            lblNachname.Click += label2_Click;
            // 
            // txtNachname
            // 
            txtNachname.Location = new Point(12, 82);
            txtNachname.Name = "txtNachname";
            txtNachname.Size = new Size(192, 23);
            txtNachname.TabIndex = 3;
            // 
            // lblJobtitel
            // 
            lblJobtitel.AccessibleName = "labeljobtitel";
            lblJobtitel.AutoSize = true;
            lblJobtitel.Location = new Point(12, 119);
            lblJobtitel.Name = "lblJobtitel";
            lblJobtitel.Size = new Size(45, 15);
            lblJobtitel.TabIndex = 4;
            lblJobtitel.Text = "Jobtitel";
            // 
            // txtJobtitel
            // 
            txtJobtitel.AccessibleName = "txtjobtitel";
            txtJobtitel.Location = new Point(12, 137);
            txtJobtitel.Name = "txtJobtitel";
            txtJobtitel.Size = new Size(192, 23);
            txtJobtitel.TabIndex = 5;
            txtJobtitel.Tag = "";
            txtJobtitel.TextChanged += txtjobtitel_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtJobtitel);
            Controls.Add(lblJobtitel);
            Controls.Add(txtNachname);
            Controls.Add(lblNachname);
            Controls.Add(txtVorname);
            Controls.Add(lblVorname);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}