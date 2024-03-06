using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecticityApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void txtBxEmailLogin_Enter(object sender, EventArgs e)
        {
            txtBxEmailLogin.ForeColor = Color.Black;
            txtBxEmailLogin.Text = "";
            txtBxEmailLogin.Enter -= txtBxEmailLogin_Enter;

            txtBxEmailLogin.Leave += txtBxEmailLogin_Leave;
            txtBxEmailLogin.TextChanged += txtBxEmailLogin_TextChanged;
        }

        private void txtBxEmailLogin_Leave(object sender, EventArgs e)
        {
            txtBxEmailLogin.ForeColor = Color.Silver;
            txtBxEmailLogin.Text = "Email";

            txtBxEmailLogin.Enter += txtBxEmailLogin_Enter;
        }

        private void txtBxEmailLogin_TextChanged(object sender, EventArgs e)
        {
            txtBxEmailLogin.Leave -= txtBxEmailLogin_Leave;
            txtBxEmailLogin.TextChanged -= txtBxEmailLogin_TextChanged;
        }

        private void txtBxPassLogin_Enter(Object sender, EventArgs e)
        {
            txtBxPassLogin.UseSystemPasswordChar = true;
            txtBxPassLogin.ForeColor = Color.Black;
            txtBxPassLogin.Text = "";
            txtBxPassLogin.Enter -= txtBxPassLogin_Enter;

            txtBxPassLogin.Leave += txtBxPassLogin_Leave;
            txtBxPassLogin.TextChanged += txtBxPassLogin_TextChanged;
        }

        private void txtBxPassLogin_Leave(object sender, EventArgs e)
        {
            txtBxPassLogin.ForeColor = Color.Silver;
            txtBxPassLogin.UseSystemPasswordChar = false;
            txtBxPassLogin.Text = "Password";

            txtBxPassLogin.Enter += txtBxPassLogin_Enter;
        }

        private void txtBxPassLogin_TextChanged(Object sender, EventArgs e)
        {
            txtBxPassLogin.Leave -= txtBxPassLogin_Leave;
            txtBxPassLogin.TextChanged -= txtBxPassLogin_TextChanged;
            btnShowPassLogin.Visible = true;
        }

        private void btnShowPassLogin_Click(object sender, EventArgs e)
        {
            bool isTxtBxPassLoginUseSystemPasswordChar = txtBxPassLogin.UseSystemPasswordChar;
            txtBxPassLogin.UseSystemPasswordChar = !isTxtBxPassLoginUseSystemPasswordChar;
        }

        private void btnNoAcc_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSignup.Visible = true;
            this.Text = "Signup";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool throwError = false;

            if (string.IsNullOrEmpty(this.txtBxEmailLogin.Text) || this.txtBxEmailLogin.Text == "Email")
            {
                errorProvider.SetError(txtBxEmailLogin, "Не указон Email!");
                throwError = true;
            }

            if (this.txtBxEmailLogin.Text.Length < 4 || !this.txtBxEmailLogin.Text.Contains("@"))
            {
                errorProvider.SetError(txtBxEmailLogin, "Такой Email не существует!");
                throwError = true;
            }

            if (this.txtBxPassLogin.Text.Length < 8)
            {
                errorProvider.SetError(txtBxPassLogin, "Неверный пароль!");
                throwError = true;
            }

            if (!throwError)
            {
                this.Hide();
            }
        }

        //panelSignup

        private void txtBxEmailSignup_Enter(object sender, EventArgs e)
        {
            txtBxEmailSignup.ForeColor = Color.Black;
            txtBxEmailSignup.Text = "";
            txtBxEmailSignup.Enter -= txtBxEmailSignup_Enter;

            txtBxEmailSignup.Leave += txtBxEmailSignup_Leave;
            txtBxEmailSignup.TextChanged += txtBxEmailSignup_TextChanged;
        }

        private void txtBxEmailSignup_Leave(object sender, EventArgs e)
        {
            txtBxEmailSignup.ForeColor = Color.Silver;
            txtBxEmailSignup.Text = "Email";
            txtBxEmailSignup.Enter += txtBxEmailSignup_Enter;
        }

        private void txtBxEmailSignup_TextChanged(object sender, EventArgs e)
        {
            txtBxEmailSignup.Leave -= txtBxEmailSignup_Leave;
            txtBxEmailSignup.TextChanged -= txtBxEmailSignup_TextChanged;
        }

        private void txtBxPassSignup_Enter(Object sender, EventArgs e)
        {
            txtBxPassSignup.Text = "";
            txtBxPassSignup.UseSystemPasswordChar = true;
            txtBxPassSignup.ForeColor = Color.Black;
            txtBxPassSignup.Enter -= txtBxPassSignup_Enter;

            txtBxPassSignup.Leave += txtBxPassSignup_Leave;
            txtBxPassSignup.TextChanged += txtBxPassSignup_TextChanged;
        }

        private void txtBxPassSignup_Leave(object sender, EventArgs e)
        {
            txtBxPassSignup.ForeColor = Color.Silver;
            txtBxPassSignup.UseSystemPasswordChar = false;
            txtBxPassSignup.Text = "Password";

            txtBxPassSignup.Enter += txtBxPassSignup_Enter;
        }

        private void txtBxPassSignup_TextChanged(Object sender, EventArgs e)
        {
            txtBxPassSignup.Leave -= txtBxPassSignup_Leave;
            txtBxPassSignup.TextChanged -= txtBxPassSignup_TextChanged;
            btnShowPassSignup.Visible = true;
        }

        private void txtBxPassConfirmSignup_Enter(object sender, EventArgs e)
        {
            txtBxPassConfirmSignup.UseSystemPasswordChar=true;
            txtBxPassConfirmSignup.ForeColor = Color.Black;
            txtBxPassConfirmSignup.Text = "";

            txtBxPassConfirmSignup.Leave += txtBxPassConfirmSignup_Leave;
            txtBxPassConfirmSignup.TextChanged += txtBxPassConfirmSignup_TextChanged;

        }

        private void txtBxPassConfirmSignup_Leave(object sender, EventArgs e)
        {
            txtBxPassConfirmSignup.UseSystemPasswordChar = false ;
            txtBxPassConfirmSignup.ForeColor = Color.Silver;
            txtBxPassConfirmSignup.Text = "Confirm password";
            txtBxPassConfirmSignup.Enter += txtBxPassConfirmSignup_Enter;
        }

        private void txtBxPassConfirmSignup_TextChanged(object sender, EventArgs e)
        {
            txtBxPassConfirmSignup.Leave -= txtBxPassConfirmSignup_Leave;
            txtBxPassConfirmSignup.TextChanged -= txtBxPassConfirmSignup_TextChanged;
            btnShowPassConfirmSignup.Visible = true;
        }

        private void btnShowPassSignup_Click(object sender, EventArgs e)
        {
            bool isTxtBxPassSignupUseSystemPasswordChar = txtBxPassSignup.UseSystemPasswordChar;
            txtBxPassSignup.UseSystemPasswordChar = !isTxtBxPassSignupUseSystemPasswordChar;
        }

        private void btnShowPassConfirmSignup_Click(object sender, EventArgs e)
        {
            bool isTxtBxPassConfirmSignupUseSystemPasswordChar = txtBxPassConfirmSignup.UseSystemPasswordChar;
            txtBxPassConfirmSignup.UseSystemPasswordChar = !isTxtBxPassConfirmSignupUseSystemPasswordChar;
        }

        private void btnHaveAcc_Click(Object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSignup.Visible = false;
            this.Text = "Login";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool throwError = false;

            if (string.IsNullOrEmpty(this.txtBxEmailSignup.Text) || txtBxEmailSignup.Text.Length < 4 || !txtBxEmailSignup.Text.Contains("@"))
            {
                errorProvider.SetError(this.txtBxEmailSignup, "Такой Email не существует!");
                throwError = true;
            }

            if (txtBxPassSignup.Text != txtBxPassConfirmSignup.Text)
            {
                errorProvider.SetError(txtBxPassConfirmSignup, "Подтвердите пароль!");
                throwError = true;
            }

            if (txtBxPassSignup.Text.Length < 8)
            {
                errorProvider.SetError(txtBxPassSignup, "Введите больше 8 символов!");
                throwError = true;
            }

            if(!throwError)
            {
                this.Hide();
            }
        }
    }
}
