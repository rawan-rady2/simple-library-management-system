namespace LMSGUI
{
    partial class Borrow
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
            this.components = new System.ComponentModel.Container();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.texisbn = new System.Windows.Forms.Label();
            this.btnBorrow = new Guna.UI2.WinForms.Guna2Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.libraryDataSet3 = new LMSGUI.libraryDataSet3();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowingTableAdapter = new LMSGUI.libraryDataSet3TableAdapters.BorrowingTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.libraryDataSet4 = new LMSGUI.libraryDataSet4();
            this.borrowingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.borrowingTableAdapter1 = new LMSGUI.libraryDataSet4TableAdapters.BorrowingTableAdapter();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelBorrow = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(1134, 384);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(148, 45);
            this.guna2Button4.TabIndex = 7;
            this.guna2Button4.Text = "back";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(171, 116);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(174, 31);
            this.txtUserID.TabIndex = 18;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(171, 52);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(174, 31);
            this.txtISBN.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(-1, 120);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(154, 27);
            this.label.TabIndex = 16;
            this.label.Text = "Enter Your ID";
            // 
            // texisbn
            // 
            this.texisbn.AutoSize = true;
            this.texisbn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texisbn.Location = new System.Drawing.Point(12, 52);
            this.texisbn.Name = "texisbn";
            this.texisbn.Size = new System.Drawing.Size(126, 27);
            this.texisbn.TabIndex = 15;
            this.texisbn.Text = "Enter ISBN";
            // 
            // btnBorrow
            // 
            this.btnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrow.FillColor = System.Drawing.Color.Black;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(27, 301);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(189, 45);
            this.btnBorrow.TabIndex = 19;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // dgvReservations
            // 
            this.dgvReservations.AutoGenerateColumns = false;
            this.dgvReservations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.borrowdateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.fineDataGridViewTextBoxColumn});
            this.dgvReservations.DataSource = this.borrowingBindingSource1;
            this.dgvReservations.Location = new System.Drawing.Point(572, 86);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(804, 199);
            this.dgvReservations.TabIndex = 20;
            // 
            // libraryDataSet3
            // 
            this.libraryDataSet3.DataSetName = "libraryDataSet3";
            this.libraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataMember = "Borrowing";
            this.borrowingBindingSource.DataSource = this.libraryDataSet3;
            // 
            // borrowingTableAdapter
            // 
            this.borrowingTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select Borrowing Duration:";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "14 ",
            "21 ",
            "28 "});
            this.cmbPeriod.Location = new System.Drawing.Point(65, 209);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(121, 24);
            this.cmbPeriod.TabIndex = 22;
            // 
            // libraryDataSet4
            // 
            this.libraryDataSet4.DataSetName = "libraryDataSet4";
            this.libraryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowingBindingSource1
            // 
            this.borrowingBindingSource1.DataMember = "Borrowing";
            this.borrowingBindingSource1.DataSource = this.libraryDataSet4;
            // 
            // borrowingTableAdapter1
            // 
            this.borrowingTableAdapter1.ClearBeforeFill = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // borrowdateDataGridViewTextBoxColumn
            // 
            this.borrowdateDataGridViewTextBoxColumn.DataPropertyName = "borrow_date";
            this.borrowdateDataGridViewTextBoxColumn.HeaderText = "borrow_date";
            this.borrowdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowdateDataGridViewTextBoxColumn.Name = "borrowdateDataGridViewTextBoxColumn";
            this.borrowdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.duedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // fineDataGridViewTextBoxColumn
            // 
            this.fineDataGridViewTextBoxColumn.DataPropertyName = "fine";
            this.fineDataGridViewTextBoxColumn.HeaderText = "fine";
            this.fineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            this.fineDataGridViewTextBoxColumn.ReadOnly = true;
            this.fineDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnCancelBorrow
            // 
            this.btnCancelBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelBorrow.FillColor = System.Drawing.Color.Black;
            this.btnCancelBorrow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBorrow.ForeColor = System.Drawing.Color.White;
            this.btnCancelBorrow.Location = new System.Drawing.Point(263, 301);
            this.btnCancelBorrow.Name = "btnCancelBorrow";
            this.btnCancelBorrow.Size = new System.Drawing.Size(339, 45);
            this.btnCancelBorrow.TabIndex = 23;
            this.btnCancelBorrow.Text = "Cancel Borrowing";
            this.btnCancelBorrow.Click += new System.EventHandler(this.btnCancelBorrow_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 450);
            this.Controls.Add(this.btnCancelBorrow);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label);
            this.Controls.Add(this.texisbn);
            this.Controls.Add(this.guna2Button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label texisbn;
        private Guna.UI2.WinForms.Guna2Button btnBorrow;
        private System.Windows.Forms.DataGridView dgvReservations;
        private libraryDataSet3 libraryDataSet3;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private libraryDataSet3TableAdapters.BorrowingTableAdapter borrowingTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private libraryDataSet4 libraryDataSet4;
        private System.Windows.Forms.BindingSource borrowingBindingSource1;
        private libraryDataSet4TableAdapters.BorrowingTableAdapter borrowingTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnCancelBorrow;
    }
}