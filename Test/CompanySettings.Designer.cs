namespace ActiPulse
{
    partial class CompanySettings
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
            label_users = new Label();
            lb_overview = new ListBox();
            cb_users = new ComboBox();
            label_standingTime = new Label();
            label_SittingTime = new Label();
            label_companyName = new Label();
            label_companyId = new Label();
            bt_X = new Button();
            bt_Back = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nud_standingTime = new NumericUpDown();
            nud_sittingTime = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            LogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_standingTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_sittingTime).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label_users
            // 
            label_users.AutoSize = true;
            label_users.Location = new Point(152, 21);
            label_users.Name = "label_users";
            label_users.Size = new Size(29, 15);
            label_users.TabIndex = 0;
            label_users.Text = "user";
            label_users.Click += label_users_Click;
            // 
            // lb_overview
            // 
            lb_overview.FormattingEnabled = true;
            lb_overview.ItemHeight = 15;
            lb_overview.Location = new Point(6, 47);
            lb_overview.Name = "lb_overview";
            lb_overview.Size = new Size(302, 124);
            lb_overview.TabIndex = 2;
            // 
            // cb_users
            // 
            cb_users.FormattingEnabled = true;
            cb_users.Location = new Point(187, 18);
            cb_users.Name = "cb_users";
            cb_users.Size = new Size(121, 23);
            cb_users.TabIndex = 3;
            cb_users.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label_standingTime
            // 
            label_standingTime.AutoSize = true;
            label_standingTime.Location = new Point(14, 25);
            label_standingTime.Name = "label_standingTime";
            label_standingTime.Size = new Size(80, 15);
            label_standingTime.TabIndex = 4;
            label_standingTime.Text = "standing time";
            label_standingTime.Click += label3_Click;
            // 
            // label_SittingTime
            // 
            label_SittingTime.AutoSize = true;
            label_SittingTime.Location = new Point(27, 54);
            label_SittingTime.Name = "label_SittingTime";
            label_SittingTime.Size = new Size(67, 15);
            label_SittingTime.TabIndex = 5;
            label_SittingTime.Text = "sitting time";
            // 
            // label_companyName
            // 
            label_companyName.AutoSize = true;
            label_companyName.Location = new Point(100, 351);
            label_companyName.Name = "label_companyName";
            label_companyName.Size = new Size(81, 15);
            label_companyName.TabIndex = 6;
            label_companyName.Text = "company info";
            // 
            // label_companyId
            // 
            label_companyId.AutoSize = true;
            label_companyId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label_companyId.Location = new Point(517, 199);
            label_companyId.Name = "label_companyId";
            label_companyId.Size = new Size(71, 30);
            label_companyId.TabIndex = 9;
            label_companyId.Text = "label1";
            // 
            // bt_X
            // 
            bt_X.BackColor = Color.Transparent;
            bt_X.Cursor = Cursors.Hand;
            bt_X.FlatAppearance.BorderSize = 0;
            bt_X.FlatStyle = FlatStyle.Flat;
            bt_X.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_X.ForeColor = Color.SpringGreen;
            bt_X.Location = new Point(591, 1);
            bt_X.Name = "bt_X";
            bt_X.Size = new Size(28, 35);
            bt_X.TabIndex = 10;
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
            bt_Back.ForeColor = Color.SpringGreen;
            bt_Back.Location = new Point(1, 1);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(19, 35);
            bt_Back.TabIndex = 26;
            bt_Back.Text = "<";
            bt_Back.UseVisualStyleBackColor = false;
            bt_Back.Click += bt_Back_Click;
            // 
            // button1
            // 
            button1.Location = new Point(280, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(381, 199);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 10;
            label1.Text = "Company ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 25);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 28;
            label2.Text = "seconds";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 54);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 29;
            label3.Text = "seconds";
            // 
            // nud_standingTime
            // 
            nud_standingTime.Location = new Point(100, 22);
            nud_standingTime.Name = "nud_standingTime";
            nud_standingTime.Size = new Size(100, 23);
            nud_standingTime.TabIndex = 30;
            // 
            // nud_sittingTime
            // 
            nud_sittingTime.Location = new Point(100, 51);
            nud_sittingTime.Name = "nud_sittingTime";
            nud_sittingTime.Size = new Size(100, 23);
            nud_sittingTime.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nud_standingTime);
            groupBox1.Controls.Add(label_standingTime);
            groupBox1.Controls.Add(nud_sittingTime);
            groupBox1.Controls.Add(label_SittingTime);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 100);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Update time";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lb_overview);
            groupBox2.Controls.Add(label_users);
            groupBox2.Controls.Add(cb_users);
            groupBox2.Location = new Point(12, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 183);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "User overview";
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.SpringGreen;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.ForeColor = Color.White;
            LogOut.Location = new Point(12, 347);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(82, 23);
            LogOut.TabIndex = 34;
            LogOut.Text = "LOG OUT";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // CompanySettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 375);
            ControlBox = false;
            Controls.Add(LogOut);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label_companyId);
            Controls.Add(label1);
            Controls.Add(bt_Back);
            Controls.Add(bt_X);
            Controls.Add(label_companyName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompanySettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompanySettings";
            Load += CompanySettings_Load;
            ((System.ComponentModel.ISupportInitialize)nud_standingTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_sittingTime).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_users;
        private ListBox lb_overview;
        private ComboBox cb_users;
        private Label label_standingTime;
        private Label label_SittingTime;
        private Label label_companyName;
        private TextBox tb_sittingTime;
        private TextBox tb_standingTime;
        private Label label_companyId;
        private Button bt_X;
        private Button bt_Back;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nud_standingTime;
        private NumericUpDown nud_sittingTime;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button LogOut;
    }
}