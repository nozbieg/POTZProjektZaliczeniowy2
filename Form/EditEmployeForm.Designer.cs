namespace POTZProjektZaliczeniowy.Form
{
    partial class EditEmployeForm
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
            this.EmployeID = new System.Windows.Forms.Label();
            this.EmployeFirstName = new System.Windows.Forms.Label();
            this.EmployeLastName = new System.Windows.Forms.Label();
            this.EmployeEmail = new System.Windows.Forms.Label();
            this.EmployeCompany = new System.Windows.Forms.Label();
            this.txtBoxEmployeId = new System.Windows.Forms.TextBox();
            this.txtBoxEmployeFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxEmployeLastName = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeCompany = new System.Windows.Forms.ComboBox();
            this.txtBoxEmployeEmail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeID
            // 
            this.EmployeID.AutoSize = true;
            this.EmployeID.Location = new System.Drawing.Point(23, 17);
            this.EmployeID.Name = "EmployeID";
            this.EmployeID.Size = new System.Drawing.Size(73, 15);
            this.EmployeID.TabIndex = 0;
            this.EmployeID.Text = "Employee ID";
            this.EmployeID.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeFirstName
            // 
            this.EmployeFirstName.AutoSize = true;
            this.EmployeFirstName.Location = new System.Drawing.Point(31, 46);
            this.EmployeFirstName.Name = "EmployeFirstName";
            this.EmployeFirstName.Size = new System.Drawing.Size(62, 15);
            this.EmployeFirstName.TabIndex = 1;
            this.EmployeFirstName.Text = "First name";
            // 
            // EmployeLastName
            // 
            this.EmployeLastName.AutoSize = true;
            this.EmployeLastName.Location = new System.Drawing.Point(32, 75);
            this.EmployeLastName.Name = "EmployeLastName";
            this.EmployeLastName.Size = new System.Drawing.Size(61, 15);
            this.EmployeLastName.TabIndex = 2;
            this.EmployeLastName.Text = "Last name";
            // 
            // EmployeEmail
            // 
            this.EmployeEmail.AutoSize = true;
            this.EmployeEmail.Location = new System.Drawing.Point(52, 104);
            this.EmployeEmail.Name = "EmployeEmail";
            this.EmployeEmail.Size = new System.Drawing.Size(41, 15);
            this.EmployeEmail.TabIndex = 3;
            this.EmployeEmail.Text = "E-mail";
            // 
            // EmployeCompany
            // 
            this.EmployeCompany.AutoSize = true;
            this.EmployeCompany.Location = new System.Drawing.Point(34, 133);
            this.EmployeCompany.Name = "EmployeCompany";
            this.EmployeCompany.Size = new System.Drawing.Size(59, 15);
            this.EmployeCompany.TabIndex = 4;
            this.EmployeCompany.Text = "Company";
            // 
            // txtBoxEmployeId
            // 
            this.txtBoxEmployeId.Location = new System.Drawing.Point(102, 14);
            this.txtBoxEmployeId.Name = "txtBoxEmployeId";
            this.txtBoxEmployeId.ReadOnly = true;
            this.txtBoxEmployeId.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeId.TabIndex = 5;
            // 
            // txtBoxEmployeFirstName
            // 
            this.txtBoxEmployeFirstName.Location = new System.Drawing.Point(102, 43);
            this.txtBoxEmployeFirstName.Name = "txtBoxEmployeFirstName";
            this.txtBoxEmployeFirstName.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeFirstName.TabIndex = 6;
            // 
            // txtBoxEmployeLastName
            // 
            this.txtBoxEmployeLastName.Location = new System.Drawing.Point(102, 72);
            this.txtBoxEmployeLastName.Name = "txtBoxEmployeLastName";
            this.txtBoxEmployeLastName.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeLastName.TabIndex = 7;
            // 
            // comboBoxEmployeCompany
            // 
            this.comboBoxEmployeCompany.FormattingEnabled = true;
            this.comboBoxEmployeCompany.Location = new System.Drawing.Point(102, 130);
            this.comboBoxEmployeCompany.Name = "comboBoxEmployeCompany";
            this.comboBoxEmployeCompany.Size = new System.Drawing.Size(192, 23);
            this.comboBoxEmployeCompany.TabIndex = 8;
            this.comboBoxEmployeCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeCompany_SelectedIndexChanged);
            // 
            // txtBoxEmployeEmail
            // 
            this.txtBoxEmployeEmail.Location = new System.Drawing.Point(102, 101);
            this.txtBoxEmployeEmail.Name = "txtBoxEmployeEmail";
            this.txtBoxEmployeEmail.Size = new System.Drawing.Size(192, 23);
            this.txtBoxEmployeEmail.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditEmployeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 217);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxEmployeEmail);
            this.Controls.Add(this.comboBoxEmployeCompany);
            this.Controls.Add(this.txtBoxEmployeLastName);
            this.Controls.Add(this.txtBoxEmployeFirstName);
            this.Controls.Add(this.txtBoxEmployeId);
            this.Controls.Add(this.EmployeCompany);
            this.Controls.Add(this.EmployeEmail);
            this.Controls.Add(this.EmployeLastName);
            this.Controls.Add(this.EmployeFirstName);
            this.Controls.Add(this.EmployeID);
            this.Name = "EditEmployeForm";
            this.Text = "EditEmployeForm";
            this.Load += new System.EventHandler(this.EditEmployeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeID;
        private System.Windows.Forms.Label EmployeFirstName;
        private System.Windows.Forms.Label EmployeLastName;
        private System.Windows.Forms.Label EmployeEmail;
        private System.Windows.Forms.Label EmployeCompany;
        private System.Windows.Forms.TextBox txtBoxEmployeId;
        private System.Windows.Forms.TextBox txtBoxEmployeFirstName;
        private System.Windows.Forms.TextBox txtBoxEmployeLastName;
        private System.Windows.Forms.ComboBox comboBoxEmployeCompany;
        private System.Windows.Forms.TextBox txtBoxEmployeEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}