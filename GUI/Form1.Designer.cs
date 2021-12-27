namespace GUI
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
            this.dgvCongno = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.grBThongtin = new System.Windows.Forms.GroupBox();
            this.tbSono = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.lblSono = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongno)).BeginInit();
            this.grBThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCongno
            // 
            this.dgvCongno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colSdt,
            this.colSono});
            this.dgvCongno.Location = new System.Drawing.Point(13, 13);
            this.dgvCongno.Name = "dgvCongno";
            this.dgvCongno.RowTemplate.Height = 24;
            this.dgvCongno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongno.Size = new System.Drawing.Size(775, 195);
            this.dgvCongno.TabIndex = 0;
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "Ma";
            this.colMa.HeaderText = "Mã khách hàng";
            this.colMa.Name = "colMa";
            this.colMa.Width = 150;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            this.colTen.HeaderText = "Tên khách hàng";
            this.colTen.Name = "colTen";
            this.colTen.Width = 220;
            // 
            // colSdt
            // 
            this.colSdt.DataPropertyName = "Sdt";
            this.colSdt.HeaderText = "Số điện thoại";
            this.colSdt.Name = "colSdt";
            this.colSdt.Width = 150;
            // 
            // colSono
            // 
            this.colSono.DataPropertyName = "Sono";
            this.colSono.HeaderText = "Số nợ";
            this.colSono.Name = "colSono";
            this.colSono.Width = 150;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(284, 415);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(104, 30);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // grBThongtin
            // 
            this.grBThongtin.Controls.Add(this.tbSono);
            this.grBThongtin.Controls.Add(this.tbSdt);
            this.grBThongtin.Controls.Add(this.tbTen);
            this.grBThongtin.Controls.Add(this.tbMa);
            this.grBThongtin.Controls.Add(this.lblSono);
            this.grBThongtin.Controls.Add(this.lblSdt);
            this.grBThongtin.Controls.Add(this.lblTen);
            this.grBThongtin.Controls.Add(this.lblMa);
            this.grBThongtin.Location = new System.Drawing.Point(12, 214);
            this.grBThongtin.Name = "grBThongtin";
            this.grBThongtin.Size = new System.Drawing.Size(776, 195);
            this.grBThongtin.TabIndex = 2;
            this.grBThongtin.TabStop = false;
            this.grBThongtin.Text = "Thông tin chi tiết";
            this.grBThongtin.Enter += new System.EventHandler(this.grBThongtin_Enter);
            // 
            // tbSono
            // 
            this.tbSono.Location = new System.Drawing.Point(147, 112);
            this.tbSono.Name = "tbSono";
            this.tbSono.Size = new System.Drawing.Size(164, 22);
            this.tbSono.TabIndex = 7;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(147, 84);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(164, 22);
            this.tbSdt.TabIndex = 6;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(147, 56);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(337, 22);
            this.tbTen.TabIndex = 5;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(147, 28);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(164, 22);
            this.tbMa.TabIndex = 4;
            // 
            // lblSono
            // 
            this.lblSono.AutoSize = true;
            this.lblSono.Location = new System.Drawing.Point(72, 119);
            this.lblSono.Name = "lblSono";
            this.lblSono.Size = new System.Drawing.Size(45, 17);
            this.lblSono.TabIndex = 3;
            this.lblSono.Text = "Số nợ";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(26, 91);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(91, 17);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(6, 62);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(111, 17);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên khách hàng";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(12, 33);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(105, 17);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã khách hàng";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(394, 415);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(104, 30);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(504, 415);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(104, 30);
            this.btSua.TabIndex = 4;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(614, 415);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(104, 30);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.grBThongtin);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvCongno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongno)).EndInit();
            this.grBThongtin.ResumeLayout(false);
            this.grBThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCongno;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox grBThongtin;
        private System.Windows.Forms.TextBox tbSono;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label lblSono;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSono;
    }
}

