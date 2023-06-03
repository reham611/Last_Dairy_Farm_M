using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cow_Farm_System
{
    public partial class DashBoard : Form
    {
        Functions Con;
        int key = 0;
        public DashBoard()
        {
            InitializeComponent();
            FinanceCalc();
            LogistecCalc();
            getMax();
        }

        private void FinanceCalc()
        {
            int inc, exp;
            double bal;
            String Query = "Select sum(IncAmount) from IncomeTbl";
            inc = Convert.ToInt32(Con.GetData(Query).Rows[0][0]);
            FInc.Text = "$ " + inc.ToString();

            String Query2 = "Select sum(ExpAmount) from ExpenditureTbl";
            exp = Convert.ToInt32(Con.GetData(Query2).Rows[0][0]);
            FExp.Text = "$ " + exp.ToString();

            bal = inc - exp;
            FBal.Text = "$ " + bal;
        }

        private void LogistecCalc()
        {
            String Query = "Select count(*) from CowTbl";
            LCow.Text = Con.GetData(Query).Rows[0][0].ToString();

            String Query2 = "Select sum(TotalMilk) from MilkTbl";
            LMilk.Text = Con.GetData(Query2).Rows[0][0].ToString() + " Litters";

            String Query3 = "Select count(*) from EmpTbl";
            LEmp.Text = Con.GetData(Query3).Rows[0][0].ToString();
        }

        private void getMax()
        {
            String Query = "Select Max(IncAmount) from IncomeTbl";
            SMax.Text = "$ " + Con.GetData(Query).Rows[0][0].ToString();

            String Query2 = "Select Max(ExpAmount) from ExpenditureTbl";
            ExpMax.Text = "$ " + Con.GetData(Query2).Rows[0][0].ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void DashboardPg_Click(object sender, EventArgs e)
        {
            DashBoard page = new DashBoard();
            page.Show();
            this.Hide();
        }

        private void FinancePg_Click(object sender, EventArgs e)
        {
            Finance page = new Finance();
            page.Show();
            this.Hide();
        }

        private void SalesPg_Click(object sender, EventArgs e)
        {
            MilkSales page = new MilkSales();
            page.Show();
            this.Hide();
        }

        private void BreadingPg_Click(object sender, EventArgs e)
        {
            CowBreeding page = new CowBreeding();
            page.Show();
            this.Hide();
        }

        private void HealthPg_Click(object sender, EventArgs e)
        {
            CowHealth page = new CowHealth();
            page.Show();
            this.Hide();
        }

        private void MilkPg_Click(object sender, EventArgs e)
        {
            MilkProduction page = new MilkProduction();
            page.Show();
            this.Hide();
        }

        private void CowsPg_Click(object sender, EventArgs e)
        {
            Cows page = new Cows();
            page.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FBal_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FExp_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FInc_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LEmp_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LMilk_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LCow_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void SMax_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ExpMax_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
