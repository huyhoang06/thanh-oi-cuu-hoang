using BT03_102190164_BuiVietHuyhoang.BLL;
using BT03_102190164_BuiVietHuyhoang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_102190164_BuiVietHuyhoang.View
{
    public partial class Form2 : Form
    {
        public delegate void Mydel(string mssv);
        public Mydel d;
        public delegate void MydelLoad();
        public MydelLoad d1;
        public Form2()
        {
            InitializeComponent();
            SetCBB();
            d = new Mydel(SetGUI);
        }
        private void SetCBB()
        {
            foreach (LopSH lsh in BLL_QLSV.Instance.GetAllLSH_BLL())
            {
                cbbLopSH1.Items.Add(new LopSH()
                {
                    ID_Lop = lsh.ID_Lop,
                    NameLop = lsh.NameLop
                });
            }
        }
        public void SetGUI(string MSSV)
        {
            SV s = BLL_QLSV.Instance.GetSVByMSSV(MSSV);
            txtMSSV.Text = s.MSSV;
            txtMSSV.Enabled = false;
            txtName.Text = s.NameSV;
            radioMale.Checked = s.Gender;
            radioFemale.Checked = !radioFemale.Checked;
            dateTimePicker1.Value = s.NS;
            foreach (LopSH lsh in cbbLopSH1.Items)
            {
                if (lsh.ID_Lop == s.ID_Lop)
                {
                    cbbLopSH1.SelectedItem = lsh;
                }
            }
        }
        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "")
            {
                MessageBox.Show("nhập mssv");
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("nhập Tên SV");
                return;
            }
            if (cbbLopSH1.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn LSH");
                return;
            }
            if (radioMale.Checked == false && radioFemale.Checked == false)
            {
                MessageBox.Show("Chọn giới tính");
                return;
            }
            SV s = new SV()
            {
                MSSV = txtMSSV.Text,
                NameSV = txtName.Text,
                Gender = radioMale.Checked,
                NS = dateTimePicker1.Value,
                ID_Lop = ((LopSH)cbbLopSH1.SelectedItem).ID_Lop
            };
            BLL_QLSV.Instance.AddOrEditSV(s);
            d1();
            this.Dispose();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
