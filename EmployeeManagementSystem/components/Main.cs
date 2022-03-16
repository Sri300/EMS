using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.service;
using EmployeeManagementSystem.model;
using EmployeeManagementSystem.components;
using System.IO;

namespace EmployeeManagementSystem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			var action = new EmployeeActions();
			var model = action.getEmployees();
			var list = new BindingList<Employee>(model.data);
			dataGridView1.DataSource = list;
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	 	{
			
			Employee employee = dataGridView1.CurrentRow.DataBoundItem as Employee;
			if (e.ColumnIndex == 1) {
				// if delete clicked
				var dialogResult =  MessageBox.Show("Do you want delete  " + employee.name + " ?" ,"Delete Employee", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes)
				{
					var action = new EmployeeActions();
					action.deleteEmployee(employee.id);
					MessageBox.Show(employee.name + " deleted successfully");
					reLoadData();
				}
				else if(dialogResult == DialogResult.No) { 
					//nothing

				}

			}

			if (e.ColumnIndex == 0) {

			    var modal = new EditEmployee(employee);
				DialogResult dialogResult = modal.ShowDialog();
				reLoadData();
			}
			
     	}

		private void reLoadData() {

			var action = new EmployeeActions();
			var model = action.getEmployees();
			var list = new BindingList<Employee>(model.data);
			dataGridView1.DataSource = list;
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			var modal = new AddEmployee();
			DialogResult dialogResult = modal.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				// reload 
				reLoadData();
			}

			if (dialogResult == DialogResult.Abort)
			{
				MessageBox.Show("Error occurred. Please try again ");
			}
			
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			String searchText = this.searchTxt.Text;
			// reload 
			var action = new EmployeeActions();
			var model = action.getEmployees(1, searchText);
			var list = new BindingList<Employee>(model.data);
			dataGridView1.DataSource = list;

		}

		private void btnCSV_Click(object sender, EventArgs e)
		{

			if (dataGridView1.Rows.Count > 0)
			{
				SaveFileDialog fileDialog = new SaveFileDialog();
				fileDialog.Filter = "CSV (*.csv)|*.csv";
				fileDialog.FileName = "EmployeeData.csv";
				bool fileError = false;
				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					if (File.Exists(fileDialog.FileName))
					{
						try
						{
							File.Delete(fileDialog.FileName);
						}
						catch (IOException ex)
						{
							fileError = true;
							MessageBox.Show("Can't Create file" + ex.Message);
						}
					}
					if (!fileError)
					{
						try
						{
							int columnCount = dataGridView1.Columns.Count;
							string columnNames = "";
							string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
							for (int i = 2; i < columnCount; i++)
							{
								columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
							}
							outputCsv[0] += columnNames;

							for (int i = 1; i < dataGridView1.Rows.Count; i++)
							{
								for (int j = 2; j < columnCount; j++)
								{
									outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
								}
							}

							File.WriteAllLines(fileDialog.FileName, outputCsv, Encoding.UTF8);
							MessageBox.Show("Data Exported!!!", "Info");
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error :" + ex.Message);
						}
					}
				}
			}
			else
			{
				MessageBox.Show("No Record To Export !!!", "Info");
			}
		}

	}
}
