namespace LMSGUI
{
    partial class Reserve
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
            this.texisbn = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label = new System.Windows.Forms.Label();
            this.btnReserve = new Guna.UI2.WinForms.Guna2Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resevationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet2 = new LMSGUI.libraryDataSet2();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new LMSGUI.libraryDataSet1();
            this.reservaTableAdapter = new LMSGUI.libraryDataSet1TableAdapters.reservaTableAdapter();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.reservationsTableAdapter = new LMSGUI.libraryDataSet2TableAdapters.ReservationsTableAdapter();
            this.btnCancelreserve = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
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
            this.guna2Button4.Location = new System.Drawing.Point(640, 382);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(148, 45);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "back";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // texisbn
            // 
            this.texisbn.AutoSize = true;
            this.texisbn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texisbn.Location = new System.Drawing.Point(12, 63);
            this.texisbn.Name = "texisbn";
            this.texisbn.Size = new System.Drawing.Size(126, 27);
            this.texisbn.TabIndex = 7;
            this.texisbn.Text = "Enter ISBN";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(1, 134);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(154, 27);
            this.label.TabIndex = 9;
            this.label.Text = "Enter Your ID";
            // 
            // btnReserve
            // 
            this.btnReserve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReserve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReserve.FillColor = System.Drawing.Color.Black;
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(6, 270);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(149, 45);
            this.btnReserve.TabIndex = 11;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dgvReservations
            // 
            this.dgvReservations.AutoGenerateColumns = false;
            this.dgvReservations.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.iSBNDataGridViewTextBoxColumn,
            this.bookstate,
            this.resevationdateDataGridViewTextBoxColumn});
            this.dgvReservations.DataSource = this.reservationsBindingSource;
            this.dgvReservations.Location = new System.Drawing.Point(503, 104);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(736, 199);
            this.dgvReservations.TabIndex = 12;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "userid";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Width = 125;
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
            // bookstate
            // 
            this.bookstate.DataPropertyName = "bookstate";
            this.bookstate.HeaderText = "bookstate";
            this.bookstate.MinimumWidth = 6;
            this.bookstate.Name = "bookstate";
            this.bookstate.ReadOnly = true;
            this.bookstate.Width = 125;
            // 
            // resevationdateDataGridViewTextBoxColumn
            // 
            this.resevationdateDataGridViewTextBoxColumn.DataPropertyName = "resevation_date";
            this.resevationdateDataGridViewTextBoxColumn.HeaderText = "resevation_date";
            this.resevationdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resevationdateDataGridViewTextBoxColumn.Name = "resevationdateDataGridViewTextBoxColumn";
            this.resevationdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.resevationdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.libraryDataSet2;
            // 
            // libraryDataSet2
            // 
            this.libraryDataSet2.DataSetName = "libraryDataSet2";
            this.libraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "reserva";
            this.reservaBindingSource.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "libraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(161, 63);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(174, 31);
            this.txtISBN.TabIndex = 13;
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(161, 134);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(174, 31);
            this.txtUserID.TabIndex = 14;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelreserve
            // 
            this.btnCancelreserve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelreserve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelreserve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelreserve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelreserve.FillColor = System.Drawing.Color.Black;
            this.btnCancelreserve.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelreserve.ForeColor = System.Drawing.Color.White;
            this.btnCancelreserve.Location = new System.Drawing.Point(232, 270);
            this.btnCancelreserve.Name = "btnCancelreserve";
            this.btnCancelreserve.Size = new System.Drawing.Size(162, 45);
            this.btnCancelreserve.TabIndex = 24;
            this.btnCancelreserve.Text = "Cancel";
            this.btnCancelreserve.Click += new System.EventHandler(this.btnCancelreserve_Click);
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 450);
            this.Controls.Add(this.btnCancelreserve);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label);
            this.Controls.Add(this.texisbn);
            this.Controls.Add(this.guna2Button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.Load += new System.EventHandler(this.Reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label texisbn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnReserve;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dgvReservations;
        private libraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private libraryDataSet1TableAdapters.reservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtISBN;
        private libraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private libraryDataSet2TableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn resevationdateDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnCancelreserve;
    }
}