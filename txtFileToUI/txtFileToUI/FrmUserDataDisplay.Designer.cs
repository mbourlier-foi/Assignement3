namespace txtFileToUI
{
    partial class FrmUserDataDisplay
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblYearOfBirth = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleSpecificAttribute = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtYearofbirth = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtRoleSpecificAttribute = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(52, 99);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblYearOfBirth
            // 
            this.lblYearOfBirth.AutoSize = true;
            this.lblYearOfBirth.Location = new System.Drawing.Point(52, 142);
            this.lblYearOfBirth.Name = "lblYearOfBirth";
            this.lblYearOfBirth.Size = new System.Drawing.Size(81, 16);
            this.lblYearOfBirth.TabIndex = 1;
            this.lblYearOfBirth.Text = "Year of birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(52, 186);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(52, 231);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(53, 16);
            this.lblFaculty.TabIndex = 3;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(52, 272);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role:";
            // 
            // lblRoleSpecificAttribute
            // 
            this.lblRoleSpecificAttribute.AutoSize = true;
            this.lblRoleSpecificAttribute.Location = new System.Drawing.Point(52, 315);
            this.lblRoleSpecificAttribute.Name = "lblRoleSpecificAttribute";
            this.lblRoleSpecificAttribute.Size = new System.Drawing.Size(140, 16);
            this.lblRoleSpecificAttribute.TabIndex = 5;
            this.lblRoleSpecificAttribute.Text = "[role specific attribute]:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(227, 96);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(251, 22);
            this.txtFullName.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(227, 183);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(251, 22);
            this.txtCity.TabIndex = 7;
            // 
            // txtYearofbirth
            // 
            this.txtYearofbirth.Location = new System.Drawing.Point(227, 139);
            this.txtYearofbirth.Name = "txtYearofbirth";
            this.txtYearofbirth.Size = new System.Drawing.Size(251, 22);
            this.txtYearofbirth.TabIndex = 8;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(227, 228);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(251, 22);
            this.txtFaculty.TabIndex = 9;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(227, 272);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(251, 22);
            this.txtRole.TabIndex = 10;
            // 
            // txtRoleSpecificAttribute
            // 
            this.txtRoleSpecificAttribute.Location = new System.Drawing.Point(227, 312);
            this.txtRoleSpecificAttribute.Name = "txtRoleSpecificAttribute";
            this.txtRoleSpecificAttribute.Size = new System.Drawing.Size(251, 22);
            this.txtRoleSpecificAttribute.TabIndex = 11;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(55, 39);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(171, 23);
            this.btnChooseFile.TabIndex = 12;
            this.btnChooseFile.Text = "Choose file...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // FrmUserDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 385);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.txtRoleSpecificAttribute);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtYearofbirth);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblRoleSpecificAttribute);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblYearOfBirth);
            this.Controls.Add(this.lblFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserDataDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User data display";
            this.Load += new System.EventHandler(this.FrmUserDataDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblYearOfBirth;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRoleSpecificAttribute;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtYearofbirth;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtRoleSpecificAttribute;
        private System.Windows.Forms.Button btnChooseFile;
    }
}

