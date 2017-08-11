using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeCSharp
{
    public partial class RightCF : Form
    {
        Connection cn = new Connection();
        DataRowView drv;
        int right =0;
        int sum = 0;
        public RightCF()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
            this.Dispose();

        }

        private void RightCF_Load(object sender, EventArgs e)
        {
            loadRightCustomer();

        }

        private void btCal_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("You Are Sure For Pay?",
            "Calculate", MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                PublicVar.countRight = Convert.ToInt16(Math.Round(udUnit.Value, 0)) * 25;
                PublicVar.buttonRightClick = true;
                frmMain fm = new frmMain();
                fm.Show();
                this.Dispose();
            }
        }

        private void cbbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {

            udUnit.Maximum = Convert.ToInt16(cbbCustomer.SelectedValue.ToString())/10;
            checkRight();
        }
        public void loadRightCustomer()
        {
            string sql3;
            sql3 = "SELECT COUNT(cus_id_best) as Total, cus_id_best, cus_name_best FROM tb_best_seller";
            sql3 += " WHERE hcs_name_best != '' GROUP BY cus_id_best, cus_name_best HAVING COUNT(cus_id_best) > 9";

            cn.openConection();
            cbbCustomer.DataSource = cn.showDataInGridView(sql3);
            cbbCustomer.DisplayMember = "cus_name_best";
            cbbCustomer.ValueMember = "Total";
            drv = cbbCustomer.SelectedItem as DataRowView;
            if (cbbCustomer.SelectedItem == null || cbbCustomer.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                cbbCustomer.Enabled = true;
                udUnit.Enabled = true;
                btCal.Enabled = true;
                udUnit.Value = Convert.ToInt16(cbbCustomer.SelectedValue.ToString()) / 10;
                udUnit.Maximum = Convert.ToInt16(cbbCustomer.SelectedValue.ToString()) / 10;
                udUnit.Minimum = 1;
                PublicVar.cusId = drv.Row["cus_id_best"].ToString();
                lbShowRight.Text = drv.Row["cus_name_best"].ToString();
                checkRight();
                //drv = cbbCustomer.SelectedItem as DataRowView;
                cn.closeConnection();
                

            }

            

        }
        private void checkRight() 
        {
            right = Convert.ToInt16(cbbCustomer.SelectedValue.ToString()) % 10;

            for (int i = right; i < 10; i++)
            {
                sum++;

            }
            lblShowRightTotal.Text = sum.ToString();
            sum = 0;
        }
    }
}
