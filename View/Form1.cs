using BT03_102190164_BuiVietHuyhoang.BLL;
using BT03_102190164_BuiVietHuyhoang.DTO;
using BT03_102190164_BuiVietHuyhoang.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190164_BuiVietHuyhoang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            SetCBBSort();
            LoadData();
            dataGridView1.Columns[0].Visible = false;
        }
        private void SetCBB()
        {
            cbbLopSH.Items.Add(new LopSH()
            {
                ID_Lop = 0,
                NameLop = "All"
            });
            foreach (LopSH lsh in BLL_QLSV.Instance.GetAllLSH_BLL())
            {
                cbbLopSH.Items.Add(new LopSH()
                {
                    ID_Lop = lsh.ID_Lop,
                    NameLop = lsh.NameLop
                });
            }
            cbbLopSH.SelectedIndex = 0;
        }
        public void SetCBBSort()
        {
            cbbSortBy.Items.AddRange(new string[]
                {
                "1 : Tuổi giảm",
                "2 : Tuổi Tăng",
                "3 : Tên SV A-Z",
                "4 : Tên SV Z-A"
                });
        }
        private void butShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            //dataGridView1.DataSource = BLL_QLSV.Instance.GetListSV_BLL(((LopSH)cbbLopSH.SelectedItem).ID_Lop, textBox1.Text);
            dataGridView1.DataSource = BLL_QLSV.Instance.Views(((LopSH)cbbLopSH.SelectedItem).ID_Lop, textBox1.Text);
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.d1 = new Form2.MydelLoad(LoadData);
            f.Show();
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            List<SV> list = BLL_QLSV.Instance.GetListSV_BLL(((LopSH)cbbLopSH.SelectedItem).ID_Lop, textBox1.Text);
            switch (cbbSortBy.SelectedIndex)
            {
                case 0:
                    BLL_QLSV.Instance.Sort(list, SV.ASCNS);
                    dataGridView1.DataSource = list;
                    break;
                case 1:
                    BLL_QLSV.Instance.Sort(list, SV.DESCNS);
                    dataGridView1.DataSource = list;
                    break;
                case 2:
                    BLL_QLSV.Instance.Sort(list, SV.ASCNameSV);
                    dataGridView1.DataSource = list;
                    break;
                case 3:
                    BLL_QLSV.Instance.Sort(list, SV.DESCTenSV);
                    dataGridView1.DataSource = list;
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Form2 f = new Form2();
                f.d1 = new Form2.MydelLoad(LoadData);
                f.d(dataGridView1.CurrentRow.Cells["MSSV"].Value.ToString());
                f.Show();
            }
            else
            {
                MessageBox.Show("Chọn sinh viên cần Edit");
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            BLL_QLSV.Instance.DeleteSV(dataGridView1.CurrentRow.Cells["MSSV"].Value.ToString());
            MessageBox.Show("Đã xóa sinh viên " + dataGridView1.CurrentRow.Cells["NameSV"].Value.ToString());
        }
    }
}
