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
    public partial class ManageCustomer : Form
    {
        Connection cn = new Connection();
        string idCus = "", telCus = null;
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
            this.Dispose();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            tbSearchID.Focus();
            showGird();
        }
        private void showGird()
        {
            cn.openConection();
            string sql;
            sql = "  SELECT cus_id as [รหัสลูกค้า], cus_name as [ชื่อ], cus_tel as [เบอร์โทร] FROM tb_cus";
            dgvCustomer.DataSource = cn.showDataInGridView(sql);
            cn.closeConnection();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            tbSearchID.Enabled = false;

            btSearch.Enabled = false;
            btDelete.Enabled = false;
            btUpdate.Enabled = false;

            tbShowCusName.Enabled = true;
            tbShowCusTel.Enabled = true;
            btSave.Enabled = true;
            string sql;
            sql = "SELECT TOP (1)cus_id FROM tb_cus ORDER BY cus_id DESC";
            cn.openConection();
            cn.dataReader(sql);
            while (PublicVar.dr.Read())
            {
                if (PublicVar.dr["cus_id"].ToString() == null)
                {
                    tbShowCusID.Text = "C001";
                    return;
                }

                idCus = PublicVar.dr["cus_id"].ToString();


            }
            string sub = idCus.Substring(1, 3);

            int newId = Convert.ToInt16(sub) + 1;

            string setId = "C" + newId.ToString("000");

            tbShowCusID.Text = setId.ToString().Trim();
            tbShowCusName.Focus();

            cn.closeConnection();
        }
        private void clearUI()
        {
            tbSearchID.Enabled = true;

            btSearch.Enabled = true;
            btDelete.Enabled = true;
            btUpdate.Enabled = true;
            btAdd.Enabled = true;

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            tbShowCusName.Enabled = false;
            tbShowCusTel.Enabled = false;
            btSave.Enabled = false;

            tbShowCusID.Text = "";
            tbShowCusName.Text = "";
            tbShowCusTel.Text = "";
            tbSearchID.Text = "";
            tbShowCusTel.Text = "Ex.0812345678";
            idCus = "";
            telCus = null;
            tbSearchID.Focus();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            clearUI();
        }

        private void tbShowCusTel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;

            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void tbShowCusTel_Enter(object sender, EventArgs e)
        {
            if (tbShowCusTel.Text.Equals("Ex.0812345678"))
            {
                tbShowCusTel.Text = "";
                tbShowCusTel.ForeColor = Color.Black;

            }
        }

        private void tbShowCusTel_Leave(object sender, EventArgs e)
        {
            if (tbShowCusTel.Text.Equals(""))
            {
                tbShowCusTel.Text = "Ex.0812345678";
                tbShowCusTel.ForeColor = Color.Silver;

            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbShowCusName.Text.Equals(""))
            {
                MessageBox.Show("กรุณาใส่ชื่อลูกค้า");
                return;
            }
            else
            {
                DialogResult result1 = MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่?",
                "บันทึกข้อมูล", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {

                    if (tbShowCusTel.Text.Equals("") || tbShowCusTel.Text.Equals("Ex.0812345678"))
                    {
                        telCus = null;

                    }
                    else
                    {
                        telCus = tbShowCusTel.Text.ToString();
                    }
                    string sql = "";
                    sql = "insert into tb_cus (cus_id, cus_name, cus_tel)";
                    sql += " values ('" + tbShowCusID.Text.ToString() + "',";
                    sql += " '" + tbShowCusName.Text.ToString() + "', '" + telCus + "');";

                    cn.openConection();
                    cn.executeQueries(sql);
                    cn.closeConnection();
                    clearUI();



                }
                showGird();
                MessageBox.Show("บันทึกสำเร็จ");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            string sql;
            sql = "SELECT * FROM tb_cus WHERE cus_id = '" + tbSearchID.Text.Trim() + "'";
            cn.openConection();
            cn.dataReader(sql);
            if (!PublicVar.dr.HasRows)
            {
                MessageBox.Show("ไม่มีรายการที่ค้นหา");
                tbSearchID.Focus();
                return;
            }

            while (PublicVar.dr.Read())
            {
                //if (PublicVar.dr["id_drink"].ToString() == null)
                //{
                //    MessageBox.Show("ไม่มีรายการที่ค้นหา");
                //    return;
                //}

                btAdd.Enabled = false;
                btDelete.Enabled = true;
                btUpdate.Enabled = true;

                tbShowCusName.Enabled = true;
                tbShowCusTel.Enabled = true;
                btCancel.Enabled = true;
                btSave.Enabled = false;

                //checkIdDtype = Convert.ToInt16(PublicVar.dr["id_dType"].ToString());
                tbShowCusID.Text = PublicVar.dr["cus_id"].ToString();

                tbShowCusName.Text = PublicVar.dr["cus_name"].ToString().Trim();
                tbShowCusTel.Text = PublicVar.dr["cus_tel"].ToString().Trim();
                tbShowCusTel.ForeColor = Color.Black;



            }



        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("ต้องการลบรายการนี้ใช่หรือไม่ ?",
               "ลบรายการ", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {

                string sql;
                sql = "DELETE FROM tb_cus WHERE cus_id ='" + tbShowCusID.Text.Trim() + "';";
                cn.openConection();
                cn.executeQueries(sql);
                cn.closeConnection();

                clearUI();


                MessageBox.Show("ลบรายการเรียบร้อยแล้ว");
                showGird();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (!dgvCustomer.Rows[e.RowIndex].IsNewRow)
            {
                dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                var cusId = dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
                var cusName = dgvCustomer.Rows[e.RowIndex].Cells[1].Value;
                var cusTel = dgvCustomer.Rows[e.RowIndex].Cells[2].Value;
                clearUIWhenClickGridForPlace();
                tbSearchID.Text = "";
                tbShowCusID.Text = cusId.ToString();
                tbShowCusName.Text = cusName.ToString();
                tbShowCusTel.Text = cusTel.ToString();
                tbShowCusTel.ForeColor = Color.Black;

            }
        }
        private void clearUIWhenClickGridForPlace()
        {
            btAdd.Enabled = false;
            btDelete.Enabled = true;
            btUpdate.Enabled = true;

            tbShowCusName.Enabled = true;
            tbShowCusTel.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("ต้องการอัพเดทรายการนี้ใช่หรือไม่ ?",
               "อัพเดท", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                if (tbShowCusTel.Text.Equals("Ex.0812345678"))
                {
                    tbShowCusTel.Text = "";

                }               
                string sql;
                sql = "UPDATE tb_cus SET ";
                sql += "cus_name = '" + tbShowCusName.Text.ToString() + "', ";
                sql += "cus_tel = '" + tbShowCusTel.Text.ToString() + "' ";
                sql += "WHERE cus_id = '" + tbShowCusID.Text.ToString().Trim() + "';";
                cn.openConection();
                cn.executeQueries(sql);
                cn.closeConnection();

                clearUI();
                showGird();
                MessageBox.Show("อัพเดทข้อมูลเรียบร้อยแล้ว");
            }
        }

        private void tbSearchID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btExit.PerformClick();
            }
        }

    }
}
