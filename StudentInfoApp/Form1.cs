using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            btnCount.AutoSize = true;
            //cbBus.Checked = true;

            btnAdd.Enabled = false;
                

            comboCountry.Items.Add("Egypt");

            pnlLevel.BackColor = Color.LightBlue;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gender;
            if (rbMale.Checked)
                gender = "Male";
            else
                gender = "Female";
            lstStudents.Items.Add($"Name: {txtName.Text}, " +
                $"Gender:{gender}, " + 
                $"GPA: {nudGPA.Value}");


            // reset form
            txtName.Text = "";
            rbMale.Checked = true;
            comboCountry.SelectedIndex = -1;

            if (comboCountry.SelectedIndex == -1)
                MessageBox.Show("You have to select a country");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {

        }

        private void cbBus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBus.Checked)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        private void cbCar_CheckedChanged(object sender, EventArgs e)
        {

            btnAdd.Enabled = cbCar.Checked;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length >= 10)
                //txtName.ReadOnly = true;
                txtName.Enabled = false;
        }

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCountry.SelectedIndex == -1)
                MessageBox.Show("You have to select a country");
            else
            {
                DialogResult r = MessageBox.Show(comboCountry.SelectedItem.ToString(),
                    "Your Country", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);


                if (r == DialogResult.Yes)
                    MessageBox.Show("Yes clicked");
               
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            picLogo.Width += 200;
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
