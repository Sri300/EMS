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
	public partial class AddEmployee : Form
	{
		private Employee currentUserData { get; set; }
		public AddEmployee()
		{
			InitializeComponent();
		}

		private void submit_Click(object sender, EventArgs e)
		{
			this.currentUserData = new Employee();
			this.currentUserData.name = this.txtName.Text;
			this.currentUserData.email = this.txtEmail.Text;
			this.currentUserData.gender = this.comboGender.SelectedItem.ToString();
			this.currentUserData.status = this.comboStatus.SelectedItem.ToString();

			var action = new EmployeeActions();
			if (action.createEmployee(currentUserData) !=-1)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				this.DialogResult = DialogResult.Abort;
				this.Close();
			}
		}

		private void AddEmployee_Load(object sender, EventArgs e)
		{

		}
	}
}
