using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.model;
using EmployeeManagementSystem.service;

namespace EmployeeManagementSystem.components
{
	public partial class EditEmployee : Form
	{
		public EditEmployee(Employee e)
		{
			InitializeComponent();
			this.txtId.Text = e.id.ToString();
			this.txtName.Text = e.name;
			this.txtEmail.Text = e.email;
			this.comboGender.Text = e.gender;
			this.comboStatus.Text = e.status;
		
		}

	 
		private Employee currentUserData { get; set; }

		private void EditEmployee_Load(object sender, EventArgs e)
		{

		}

		private void submit_Click(object sender, EventArgs e)
		{
			this.currentUserData = new Employee();
			this.currentUserData.id = Int32.Parse(this.txtId.Text);
			this.currentUserData.name = this.txtName.Text;
			this.currentUserData.email = this.txtEmail.Text;
			this.currentUserData.gender = this.comboGender.SelectedItem.ToString();
			this.currentUserData.status = this.comboStatus.SelectedItem.ToString();

			var action = new EmployeeActions();
			if (action.updateEmployee(currentUserData))
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
				MessageBox.Show("Details updated successfully");
			}
			else
			{
				this.DialogResult = DialogResult.Abort;
				this.Close();
				MessageBox.Show("Error occured. Please try again!!");
			}
		}

	}
}
