namespace appquanlimon
{
    partial class frmMain
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
            this.tabTKB = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.tabBangdiem = new System.Windows.Forms.TabPage();
            this.tabLichthi = new System.Windows.Forms.TabPage();
            this.tabHocphi = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabTKB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.tabBangdiem.SuspendLayout();
            this.tabLichthi.SuspendLayout();
            this.tabHocphi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTKB
            // 
            this.tabTKB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTKB.Controls.Add(this.tabPage1);
            this.tabTKB.Controls.Add(this.tabBangdiem);
            this.tabTKB.Controls.Add(this.tabLichthi);
            this.tabTKB.Controls.Add(this.tabHocphi);
            this.tabTKB.Location = new System.Drawing.Point(13, -2);
            this.tabTKB.Name = "tabTKB";
            this.tabTKB.SelectedIndex = 0;
            this.tabTKB.Size = new System.Drawing.Size(765, 450);
            this.tabTKB.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dgvTKB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thời Khóa Biểu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dgvTKB
            // 
            this.dgvTKB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Location = new System.Drawing.Point(3, 108);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.Size = new System.Drawing.Size(748, 310);
            this.dgvTKB.TabIndex = 0;
            // 
            // tabBangdiem
            // 
            this.tabBangdiem.Controls.Add(this.dataGridView1);
            this.tabBangdiem.Location = new System.Drawing.Point(4, 22);
            this.tabBangdiem.Name = "tabBangdiem";
            this.tabBangdiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabBangdiem.Size = new System.Drawing.Size(757, 424);
            this.tabBangdiem.TabIndex = 1;
            this.tabBangdiem.Text = "Bảng Điểm";
            this.tabBangdiem.UseVisualStyleBackColor = true;
            // 
            // tabLichthi
            // 
            this.tabLichthi.Controls.Add(this.dataGridView2);
            this.tabLichthi.Location = new System.Drawing.Point(4, 22);
            this.tabLichthi.Name = "tabLichthi";
            this.tabLichthi.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichthi.Size = new System.Drawing.Size(757, 424);
            this.tabLichthi.TabIndex = 2;
            this.tabLichthi.Text = "Lịch Thi";
            this.tabLichthi.UseVisualStyleBackColor = true;
            // 
            // tabHocphi
            // 
            this.tabHocphi.Controls.Add(this.dataGridView3);
            this.tabHocphi.Location = new System.Drawing.Point(4, 22);
            this.tabHocphi.Name = "tabHocphi";
            this.tabHocphi.Padding = new System.Windows.Forms.Padding(3);
            this.tabHocphi.Size = new System.Drawing.Size(757, 424);
            this.tabHocphi.TabIndex = 3;
            this.tabHocphi.Text = "Học Phí";
            this.tabHocphi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(756, 356);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 75);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(753, 348);
            this.dataGridView3.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.tabTKB);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabTKB.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.tabBangdiem.ResumeLayout(false);
            this.tabLichthi.ResumeLayout(false);
            this.tabHocphi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTKB;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabBangdiem;
        private System.Windows.Forms.TabPage tabLichthi;
        private System.Windows.Forms.TabPage tabHocphi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}