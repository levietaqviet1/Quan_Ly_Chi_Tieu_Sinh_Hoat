namespace TinhTienSinhHoat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiChiTieu = new System.Windows.Forms.ComboBox();
            this.txtMucDich = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numGiaTien = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.Button();
            this.resetInput = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenExcel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLoaiSe = new System.Windows.Forms.ComboBox();
            this.labelTong = new System.Windows.Forms.Label();
            this.btnImportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(30, 38);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(684, 565);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(60, 56);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(35, 21);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(273, 56);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(75, 23);
            this.txtID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Chi Tiêu";
            // 
            // cboLoaiChiTieu
            // 
            this.cboLoaiChiTieu.FormattingEnabled = true;
            this.cboLoaiChiTieu.Location = new System.Drawing.Point(273, 259);
            this.cboLoaiChiTieu.Name = "cboLoaiChiTieu";
            this.cboLoaiChiTieu.Size = new System.Drawing.Size(154, 23);
            this.cboLoaiChiTieu.TabIndex = 4;
            // 
            // txtMucDich
            // 
            this.txtMucDich.Location = new System.Drawing.Point(273, 121);
            this.txtMucDich.Name = "txtMucDich";
            this.txtMucDich.Size = new System.Drawing.Size(154, 23);
            this.txtMucDich.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mục Đích Chi Tiêu";
            // 
            // numGiaTien
            // 
            this.numGiaTien.Location = new System.Drawing.Point(274, 189);
            this.numGiaTien.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numGiaTien.Name = "numGiaTien";
            this.numGiaTien.Size = new System.Drawing.Size(153, 23);
            this.numGiaTien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá Tiền";
            // 
            // dtThoiGian
            // 
            this.dtThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiGian.Location = new System.Drawing.Point(272, 325);
            this.dtThoiGian.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtThoiGian.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtThoiGian.Name = "dtThoiGian";
            this.dtThoiGian.Size = new System.Drawing.Size(155, 23);
            this.dtThoiGian.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(59, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thời Gian";
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(753, 6);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(75, 23);
            this.loadData.TabIndex = 11;
            this.loadData.Text = "Load All";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // resetInput
            // 
            this.resetInput.Location = new System.Drawing.Point(19, 448);
            this.resetInput.Name = "resetInput";
            this.resetInput.Size = new System.Drawing.Size(75, 23);
            this.resetInput.TabIndex = 12;
            this.resetInput.Text = "Reset Input";
            this.resetInput.UseVisualStyleBackColor = true;
            this.resetInput.Click += new System.EventHandler(this.resetInput_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(137, 448);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Insert";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(263, 448);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(249, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Đến";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(68, 7);
            this.dtTu.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtTu.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(155, 23);
            this.dtTu.TabIndex = 17;
            this.dtTu.ValueChanged += new System.EventHandler(this.dtTu_ValueChanged);
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(312, 7);
            this.dtDen.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtDen.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(155, 23);
            this.dtDen.TabIndex = 18;
            this.dtDen.ValueChanged += new System.EventHandler(this.dtDen_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportExcel);
            this.groupBox1.Controls.Add(this.btnGenExcel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboLoaiChiTieu);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMucDich);
            this.groupBox1.Controls.Add(this.resetInput);
            this.groupBox1.Controls.Add(this.numGiaTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtThoiGian);
            this.groupBox1.Location = new System.Drawing.Point(753, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 565);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnGenExcel
            // 
            this.btnGenExcel.Location = new System.Drawing.Point(474, 448);
            this.btnGenExcel.Name = "btnGenExcel";
            this.btnGenExcel.Size = new System.Drawing.Size(104, 23);
            this.btnGenExcel.TabIndex = 16;
            this.btnGenExcel.Text = "Export Excel";
            this.btnGenExcel.UseVisualStyleBackColor = true;
            this.btnGenExcel.Click += new System.EventHandler(this.btnGenExcel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(373, 448);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(484, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Loại";
            // 
            // cboLoaiSe
            // 
            this.cboLoaiSe.FormattingEnabled = true;
            this.cboLoaiSe.Location = new System.Drawing.Point(560, 7);
            this.cboLoaiSe.Name = "cboLoaiSe";
            this.cboLoaiSe.Size = new System.Drawing.Size(154, 23);
            this.cboLoaiSe.TabIndex = 15;
            this.cboLoaiSe.TextChanged += new System.EventHandler(this.cboLoaiSe_TextChanged);
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTong.Location = new System.Drawing.Point(858, 11);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(0, 18);
            this.labelTong.TabIndex = 16;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(474, 495);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(104, 23);
            this.btnImportExcel.TabIndex = 17;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 615);
            this.Controls.Add(this.labelTong);
            this.Controls.Add(this.cboLoaiSe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.loadData);
            this.Name = "Form1";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private Label ID;
        private TextBox txtID;
        private Label label2;
        private ComboBox cboLoaiChiTieu;
        private TextBox txtMucDich;
        private Label label3;
        private NumericUpDown numGiaTien;
        private Label label4;
        private DateTimePicker dtThoiGian;
        private Label label5;
        private Button loadData;
        private Button resetInput;
        private Button Add;
        private Button delete;
        private Label label1;
        private Label label6;
        private DateTimePicker dtTu;
        private DateTimePicker dtDen;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox cboLoaiSe;
        private Button btnEdit;
        private Label labelTong;
        private Button btnGenExcel;
        private Button btnImportExcel;
    }
}