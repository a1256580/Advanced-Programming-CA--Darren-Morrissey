namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelFileSubMenu = new System.Windows.Forms.Panel();
            this.btnExitMenu = new System.Windows.Forms.Button();
            this.btnLoginMenu = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelFileSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.Font = new System.Drawing.Font("Arial Nova", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(214, 248);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUsername.Font = new System.Drawing.Font("Arial Nova", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(42, 114);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassword.Font = new System.Drawing.Font("Arial Nova", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(43, 191);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial Nova", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(214, 114);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(282, 28);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial Nova", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(214, 191);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(282, 28);
            this.txtPassword.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.Font = new System.Drawing.Font("Arial Nova", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(371, 248);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelSideMenu.Controls.Add(this.panelFileSubMenu);
            this.panelSideMenu.Controls.Add(this.btnFile);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(566, 75);
            this.panelSideMenu.TabIndex = 6;
            // 
            // panelFileSubMenu
            // 
            this.panelFileSubMenu.BackColor = System.Drawing.Color.White;
            this.panelFileSubMenu.Controls.Add(this.btnExitMenu);
            this.panelFileSubMenu.Controls.Add(this.btnLoginMenu);
            this.panelFileSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFileSubMenu.Location = new System.Drawing.Point(212, 0);
            this.panelFileSubMenu.Name = "panelFileSubMenu";
            this.panelFileSubMenu.Size = new System.Drawing.Size(184, 75);
            this.panelFileSubMenu.TabIndex = 2;
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExitMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExitMenu.FlatAppearance.BorderSize = 0;
            this.btnExitMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMenu.ForeColor = System.Drawing.Color.White;
            this.btnExitMenu.Location = new System.Drawing.Point(100, 0);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExitMenu.Size = new System.Drawing.Size(84, 75);
            this.btnExitMenu.TabIndex = 9;
            this.btnExitMenu.Text = "Exit";
            this.btnExitMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitMenu.UseVisualStyleBackColor = false;
            this.btnExitMenu.Click += new System.EventHandler(this.btnExitMenu_Click);
            // 
            // btnLoginMenu
            // 
            this.btnLoginMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoginMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoginMenu.FlatAppearance.BorderSize = 0;
            this.btnLoginMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnLoginMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMenu.ForeColor = System.Drawing.Color.White;
            this.btnLoginMenu.Location = new System.Drawing.Point(0, 0);
            this.btnLoginMenu.Name = "btnLoginMenu";
            this.btnLoginMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLoginMenu.Size = new System.Drawing.Size(100, 75);
            this.btnLoginMenu.TabIndex = 8;
            this.btnLoginMenu.Text = "Login";
            this.btnLoginMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginMenu.UseVisualStyleBackColor = false;
            this.btnLoginMenu.Click += new System.EventHandler(this.btnLoginMenu_Click);
            // 
            // btnFile
            // 
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(112, 0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFile.Size = new System.Drawing.Size(100, 75);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "File";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(112, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(566, 360);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelSideMenu.ResumeLayout(false);
            this.panelFileSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelFileSubMenu;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExitMenu;
        private System.Windows.Forms.Button btnLoginMenu;
    }
}