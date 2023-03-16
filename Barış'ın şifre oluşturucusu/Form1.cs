using System.Security.Cryptography;
using System.Text;

namespace Barış_ın_şifre_oluşturucusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lengthTextBox.Text))
            {
                MessageBox.Show("Lütfen bir şifre uzunluğu gir.");
                return;
            }

            int length = Convert.ToInt32(lengthTextBox.Text);
            string password = GeneratePassword(length);
            passwordTextBox.Text = password;
        }

        private string GeneratePassword(int length)
        {
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=[{]};:<>|./?";
            byte[] randomBytes = new byte[length];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            StringBuilder passwordBuilder = new StringBuilder(length);
            foreach (byte b in randomBytes)
            {
                passwordBuilder.Append(allowedChars[b % allowedChars.Length]);
            }
            return passwordBuilder.ToString();
        }
    }
}