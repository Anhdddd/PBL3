﻿namespace PBL3
{
    partial class FormQuanLiLoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.comboBoxKieuSapXep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXem
            // 
            this.buttonXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonXem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonXem.Location = new System.Drawing.Point(94, 64);
            this.buttonXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(70, 28);
            this.buttonXem.TabIndex = 46;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "Quản lí lô hàng";
            // 
            // buttonThem
            // 
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonThem.Location = new System.Drawing.Point(18, 64);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(70, 28);
            this.buttonThem.TabIndex = 45;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxTimKiem.Location = new System.Drawing.Point(458, 69);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(246, 24);
            this.textBoxTimKiem.TabIndex = 48;
            this.textBoxTimKiem.Text = "Nhập để tìm kiếm...";
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.ReloadDataGridView);
            this.textBoxTimKiem.Enter += new System.EventHandler(this.textBoxTimKiem_Enter);
            this.textBoxTimKiem.Leave += new System.EventHandler(this.textBoxTimKiem_Leave);
            // 
            // comboBoxKieuSapXep
            // 
            this.comboBoxKieuSapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKieuSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKieuSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKieuSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKieuSapXep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxKieuSapXep.FormattingEnabled = true;
            this.comboBoxKieuSapXep.Location = new System.Drawing.Point(552, 20);
            this.comboBoxKieuSapXep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKieuSapXep.Name = "comboBoxKieuSapXep";
            this.comboBoxKieuSapXep.Size = new System.Drawing.Size(152, 24);
            this.comboBoxKieuSapXep.TabIndex = 49;
            this.comboBoxKieuSapXep.DropDownClosed += new System.EventHandler(this.ReloadDataGridView);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Sắp xếp theo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 302);
            this.dataGridView1.TabIndex = 52;
            // 
            // FormQuanLiLoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.comboBoxKieuSapXep);
            this.Controls.Add(this.label3);
            this.Name = "FormQuanLiLoHang";
            this.Text = "FormQuanLiLoHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.ComboBox comboBoxKieuSapXep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}