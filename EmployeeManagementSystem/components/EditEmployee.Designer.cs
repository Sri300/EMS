
namespace EmployeeManagementSystem.components
{
	partial class EditEmployee
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
			this.status = new System.Windows.Forms.Label();
			this.gender = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.Label();
			this.submit = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.comboGender = new System.Windows.Forms.ComboBox();
			this.comboStatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// status
			// 
			this.status.AutoSize = true;
			this.status.Location = new System.Drawing.Point(31, 202);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(48, 17);
			this.status.TabIndex = 2;
			this.status.Text = "Status";
			// 
			// gender
			// 
			this.gender.AutoSize = true;
			this.gender.Location = new System.Drawing.Point(31, 162);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(56, 17);
			this.gender.TabIndex = 3;
			this.gender.Text = "Gender";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Location = new System.Drawing.Point(37, 119);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(42, 17);
			this.email.TabIndex = 4;
			this.email.Text = "Email";
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(37, 86);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(45, 17);
			this.name.TabIndex = 5;
			this.name.Text = "Name";
			// 
			// submit
			// 
			this.submit.Location = new System.Drawing.Point(230, 257);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(75, 27);
			this.submit.TabIndex = 6;
			this.submit.Text = "Update";
			this.submit.UseVisualStyleBackColor = true;
			this.submit.Click += new System.EventHandler(this.submit_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(103, 119);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(202, 22);
			this.txtEmail.TabIndex = 7;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(103, 86);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(202, 22);
			this.txtName.TabIndex = 9;
			// 
			// comboGender
			// 
			this.comboGender.FormattingEnabled = true;
			this.comboGender.Items.AddRange(new object[] {
            "male",
            "female"});
			this.comboGender.Location = new System.Drawing.Point(103, 155);
			this.comboGender.Name = "comboGender";
			this.comboGender.Size = new System.Drawing.Size(202, 24);
			this.comboGender.TabIndex = 11;
			// 
			// comboStatus
			// 
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Items.AddRange(new object[] {
            "active",
            "inactive"});
			this.comboStatus.Location = new System.Drawing.Point(103, 195);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(202, 24);
			this.comboStatus.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Id";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(103, 51);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(202, 22);
			this.txtId.TabIndex = 14;
			// 
			// EditEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 320);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboStatus);
			this.Controls.Add(this.comboGender);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.submit);
			this.Controls.Add(this.name);
			this.Controls.Add(this.email);
			this.Controls.Add(this.gender);
			this.Controls.Add(this.status);
			this.Name = "EditEmployee";
			this.Text = "Edit employee";
			this.Load += new System.EventHandler(this.EditEmployee_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Label gender;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Button submit;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox comboGender;
		private System.Windows.Forms.ComboBox comboStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
	}
}