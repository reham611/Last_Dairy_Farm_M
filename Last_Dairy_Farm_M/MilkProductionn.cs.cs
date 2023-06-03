using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cow_Farm_System
{
    public partial class MilkProduction : Form
    {
        
        int key = 0;
        public MilkProduction()
        {
            InitializeComponent();
            
            getCowId();
            showMilk();
        }

        private void showMilk()
        {
            String Query = "Select * from MilkTbl";
            
        }

        private void getCowId()
        {
            string Query = "Select CowId from CowTbl";
            CID.ValueMember = "CowId";
            
        }

        private void getCowName()
        {
            string Query = "Select * from CowTbl where CowId=" + CID.SelectedValue + "";
            
            {
                
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DashboardPg_Click(object sender, EventArgs e)
        {
            
        }

        private void FinancePg_Click(object sender, EventArgs e)
        {
            
        }

        private void SalesPg_Click(object sender, EventArgs e)
        {
            
        }

        private void BreadingPg_Click(object sender, EventArgs e)
        {
            
        }

        private void HealthPg_Click(object sender, EventArgs e)
        {
            
        }

        private void MilkPg_Click(object sender, EventArgs e)
        {
            MilkProduction page = new MilkProduction();
            page.Show();
            this.Hide();
        }

        private void CowsPg_Click(object sender, EventArgs e)
        {
            
        }

        private void Clear()
        {
            MDate.Value = DateTime.Today.Date;
            CName.Text = "";
            MAm.Text = "";
            MNoon.Text = "";
            MPm.Text = "";
            MTotal.Text = "";
            key = 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CID.SelectedIndex == -1 || MAm.Text == "" || MNoon.Text == "" || MPm.Text == "" || MTotal.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "insert into MilkTbl values(" + CID.SelectedValue.ToString() + ",'" + CName.Text + "'," + Convert.ToInt32(MAm.Text) + "," + Convert.ToInt32(MNoon.Text) + "," + Convert.ToInt32(MPm.Text) + "," + Convert.ToInt32(MTotal.Text) + ", '" + MDate.Value.Date.ToShortDateString() + "')";
                    
                    showMilk();
                    Clear();
                    MessageBox.Show("Milk Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getCowName();
        }

        private void MPm_Leave(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(MAm.Text) + Convert.ToInt32(MNoon.Text) + Convert.ToInt32(MPm.Text);
            MTotal.Text = total.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CID.SelectedIndex == -1 || MAm.Text == "" || MNoon.Text == "" || MPm.Text == "" || MTotal.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "Update MilkTbl set CowId='" + CID.SelectedValue.ToString() + "',CowName='" + CName.Text + "',AmMilk=" + Convert.ToInt32(MAm.Text) + ",NoonMilk=" + Convert.ToInt32(MNoon.Text) + ",PmMilk=" + Convert.ToInt32(MPm.Text) + ",TotalMilk=" + Convert.ToInt32(MTotal.Text) + ",DateProd= '" + MDate.Value.Date.ToShortDateString() + "' where MId=" + key + " ";
                    
                    showMilk();
                    Clear();
                    MessageBox.Show("Milk Edited!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CID.SelectedValue = MList.SelectedRows[0].Cells[1].Value.ToString();
            CName.Text = MList.SelectedRows[0].Cells[2].Value.ToString();
            MAm.Text = MList.SelectedRows[0].Cells[3].Value.ToString();
            MNoon.Text = MList.SelectedRows[0].Cells[4].Value.ToString();
            MPm.Text = MList.SelectedRows[0].Cells[5].Value.ToString();
            MTotal.Text = MList.SelectedRows[0].Cells[6].Value.ToString();
            MDate.Text = MList.SelectedRows[0].Cells[7].Value.ToString();
            if (CName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(MList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please Sellect a Milk!!!");
            }
            else
            {
                try
                {
                    String Query = "Delete from MilkTbl where MId = {0}";
                    Query = string.Format(Query, key);
                    
                    showMilk();
                    Clear();
                    MessageBox.Show("Milk Deleted!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MilkProduction_Load(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
