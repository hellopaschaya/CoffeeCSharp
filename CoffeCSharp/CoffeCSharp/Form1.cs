using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeCSharp
{
    public partial class frmMain : Form
    {

        Connection cn = new Connection();
        DataRowView drv;
        
        float sum = 0, sumTotal = 0;
        int i = 1;
        public frmMain()
        {
            
            InitializeComponent();
          
            if (PublicVar.buttonRightClick == true)
            {
                lbDC.Text = PublicVar.countRight.ToString();
            }
        }

        private void tsbtExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applecation ?", "Do You Sure Exit ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            cn.openConection();

            string sql;
            sql = "SELECT id_dType, name_dType as [ประเภทสินค้า], id_drink as [รหัสสินค้า],";
            sql += " name_drink as [ชื่อสินค้า], price_drink as [ราคา], tb_hcptype.hcp_name as [TYPE] FROM tb_drink";
            sql += " INNER JOIN tb_hcptype ON tb_drink.hcp_id = tb_hcptype.hcp_id";

            dgvDrink.DataSource = cn.showDataInGridView(sql);
            dgvDrink.Columns[0].Visible = false;

            string sql2;
            sql2 = "SELECT id_dType, name_dType as [ประเภทสินค้า], id_other as [รหัสสินค้า],";
            sql2 += " name_other as [ชื่อสินค้า], price_other as [ราคา] FROM tb_other";
            dgvOther.DataSource = cn.showDataInGridView(sql2);
            dgvOther.Columns[0].Visible = false;

            string sql3;
            sql3 = "select cus_id, cus_name from tb_cus";


            cbbCustomer.DataSource = cn.showDataInGridView(sql3);
            cbbCustomer.DisplayMember = "cus_name";
            cbbCustomer.ValueMember = "cus_name";
            drv = cbbCustomer.SelectedItem as DataRowView;
            cn.closeConnection();

            dgvShowResult.ColumnCount = 8;

            dgvShowResult.Columns[1].HeaderText = "รหัสสินค้า";
            dgvShowResult.Columns[2].HeaderText = "ชื่อสินค้า";
            dgvShowResult.Columns[3].HeaderText = "#";
            dgvShowResult.Columns[4].HeaderText = "ราคา";
            dgvShowResult.Columns[5].HeaderText = "จำนวน";
            dgvShowResult.Columns[6].HeaderText = "รหัสลูกค้า";
            dgvShowResult.Columns[7].HeaderText = "ชื่อลูกค้า";

            chart();




        }
        private void btClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            dgvDrink.ClearSelection();
            dgvOther.ClearSelection();
            dgvShowResult.ClearSelection();
            dgvShowResult.Rows.Clear();
            lbSumDrink.Text = "0";
            lbSum.Text = "0";
            lbDC.Text = "0";
            lbSumtotal.Text = "0";

            sum = 0;
            sumTotal = 0;
           
            PublicVar.cusId = "";
            PublicVar.buttonRightClick = false;
            PublicVar.countRight = 0;
            chart();

        }
        private void chart()
        {


            string sql4;
            cn.openConection();
            sql4 = "SELECT TOP(5) COUNT(sell_id) as Total, sell_name FROM tb_sellcoffe GROUP BY sell_name ORDER BY Total DESC";
            cShowDetail.DataSource = cn.showDataInGridView(sql4);
            cShowDetail.Series["Series1"].XValueMember = "sell_name";

            cShowDetail.Series["Series1"].YValueMembers = "Total";
            cn.closeConnection();
            cShowDetail.Refresh();
          
        }



        private void dgvDrink_Leave(object sender, EventArgs e)
        {
            dgvDrink.ClearSelection();
        }

        private void dgvOther_Leave(object sender, EventArgs e)
        {
            dgvOther.ClearSelection();
        }

        private void dgvShowResult_Leave(object sender, EventArgs e)
        {
            dgvShowResult.ClearSelection();
        }



        private void cbbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {

            drv = cbbCustomer.SelectedItem as DataRowView;

        }



        private void dgvDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;
            if (!dgvDrink.Rows[e.RowIndex].IsNewRow)
            {
                dgvDrink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //int rowindex = dgvDrink.CurrentRow.Index;
                var nameCus = cbbCustomer.SelectedValue.ToString();

                var no = dgvDrink.Rows[e.RowIndex].Cells[0].Value;
                var proType = dgvDrink.Rows[e.RowIndex].Cells[1].Value;
                var proId = dgvDrink.Rows[e.RowIndex].Cells[2].Value;
                var proName = dgvDrink.Rows[e.RowIndex].Cells[3].Value;
                var proPrice = dgvDrink.Rows[e.RowIndex].Cells[4].Value;
                var proT = dgvDrink.Rows[e.RowIndex].Cells[5].Value;


                dgvShowResult.Rows.Add(e.RowIndex, proId, proName, proT, float.Parse(proPrice.ToString()), 1, drv.Row["cus_id"].ToString(), nameCus);
                lbSumDrink.Text = Convert.ToString(dgvShowResult.RowCount);

                sum += float.Parse(Convert.ToString(dgvDrink.Rows[e.RowIndex].Cells[4].Value));

        
                lbSum.Text = sum.ToString();
                lbSumtotal.Text = sum.ToString();
                // lbSumtotal.Text = sum - lbDC.Text;
                dgvShowResult.ClearSelection();
                //MessageBox.Show(proType.ToString());
            }
        }

        private void dgvOther_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (!dgvOther.Rows[e.RowIndex].IsNewRow)
            {
                dgvOther.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                var nameCus = cbbCustomer.SelectedValue.ToString();
                var no = dgvOther.Rows[e.RowIndex].Cells[0].Value;
                var proType = dgvOther.Rows[e.RowIndex].Cells[1].Value;
                var proId = dgvOther.Rows[e.RowIndex].Cells[2].Value;
                var proName = dgvOther.Rows[e.RowIndex].Cells[3].Value;
                var proPrice = dgvOther.Rows[e.RowIndex].Cells[4].Value;

                dgvShowResult.Rows.Add(e.RowIndex, proId, proName, null, float.Parse(proPrice.ToString()), 1, drv.Row["cus_id"].ToString(), nameCus);
                lbSumDrink.Text = Convert.ToString(dgvShowResult.RowCount);

                sum += float.Parse(Convert.ToString(dgvOther.Rows[e.RowIndex].Cells[4].Value));
                lbSum.Text = sum.ToString();
                lbSumtotal.Text = sum.ToString();



            }
        }

        private void btManageOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageOrders mo = new ManageOrders();
            mo.Show();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            cn.openConection();
       
            
            sumTotal = float.Parse(lbSum.Text) - float.Parse(lbDC.Text);
            lbSumtotal.Text = sumTotal.ToString();
            DialogResult result1 = MessageBox.Show("You Are Sure For Pay?",
            "Calculate", MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                if (dgvShowResult.Rows.Count == 0)
                {
                    MessageBox.Show("ไม่มีรายการ !!!!");
                    return;
                }

                if (Convert.ToDecimal(lbDC.Text) > 0)
                {

                    string sql;
                    sql = "DELETE TOP (10) FROM tb_best_seller WHERE cus_id_best = '" + PublicVar.cusId + "'";
                    cn.executeQueries(sql);
                    sumTotal = float.Parse(lbSum.Text) - float.Parse(lbDC.Text);
                    if (sumTotal < 0)
                    {
                        lbSumtotal.Text = "Free";
                    }
                    else
                    {
                        lbSumtotal.Text = sumTotal.ToString();
                    }

                }
               


                for (int i = 0; i < dgvShowResult.Rows.Count; i++)
                {
                    string sql = "";
                    string sql1 = "";
                    if (dgvShowResult.Rows[i].Cells[3].Value == null)
                    {
                        sql = "insert into tb_sellcoffe (sell_id, sell_name, hcs_name,";
                        sql += " sell_price, sell_unit, cus_id, cus_name) values ('" + dgvShowResult.Rows[i].Cells[1].Value.ToString() + "',";
                        sql += " '" + dgvShowResult.Rows[i].Cells[2].Value.ToString().Trim() + "', '" + null + "',";
                        sql += " '" + Convert.ToDecimal(dgvShowResult.Rows[i].Cells[4].Value.ToString()) + "', '" + Convert.ToInt16(dgvShowResult.Rows[i].Cells[5].Value.ToString()) + "',";
                        sql += " '" + dgvShowResult.Rows[i].Cells[6].Value.ToString().Trim() + "', '" + dgvShowResult.Rows[i].Cells[7].Value.ToString().Trim() + "');";
                        cn.executeQueries(sql);

                        sql1 = "insert into tb_best_seller (sell_id_best, sell_name_best, hcs_name_best,";
                        sql1 += " sell_price_best, sell_unit_best, cus_id_best, cus_name_best) values ('" + dgvShowResult.Rows[i].Cells[1].Value.ToString() + "',";
                        sql1 += " '" + dgvShowResult.Rows[i].Cells[2].Value.ToString().Trim() + "', '" + null + "',";
                        sql1 += " '" + Convert.ToDecimal(dgvShowResult.Rows[i].Cells[4].Value.ToString()) + "', '" + Convert.ToInt16(dgvShowResult.Rows[i].Cells[5].Value.ToString()) + "',";
                        sql1 += " '" + dgvShowResult.Rows[i].Cells[6].Value.ToString().Trim() + "', '" + dgvShowResult.Rows[i].Cells[7].Value.ToString().Trim() + "');";
                        cn.executeQueries(sql1);

                    }
                    else
                    {
                        sql = "insert into tb_sellcoffe (sell_id, sell_name, hcs_name,";
                        sql += " sell_price, sell_unit, cus_id, cus_name) values ('" + dgvShowResult.Rows[i].Cells[1].Value.ToString() + "',";
                        sql += " '" + dgvShowResult.Rows[i].Cells[2].Value.ToString().Trim() + "', '" + dgvShowResult.Rows[i].Cells[3].Value.ToString().Trim() + "',";
                        sql += " '" + Convert.ToDecimal(dgvShowResult.Rows[i].Cells[4].Value.ToString()) + "', '" + Convert.ToInt16(dgvShowResult.Rows[i].Cells[5].Value.ToString()) + "',";
                        sql += " '" + dgvShowResult.Rows[i].Cells[6].Value.ToString().Trim() + "', '" + dgvShowResult.Rows[i].Cells[7].Value.ToString().Trim() + "');";
                        cn.executeQueries(sql);

                        sql1 = "insert into tb_best_seller (sell_id_best, sell_name_best, hcs_name_best,";
                        sql1 += " sell_price_best, sell_unit_best, cus_id_best, cus_name_best) values ('" + dgvShowResult.Rows[i].Cells[1].Value.ToString() + "',";
                        sql1 += " '" + dgvShowResult.Rows[i].Cells[2].Value.ToString().Trim() + "', '" + dgvShowResult.Rows[i].Cells[3].Value.ToString().Trim() + "',";
                        sql1 += " '" + Convert.ToDecimal(dgvShowResult.Rows[i].Cells[4].Value.ToString()) + "', '" + Convert.ToInt16(dgvShowResult.Rows[i].Cells[5].Value.ToString()) + "',";
                        sql1 += " '" + dgvShowResult.Rows[i].Cells[6].Value.ToString().Trim() + "', '" + dgvShowResult.Rows[i].Cells[7].Value.ToString().Trim() + "');";
                        cn.executeQueries(sql1);
                    }


                }
                PublicVar.countRight = 0;
                cn.closeConnection();
                MessageBox.Show("บันทึกสำเร็จ");
                clear();
                chart();
            }

        }

        private void btPrivilege_Click(object sender, EventArgs e)
        {
            this.Hide();
            RightCF rc = new RightCF();
            rc.Show();
        }        

        private void btMangeCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCustomer mc = new ManageCustomer();
            mc.Show();
        }

        private void dgvShowResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            {
                
                sum -= float.Parse(Convert.ToString(dgvShowResult.Rows[e.RowIndex].Cells[4].Value));
                lbSum.Text = sum.ToString();
                lbSumtotal.Text = sum.ToString();
                //MessageBox.Show(dgvShowResult.Rows[e.RowIndex].Cells[4].Value.ToString());

                foreach (DataGridViewRow item in this.dgvShowResult.SelectedRows)
                {
                    dgvShowResult.Rows.RemoveAt(item.Index);
                }
                lbSumDrink.Text = Convert.ToString(dgvShowResult.RowCount);
                //result = sum - float.Parse(dgvShowResult.Rows[e.RowIndex].Cells[4].Value.ToString());


                if (dgvShowResult.Rows.Count == 0 || dgvShowResult.Rows.Count == null)
                {
                    clear();
                }

            }

        }

        private void dgvShowResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvShowResult.Rows[e.RowIndex].Cells["sno"].Value = (e.RowIndex+1).ToString();
        }

      

      
        

    }
}
