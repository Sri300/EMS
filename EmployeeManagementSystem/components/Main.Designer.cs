
namespace EmployeeManagementSystem
{
	partial class Form1
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.btnCSV = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(135, 29);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(85, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// searchTxt
			// 
			this.searchTxt.Location = new System.Drawing.Point(2, 29);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(127, 22);
			this.searchTxt.TabIndex = 3;
			// 
			// btnCSV
			// 
			this.btnCSV.Location = new System.Drawing.Point(41, 258);
			this.btnCSV.Name = "btnCSV";
			this.btnCSV.Size = new System.Drawing.Size(129, 38);
			this.btnCSV.TabIndex = 4;
			this.btnCSV.Text = "Export CSV ";
			this.btnCSV.UseVisualStyleBackColor = true;
			this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(41, 179);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(129, 38);
			this.btnAddNew.TabIndex = 5;
			this.btnAddNew.Text = "Add New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.delete});
			this.dataGridView1.Location = new System.Drawing.Point(226, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1254, 510);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// edit
			// 
			this.edit.HeaderText = "Edit";
			this.edit.MinimumWidth = 6;
			this.edit.Name = "edit";
			this.edit.Text = "Edit";
			this.edit.ToolTipText = "Edit this employee";
			this.edit.UseColumnTextForButtonValue = true;
			this.edit.Width = 125;
			// 
			// delete
			// 
			this.delete.HeaderText = "Delete";
			this.delete.MinimumWidth = 6;
			this.delete.Name = "delete";
			this.delete.ReadOnly = true;
			this.delete.Text = "Delete";
			this.delete.ToolTipText = "Delete Employee";
			this.delete.UseColumnTextForButtonValue = true;
			this.delete.Width = 125;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-1, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Search by name";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1539, 533);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.btnCSV);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.btnSearch);
			this.Name = "Form1";
			this.Text = "EmployeeManagementSystem";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.Button btnCSV;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewButtonColumn edit;
		private System.Windows.Forms.DataGridViewButtonColumn delete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
	}
}

