namespace ActiPulse
{
    partial class SignUpCompany
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
            bt_Register = new Button();
            p_BlueSide = new Panel();
            lb_Names = new Label();
            lb_DevelopedBy = new Label();
            pb_Logo = new PictureBox();
            lb_ActiPulse = new Label();
            lb_WelcomeTo = new Label();
            tb_CompanyName = new TextBox();
            tb_Password = new TextBox();
            tb_ReenterPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bt_X = new Button();
            bt_Back = new Button();
            lb_SignUpToYourAccount = new Label();
            p_BlueSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            SuspendLayout();
            // 
            // bt_Register
            // 
            bt_Register.BackColor = Color.SpringGreen;
            bt_Register.FlatStyle = FlatStyle.Flat;
            bt_Register.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Register.ForeColor = Color.White;
            bt_Register.Location = new Point(443, 316);
            bt_Register.Name = "bt_Register";
            bt_Register.Size = new Size(129, 34);
            bt_Register.TabIndex = 16;
            bt_Register.Text = "Register";
            bt_Register.UseVisualStyleBackColor = false;
            bt_Register.Click += bt_Register_Click;
            // 
            // p_BlueSide
            // 
            p_BlueSide.BackColor = Color.SpringGreen;
            p_BlueSide.Controls.Add(lb_Names);
            p_BlueSide.Controls.Add(lb_DevelopedBy);
            p_BlueSide.Controls.Add(pb_Logo);
            p_BlueSide.Controls.Add(lb_ActiPulse);
            p_BlueSide.Controls.Add(lb_WelcomeTo);
            p_BlueSide.Dock = DockStyle.Left;
            p_BlueSide.Location = new Point(0, 0);
            p_BlueSide.Name = "p_BlueSide";
            p_BlueSide.Size = new Size(228, 375);
            p_BlueSide.TabIndex = 17;
            // 
            // lb_Names
            // 
            lb_Names.AutoSize = true;
            lb_Names.ForeColor = Color.White;
            lb_Names.Location = new Point(61, 352);
            lb_Names.Name = "lb_Names";
            lb_Names.Size = new Size(161, 15);
            lb_Names.TabIndex = 4;
            lb_Names.Text = "Loes, Jimmy, Guus and Julian";
            // 
            // lb_DevelopedBy
            // 
            lb_DevelopedBy.AutoSize = true;
            lb_DevelopedBy.ForeColor = Color.White;
            lb_DevelopedBy.Location = new Point(140, 337);
            lb_DevelopedBy.Name = "lb_DevelopedBy";
            lb_DevelopedBy.Size = new Size(82, 15);
            lb_DevelopedBy.TabIndex = 3;
            lb_DevelopedBy.Text = "Developed by:";
            // 
            // pb_Logo
            // 
            pb_Logo.Image = Properties.Resources.ActiPulse_Logo;
            pb_Logo.Location = new Point(64, 24);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(106, 92);
            pb_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Logo.TabIndex = 2;
            pb_Logo.TabStop = false;
            // 
            // lb_ActiPulse
            // 
            lb_ActiPulse.AutoSize = true;
            lb_ActiPulse.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ActiPulse.ForeColor = Color.White;
            lb_ActiPulse.Location = new Point(125, 161);
            lb_ActiPulse.Name = "lb_ActiPulse";
            lb_ActiPulse.Size = new Size(97, 22);
            lb_ActiPulse.TabIndex = 1;
            lb_ActiPulse.Text = "ActiPulse";
            // 
            // lb_WelcomeTo
            // 
            lb_WelcomeTo.AutoSize = true;
            lb_WelcomeTo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_WelcomeTo.ForeColor = Color.White;
            lb_WelcomeTo.Location = new Point(105, 139);
            lb_WelcomeTo.Name = "lb_WelcomeTo";
            lb_WelcomeTo.Size = new Size(117, 22);
            lb_WelcomeTo.TabIndex = 0;
            lb_WelcomeTo.Text = "Welcome to";
            // 
            // tb_CompanyName
            // 
            tb_CompanyName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_CompanyName.Location = new Point(252, 80);
            tb_CompanyName.Name = "tb_CompanyName";
            tb_CompanyName.Size = new Size(159, 21);
            tb_CompanyName.TabIndex = 18;
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.Location = new Point(252, 142);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.Size = new Size(159, 21);
            tb_Password.TabIndex = 19;
            // 
            // tb_ReenterPassword
            // 
            tb_ReenterPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ReenterPassword.Location = new Point(443, 142);
            tb_ReenterPassword.Name = "tb_ReenterPassword";
            tb_ReenterPassword.PasswordChar = '*';
            tb_ReenterPassword.Size = new Size(159, 21);
            tb_ReenterPassword.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 62);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 21;
            label1.Text = "Company name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 124);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 22;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 124);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 23;
            label3.Text = "Re-enter password:";
            // 
            // bt_X
            // 
            bt_X.BackColor = Color.Transparent;
            bt_X.Cursor = Cursors.Hand;
            bt_X.FlatAppearance.BorderSize = 0;
            bt_X.FlatStyle = FlatStyle.Flat;
            bt_X.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_X.ForeColor = Color.SpringGreen;
            bt_X.Location = new Point(591, 0);
            bt_X.Name = "bt_X";
            bt_X.Size = new Size(28, 35);
            bt_X.TabIndex = 24;
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
            bt_Back.Location = new Point(234, 0);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(19, 35);
            bt_Back.TabIndex = 25;
            bt_Back.Text = "<";
            bt_Back.UseVisualStyleBackColor = false;
            bt_Back.Click += bt_Back_Click;
            // 
            // lb_SignUpToYourAccount
            // 
            lb_SignUpToYourAccount.AutoSize = true;
            lb_SignUpToYourAccount.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_SignUpToYourAccount.ForeColor = Color.SpringGreen;
            lb_SignUpToYourAccount.Location = new Point(342, 9);
            lb_SignUpToYourAccount.Name = "lb_SignUpToYourAccount";
            lb_SignUpToYourAccount.Size = new Size(158, 18);
            lb_SignUpToYourAccount.TabIndex = 26;
            lb_SignUpToYourAccount.Text = "Sign up to a company";
            lb_SignUpToYourAccount.Click += lb_SignUpToYourAccount_Click;
            // 
            // SignUpCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 375);
            ControlBox = false;
            Controls.Add(lb_SignUpToYourAccount);
            Controls.Add(bt_Back);
            Controls.Add(bt_X);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_ReenterPassword);
            Controls.Add(tb_Password);
            Controls.Add(tb_CompanyName);
            Controls.Add(p_BlueSide);
            Controls.Add(bt_Register);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SignUpCompany_Load;
            p_BlueSide.ResumeLayout(false);
            p_BlueSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_Register;
        private Panel p_BlueSide;
        private Label lb_Names;
        private Label lb_DevelopedBy;
        private PictureBox pb_Logo;
        private Label lb_ActiPulse;
        private Label lb_WelcomeTo;
        private TextBox tb_CompanyName;
        private TextBox tb_Password;
        private TextBox tb_ReenterPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bt_X;
        private Button bt_Back;
        private Label lb_SignUpToYourAccount;
    }
}