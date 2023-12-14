namespace ActiPulse
{
    partial class MainScreenActiPulse
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
            Inloggegevens = new Label();
            LogOut = new Button();
            listBox = new ListBox();
            HoelangText = new Label();
            ZitTimer = new Label();
            bt_puntenoverzicht = new Button();
            bt_X = new Button();
            Punten = new Label();
            bt_update = new Button();
            nud_SensorID = new NumericUpDown();
            SensorId = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_SensorID).BeginInit();
            SuspendLayout();
            // 
            // Inloggegevens
            // 
            Inloggegevens.AutoSize = true;
            Inloggegevens.Location = new Point(100, 344);
            Inloggegevens.Name = "Inloggegevens";
            Inloggegevens.Size = new Size(98, 15);
            Inloggegevens.TabIndex = 0;
            Inloggegevens.Text = "INLOGGEGEVENS";
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.FromArgb(61, 123, 177);
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.ForeColor = Color.White;
            LogOut.Location = new Point(12, 340);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(82, 23);
            LogOut.TabIndex = 3;
            LogOut.Text = "LOG OUT";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += bt_SignOut_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(289, 256);
            listBox.Name = "listBox";
            listBox.Size = new Size(316, 94);
            listBox.TabIndex = 4;
            // 
            // HoelangText
            // 
            HoelangText.AutoSize = true;
            HoelangText.Location = new Point(32, 105);
            HoelangText.Name = "HoelangText";
            HoelangText.Size = new Size(0, 15);
            HoelangText.TabIndex = 5;
            // 
            // ZitTimer
            // 
            ZitTimer.AutoSize = true;
            ZitTimer.Location = new Point(32, 77);
            ZitTimer.Name = "ZitTimer";
            ZitTimer.Size = new Size(190, 15);
            ZitTimer.TabIndex = 6;
            ZitTimer.Text = "You have not used your sensor yet!";
            // 
            // bt_puntenoverzicht
            // 
            bt_puntenoverzicht.BackColor = Color.FromArgb(61, 123, 177);
            bt_puntenoverzicht.FlatStyle = FlatStyle.Flat;
            bt_puntenoverzicht.ForeColor = Color.White;
            bt_puntenoverzicht.Location = new Point(394, 216);
            bt_puntenoverzicht.Name = "bt_puntenoverzicht";
            bt_puntenoverzicht.Size = new Size(129, 34);
            bt_puntenoverzicht.TabIndex = 1;
            bt_puntenoverzicht.Text = "POINT OVERVIEW";
            bt_puntenoverzicht.UseVisualStyleBackColor = false;
            bt_puntenoverzicht.Click += bt_puntenoverzicht_Click;
            // 
            // bt_X
            // 
            bt_X.BackColor = Color.Transparent;
            bt_X.Cursor = Cursors.Hand;
            bt_X.FlatAppearance.BorderSize = 0;
            bt_X.FlatStyle = FlatStyle.Flat;
            bt_X.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_X.ForeColor = Color.FromArgb(61, 123, 177);
            bt_X.Location = new Point(591, -1);
            bt_X.Name = "bt_X";
            bt_X.Size = new Size(28, 35);
            bt_X.TabIndex = 2;
            bt_X.Text = "X";
            bt_X.UseVisualStyleBackColor = false;
            bt_X.Click += bt_X_Click;
            // 
            // Punten
            // 
            Punten.AutoSize = true;
            Punten.Location = new Point(444, 128);
            Punten.Name = "Punten";
            Punten.Size = new Size(45, 15);
            Punten.TabIndex = 17;
            Punten.Text = "Punten";
            // 
            // bt_update
            // 
            bt_update.Location = new Point(147, 180);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(75, 23);
            bt_update.TabIndex = 18;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // nud_SensorID
            // 
            nud_SensorID.Location = new Point(46, 180);
            nud_SensorID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_SensorID.Name = "nud_SensorID";
            nud_SensorID.Size = new Size(95, 23);
            nud_SensorID.TabIndex = 19;
            // 
            // SensorId
            // 
            SensorId.AutoSize = true;
            SensorId.Location = new Point(46, 162);
            SensorId.Name = "SensorId";
            SensorId.Size = new Size(55, 15);
            SensorId.TabIndex = 20;
            SensorId.Text = "Sensor Id";
            // 
            // MainScreenActiPulse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 375);
            ControlBox = false;
            Controls.Add(SensorId);
            Controls.Add(nud_SensorID);
            Controls.Add(bt_update);
            Controls.Add(Punten);
            Controls.Add(bt_X);
            Controls.Add(bt_puntenoverzicht);
            Controls.Add(ZitTimer);
            Controls.Add(HoelangText);
            Controls.Add(listBox);
            Controls.Add(LogOut);
            Controls.Add(Inloggegevens);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainScreenActiPulse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main | ActiPulse";
            Shown += MainScreenActiPulse_Shown;
            ((System.ComponentModel.ISupportInitialize)nud_SensorID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Inloggegevens;
        private Button LogOut;
        private Label Points;
        private ListBox listBox;
        private Label HoelangText;
        private Label ZitTimer;
        private Button bt_puntenoverzicht;
        private Button bt_X;
        private Label Punten;
        private Button bt_update;
        private NumericUpDown nud_SensorID;
        private Label SensorId;
    }
}