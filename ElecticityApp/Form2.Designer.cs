using System.Drawing;

namespace ElecticityApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnShowPassLogin = new System.Windows.Forms.Button();
            this.btnNoAcc = new System.Windows.Forms.Button();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBxPassLogin = new System.Windows.Forms.TextBox();
            this.txtBxEmailLogin = new System.Windows.Forms.TextBox();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.btnShowPassSignup = new System.Windows.Forms.Button();
            this.btnHaveAcc = new System.Windows.Forms.Button();
            this.btnShowPassConfirmSignup = new System.Windows.Forms.Button();
            this.lblSignup = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtBxPassSignup = new System.Windows.Forms.TextBox();
            this.txtBxPassConfirmSignup = new System.Windows.Forms.TextBox();
            this.txtBxEmailSignup = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelLogin.SuspendLayout();
            this.panelSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnShowPassLogin);
            this.panelLogin.Controls.Add(this.btnNoAcc);
            this.panelLogin.Controls.Add(this.btnForgotPass);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtBxPassLogin);
            this.panelLogin.Controls.Add(this.txtBxEmailLogin);
            this.panelLogin.Location = new System.Drawing.Point(100, 80);
            this.panelLogin.MaximumSize = new System.Drawing.Size(600, 500);
            this.panelLogin.MinimumSize = new System.Drawing.Size(600, 500);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(600, 500);
            this.panelLogin.TabIndex = 0;
            // 
            // btnShowPassLogin
            // 
            this.btnShowPassLogin.BackgroundImage = global::ElecticityApp.Properties.Resources.ShowPassIcon;
            this.btnShowPassLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassLogin.FlatAppearance.BorderSize = 0;
            this.btnShowPassLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassLogin.Location = new System.Drawing.Point(506, 220);
            this.btnShowPassLogin.Name = "btnShowPassLogin";
            this.btnShowPassLogin.Size = new System.Drawing.Size(34, 34);
            this.btnShowPassLogin.TabIndex = 6;
            this.btnShowPassLogin.UseVisualStyleBackColor = true;
            this.btnShowPassLogin.Visible = false;
            this.btnShowPassLogin.Click += new System.EventHandler(this.btnShowPassLogin_Click);
            // 
            // btnNoAcc
            // 
            this.btnNoAcc.FlatAppearance.BorderSize = 0;
            this.btnNoAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNoAcc.Location = new System.Drawing.Point(100, 400);
            this.btnNoAcc.Name = "btnNoAcc";
            this.btnNoAcc.Size = new System.Drawing.Size(400, 35);
            this.btnNoAcc.TabIndex = 5;
            this.btnNoAcc.Text = "Don\'t have an account? Sign up";
            this.btnNoAcc.UseVisualStyleBackColor = true;
            this.btnNoAcc.Click += new System.EventHandler(this.btnNoAcc_Click);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.FlatAppearance.BorderSize = 0;
            this.btnForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForgotPass.Location = new System.Drawing.Point(315, 260);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(185, 34);
            this.btnForgotPass.TabIndex = 4;
            this.btnForgotPass.Text = "Forgot password";
            this.btnForgotPass.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(238, 50);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(123, 46);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(211)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(100, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBxPassLogin
            // 
            this.txtBxPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxPassLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxPassLogin.ForeColor = System.Drawing.Color.Silver;
            this.txtBxPassLogin.Location = new System.Drawing.Point(100, 220);
            this.txtBxPassLogin.Name = "txtBxPassLogin";
            this.txtBxPassLogin.Size = new System.Drawing.Size(400, 34);
            this.txtBxPassLogin.TabIndex = 1;
            this.txtBxPassLogin.Text = "Password";
            this.txtBxPassLogin.Enter += new System.EventHandler(this.txtBxPassLogin_Enter);
            // 
            // txtBxEmailLogin
            // 
            this.txtBxEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxEmailLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxEmailLogin.ForeColor = System.Drawing.Color.Silver;
            this.txtBxEmailLogin.Location = new System.Drawing.Point(100, 150);
            this.txtBxEmailLogin.Name = "txtBxEmailLogin";
            this.txtBxEmailLogin.Size = new System.Drawing.Size(400, 34);
            this.txtBxEmailLogin.TabIndex = 0;
            this.txtBxEmailLogin.Text = "Email";
            this.txtBxEmailLogin.Enter += new System.EventHandler(this.txtBxEmailLogin_Enter);
            // 
            // panelSignup
            // 
            this.panelSignup.Controls.Add(this.btnShowPassSignup);
            this.panelSignup.Controls.Add(this.btnHaveAcc);
            this.panelSignup.Controls.Add(this.btnShowPassConfirmSignup);
            this.panelSignup.Controls.Add(this.lblSignup);
            this.panelSignup.Controls.Add(this.btnSignUp);
            this.panelSignup.Controls.Add(this.txtBxPassSignup);
            this.panelSignup.Controls.Add(this.txtBxPassConfirmSignup);
            this.panelSignup.Controls.Add(this.txtBxEmailSignup);
            this.panelSignup.Location = new System.Drawing.Point(100, 80);
            this.panelSignup.MaximumSize = new System.Drawing.Size(600, 500);
            this.panelSignup.MinimumSize = new System.Drawing.Size(600, 500);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(600, 500);
            this.panelSignup.TabIndex = 0;
            // 
            // btnShowPassSignup
            // 
            this.btnShowPassSignup.BackgroundImage = global::ElecticityApp.Properties.Resources.ShowPassIcon;
            this.btnShowPassSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassSignup.FlatAppearance.BorderSize = 0;
            this.btnShowPassSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassSignup.Location = new System.Drawing.Point(506, 220);
            this.btnShowPassSignup.Name = "btnShowPassSignup";
            this.btnShowPassSignup.Size = new System.Drawing.Size(34, 34);
            this.btnShowPassSignup.TabIndex = 3;
            this.btnShowPassSignup.UseVisualStyleBackColor = true;
            this.btnShowPassSignup.Visible = false;
            this.btnShowPassSignup.Click += new System.EventHandler(this.btnShowPassSignup_Click);
            // 
            // btnHaveAcc
            // 
            this.btnHaveAcc.FlatAppearance.BorderSize = 0;
            this.btnHaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaveAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHaveAcc.Location = new System.Drawing.Point(100, 470);
            this.btnHaveAcc.Name = "btnHaveAcc";
            this.btnHaveAcc.Size = new System.Drawing.Size(400, 35);
            this.btnHaveAcc.TabIndex = 7;
            this.btnHaveAcc.Text = "Already have an account? Log in";
            this.btnHaveAcc.UseVisualStyleBackColor = true;
            this.btnHaveAcc.Click += new System.EventHandler(this.btnHaveAcc_Click);
            // 
            // btnShowPassConfirmSignup
            // 
            this.btnShowPassConfirmSignup.BackgroundImage = global::ElecticityApp.Properties.Resources.ShowPassIcon;
            this.btnShowPassConfirmSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassConfirmSignup.FlatAppearance.BorderSize = 0;
            this.btnShowPassConfirmSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassConfirmSignup.Location = new System.Drawing.Point(506, 290);
            this.btnShowPassConfirmSignup.Name = "btnShowPassConfirmSignup";
            this.btnShowPassConfirmSignup.Size = new System.Drawing.Size(34, 34);
            this.btnShowPassConfirmSignup.TabIndex = 5;
            this.btnShowPassConfirmSignup.UseVisualStyleBackColor = true;
            this.btnShowPassConfirmSignup.Visible = false;
            this.btnShowPassConfirmSignup.Click += new System.EventHandler(this.btnShowPassConfirmSignup_Click);
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSignup.Location = new System.Drawing.Point(238, 50);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(150, 46);
            this.lblSignup.TabIndex = 0;
            this.lblSignup.Text = "Signup";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(113)))), ((int)(((byte)(211)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(100, 390);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(400, 50);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtBxPassSignup
            // 
            this.txtBxPassSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxPassSignup.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxPassSignup.ForeColor = System.Drawing.Color.Silver;
            this.txtBxPassSignup.Location = new System.Drawing.Point(100, 220);
            this.txtBxPassSignup.Name = "txtBxPassSignup";
            this.txtBxPassSignup.Size = new System.Drawing.Size(400, 34);
            this.txtBxPassSignup.TabIndex = 2;
            this.txtBxPassSignup.Text = "Password";
            this.txtBxPassSignup.Enter += new System.EventHandler(this.txtBxPassSignup_Enter);
            // 
            // txtBxPassConfirmSignup
            // 
            this.txtBxPassConfirmSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxPassConfirmSignup.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxPassConfirmSignup.ForeColor = System.Drawing.Color.Silver;
            this.txtBxPassConfirmSignup.Location = new System.Drawing.Point(100, 290);
            this.txtBxPassConfirmSignup.Name = "txtBxPassConfirmSignup";
            this.txtBxPassConfirmSignup.Size = new System.Drawing.Size(400, 34);
            this.txtBxPassConfirmSignup.TabIndex = 4;
            this.txtBxPassConfirmSignup.Text = "Password";
            this.txtBxPassConfirmSignup.Enter += new System.EventHandler(this.txtBxPassConfirmSignup_Enter);
            // 
            // txtBxEmailSignup
            // 
            this.txtBxEmailSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxEmailSignup.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxEmailSignup.ForeColor = System.Drawing.Color.Silver;
            this.txtBxEmailSignup.Location = new System.Drawing.Point(100, 150);
            this.txtBxEmailSignup.Name = "txtBxEmailSignup";
            this.txtBxEmailSignup.Size = new System.Drawing.Size(400, 34);
            this.txtBxEmailSignup.TabIndex = 1;
            this.txtBxEmailSignup.Text = "Email";
            this.txtBxEmailSignup.Enter += new System.EventHandler(this.txtBxEmailSignup_Enter);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 703);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelSignup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBxPassLogin;
        private System.Windows.Forms.TextBox txtBxEmailLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.Button btnNoAcc;
        private System.Windows.Forms.Button btnShowPassLogin;
        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtBxPassSignup;
        private System.Windows.Forms.TextBox txtBxPassConfirmSignup;
        private System.Windows.Forms.TextBox txtBxEmailSignup;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Button btnHaveAcc;
        private System.Windows.Forms.Button btnShowPassSignup;
        private System.Windows.Forms.Button btnShowPassConfirmSignup;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}