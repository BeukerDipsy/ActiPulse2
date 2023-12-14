using ActiPulse;
using System.Data.SqlClient;
using Konscious.Security.Cryptography;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Test
{
    public partial class SignUp : Form
    {

        DBAccess objDbAccess = new DBAccess();

        public SignUp()
        {
            InitializeComponent();

            tb_Firstname.TabIndex = 1;
            tb_Preposition.TabIndex = 2;
            tb_Lastname.TabIndex = 3;
            cb_Country.TabIndex = 4;
            tb_City.TabIndex = 5;
            tb_Email.TabIndex = 6;
            tb_Username.TabIndex = 7;
            tb_Password.TabIndex = 8;
            tb_ReenterPassword.TabIndex = 9;
            bt_Back.TabIndex = 10;
        }

        private void bt_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            SignIn signInForm = new SignIn();
            signInForm.Show();

            this.Close();
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {

            bool CompanyExists = false;
            string UsernameCheck = "";
            string Company = "";
            string email = "";


            string userFirstName = tb_Firstname.Text;
            string userPreposition = tb_Preposition.Text;
            string userLastName = tb_Lastname.Text;
            string userCountry = cb_Country.Text;
            string userCity = tb_City.Text;
            string userEmail = tb_Email.Text;
            string userName = tb_Username.Text;
            string userPassword = tb_Password.Text;
            string reenterPassword = tb_ReenterPassword.Text;
            string userCompanyString = Convert.ToString(tb_company.Value);

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userFirstName) || string.IsNullOrEmpty(userLastName) ||
                string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(userCountry) || string.IsNullOrEmpty(userCity) || string.IsNullOrEmpty(userCompanyString))
            {
                MessageBox.Show("Please fill in all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (userPassword != reenterPassword)
            {
                MessageBox.Show("Your passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string emailCheck = "SELECT email FROM accounts";
            using (SqlCommand CheckEmail = new SqlCommand(emailCheck))
            {
                SqlDataReader CheckEmailReader = objDbAccess.ExecuteReader(CheckEmail);
                if (CheckEmailReader.HasRows)
                {
                    while (CheckEmailReader.Read())
                    {
                        int emailCount = CheckEmailReader.FieldCount;
                        for (int i = 0; i < emailCount; i++)
                        {
                            email = $"{CheckEmailReader.GetValue(i)}";
                            if (email == $"{userEmail}")
                            {
                                MessageBox.Show("This email already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                objDbAccess.CloseConnection();
                                return;
                            }
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }

            string CompanyCheck = "SELECT company_id FROM company";
            using (SqlCommand CheckCompany = new SqlCommand(CompanyCheck))
            {
                SqlDataReader CheckCompanyReader = objDbAccess.ExecuteReader(CheckCompany);
                if (CheckCompanyReader.HasRows)
                {
                    while (CheckCompanyReader.Read())
                    {
                        int CompanyCount = CheckCompanyReader.FieldCount;
                        for (int i = 0; i < CompanyCount; i++)
                        {
                            Company = $"{CheckCompanyReader.GetValue(i)}";
                            if (Company == $"{userCompanyString}")
                            {
                                CompanyExists = true;
                            }
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }
            if (CompanyExists == false)
            {
                MessageBox.Show("This company-id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            string allUsernames = "SELECT username FROM accounts";
            using (SqlCommand UsernamesOphalen = new SqlCommand(allUsernames))
            {
                SqlDataReader UsernameReader = objDbAccess.ExecuteReader(UsernamesOphalen);
                if (UsernameReader.HasRows)
                {
                    while (UsernameReader.Read())
                    {
                        int fieldCountUsernames = UsernameReader.FieldCount;
                        for (int i = 0; i < fieldCountUsernames; i++)
                        {
                            UsernameCheck = $"{UsernameReader.GetValue(i)}";
                            if (UsernameCheck == userName)
                            {
                                MessageBox.Show("This username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                objDbAccess.CloseConnection();
                                return;
                            }
                        }
                    }
                }
                objDbAccess.CloseConnection();
            }


            byte[] salt = Encrypt.GenerateSalt();
            byte[] password = Encoding.Default.GetBytes(userPassword);

            byte[] encryptedPassword = Encrypt.CreateHash(password, salt);


            string query = "INSERT INTO accounts (username, firstname, preposition, lastname, email, password, country, city, company_id) " +
                           "VALUES (@Username, @FirstName, @Preposition, @LastName, @Email, @Password, @Country, @City, @Company_ID)";

            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@Username", userName);
                cmd.Parameters.AddWithValue("@Preposition", userPreposition);
                cmd.Parameters.AddWithValue("@FirstName", userFirstName);
                cmd.Parameters.AddWithValue("@LastName", userLastName);
                cmd.Parameters.AddWithValue("@Email", userEmail);
                cmd.Parameters.AddWithValue("@Password", $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(encryptedPassword)}");
                cmd.Parameters.AddWithValue("@Country", userCountry);
                cmd.Parameters.AddWithValue("@City", userCity);
                cmd.Parameters.AddWithValue("@Company_ID", userCompanyString);

                int rowsAffected = objDbAccess.ExecuteNonQuery(cmd);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    // Additional actions if registration is successful
                }
                else
                {
                    MessageBox.Show("Error during the registration!", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Open the SignIn form
                SignIn signInForm = new SignIn();
                signInForm.Show();
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p_BlueSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}