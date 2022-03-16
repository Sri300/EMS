
namespace EmployeeManagementSystem.components
{
	partial class AddEmployee
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
			this.SuspendLayout();
			// 
			// status
			// 
			this.status.AutoSize = true;
			this.status.Location = new System.Drawing.Point(20, 179);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(48, 17);
			this.status.TabIndex = 2;
			this.status.Text = "Status";
			// 
			// gender
			// 
			this.gender.AutoSize = true;
			this.gender.Location = new System.Drawing.Point(17, 134);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(56, 17);
			this.gender.TabIndex = 3;
			this.gender.Text = "Gender";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Location = new System.Drawing.Point(23, 95);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(42, 17);
			this.email.TabIndex = 4;
			this.email.Text = "Email";
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(23, 48);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(45, 17);
			this.name.TabIndex = 5;
			this.name.Text = "Name";
			// 
			// submit
			// 
			this.submit.Location = new System.Drawing.Point(222, 237);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(75, 27);
			this.submit.TabIndex = 6;
			this.submit.Text = "Submit";
			this.submit.UseVisualStyleBackColor = true;
			this.submit.Click += new System.EventHandler(this.submit_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(103, 90);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(194, 22);
			this.txtEmail.TabIndex = 7;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(103, 48);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(194, 22);
			this.txtName.TabIndex = 9;
			// 
			// comboGender
			// 
			this.comboGender.FormattingEnabled = true;
			this.comboGender.Items.AddRange(new object[] {
            "male",
            "female"});
			this.comboGender.Location = new System.Drawing.Point(103, 131);
			this.comboGender.Name = "comboGender";
			this.comboGender.Size = new System.Drawing.Size(194, 24);
			this.comboGender.TabIndex = 11;
			// 
			// comboStatus
			// 
			this.comboStatus.FormattingEnabled = true;
			this.comboStatus.Items.AddRange(new object[] {
            "active",
            "inactive"});
			this.comboStatus.Location = new System.Drawing.Point(103, 172);
			this.comboStatus.Name = "comboStatus";
			this.comboStatus.Size = new System.Drawing.Size(194, 24);
			this.comboStatus.TabIndex = 12;
			// 
			// AddEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 320);
			this.Controls.Add(this.comboStatus);
			this.Controls.Add(this.comboGender);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.submit);
			this.Controls.Add(this.name);
			this.Controls.Add(this.email);
			this.Controls.Add(this.gender);
			this.Controls.Add(this.status);
			this.Name = "AddEmployee";
			this.Text = "Add new employee";
			this.Load += new System.EventHandler(this.AddEmployee_Load);
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
	}
}