using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jie_Huang___Membership_Fee_Calculator
{
    public partial class frmMFC : Form
    {
        public frmMFC()
        {
            InitializeComponent();
        }


        private void txtMonthlyFee_TextChanged(object sender, EventArgs e)
        {
 
           
        }

        private void radAdult_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radChild_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radSenior_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkYoga_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkKarate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPersonalTrainer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMonths_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int typePrice, Option;

            typePrice = Option = 0;
            //TextBox check = (TextBox)sender;

            
            bool type = true;

            while (type == true)
            {
                if (radAdult.Checked)
                {
                    typePrice = 40;
                }
                else if (radChild.Checked)
                {
                    typePrice = 20;
                }
                else if (radStudent.Checked)
                {
                    typePrice = 25;
                }
                else if (radSenior.Checked)
                {
                    typePrice = 30;
                }
                else
                {
                    MessageBox.Show("Please select a membership type");
                    type = true;
                }

                type = false;
            }

            
            if (chkYoga.Checked) Option += 10;
            if (chkKarate.Checked) Option += 30;
            if (chkPersonalTrainer.Checked) Option += 50;



            int NOM;

            bool isInt = int.TryParse(txtMonths.Text, out NOM);
            bool monthlyMembership = false;


            while (monthlyMembership == false)
            {
                if(txtMonths.Text == "")
                {
                    MessageBox.Show("Plesae enter how many months for the membership");
                    monthlyMembership = false;
                    //e.Cancel = true;
                    
                }
                else if (isInt)
                {
                    //e.Cancel = false;
                    NOM = Convert.ToInt32(txtMonths.Text);

                    if (NOM == 0)
                    {
                        MessageBox.Show("Monthly membership can't be zero");
                        monthlyMembership = false;
                        //e.Cancel = true;
                    }

                    //e.Cancel = false;
                }
                else
                {
                    MessageBox.Show("Monthly membership only accept intergers");
                    monthlyMembership = false;
                    //e.Cancel = true;
                }

               // e.Cancel = false;

                monthlyMembership = true;
            }
            



            int monthlyPay = typePrice + Option;
            int netPay = (typePrice + Option) * NOM;

            lblMFeeBox.Text= "$"+monthlyPay.ToString();
            lblTotalBox.Text = "$"+netPay.ToString();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //lblTotalBox.Text.Clear();


            chkKarate.Checked = false;
            chkPersonalTrainer.Checked = false;
            chkYoga.Checked = false;

            radAdult.Checked = false;
            radChild.Checked = false;
            radSenior.Checked = false;
            radStudent.Checked = false;

            lblMFeeBox.Text = "";
            lblTotalBox.Text = "";

            txtMonths.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMFeeBox_Click(object sender, EventArgs e)
        {

        }

        private void gbxMembershipFees_Enter(object sender, EventArgs e)
        {

        }

        private void frmMFC_Load(object sender, EventArgs e)
        {

        }



    }
}
