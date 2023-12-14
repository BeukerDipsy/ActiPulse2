namespace Test
{
    partial class SignUp
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
            p_BlueSide = new Panel();
            lb_Names = new Label();
            lb_DevelopedBy = new Label();
            pb_Logo = new PictureBox();
            lb_ActiPulse = new Label();
            lb_WelcomeTo = new Label();
            p_WhiteSide = new Panel();
            tb_company = new NumericUpDown();
            Company_Name = new Label();
            bt_Back = new Button();
            tb_City = new TextBox();
            cb_Country = new ComboBox();
            lb_Country = new Label();
            lb_City = new Label();
            lb_ReenterPassword = new Label();
            tb_ReenterPassword = new TextBox();
            bt_Register = new Button();
            label3 = new Label();
            tb_Email = new TextBox();
            lb_Password = new Label();
            tb_Password = new TextBox();
            lb_Username = new Label();
            tb_Username = new TextBox();
            lb_Preposition = new Label();
            tb_Preposition = new TextBox();
            lb_Lastname = new Label();
            tb_Lastname = new TextBox();
            lb_Firstname = new Label();
            tb_Firstname = new TextBox();
            lb_SignUpToYourAccount = new Label();
            bt_X = new Button();
            p_BlueSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            p_WhiteSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tb_company).BeginInit();
            SuspendLayout();
            // 
            // p_BlueSide
            // 
            p_BlueSide.BackColor = Color.FromArgb(61, 123, 177);
            p_BlueSide.Controls.Add(lb_Names);
            p_BlueSide.Controls.Add(lb_DevelopedBy);
            p_BlueSide.Controls.Add(pb_Logo);
            p_BlueSide.Controls.Add(lb_ActiPulse);
            p_BlueSide.Controls.Add(lb_WelcomeTo);
            p_BlueSide.Dock = DockStyle.Left;
            p_BlueSide.Location = new Point(0, 0);
            p_BlueSide.Name = "p_BlueSide";
            p_BlueSide.Size = new Size(228, 376);
            p_BlueSide.TabIndex = 0;
            p_BlueSide.Paint += p_BlueSide_Paint;
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
            pb_Logo.Image = ActiPulse.Properties.Resources.ActiPulse_Logo;
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
            // p_WhiteSide
            // 
            p_WhiteSide.Controls.Add(tb_company);
            p_WhiteSide.Controls.Add(Company_Name);
            p_WhiteSide.Controls.Add(bt_Back);
            p_WhiteSide.Controls.Add(tb_City);
            p_WhiteSide.Controls.Add(cb_Country);
            p_WhiteSide.Controls.Add(lb_Country);
            p_WhiteSide.Controls.Add(lb_City);
            p_WhiteSide.Controls.Add(lb_ReenterPassword);
            p_WhiteSide.Controls.Add(tb_ReenterPassword);
            p_WhiteSide.Controls.Add(bt_Register);
            p_WhiteSide.Controls.Add(label3);
            p_WhiteSide.Controls.Add(tb_Email);
            p_WhiteSide.Controls.Add(lb_Password);
            p_WhiteSide.Controls.Add(tb_Password);
            p_WhiteSide.Controls.Add(lb_Username);
            p_WhiteSide.Controls.Add(tb_Username);
            p_WhiteSide.Controls.Add(lb_Preposition);
            p_WhiteSide.Controls.Add(tb_Preposition);
            p_WhiteSide.Controls.Add(lb_Lastname);
            p_WhiteSide.Controls.Add(tb_Lastname);
            p_WhiteSide.Controls.Add(lb_Firstname);
            p_WhiteSide.Controls.Add(tb_Firstname);
            p_WhiteSide.Controls.Add(lb_SignUpToYourAccount);
            p_WhiteSide.Controls.Add(bt_X);
            p_WhiteSide.Dock = DockStyle.Fill;
            p_WhiteSide.Location = new Point(228, 0);
            p_WhiteSide.Name = "p_WhiteSide";
            p_WhiteSide.Size = new Size(391, 376);
            p_WhiteSide.TabIndex = 1;
            // 
            // tb_company
            // 
            tb_company.Location = new Point(20, 328);
            tb_company.Name = "tb_company";
            tb_company.Size = new Size(120, 23);
            tb_company.TabIndex = 27;
            // 
            // Company_Name
            // 
            Company_Name.AutoSize = true;
            Company_Name.Location = new Point(20, 300);
            Company_Name.Name = "Company_Name";
            Company_Name.Size = new Size(75, 15);
            Company_Name.TabIndex = 26;
            Company_Name.Text = "Company id:";
            // 
            // bt_Back
            // 
            bt_Back.BackColor = Color.Transparent;
            bt_Back.Cursor = Cursors.Hand;
            bt_Back.FlatAppearance.BorderSize = 0;
            bt_Back.FlatStyle = FlatStyle.Flat;
            bt_Back.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Back.ForeColor = Color.FromArgb(61, 123, 177);
            bt_Back.Location = new Point(0, 3);
            bt_Back.Name = "bt_Back";
            bt_Back.Size = new Size(28, 35);
            bt_Back.TabIndex = 24;
            bt_Back.Text = "<";
            bt_Back.UseVisualStyleBackColor = false;
            bt_Back.Click += bt_Back_Click;
            // 
            // tb_City
            // 
            tb_City.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_City.Location = new Point(201, 152);
            tb_City.Name = "tb_City";
            tb_City.Size = new Size(159, 21);
            tb_City.TabIndex = 23;
            // 
            // cb_Country
            // 
            cb_Country.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Country.FormattingEnabled = true;
            cb_Country.Items.AddRange(new object[] { "The Netherlands", "Belgium", "France", "Germany" });
            cb_Country.Location = new Point(19, 152);
            cb_Country.Name = "cb_Country";
            cb_Country.Size = new Size(159, 23);
            cb_Country.TabIndex = 22;
            // 
            // lb_Country
            // 
            lb_Country.AutoSize = true;
            lb_Country.Location = new Point(19, 134);
            lb_Country.Name = "lb_Country";
            lb_Country.Size = new Size(53, 15);
            lb_Country.TabIndex = 21;
            lb_Country.Text = "Country:";
            // 
            // lb_City
            // 
            lb_City.AutoSize = true;
            lb_City.Location = new Point(201, 134);
            lb_City.Name = "lb_City";
            lb_City.Size = new Size(31, 15);
            lb_City.TabIndex = 19;
            lb_City.Text = "City:";
            // 
            // lb_ReenterPassword
            // 
            lb_ReenterPassword.AutoSize = true;
            lb_ReenterPassword.Location = new Point(201, 251);
            lb_ReenterPassword.Name = "lb_ReenterPassword";
            lb_ReenterPassword.Size = new Size(108, 15);
            lb_ReenterPassword.TabIndex = 17;
            lb_ReenterPassword.Text = "Re-enter Password:";
            // 
            // tb_ReenterPassword
            // 
            tb_ReenterPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_ReenterPassword.Location = new Point(201, 269);
            tb_ReenterPassword.Name = "tb_ReenterPassword";
            tb_ReenterPassword.PasswordChar = '*';
            tb_ReenterPassword.Size = new Size(159, 21);
            tb_ReenterPassword.TabIndex = 16;
            // 
            // bt_Register
            // 
            bt_Register.BackColor = Color.FromArgb(61, 123, 177);
            bt_Register.FlatStyle = FlatStyle.Flat;
            bt_Register.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Register.ForeColor = Color.White;
            bt_Register.Location = new Point(215, 318);
            bt_Register.Name = "bt_Register";
            bt_Register.Size = new Size(129, 34);
            bt_Register.TabIndex = 15;
            bt_Register.Text = "Register";
            bt_Register.UseVisualStyleBackColor = false;
            bt_Register.Click += bt_Register_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 194);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 14;
            label3.Text = "Email:";
            // 
            // tb_Email
            // 
            tb_Email.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Email.Location = new Point(19, 212);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(159, 21);
            tb_Email.TabIndex = 13;
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Location = new Point(19, 251);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(60, 15);
            lb_Password.TabIndex = 12;
            lb_Password.Text = "Password:";
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.Location = new Point(19, 269);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.Size = new Size(159, 21);
            tb_Password.TabIndex = 11;
            // 
            // lb_Username
            // 
            lb_Username.AutoSize = true;
            lb_Username.Location = new Point(201, 194);
            lb_Username.Name = "lb_Username";
            lb_Username.Size = new Size(63, 15);
            lb_Username.TabIndex = 10;
            lb_Username.Text = "Username:";
            // 
            // tb_Username
            // 
            tb_Username.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Username.Location = new Point(201, 212);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(159, 21);
            tb_Username.TabIndex = 9;
            // 
            // lb_Preposition
            // 
            lb_Preposition.AutoSize = true;
            lb_Preposition.Location = new Point(150, 77);
            lb_Preposition.Name = "lb_Preposition";
            lb_Preposition.Size = new Size(70, 15);
            lb_Preposition.TabIndex = 8;
            lb_Preposition.Text = "Preposition:";
            // 
            // tb_Preposition
            // 
            tb_Preposition.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Preposition.Location = new Point(150, 99);
            tb_Preposition.Name = "tb_Preposition";
            tb_Preposition.Size = new Size(76, 21);
            tb_Preposition.TabIndex = 7;
            // 
            // lb_Lastname
            // 
            lb_Lastname.AutoSize = true;
            lb_Lastname.Location = new Point(245, 77);
            lb_Lastname.Name = "lb_Lastname";
            lb_Lastname.Size = new Size(64, 15);
            lb_Lastname.TabIndex = 6;
            lb_Lastname.Text = "Last name:";
            // 
            // tb_Lastname
            // 
            tb_Lastname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Lastname.Location = new Point(245, 99);
            tb_Lastname.Name = "tb_Lastname";
            tb_Lastname.Size = new Size(115, 21);
            tb_Lastname.TabIndex = 5;
            // 
            // lb_Firstname
            // 
            lb_Firstname.AutoSize = true;
            lb_Firstname.Location = new Point(18, 77);
            lb_Firstname.Name = "lb_Firstname";
            lb_Firstname.Size = new Size(65, 15);
            lb_Firstname.TabIndex = 4;
            lb_Firstname.Text = "First name:";
            // 
            // tb_Firstname
            // 
            tb_Firstname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Firstname.Location = new Point(18, 99);
            tb_Firstname.Name = "tb_Firstname";
            tb_Firstname.Size = new Size(115, 21);
            tb_Firstname.TabIndex = 2;
            // 
            // lb_SignUpToYourAccount
            // 
            lb_SignUpToYourAccount.AutoSize = true;
            lb_SignUpToYourAccount.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_SignUpToYourAccount.ForeColor = Color.FromArgb(61, 123, 177);
            lb_SignUpToYourAccount.Location = new Point(125, 12);
            lb_SignUpToYourAccount.Name = "lb_SignUpToYourAccount";
            lb_SignUpToYourAccount.Size = new Size(157, 18);
            lb_SignUpToYourAccount.TabIndex = 1;
            lb_SignUpToYourAccount.Text = "Sign up to an account";
            // 
            // bt_X
            // 
            bt_X.BackColor = Color.Transparent;
            bt_X.Cursor = Cursors.Hand;
            bt_X.FlatAppearance.BorderSize = 0;
            bt_X.FlatStyle = FlatStyle.Flat;
            bt_X.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_X.ForeColor = Color.FromArgb(61, 123, 177);
            bt_X.Location = new Point(360, 3);
            bt_X.Name = "bt_X";
            bt_X.Size = new Size(28, 35);
            bt_X.TabIndex = 0;
            bt_X.Text = "X";
            bt_X.UseVisualStyleBackColor = false;
            bt_X.Click += bt_Close_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 376);
            ControlBox = false;
            Controls.Add(p_WhiteSide);
            Controls.Add(p_BlueSide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up to ActiPulse";
            p_BlueSide.ResumeLayout(false);
            p_BlueSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            p_WhiteSide.ResumeLayout(false);
            p_WhiteSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tb_company).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel p_BlueSide;
        private Panel p_WhiteSide;
        private PictureBox pb_Logo;
        private Label lb_ActiPulse;
        private Label lb_WelcomeTo;
        private Label lb_DevelopedBy;
        private Label lb_Names;
        private Label lb_SignUpToYourAccount;
        private TextBox tb_Firstname;
        private Label lb_Firstname;
        private Label lb_Username;
        private TextBox tb_Username;
        private Label lb_Preposition;
        private TextBox tb_Preposition;
        private Label lb_Lastname;
        private TextBox tb_Lastname;
        private Label lb_Password;
        private TextBox tb_Password;
        private Button bt_Register;
        private Label label3;
        private TextBox tb_Email;
        private Label lb_ReenterPassword;
        private TextBox tb_ReenterPassword;
        private Label lb_Country;
        private TextBox tb_Count;
        private Label lb_City;
        private TextBox tb_City;
        private ComboBox cb_Country;
        private TextBox textBox2;
        private Button bt_Back;
        private Button bt_X;
        private Label Company_Name;
        private NumericUpDown tb_company;
    }
}