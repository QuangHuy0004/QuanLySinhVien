namespace BLL
{
    partial class QUANTRIVIEN
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
            this.btDel = new System.Windows.Forms.Button();
            this.btChoose = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbFaculty = new System.Windows.Forms.ComboBox();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnDelete_ALL = new System.Windows.Forms.Button();
            this.btnExportEX = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(929, 617);
            this.btDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(95, 39);
            this.btDel.TabIndex = 48;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btChoose
            // 
            this.btChoose.Location = new System.Drawing.Point(684, 405);
            this.btChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(103, 31);
            this.btChoose.TabIndex = 47;
            this.btChoose.Text = "Chọn ảnh";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(811, 405);
            this.pbImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(173, 179);
            this.pbImg.TabIndex = 46;
            this.pbImg.TabStop = false;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(446, 617);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(95, 39);
            this.btClear.TabIndex = 45;
            this.btClear.Text = "Làm mới";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(564, 617);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(95, 39);
            this.btExit.TabIndex = 44;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(812, 617);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 39);
            this.btEdit.TabIndex = 43;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(317, 617);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(104, 39);
            this.btAdd.TabIndex = 42;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 315);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(357, 22);
            this.txtID.TabIndex = 41;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbId.Location = new System.Drawing.Point(27, 313);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(57, 18);
            this.lbId.TabIndex = 40;
            this.lbId.Text = "Mã SV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnUser,
            this.ColumnDate,
            this.ColumnGender,
            this.ColumnFaculty,
            this.picture});
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 273);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnID.FillWeight = 152.2843F;
            this.ColumnID.HeaderText = "Mã SV";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 70;
            // 
            // ColumnUser
            // 
            this.ColumnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUser.FillWeight = 25.55858F;
            this.ColumnUser.HeaderText = "Họ Tên";
            this.ColumnUser.MinimumWidth = 8;
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDate.FillWeight = 345.4814F;
            this.ColumnDate.HeaderText = "Ngày Sinh";
            this.ColumnDate.MinimumWidth = 8;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 125;
            // 
            // ColumnGender
            // 
            this.ColumnGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnGender.FillWeight = 25.55858F;
            this.ColumnGender.HeaderText = "Giới tính";
            this.ColumnGender.MinimumWidth = 8;
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.ReadOnly = true;
            this.ColumnGender.Width = 80;
            // 
            // ColumnFaculty
            // 
            this.ColumnFaculty.FillWeight = 25.55858F;
            this.ColumnFaculty.HeaderText = "Khoa";
            this.ColumnFaculty.MinimumWidth = 8;
            this.ColumnFaculty.Name = "ColumnFaculty";
            this.ColumnFaculty.ReadOnly = true;
            // 
            // picture
            // 
            this.picture.FillWeight = 25.55858F;
            this.picture.HeaderText = "Hình ảnh";
            this.picture.MinimumWidth = 6;
            this.picture.Name = "picture";
            this.picture.ReadOnly = true;
            // 
            // cbbFaculty
            // 
            this.cbbFaculty.FormattingEnabled = true;
            this.cbbFaculty.Items.AddRange(new object[] {
            "Ngoại Ngữ",
            "Công nghệ hóa học",
            "Điện - Điện tử",
            "Ô tô",
            "Công nghệ may"});
            this.cbbFaculty.Location = new System.Drawing.Point(619, 356);
            this.cbbFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbFaculty.Name = "cbbFaculty";
            this.cbbFaculty.Size = new System.Drawing.Size(365, 24);
            this.cbbFaculty.TabIndex = 38;
            this.cbbFaculty.Text = "Công nghệ thông tin";
            // 
            // lbFaculty
            // 
            this.lbFaculty.AutoSize = true;
            this.lbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFaculty.Location = new System.Drawing.Point(551, 356);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(47, 18);
            this.lbFaculty.TabIndex = 37;
            this.lbFaculty.Text = "Khoa";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(619, 310);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(365, 22);
            this.dtpDate.TabIndex = 36;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(125, 361);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(357, 22);
            this.txtUser.TabIndex = 35;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(125, 409);
            this.gbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGender.Size = new System.Drawing.Size(357, 98);
            this.gbGender.TabIndex = 34;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới tính";
            this.gbGender.Enter += new System.EventHandler(this.gbGender_Enter);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(209, 33);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(45, 20);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(93, 33);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDate.Location = new System.Drawing.Point(516, 312);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(82, 18);
            this.lbDate.TabIndex = 33;
            this.lbDate.Text = "Ngày sinh";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUser.Location = new System.Drawing.Point(26, 360);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(58, 18);
            this.lbUser.TabIndex = 32;
            this.lbUser.Text = "Họ tên";
            // 
            // btnDelete_ALL
            // 
            this.btnDelete_ALL.Location = new System.Drawing.Point(684, 617);
            this.btnDelete_ALL.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete_ALL.Name = "btnDelete_ALL";
            this.btnDelete_ALL.Size = new System.Drawing.Size(104, 39);
            this.btnDelete_ALL.TabIndex = 50;
            this.btnDelete_ALL.Text = "Xóa hết";
            this.btnDelete_ALL.UseVisualStyleBackColor = true;
            this.btnDelete_ALL.Click += new System.EventHandler(this.btnDelete_ALL_Click);
            // 
            // btnExportEX
            // 
            this.btnExportEX.Location = new System.Drawing.Point(18, 570);
            this.btnExportEX.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportEX.Name = "btnExportEX";
            this.btnExportEX.Size = new System.Drawing.Size(99, 39);
            this.btnExportEX.TabIndex = 51;
            this.btnExportEX.Text = "Xuất Excel";
            this.btnExportEX.UseVisualStyleBackColor = true;
            this.btnExportEX.Click += new System.EventHandler(this.btnExportEX_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(125, 617);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(104, 39);
            this.btnExportPDF.TabIndex = 52;
            this.btnExportPDF.Text = "Import Excel";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnImportEx_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 617);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 53;
            this.button1.Text = "Xuất Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_xuatWord);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 570);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 54;
            this.button2.Text = "Xuất PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QUANTRIVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 694);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnExportEX);
            this.Controls.Add(this.btnDelete_ALL);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbFaculty);
            this.Controls.Add(this.lbFaculty);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QUANTRIVIEN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbFaculty;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn picture;
        private System.Windows.Forms.Button btnDelete_ALL;
        private System.Windows.Forms.Button btnExportEX;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}