using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_PhoneBook
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Use Singleton Pattern to Create an Instance.
		static DataSet1 db;
		protected static DataSet1 App
		{
			get
			{
				if (db == null)
				{
					db = new DataSet1();
				}
				return db;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			//Form2 q = new Form2();
			//q.Show();
			try
			{
				panel1.Enabled = true;
				 
				App.PhoneBook.AddPhoneBookRow(App.PhoneBook.NewPhoneBookRow());
				phoneBookBindingSource.MoveLast();
				textBoxNAME.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				App.PhoneBook.RejectChanges();
			}
		}

		private void buttonEDIT_Click(object sender, EventArgs e)
		{
			panel1.Enabled = true;
			textBoxNAME.Focus();
		}

		private void buttonDELETE_Click(object sender, EventArgs e)
		{
			phoneBookBindingSource.RemoveCurrent();

		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Are You sure that you want to Delete this Record?", "Message",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					phoneBookBindingSource.RemoveCurrent();
				}
			}
		}

		private void buttonSAVE_Click(object sender, EventArgs e)
		{
			try
			{
				//End Edit, Save Data To file:
				phoneBookBindingSource.EndEdit();
				App.PhoneBook.AcceptChanges();
				App.PhoneBook.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
				panel1.Enabled = false;

				MessageBox.Show("Number Store Successfully:");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				App.PhoneBook.RejectChanges();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string filename = string.Format("{0}//data.dat", Application.StartupPath);
			if (File.Exists(filename))
			{
				App.PhoneBook.ReadXml(filename);
			}
			phoneBookBindingSource.DataSource = App.PhoneBook;
			panel1.Enabled = false;
		}
	}
}
