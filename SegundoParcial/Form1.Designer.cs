namespace SegundoParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.btnRegisterHome = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.txtUsernameRegister = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.panelRegister);
            this.panelLogin.Controls.Add(this.panelHome);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Font = new System.Drawing.Font("Century Gothic", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(72, 49);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(726, 388);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(202, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(333, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassEnter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassLeave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(202, 195);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(333, 30);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username \\ Email";
            this.txtUsername.Enter += new System.EventHandler(this.txtUserEntered);
            this.txtUsername.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(293, 318);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 41);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 197);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SegundoParcial.Properties.Resources.perfil;
            this.pictureBox1.Location = new System.Drawing.Point(274, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.txtPasswordRegister);
            this.panelRegister.Controls.Add(this.txtUsernameRegister);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.pictureBox3);
            this.panelRegister.Location = new System.Drawing.Point(32, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(667, 388);
            this.panelRegister.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SegundoParcial.Properties.Resources.clima;
            this.pictureBox2.Location = new System.Drawing.Point(228, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLoginHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginHome.Location = new System.Drawing.Point(80, 248);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(189, 89);
            this.btnLoginHome.TabIndex = 1;
            this.btnLoginHome.Text = "LOG IN";
            this.btnLoginHome.UseVisualStyleBackColor = false;
            // 
            // btnRegisterHome
            // 
            this.btnRegisterHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegisterHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterHome.Location = new System.Drawing.Point(429, 248);
            this.btnRegisterHome.Name = "btnRegisterHome";
            this.btnRegisterHome.Size = new System.Drawing.Size(188, 89);
            this.btnRegisterHome.TabIndex = 2;
            this.btnRegisterHome.Text = "REGISTER";
            this.btnRegisterHome.UseVisualStyleBackColor = false;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Turquoise;
            this.panelHome.Controls.Add(this.btnRegisterHome);
            this.panelHome.Controls.Add(this.btnLoginHome);
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Location = new System.Drawing.Point(14, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(698, 388);
            this.panelHome.TabIndex = 6;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.Location = new System.Drawing.Point(167, 262);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.PasswordChar = '*';
            this.txtPasswordRegister.Size = new System.Drawing.Size(333, 30);
            this.txtPasswordRegister.TabIndex = 9;
            this.txtPasswordRegister.Text = "Password";
            this.txtPasswordRegister.Enter += new System.EventHandler(this.txtPassEnterRegister);
            this.txtPasswordRegister.Leave += new System.EventHandler(this.txtPassLeaveRegister);
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.Location = new System.Drawing.Point(167, 204);
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Size = new System.Drawing.Size(333, 30);
            this.txtUsernameRegister.TabIndex = 8;
            this.txtUsernameRegister.Text = "Username \\ Email";
            this.txtUsernameRegister.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.txtUsernameRegister.Enter += new System.EventHandler(this.txtUserEnteredRegister);
            this.txtUsernameRegister.Leave += new System.EventHandler(this.txtUserLeaveRegister);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(258, 327);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(158, 41);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "LOG IN";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SegundoParcial.Properties.Resources.perfil;
            this.pictureBox3.Location = new System.Drawing.Point(239, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 487);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnRegisterHome;
        private System.Windows.Forms.Button btnLoginHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.TextBox txtUsernameRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

