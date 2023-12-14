namespace ActiPulse
{
    partial class PuntenOverzicht
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
            listBox = new ListBox();
            PuntenTotaal = new Label();
            PuntenInleveren = new Button();
            HoeveelMinpunten = new NumericUpDown();
            bt_X = new Button();
            bt_Back = new Button();
            InlogGegevens = new Label();
            ((System.ComponentModel.ISupportInitialize)HoeveelMinpunten).BeginInit();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(12, 211);
            listBox.Name = "listBox";
            listBox.Size = new Size(595, 124);
            listBox.TabIndex = 0;
            // 
            // PuntenTotaal
            // 
            PuntenTotaal.AutoSize = true;
            PuntenTotaal.Location = new Point(108, 129);
            PuntenTotaal.Name = "PuntenTotaal";
            PuntenTotaal.Size = new Size(92, 15);
            PuntenTotaal.TabIndex = 1;
            PuntenTotaal.Text = "PUNTENTOTAAL";
            // 
            // PuntenInleveren
            // 
            PuntenInleveren.BackColor = Color.FromArgb(61, 123, 177);
            PuntenInleveren.ForeColor = Color.White;
            PuntenInleveren.Location = new Point(413, 114);
            PuntenInleveren.Name = "PuntenInleveren";
            PuntenInleveren.Size = new Size(132, 51);
            PuntenInleveren.TabIndex = 16;
            PuntenInleveren.Text = "Punten Inleveren";
            PuntenInleveren.UseVisualStyleBackColor = false;
            PuntenInleveren.Click += button1_Click;
            // 
            // HoeveelMinpunten
            // 
            HoeveelMinpunten.Location = new Point(446, 85);
            HoeveelMinpunten.Name = "HoeveelMinpunten";
            HoeveelMinpunten.Size = new Size(68, 23);
            HoeveelMinpunten.TabIndex = 4;
            HoeveelMinpunten.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // bt_X
            // 
            bt_X.BackColor = Color.Transparent;
            bt_X.Cursor = Cursors.Hand;
            bt_X.FlatAppearance.BorderSize = 0;
            bt_X.FlatStyle = FlatStyle.Flat;
            bt_X.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_X.ForeColor = Color.FromArgb(61, 123, 177);
            bt_X.Location = new Point(591, 0);
            bt_X.Name = "bt_X";
            bt_X.Size = new Size(28, 35);
            bt_X.TabIndex = 9;
            bt_X.Text = "X";
            bt_X.UseVisualStyleBackColor = false;
            bt_X.Click += bt_X_Click;
            // 
            // bt_Back
            // 
            bt_Back.BackColor = Color.Transparent;
            bt_Back.Cursor = Cursors.Hand;
            bt_Back.FlatAppearance.BorderSize = 0;
            bt_Back.FlatStyle = FlatStyle.Flat;
            bt_Back.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Back.ForeColor = Color.FromArgb(61, 123, 177);
            bt_Back.Location = new Point(0, 0);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(28, 35);
            bt_Back.TabIndex = 25;
            bt_Back.Text = "<";
            bt_Back.UseVisualStyleBackColor = false;
            bt_Back.Click += bt_Back_Click;
            // 
            // InlogGegevens
            // 
            InlogGegevens.AutoSize = true;
            InlogGegevens.Location = new Point(12, 351);
            InlogGegevens.Name = "InlogGegevens";
            InlogGegevens.Size = new Size(98, 15);
            InlogGegevens.TabIndex = 26;
            InlogGegevens.Text = "INLOGGEGEVENS";
            // 
            // PuntenOverzicht
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 375);
            Controls.Add(PuntenInleveren);
            Controls.Add(HoeveelMinpunten);
            Controls.Add(InlogGegevens);
            Controls.Add(bt_Back);
            Controls.Add(bt_X);
            Controls.Add(PuntenTotaal);
            Controls.Add(listBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PuntenOverzicht";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuntenOverzicht";
            Shown += PuntenOverzicht_Shown;
            ((System.ComponentModel.ISupportInitialize)HoeveelMinpunten).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Label PuntenTotaal;
        private NumericUpDown HoeveelMinpunten;
        private Button PuntenInleveren;
        private Button bt_X;
        private Button bt_Back;
        private Label InlogGegevens;
    }
}