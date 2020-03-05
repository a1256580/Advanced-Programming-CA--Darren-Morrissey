namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelStudentSubMenu = new System.Windows.Forms.Panel();
            this.btnViewDBHis = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panelFileSubMenu = new System.Windows.Forms.Panel();
            this.btnExitMenu = new System.Windows.Forms.Button();
            this.btnLoginMenu = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rbUndergrad = new System.Windows.Forms.RadioButton();
            this.rbPostgrad = new System.Windows.Forms.RadioButton();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cbCounty = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAdress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAdress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.txtMod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelStudentSubMenu.SuspendLayout();
            this.panelFileSubMenu.SuspendLayout();
            this.gbLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(27, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(120, 624);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(226, 624);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvStudent.Location = new System.Drawing.Point(379, 134);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(619, 252);
            this.dgvStudent.TabIndex = 9;
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(379, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(443, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(828, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelSideMenu.Controls.Add(this.panelStudentSubMenu);
            this.panelSideMenu.Controls.Add(this.btnStudent);
            this.panelSideMenu.Controls.Add(this.panelFileSubMenu);
            this.panelSideMenu.Controls.Add(this.btnFile);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(1025, 75);
            this.panelSideMenu.TabIndex = 18;
            // 
            // panelStudentSubMenu
            // 
            this.panelStudentSubMenu.BackColor = System.Drawing.Color.White;
            this.panelStudentSubMenu.Controls.Add(this.btnViewDBHis);
            this.panelStudentSubMenu.Controls.Add(this.btnDeleteMenu);
            this.panelStudentSubMenu.Controls.Add(this.btnEdit);
            this.panelStudentSubMenu.Controls.Add(this.btnNew);
            this.panelStudentSubMenu.Location = new System.Drawing.Point(507, 0);
            this.panelStudentSubMenu.Name = "panelStudentSubMenu";
            this.panelStudentSubMenu.Size = new System.Drawing.Size(399, 75);
            this.panelStudentSubMenu.TabIndex = 4;
            // 
            // btnViewDBHis
            // 
            this.btnViewDBHis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewDBHis.FlatAppearance.BorderSize = 0;
            this.btnViewDBHis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnViewDBHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDBHis.ForeColor = System.Drawing.Color.White;
            this.btnViewDBHis.Location = new System.Drawing.Point(288, 0);
            this.btnViewDBHis.Name = "btnViewDBHis";
            this.btnViewDBHis.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnViewDBHis.Size = new System.Drawing.Size(112, 75);
            this.btnViewDBHis.TabIndex = 3;
            this.btnViewDBHis.Text = "View Database History";
            this.btnViewDBHis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDBHis.UseVisualStyleBackColor = false;
            this.btnViewDBHis.Click += new System.EventHandler(this.btnViewDBHis_Click);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteMenu.FlatAppearance.BorderSize = 0;
            this.btnDeleteMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnDeleteMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMenu.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMenu.Location = new System.Drawing.Point(192, 0);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDeleteMenu.Size = new System.Drawing.Size(100, 75);
            this.btnDeleteMenu.TabIndex = 2;
            this.btnDeleteMenu.Text = "Delete Student";
            this.btnDeleteMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMenu.UseVisualStyleBackColor = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(97, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(100, 75);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Student";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNew.Size = new System.Drawing.Size(100, 75);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Student";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(411, 0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(100, 75);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panelFileSubMenu
            // 
            this.panelFileSubMenu.BackColor = System.Drawing.Color.White;
            this.panelFileSubMenu.Controls.Add(this.btnExitMenu);
            this.panelFileSubMenu.Controls.Add(this.btnLoginMenu);
            this.panelFileSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFileSubMenu.Location = new System.Drawing.Point(220, 0);
            this.panelFileSubMenu.Name = "panelFileSubMenu";
            this.panelFileSubMenu.Size = new System.Drawing.Size(195, 75);
            this.panelFileSubMenu.TabIndex = 2;
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExitMenu.FlatAppearance.BorderSize = 0;
            this.btnExitMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitMenu.ForeColor = System.Drawing.Color.White;
            this.btnExitMenu.Location = new System.Drawing.Point(94, 0);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExitMenu.Size = new System.Drawing.Size(100, 75);
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
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(120, 0);
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
            this.panelLogo.Size = new System.Drawing.Size(120, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "IT",
            "Journalism",
            "Medicine",
            "Accountancy",
            "Nursing"});
            this.cbCourse.Location = new System.Drawing.Point(155, 508);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(143, 24);
            this.cbCourse.TabIndex = 73;
            // 
            // gbLevel
            // 
            this.gbLevel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbLevel.Controls.Add(this.rbUndergrad);
            this.gbLevel.Controls.Add(this.rbPostgrad);
            this.gbLevel.ForeColor = System.Drawing.Color.White;
            this.gbLevel.Location = new System.Drawing.Point(155, 387);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(143, 100);
            this.gbLevel.TabIndex = 72;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level";
            // 
            // rbUndergrad
            // 
            this.rbUndergrad.AutoSize = true;
            this.rbUndergrad.Location = new System.Drawing.Point(7, 62);
            this.rbUndergrad.Name = "rbUndergrad";
            this.rbUndergrad.Size = new System.Drawing.Size(97, 21);
            this.rbUndergrad.TabIndex = 1;
            this.rbUndergrad.TabStop = true;
            this.rbUndergrad.Text = "Undergrad";
            this.rbUndergrad.UseVisualStyleBackColor = true;
            // 
            // rbPostgrad
            // 
            this.rbPostgrad.AutoSize = true;
            this.rbPostgrad.Location = new System.Drawing.Point(7, 32);
            this.rbPostgrad.Name = "rbPostgrad";
            this.rbPostgrad.Size = new System.Drawing.Size(86, 21);
            this.rbPostgrad.TabIndex = 0;
            this.rbPostgrad.TabStop = true;
            this.rbPostgrad.Text = "Postgrad";
            this.rbPostgrad.UseVisualStyleBackColor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(24, 387);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(42, 17);
            this.lblLevel.TabIndex = 71;
            this.lblLevel.Text = "Level";
            // 
            // cbCounty
            // 
            this.cbCounty.FormattingEnabled = true;
            this.cbCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbCounty.Location = new System.Drawing.Point(155, 336);
            this.cbCounty.Name = "cbCounty";
            this.cbCounty.Size = new System.Drawing.Size(143, 24);
            this.cbCounty.TabIndex = 70;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(155, 297);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(143, 22);
            this.txtCity.TabIndex = 69;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(155, 271);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(143, 22);
            this.txtAddress2.TabIndex = 68;
            // 
            // txtAdress1
            // 
            this.txtAdress1.Location = new System.Drawing.Point(155, 241);
            this.txtAdress1.Name = "txtAdress1";
            this.txtAdress1.Size = new System.Drawing.Size(143, 22);
            this.txtAdress1.TabIndex = 67;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAddress1.ForeColor = System.Drawing.Color.White;
            this.lblAddress1.Location = new System.Drawing.Point(24, 241);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(103, 17);
            this.lblAddress1.TabIndex = 66;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // lblAdress2
            // 
            this.lblAdress2.AutoSize = true;
            this.lblAdress2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAdress2.ForeColor = System.Drawing.Color.White;
            this.lblAdress2.Location = new System.Drawing.Point(24, 271);
            this.lblAdress2.Name = "lblAdress2";
            this.lblAdress2.Size = new System.Drawing.Size(103, 17);
            this.lblAdress2.TabIndex = 65;
            this.lblAdress2.Text = "Address Line 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(24, 302);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 64;
            this.lblCity.Text = "City";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(155, 211);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 22);
            this.txtPhone.TabIndex = 63;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(24, 211);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 62;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 22);
            this.txtEmail.TabIndex = 61;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(24, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 60;
            this.lblEmail.Text = "Email";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCourse.ForeColor = System.Drawing.Color.White;
            this.lblCourse.Location = new System.Drawing.Point(24, 508);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 17);
            this.lblCourse.TabIndex = 59;
            this.lblCourse.Text = "Course";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCounty.ForeColor = System.Drawing.Color.White;
            this.lblCounty.Location = new System.Drawing.Point(24, 336);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(52, 17);
            this.lblCounty.TabIndex = 58;
            this.lblCounty.Text = "County";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(155, 544);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(143, 22);
            this.txtStuNo.TabIndex = 57;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblStudentNumber.ForeColor = System.Drawing.Color.White;
            this.lblStudentNumber.Location = new System.Drawing.Point(24, 544);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(111, 17);
            this.lblStudentNumber.TabIndex = 56;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(155, 126);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(143, 22);
            this.txtSurname.TabIndex = 55;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(24, 129);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 54;
            this.lblSurname.Text = "Surname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(155, 91);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 22);
            this.txtFirstName.TabIndex = 53;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(24, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 19);
            this.lblFirstName.TabIndex = 52;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMod.ForeColor = System.Drawing.Color.White;
            this.lblMod.Location = new System.Drawing.Point(24, 589);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(101, 17);
            this.lblMod.TabIndex = 74;
            this.lblMod.Text = "Modifier Initials";
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(155, 589);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(143, 22);
            this.txtMod.TabIndex = 75;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1025, 665);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbCounty);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAdress1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblAdress2);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtStuNo);
            this.Controls.Add(this.lblCourse);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelStudentSubMenu.ResumeLayout(false);
            this.panelFileSubMenu.ResumeLayout(false);
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelFileSubMenu;
        private System.Windows.Forms.Button btnExitMenu;
        private System.Windows.Forms.Button btnLoginMenu;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelStudentSubMenu;
        private System.Windows.Forms.Button btnViewDBHis;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.RadioButton rbUndergrad;
        private System.Windows.Forms.RadioButton rbPostgrad;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cbCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAdress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAdress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.TextBox txtMod;
    }
}

