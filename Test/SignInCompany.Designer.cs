namespace ActiPulse
{
    partial class SignInCompany
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
            p_WhiteSide = new Panel();
            bt_user = new Button();
            bt_NewCompany = new Button();
            bt_Login = new Button();
            lb_Password = new Label();
            tb_Password = new TextBox();
            lb_CompanyName = new Label();
            tb_CompanyName = new TextBox();
            lb_SignUpToYourAccount = new Label();
            bt_X = new Button();
            p_BlueSide = new Panel();
            lb_Names = new Label();
            lb_DevelopedBy = new Label();
            pb_Logo = new PictureBox();
            lb_ActiPulse = new Label();
            lb_WelcomeTo = new Label();
            p_WhiteSide.SuspendLayout();
            p_BlueSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            SuspendLayout();
            // 
            // p_WhiteSide
            // 
            p_WhiteSide.Controls.Add(bt_user);
            p_WhiteSide.Controls.Add(bt_NewCompany);
            p_WhiteSide.Controls.Add(bt_Login);
            p_WhiteSide.Controls.Add(lb_Password);
            p_WhiteSide.Controls.Add(tb_Password);
            p_WhiteSide.Controls.Add(lb_CompanyName);
            p_WhiteSide.Controls.Add(tb_CompanyName);
            p_WhiteSide.Controls.Add(lb_SignUpToYourAccount);
            p_WhiteSide.Controls.Add(bt_X);
            p_WhiteSide.Location = new Point(228, 0);
            p_WhiteSide.Name = "p_WhiteSide";
            p_WhiteSide.Size = new Size(390, 376);
            p_WhiteSide.TabIndex = 4;
            // 
            // bt_user
            // 
            bt_user.BackColor = Color.SpringGreen;
            bt_user.FlatStyle = FlatStyle.Flat;
            bt_user.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_user.ForeColor = Color.White;
            bt_user.Location = new Point(97, 340);
            bt_user.Name = "bt_user";
            bt_user.Size = new Size(198, 27);
            bt_user.TabIndex = 17;
            bt_user.Text = "User Login/Register";
            bt_user.UseVisualStyleBackColor = false;
            bt_user.Click += bt_user_Click;
            // 
            // bt_NewCompany
            // 
            bt_NewCompany.BackColor = Color.SpringGreen;
            bt_NewCompany.FlatStyle = FlatStyle.Flat;
            bt_NewCompany.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_NewCompany.ForeColor = Color.White;
            bt_NewCompany.Location = new Point(42, 290);
            bt_NewCompany.Name = "bt_NewCompany";
            bt_NewCompany.Size = new Size(129, 34);
            bt_NewCompany.TabIndex = 16;
            bt_NewCompany.Text = "Register";
            bt_NewCompany.UseVisualStyleBackColor = false;
            bt_NewCompany.Click += bt_NewUser_Click_1;
            // 
            // bt_Login
            // 
            bt_Login.BackColor = Color.SpringGreen;
            bt_Login.FlatStyle = FlatStyle.Flat;
            bt_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Login.ForeColor = Color.White;
            bt_Login.Location = new Point(217, 290);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(129, 34);
            bt_Login.TabIndex = 15;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = false;
            bt_Login.Click += bt_Login_Click;
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Location = new Point(42, 198);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(60, 15);
            lb_Password.TabIndex = 12;
            lb_Password.Text = "Password:";
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.Location = new Point(42, 216);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.Size = new Size(304, 21);
            tb_Password.TabIndex = 11;
            // 
            // lb_CompanyName
            // 
            lb_CompanyName.AutoSize = true;
            lb_CompanyName.Location = new Point(39, 127);
            lb_CompanyName.Name = "lb_CompanyName";
            lb_CompanyName.Size = new Size(95, 15);
            lb_CompanyName.TabIndex = 10;
            lb_CompanyName.Text = "Company name:";
            // 
            // tb_CompanyName
            // 
            tb_CompanyName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_CompanyName.Location = new Point(39, 145);
            tb_CompanyName.Name = "tb_CompanyName";
            tb_CompanyName.Size = new Size(307, 21);
            tb_CompanyName.TabIndex = 9;
            // 
            // lb_SignUpToYourAccount
            // 
            lb_SignUpToYourAccount.AutoSize = true;
            lb_SignUpToYourAccount.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_SignUpToYourAccount.ForeColor = Color.SpringGreen;
            lb_SignUpToYourAccount.Location = new Point(125, 12);
            lb_SignUpToYourAccount.Name = "lb_SignUpToYourAccount";
            lb_SignUpToYourAccount.Size = new Size(142, 18);
            lb_SignUpToYourAccount.TabIndex = 1;
            lb_SignUpToYourAccount.Text = "Sign in to ActiPulse";
            // 
            // bt_X
            // 
            bt_X.BackColor = Color.Transparent;
            bt_X.Cursor = Cursors.Hand;
            bt_X.FlatAppearance.BorderSize = 0;
            bt_X.FlatStyle = FlatStyle.Flat;
            bt_X.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_X.ForeColor = Color.SpringGreen;
            bt_X.Location = new Point(360, 3);
            bt_X.Name = "bt_X";
            bt_X.Size = new Size(28, 35);
            bt_X.TabIndex = 0;
            bt_X.Text = "X";
            bt_X.UseVisualStyleBackColor = false;
            bt_X.Click += bt_X_Click;
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
            p_BlueSide.TabIndex = 5;
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
            // SignInCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 375);
            ControlBox = false;
            Controls.Add(p_BlueSide);
            Controls.Add(p_WhiteSide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignInCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInCompany";
            Load += SignInCompany_Load;
            p_WhiteSide.ResumeLayout(false);
            p_WhiteSide.PerformLayout();
            p_BlueSide.ResumeLayout(false);
            p_BlueSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel p_WhiteSide;
        private Button bt_user;
        private Button bt_NewCompany;
        private Button bt_Login;
        private Label lb_Password;
        private TextBox tb_Password;
        private Label lb_CompanyName;
        private TextBox tb_CompanyName;
        private Label lb_SignUpToYourAccount;
        private Button bt_X;
        private Panel p_BlueSide;
        private Label lb_Names;
        private Label lb_DevelopedBy;
        private PictureBox pb_Logo;
        private Label lb_ActiPulse;
        private Label lb_WelcomeTo;
    }
}