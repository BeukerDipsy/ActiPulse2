using System.Data.SqlClient;
using System.Text;
using Test;

namespace ActiPulse
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            // Open SignUpForm when the New User button is clicked
            SignUp SignUpForm = new SignUp();
            SignUpForm.Show();
            this.Hide(); // Optionally hide the SignInForm
        }

        private readonly DBAccess objDbAccess = new DBAccess();

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string userName = tb_Username.Text;
            string userPassword = tb_Password.Text;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your username", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter your password", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM accounts WHERE Username = @Username";

            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@Username", userName);

                SqlDataReader reader = objDbAccess.ExecuteReader(cmd);

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        byte[] password = Encoding.Default.GetBytes(userPassword);
                        string full_hash = (string)reader.GetValue(2);
                        string shash = (string)full_hash.Split(":")[1];
                        string ssalt = (string)full_hash.Split(":")[0];
                        byte[] hash = Convert.FromBase64String(shash);
                        byte[] salt = Convert.FromBase64String(ssalt);
                        byte[] hashed = Encrypt.CreateHash(password, salt);
                        string shashed = Convert.ToBase64String(hashed);

                        //if (Encrypt.VerifyHash(password, hash, salt))
                        if (shashed != null && shash == shashed)
                        {
                            MessageBox.Show("Successful login! Click 'OK' to open the Main window.", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            MainScreenActiPulse main = new MainScreenActiPulse();
                            main.userName = userName;
                            main.Show(); // Show the main screen
                        }
                        else
                        {
                            MessageBox.Show("Ouch, was that the wrong login?", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ouch, was that the wrong login?", "ActiPulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                objDbAccess.CloseConnection();
            }
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_Load_1(object sender, EventArgs e)
        {

        }

        private void SignIn_Load_2(object sender, EventArgs e)
        {

        }

        private void p_WhiteSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_company_Click(object sender, EventArgs e)
        {
            SignInCompany signInCompany = new SignInCompany();
            signInCompany.Show();
            this.Hide();
        }
    }
}