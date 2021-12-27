using BLL.projectBLL;
using DAL.projectDAL;
using DTO.projectDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        projectDAL cusBLL = new projectDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            projectDTO cus = new projectDTO();
            if (tbMa.Text.Equals("") || tbTen.Text.Equals("") || tbSdt.Text.Equals("") || tbSono.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống", "Thông báo");
            }
            else
            {
                cus.Sono = decimal.Parse(tbSono.Text);
                cus.Ma = tbMa.Text;
                cus.Phone = tbSdt.Text;
                cus.Name = tbTen.Text;
                cusBLL.NewCustomer(cus);

                dgvCongno.Rows.Add(cus.Ma, cus.Name, cus.Phone, cus.Sono);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult Xoa;
            Xoa = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Xoa == DialogResult.OK)
            {
                foreach (DataGridViewRow item in this.dgvCongno.SelectedRows)
                {
                    dgvCongno.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            projectDTO cus = new projectDTO();

            if (tbMa.Text.Equals("") || tbTen.Text.Equals("") || tbSdt.Text.Equals("") || tbSono.Text.Equals(""))
            {
                MessageBox.Show("Không bỏ trống", "Thông báo");
            }
            else
            {
                cus.Sono = decimal.Parse(tbSono.Text);
                cus.Ma = tbMa.Text;
                cus.Phone = tbSdt.Text;
                cus.Name = tbTen.Text;
                cusBLL.EditCustomer(cus);

                DataGridViewRow row = dgvCongno.CurrentRow;
                row.Cells[0].Value = cus.Ma;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.Phone;
                row.Cells[3].Value = cus.Sono;

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult Thoat;
            Thoat = MessageBox.Show("Bạn có muốn thoát?", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Thoat == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void grBThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<projectDTO> lstCus = cusBLL.ReadCustomer();
            foreach (projectDTO cus in lstCus)
            {
                dgvCongno.Rows.Add(cus.Ma, cus.Name, cus.Phone, cus.Sono);
            }
        }
    }
}
    
