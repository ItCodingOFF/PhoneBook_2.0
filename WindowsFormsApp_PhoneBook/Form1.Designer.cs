
namespace WindowsFormsApp_PhoneBook
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.buttonNEW = new System.Windows.Forms.Button();
			this.buttonEDIT = new System.Windows.Forms.Button();
			this.buttonDELETE = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet11 = new WindowsFormsApp_PhoneBook.DataSet1();
			this.dataSet1 = new WindowsFormsApp_PhoneBook.DataSet1();
			this.buttonSAVE = new System.Windows.Forms.Button();
			this.textBoxINFORMATION = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxCATEGORY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxADDRESS = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPHONE = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxNAME = new System.Windows.Forms.TextBox();
			this.lfio = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonNEW
			// 
			this.buttonNEW.FlatAppearance.BorderSize = 0;
			this.buttonNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonNEW.Location = new System.Drawing.Point(3, 3);
			this.buttonNEW.Name = "buttonNEW";
			this.buttonNEW.Size = new System.Drawing.Size(75, 23);
			this.buttonNEW.TabIndex = 0;
			this.buttonNEW.Text = "New";
			this.buttonNEW.UseVisualStyleBackColor = true;
			this.buttonNEW.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonEDIT
			// 
			this.buttonEDIT.FlatAppearance.BorderSize = 0;
			this.buttonEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonEDIT.Location = new System.Drawing.Point(109, 3);
			this.buttonEDIT.Name = "buttonEDIT";
			this.buttonEDIT.Size = new System.Drawing.Size(75, 23);
			this.buttonEDIT.TabIndex = 1;
			this.buttonEDIT.Text = "Edit";
			this.buttonEDIT.UseVisualStyleBackColor = true;
			this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
			// 
			// buttonDELETE
			// 
			this.buttonDELETE.FlatAppearance.BorderSize = 0;
			this.buttonDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDELETE.Location = new System.Drawing.Point(207, 3);
			this.buttonDELETE.Name = "buttonDELETE";
			this.buttonDELETE.Size = new System.Drawing.Size(75, 23);
			this.buttonDELETE.TabIndex = 2;
			this.buttonDELETE.Text = "Delete";
			this.buttonDELETE.UseVisualStyleBackColor = true;
			this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.phoneBookBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 400);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(279, 256);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// fullnameDataGridViewTextBoxColumn
			// 
			this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
			this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
			this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			// 
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.Visible = false;
			// 
			// phoneBookBindingSource
			// 
			this.phoneBookBindingSource.DataMember = "PhoneBook";
			this.phoneBookBindingSource.DataSource = this.dataSet11;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// buttonSAVE
			// 
			this.buttonSAVE.BackColor = System.Drawing.SystemColors.WindowText;
			this.buttonSAVE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.buttonSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSAVE.Location = new System.Drawing.Point(6, 364);
			this.buttonSAVE.Name = "buttonSAVE";
			this.buttonSAVE.Size = new System.Drawing.Size(276, 30);
			this.buttonSAVE.TabIndex = 23;
			this.buttonSAVE.Text = "Save";
			this.buttonSAVE.UseVisualStyleBackColor = false;
			this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
			// 
			// textBoxINFORMATION
			// 
			this.textBoxINFORMATION.BackColor = System.Drawing.Color.Black;
			this.textBoxINFORMATION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxINFORMATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxINFORMATION.ForeColor = System.Drawing.Color.White;
			this.textBoxINFORMATION.Location = new System.Drawing.Point(86, 324);
			this.textBoxINFORMATION.Multiline = true;
			this.textBoxINFORMATION.Name = "textBoxINFORMATION";
			this.textBoxINFORMATION.Size = new System.Drawing.Size(196, 21);
			this.textBoxINFORMATION.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(6, 327);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Описание";
			// 
			// textBoxCATEGORY
			// 
			this.textBoxCATEGORY.BackColor = System.Drawing.Color.Black;
			this.textBoxCATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCATEGORY.ForeColor = System.Drawing.Color.White;
			this.textBoxCATEGORY.Location = new System.Drawing.Point(86, 285);
			this.textBoxCATEGORY.Multiline = true;
			this.textBoxCATEGORY.Name = "textBoxCATEGORY";
			this.textBoxCATEGORY.Size = new System.Drawing.Size(196, 21);
			this.textBoxCATEGORY.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 288);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 17);
			this.label3.TabIndex = 19;
			this.label3.Text = "Категория";
			// 
			// textBoxADDRESS
			// 
			this.textBoxADDRESS.BackColor = System.Drawing.Color.Black;
			this.textBoxADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxADDRESS.ForeColor = System.Drawing.Color.White;
			this.textBoxADDRESS.Location = new System.Drawing.Point(86, 247);
			this.textBoxADDRESS.Multiline = true;
			this.textBoxADDRESS.Name = "textBoxADDRESS";
			this.textBoxADDRESS.Size = new System.Drawing.Size(196, 21);
			this.textBoxADDRESS.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 251);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Адрес";
			// 
			// textBoxPHONE
			// 
			this.textBoxPHONE.BackColor = System.Drawing.Color.Black;
			this.textBoxPHONE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPHONE.ForeColor = System.Drawing.Color.White;
			this.textBoxPHONE.Location = new System.Drawing.Point(86, 209);
			this.textBoxPHONE.Multiline = true;
			this.textBoxPHONE.Name = "textBoxPHONE";
			this.textBoxPHONE.Size = new System.Drawing.Size(196, 21);
			this.textBoxPHONE.TabIndex = 16;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPhone.Location = new System.Drawing.Point(3, 212);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(68, 17);
			this.labelPhone.TabIndex = 15;
			this.labelPhone.Text = "Телефон";
			// 
			// textBoxNAME
			// 
			this.textBoxNAME.BackColor = System.Drawing.Color.Black;
			this.textBoxNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNAME.ForeColor = System.Drawing.Color.White;
			this.textBoxNAME.Location = new System.Drawing.Point(86, 171);
			this.textBoxNAME.Multiline = true;
			this.textBoxNAME.Name = "textBoxNAME";
			this.textBoxNAME.Size = new System.Drawing.Size(196, 21);
			this.textBoxNAME.TabIndex = 14;
			// 
			// lfio
			// 
			this.lfio.AutoSize = true;
			this.lfio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lfio.Location = new System.Drawing.Point(3, 175);
			this.lfio.Name = "lfio";
			this.lfio.Size = new System.Drawing.Size(46, 17);
			this.lfio.TabIndex = 13;
			this.lfio.Text = " ФИО";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(88, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(3, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(279, 362);
			this.panel1.TabIndex = 24;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(285, 657);
			this.Controls.Add(this.buttonSAVE);
			this.Controls.Add(this.textBoxINFORMATION);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxCATEGORY);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxADDRESS);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPHONE);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxNAME);
			this.Controls.Add(this.lfio);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonDELETE);
			this.Controls.Add(this.buttonEDIT);
			this.Controls.Add(this.buttonNEW);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Phone Book";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNEW;
		private System.Windows.Forms.Button buttonEDIT;
		private System.Windows.Forms.Button buttonDELETE;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private DataSet1 dataSet1;
		private System.Windows.Forms.Button buttonSAVE;
		private System.Windows.Forms.TextBox textBoxINFORMATION;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxCATEGORY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxADDRESS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPHONE;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textBoxNAME;
		private System.Windows.Forms.Label lfio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.BindingSource phoneBookBindingSource;
		private DataSet1 dataSet11;
	}
}

