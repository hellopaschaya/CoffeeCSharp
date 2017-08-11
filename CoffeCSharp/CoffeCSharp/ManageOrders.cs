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
    public partial class ManageOrders : Form
    {
        Connection cn = new Connection();
        DataRowView drv;
        int checkIdDtype = 0;
        int typeDrink = 1;

        int typeOther = 2;
        int hcs = 0;
        string idCus = "";
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
            this.Dispose();

        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            tbSearchID.Focus();
            cbbType.Items.Insert(0, "-- เลือกรายการ --");
            cbbType.Items.Insert(1, "เครื่องดื่ม");
            cbbType.Items.Insert(2, "อื่นๆ");
            cbbType.SelectedIndex = 0;
            showGird();

        }
        private void showGird()
        {
            cn.openConection();

            string sql;
            sql = "SELECT id_dType, name_dType as [ประเภทสินค้า], id_drink as [รหัสสินค้า],";
            sql += " name_drink as [ชื่อสินค้า], price_drink as [ราคา], tb_hcptype.hcp_name as [TYPE], tb_drink.hcp_id as [hcpID] FROM tb_drink";
            sql += " INNER JOIN tb_hcptype ON tb_drink.hcp_id = tb_hcptype.hcp_id";

            dgvDrink.DataSource = cn.showDataInGridView(sql);
            dgvDrink.Columns[0].Visible = false;
            dgvDrink.Columns[6].Visible = false;


            string sql2;
            sql2 = "SELECT id_dType, name_dType as [ประเภทสินค้า], id_other as [รหัสสินค้า],";
            sql2 += " name_other as [ชื่อสินค้า], price_other as [ราคา] FROM tb_other";
            dgvOther.DataSource = cn.showDataInGridView(sql2);
            dgvOther.Columns[0].Visible = false;


            cn.closeConnection();
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            tbSearchID.Enabled = false;
            rbDrink.Enabled = false;
            rbOther.Enabled = false;
            btSearch.Enabled = false;
            btDelete.Enabled = false;
            btUpdate.Enabled = false;

            cbbType.Enabled = true;
            rbHot.Enabled = true;
            rbCool.Enabled = true;
            rbSpin.Enabled = true;

            tbShowProName.Enabled = true;
            tbShowProPrice.Enabled = true;
            btSave.Enabled = true;
        }
        private void clearUI()
        {
            tbSearchID.Enabled = true;
            rbDrink.Enabled = true;
            rbOther.Enabled = true;
            btSearch.Enabled = true;
            btDelete.Enabled = true;
            btUpdate.Enabled = true;
            btAdd.Enabled = true;
            cbbType.Enabled = false;
            rbHot.Enabled = false;
            rbCool.Enabled = false;
            rbSpin.Enabled = false;
            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            tbShowProName.Enabled = false;
            tbShowProPrice.Enabled = false;
            btSave.Enabled = false;
            rbHot.Visible = true;
            rbCool.Visible = true;
            rbSpin.Visible = true;
            rbHot.Checked = true;
            tbShowProID.Text = "";
            tbShowProName.Text = "";
            tbShowProPrice.Text = "";
            tbSearchID.Text = "";
            tbSearchID.Focus();
            hcs = 0;
            cbbType.SelectedIndex = 0;
            checkIdDtype = 0;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            clearUI();
        }

        private void cbbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == 1)
            {
                rbHot.Visible = true;
                rbCool.Visible = true;
                rbSpin.Visible = true;

                string sql;
                sql = "SELECT TOP (1)id_drink FROM tb_drink ORDER BY id_drink DESC";
                cn.openConection();

                cn.dataReader(sql);
                while (PublicVar.dr.Read())
                {
                    if (PublicVar.dr["id_drink"].ToString() == null)
                    {
                        tbShowProID.Text = "D001";
                        return;
                    }

                    idCus = PublicVar.dr["id_drink"].ToString();

                }
                string sub = idCus.Substring(1, 3);

                int newId = Convert.ToInt16(sub) + 1;

                string setId = "D" + newId.ToString("000");

                tbShowProID.Text = setId.ToString().Trim();

                cn.closeConnection();

            }
            else if (cbbType.SelectedIndex == 2)
            {
                rbHot.Visible = false;
                rbCool.Visible = false;
                rbSpin.Visible = false;
                string sql;
                sql = "SELECT TOP (1)id_other FROM tb_other ORDER BY id_other DESC";
                cn.openConection();
                cn.dataReader(sql);
                while (PublicVar.dr.Read())
                {
                    if (PublicVar.dr["id_other"].ToString() == null)
                    {
                        tbShowProID.Text = "E001";
                        return;
                    }

                    idCus = PublicVar.dr["id_other"].ToString();

                }
                string sub = idCus.Substring(1, 3);

                int newId = Convert.ToInt16(sub) + 1;

                string setId = "E" + newId.ToString("000");

                tbShowProID.Text = setId.ToString().Trim();
                cn.closeConnection();
            }

        }

        private void tbShowProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == 0)
            {
                MessageBox.Show("กรุณาเลือกรายการ!!!!!");
                return;
            }
            else if (tbShowProName.Text.Equals("") || tbShowProPrice.Text.Equals(""))
            {
                MessageBox.Show("กรุณาใส่ชื่อสินค้าและราคา");
                return;
            }
            else
            {
                DialogResult result1 = MessageBox.Show("ต้องการบันทึกข้อมูลใช่หรือไม่?",
                "บันทึกข้อมูล", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    if (cbbType.SelectedIndex == 1)
                    {
                        if (rbHot.Checked)
                        {
                            hcs = 1;
                        }
                        else if (rbCool.Checked)
                        {
                            hcs = 2;
                        }
                        else
                        {
                            hcs = 3;
                        }
                        string sql = "";
                        sql = "insert into tb_drink (id_dType, name_dType, id_drink,";
                        sql += " name_drink, price_drink, hcp_id) values ('" + typeDrink + "',";
                        sql += " '" + cbbType.SelectedItem.ToString().Trim() + "', '" + tbShowProID.Text.Trim() + "',";
                        sql += " '" + tbShowProName.Text + "', '" + String.Format("{0:#.00}", Convert.ToDecimal(tbShowProPrice.Text.Trim())) + "',";
                        sql += " '" + hcs + "');";
                        cn.openConection();
                        cn.executeQueries(sql);
                        cn.closeConnection();
                        clearUI();
                    }
                    else if (cbbType.SelectedIndex == 2)
                    {
                        string sql = "";
                        sql = "insert into tb_other (id_dType, name_dType, id_other,";
                        sql += " name_other, price_other) values ('" + typeOther + "',";
                        sql += " '" + cbbType.SelectedItem.ToString().Trim() + "', '" + tbShowProID.Text.Trim() + "',";
                        sql += " '" + tbShowProName.Text + "', '" + String.Format("{0:#.00}", Convert.ToDecimal(tbShowProPrice.Text.Trim())) + "');";
                        cn.openConection();
                        cn.executeQueries(sql);
                        cn.closeConnection();
                        clearUI();
                    }

                }
                showGird();
                MessageBox.Show("บันทึกสำเร็จ");
            }


        }




        private void btSearch_Click(object sender, EventArgs e)
        {

            if (rbDrink.Checked)
            {
                string sql;
                sql = "SELECT * FROM tb_drink WHERE id_drink = '" + tbSearchID.Text.Trim() + "'";
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
                    cbbType.Enabled = true;
                    rbHot.Enabled = true;
                    rbCool.Enabled = true;
                    rbSpin.Enabled = true;
                    tbShowProName.Enabled = true;
                    tbShowProPrice.Enabled = true;
                    btCancel.Enabled = true;
                    btSave.Enabled = false;
                    cbbType.Enabled = false;

                    cbbType.SelectedIndex = 1;
                    checkIdDtype = Convert.ToInt16(PublicVar.dr["id_dType"].ToString());
                    tbShowProID.Text = PublicVar.dr["id_drink"].ToString();
                    if (Convert.ToInt16(PublicVar.dr["hcp_id"].ToString()) == 1)
                    {
                        rbHot.Checked = true;
                    }
                    else if (Convert.ToInt16(PublicVar.dr["hcp_id"].ToString()) == 2)
                    {
                        rbCool.Checked = true;
                    }
                    else
                    {
                        rbSpin.Checked = true;
                    }
                    tbShowProName.Text = PublicVar.dr["name_drink"].ToString().Trim();
                    string money = PublicVar.dr["price_drink"].ToString().Trim();
                    tbShowProPrice.Text = String.Format("{0:#.00}", Convert.ToDecimal(money));


                }


            }
            else if (rbOther.Checked)
            {
                string sql;
                sql = "SELECT * FROM tb_other WHERE id_other = '" + tbSearchID.Text.Trim() + "'";
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
                    cbbType.Enabled = false;
                    btAdd.Enabled = false;
                    btDelete.Enabled = true;
                    btUpdate.Enabled = true;
                    cbbType.Enabled = true;
                    tbShowProName.Enabled = true;
                    tbShowProPrice.Enabled = true;
                    btCancel.Enabled = true;
                    btSave.Enabled = false;
                    cbbType.SelectedIndex = 2;
                    checkIdDtype = Convert.ToInt16(PublicVar.dr["id_dType"].ToString());
                    tbShowProID.Text = PublicVar.dr["id_other"].ToString();
                    tbShowProName.Text = PublicVar.dr["name_other"].ToString().Trim();
                    string money = PublicVar.dr["price_other"].ToString().Trim();
                    tbShowProPrice.Text = String.Format("{0:#.00}", Convert.ToDecimal(money));
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("ต้องการลบรายการนี้ใช่หรือไม่ ?",
               "ลบรายการ", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                if (checkIdDtype == 1)
                {
                    string sql;
                    sql = "DELETE FROM tb_drink WHERE id_drink ='" + tbShowProID.Text.Trim() + "';";
                    cn.openConection();
                    cn.executeQueries(sql);
                    cn.closeConnection();
                   
                    clearUI();
                }
                else if (checkIdDtype == 2)
                {
                    string sql;
                    sql = "DELETE FROM tb_other WHERE id_other ='" + tbShowProID.Text.Trim() + "';";
                    cn.openConection();
                    cn.executeQueries(sql);
                    cn.closeConnection();
                   
                    clearUI();
                }
                MessageBox.Show("ลบรายการเรียบร้อยแล้ว");
                showGird();
            }
        }

        private void dgvDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (!dgvDrink.Rows[e.RowIndex].IsNewRow)
            {
                
                dgvDrink.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOther.ClearSelection();
                checkIdDtype = Convert.ToInt16(dgvDrink.Rows[e.RowIndex].Cells[0].Value);
                var proType = dgvDrink.Rows[e.RowIndex].Cells[1].Value;
                var proId = dgvDrink.Rows[e.RowIndex].Cells[2].Value;
                var proName = dgvDrink.Rows[e.RowIndex].Cells[3].Value;
                var proPrice = dgvDrink.Rows[e.RowIndex].Cells[4].Value;
                var proT = dgvDrink.Rows[e.RowIndex].Cells[5].Value;
                var hcpID = dgvDrink.Rows[e.RowIndex].Cells[6].Value;
                clearUIWhenClickGridForPlace();


                cbbType.SelectedIndex = 1;
                tbShowProID.Text = proId.ToString();
                tbShowProName.Text = proName.ToString();
                tbShowProPrice.Text = String.Format("{0:#.00}", Convert.ToDecimal(proPrice));

                if (Convert.ToInt16(hcpID) == 1)
                {
                    rbHot.Checked = true;
                }
                else if (Convert.ToInt16(hcpID) == 2)
                {
                    rbCool.Checked = true;
                }
                else
                {
                    rbSpin.Checked = true;
                }
                cbbType.Enabled = false;
                tbSearchID.Text = "";

            }
        }

        private void dgvOther_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (!dgvDrink.Rows[e.RowIndex].IsNewRow)
            {                
                dgvOther.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDrink.ClearSelection();
                checkIdDtype = Convert.ToInt16( dgvOther.Rows[e.RowIndex].Cells[0].Value);
                var proType = dgvOther.Rows[e.RowIndex].Cells[1].Value;
                var proId = dgvOther.Rows[e.RowIndex].Cells[2].Value;
                var proName = dgvOther.Rows[e.RowIndex].Cells[3].Value;
                var proPrice = dgvOther.Rows[e.RowIndex].Cells[4].Value;
                clearUIWhenClickGridForPlace();
                cbbType.SelectedIndex = 2;
                tbShowProID.Text = proId.ToString();
                tbShowProName.Text = proName.ToString();
                tbShowProPrice.Text = String.Format("{0:#.00}", Convert.ToDecimal(proPrice));

                rbHot.Enabled = false;
                rbCool.Enabled = false;
                rbSpin.Enabled = false;
                cbbType.Enabled = false;
                tbSearchID.Text = "";
            }
        }

        private void clearUIWhenClickGridForPlace()
        {
            btAdd.Enabled = false;
            btDelete.Enabled = true;
            btUpdate.Enabled = true;
            cbbType.Enabled = true;
            rbHot.Enabled = true;
            rbCool.Enabled = true;
            rbSpin.Enabled = true;
            tbShowProName.Enabled = true;
            tbShowProPrice.Enabled = true;
            btCancel.Enabled = true;
            btSave.Enabled = false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
             DialogResult result1 = MessageBox.Show("ต้องการอัพเดทรายการนี้ใช่หรือไม่ ?",
               "อัพเดท", MessageBoxButtons.YesNo);
             if (result1 == DialogResult.Yes)
             {
                 if (checkIdDtype == 1)
                 {
                     if (tbShowProName.Text.Equals("") || tbShowProPrice.Text.Equals(""))
                     {
                         MessageBox.Show("ต้องใส่ชื่อสินค้าและราคา ก่อนทำการอัพเดท?");
                         return;
                     }
                     else
                     {
                         if (rbHot.Checked)
                         {
                             hcs = 1;
                         }
                         else if (rbCool.Checked)
                         {
                             hcs = 2;
                         }
                         else
                         {
                             hcs = 3;
                         }
                         string sql;
                         sql = "UPDATE tb_drink SET ";
                         sql += "name_drink = '" + tbShowProName.Text.ToString().Trim() + "', ";
                         sql += "price_drink = '" + String.Format("{0:#.00}", Convert.ToDecimal(tbShowProPrice.Text.Trim())) + "', ";
                         sql += "hcp_id = '" + hcs + "' ";
                         sql += "WHERE id_drink = '" + tbShowProID.Text.ToString().Trim() + "';";
                         cn.openConection();
                         cn.executeQueries(sql);
                         cn.closeConnection();
                     }
                 }
                 else if (checkIdDtype == 2)
                 {
                     if (tbShowProName.Text.Equals("") || tbShowProPrice.Text.Equals(""))
                     {
                         MessageBox.Show("ต้องใส่ชื่อสินค้าและราคา ก่อนทำการอัพเดท !!!");
                         return;
                     }
                     else
                     {                        
                         string sql;
                         sql = "UPDATE tb_other SET ";
                         sql += "name_other = '" + tbShowProName.Text.ToString().Trim() + "', ";
                         sql += "price_other = '" + String.Format("{0:#.00}", Convert.ToDecimal(tbShowProPrice.Text.Trim())) + "' ";
                         sql += "WHERE id_other = '" + tbShowProID.Text.ToString().Trim() + "';";
                         cn.openConection();
                         cn.executeQueries(sql);
                         cn.closeConnection();                         
                     }
                 }
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
