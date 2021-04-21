
namespace BT03_102190164_BuiVietHuyhoang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbLopSH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butSort = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.cbbSortBy = new System.Windows.Forms.ComboBox();
            this.butShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbLopSH
            // 
            this.cbbLopSH.FormattingEnabled = true;
            this.cbbLopSH.Location = new System.Drawing.Point(89, 15);
            this.cbbLopSH.Name = "cbbLopSH";
            this.cbbLopSH.Size = new System.Drawing.Size(121, 21);
            this.cbbLopSH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp sinh hoạt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(471, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(685, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "Search";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butSort);
            this.groupBox2.Controls.Add(this.butDelete);
            this.groupBox2.Controls.Add(this.butEdit);
            this.groupBox2.Controls.Add(this.butAdd);
            this.groupBox2.Controls.Add(this.cbbSortBy);
            this.groupBox2.Controls.Add(this.butShow);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 354);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(524, 289);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(75, 23);
            this.butSort.TabIndex = 1;
            this.butSort.Text = "Sort";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(397, 289);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 1;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(268, 289);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 1;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(145, 289);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // cbbSortBy
            // 
            this.cbbSortBy.FormattingEnabled = true;
            this.cbbSortBy.Location = new System.Drawing.Point(605, 289);
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.Size = new System.Drawing.Size(121, 21);
            this.cbbSortBy.TabIndex = 0;
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(23, 289);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 23);
            this.butShow.TabIndex = 1;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(703, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 429);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLopSH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbLopSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.ComboBox cbbSortBy;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

