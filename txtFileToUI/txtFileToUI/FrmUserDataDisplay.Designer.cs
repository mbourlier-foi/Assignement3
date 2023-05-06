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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(52, 103);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblYearOfBirth
            // 
            this.lblYearOfBirth.AutoSize = true;
            this.lblYearOfBirth.Location = new System.Drawing.Point(52, 146);
            this.lblYearOfBirth.Name = "lblYearOfBirth";
            this.lblYearOfBirth.Size = new System.Drawing.Size(81, 16);
            this.lblYearOfBirth.TabIndex = 1;
            this.lblYearOfBirth.Text = "Year of birth:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(52, 190);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(52, 235);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(53, 16);
            this.lblFaculty.TabIndex = 3;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(52, 276);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role:";
            // 
            // lblRoleSpecificAttribute
            // 
            this.lblRoleSpecificAttribute.AutoSize = true;
            this.lblRoleSpecificAttribute.Location = new System.Drawing.Point(52, 319);
            this.lblRoleSpecificAttribute.Name = "lblRoleSpecificAttribute";
            this.lblRoleSpecificAttribute.Size = new System.Drawing.Size(140, 16);
            this.lblRoleSpecificAttribute.TabIndex = 5;
            this.lblRoleSpecificAttribute.Text = "[role specific attribute]:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(227, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(227, 276);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(227, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 22);
            this.textBox6.TabIndex = 11;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(55, 44);
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
            this.ClientSize = new System.Drawing.Size(452, 370);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnChooseFile;
    }
}

