using System;
using System.Drawing;
using System.Windows.Forms;

namespace Giocodellanno
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            this.Text = "Login";
            this.Size = new Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblUsername = new Label() { Text = "Username:", Location = new Point(20, 20) };
            txtUsername = new TextBox() { Location = new Point(120, 20), Width = 150 };

            Label lblPassword = new Label() { Text = "Password:", Location = new Point(20, 60) };
            txtPassword = new TextBox() { Location = new Point(120, 60), Width = 150, PasswordChar = '*' };

            btnLogin = new Button() { Text = "Login", Location = new Point(100, 100) };
            btnLogin.Click += BtnLogin_Click;

            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Accesso riuscito!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crea e mostra il Form2
                Form2 form2 = new Form2();
                form2.Show();

                // Chiudi il Form di login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenziali errate!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
