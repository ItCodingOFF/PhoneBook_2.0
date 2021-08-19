
namespace WindowsFormsApp_PhoneBook
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lfio = new System.Windows.Forms.Label();
			this.textBoxNAME = new System.Windows.Forms.TextBox();
			this.textBoxPHONE = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxADDRESS = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCATEGORY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxINFORMATION = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonSAVE = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(86, 46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lfio
			// 
			this.lfio.AutoSize = true;
			this.lfio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lfio.Location = new System.Drawing.Point(1, 189);
			this.lfio.Name = "lfio";
			this.lfio.Size = new System.Drawing.Size(46, 17);
			this.lfio.TabIndex = 1;
			this.lfio.Text = " ФИО";
			// 
			// textBoxNAME
			// 
			this.textBoxNAME.BackColor = System.Drawing.Color.Black;
			this.textBoxNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNAME.Location = new System.Drawing.Point(84, 185);
			this.textBoxNAME.Multiline = true;
			this.textBoxNAME.Name = "textBoxNAME";
			this.textBoxNAME.Size = new System.Drawing.Size(196, 21);
			this.textBoxNAME.TabIndex = 2;
			// 
			// textBoxPHONE
			// 
			this.textBoxPHONE.BackColor = System.Drawing.Color.Black;
			this.textBoxPHONE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPHONE.Location = new System.Drawing.Point(84, 223);
			this.textBoxPHONE.Multiline = true;
			this.textBoxPHONE.Name = "textBoxPHONE";
			this.textBoxPHONE.Size = new System.Drawing.Size(196, 21);
			this.textBoxPHONE.TabIndex = 4;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPhone.Location = new System.Drawing.Point(1, 226);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(68, 17);
			this.labelPhone.TabIndex = 3;
			this.labelPhone.Text = "Телефон";
			// 
			// textBoxADDRESS
			// 
			this.textBoxADDRESS.BackColor = System.Drawing.Color.Black;
			this.textBoxADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxADDRESS.Location = new System.Drawing.Point(84, 261);
			this.textBoxADDRESS.Multiline = true;
			this.textBoxADDRESS.Name = "textBoxADDRESS";
			this.textBoxADDRESS.Size = new System.Drawing.Size(196, 21);
			this.textBoxADDRESS.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(1, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Адрес";
			// 
			// textBoxCATEGORY
			// 
			this.textBoxCATEGORY.BackColor = System.Drawing.Color.Black;
			this.textBoxCATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCATEGORY.Location = new System.Drawing.Point(84, 299);
			this.textBoxCATEGORY.Multiline = true;
			this.textBoxCATEGORY.Name = "textBoxCATEGORY";
			this.textBoxCATEGORY.Size = new System.Drawing.Size(196, 21);
			this.textBoxCATEGORY.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(1, 302);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Категория";
			// 
			// textBoxINFORMATION
			// 
			this.textBoxINFORMATION.BackColor = System.Drawing.Color.Black;
			this.textBoxINFORMATION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxINFORMATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxINFORMATION.Location = new System.Drawing.Point(84, 338);
			this.textBoxINFORMATION.Multiline = true;
			this.textBoxINFORMATION.Name = "textBoxINFORMATION";
			this.textBoxINFORMATION.Size = new System.Drawing.Size(196, 21);
			this.textBoxINFORMATION.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(4, 341);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Описание";
			// 
			// buttonSAVE
			// 
			this.buttonSAVE.BackColor = System.Drawing.SystemColors.WindowText;
			this.buttonSAVE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.buttonSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSAVE.Location = new System.Drawing.Point(4, 378);
			this.buttonSAVE.Name = "buttonSAVE";
			this.buttonSAVE.Size = new System.Drawing.Size(276, 30);
			this.buttonSAVE.TabIndex = 11;
			this.buttonSAVE.Text = "Save";
			this.buttonSAVE.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(4, 23);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(276, 482);
			this.panel1.TabIndex = 12;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(284, 561);
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
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.Text = "Setting";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lfio;
		private System.Windows.Forms.TextBox textBoxNAME;
		private System.Windows.Forms.TextBox textBoxPHONE;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textBoxADDRESS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCATEGORY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxINFORMATION;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonSAVE;
		private System.Windows.Forms.Panel panel1;
	}
}