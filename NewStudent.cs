﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class NewStudent : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int LoginID = 0;
        public NewStudent()
        {
            InitializeComponent();
            customDesign();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnSave.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("StudentAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@LoginID", 0);
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AddressLine1", txtAdress1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AddressLine2", txtAddress2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@County", cbCounty.GetItemText(cbCounty.SelectedItem));
                    if (rbPostgrad.Checked)
                     sqlCmd.Parameters.AddWithValue("@Level", "Postgrad");
                    else
                     sqlCmd.Parameters.AddWithValue("@Level", "Undergrad");
                    sqlCmd.Parameters.AddWithValue("@Course", cbCourse.GetItemText(cbCourse.SelectedItem));
                    sqlCmd.Parameters.AddWithValue("@StudentNumber", txtStuNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ModifierInitials", txtMod.Text.Trim());

                    if (int.TryParse(txtStuNo.Text.Trim(), out _))
                    {
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Save Successful");
                    }
                    else
                        MessageBox.Show("Save unsuccessful");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("StudentAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@LoginID", 0);
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AddressLine1", txtAdress1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AddressLine2", txtAddress2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@County", cbCounty.GetItemText(cbCounty.SelectedItem));
                    if (rbPostgrad.Checked)
                        sqlCmd.Parameters.AddWithValue("@Level", "Postgrad");
                    else
                        sqlCmd.Parameters.AddWithValue("@Level", "Undergrad");
                    sqlCmd.Parameters.AddWithValue("@Course", cbCourse.GetItemText(cbCourse.SelectedItem));
                    sqlCmd.Parameters.AddWithValue("@StudentNumber", txtStuNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@StudentNumber", txtMod.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successful");
                }

                Reset();
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error, Please try again.");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("StudentViewOrSearch", sqlCon);
            sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDA.SelectCommand.Parameters.AddWithValue("@FirstName", txtSearch.Text.Trim());
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            dgvStudent.DataSource = dataTable;
            dgvStudent.Columns[0].Visible = false;
            sqlCon.Close();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
        }

      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, Please try again.");
            }
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index !=-1)
            {
                LoginID= Convert.ToInt32(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                txtFirstName.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                txtSurname.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvStudent.CurrentRow.Cells[3].Value.ToString();
                txtPhone.Text = dgvStudent.CurrentRow.Cells[4].Value.ToString();
                txtAdress1.Text = dgvStudent.CurrentRow.Cells[5].Value.ToString();
                txtAddress2.Text = dgvStudent.CurrentRow.Cells[6].Value.ToString();
                txtCity.Text = dgvStudent.CurrentRow.Cells[7].Value.ToString();
                cbCounty.Text= dgvStudent.CurrentRow.Cells[8].Value.ToString();
                rbPostgrad.Text= dgvStudent.CurrentRow.Cells[9].Value.ToString();
                rbUndergrad.Text = dgvStudent.CurrentRow.Cells[9].Value.ToString();
                cbCourse.Text = dgvStudent.CurrentRow.Cells[10].Value.ToString();
                txtStuNo.Text = dgvStudent.CurrentRow.Cells[11].Value.ToString();
                txtMod.Text = dgvStudent.CurrentRow.Cells[12].Value.ToString();
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        void Reset()
        {
            txtFirstName.Text = txtSurname.Text = txtEmail.Text=txtPhone.Text= txtAdress1.Text= txtAddress2.Text= txtCity.Text=cbCounty.Text=rbPostgrad.Text =rbUndergrad.Text = cbCourse.Text = txtStuNo.Text=txtMod.Text = "";
            btnSave.Text = "Save";
            LoginID = 0;
            btnDelete.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("StudentDeletion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@StudentNumber", txtStuNo.Text.Trim()); //Needs changing??
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successful");
                    Reset();
                    FillDataGridView();
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, Please try again.");
            }
        }


        //Menu Bar
        private void customDesign()
        {
            panelFileSubMenu.Visible = false;
            panelStudentSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelFileSubMenu.Visible == true)
                panelFileSubMenu.Visible = false;
            if (panelStudentSubMenu.Visible == true)
                panelStudentSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFileSubMenu);
        }

        private void btnLoginMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubMenu);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            this.Hide();
            newStudent.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            this.Hide();
            newStudent.Show(); //No need to create separate page
        }
    }
}

