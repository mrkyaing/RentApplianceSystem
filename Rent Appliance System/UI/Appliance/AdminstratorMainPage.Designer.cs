namespace Rent_Appliance_System
{
    partial class AdminstratorMainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListofRent = new System.Windows.Forms.Button();
            this.btnAppliance = new System.Windows.Forms.Button();
            this.btnApplianceType = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnAdminstrator = new System.Windows.Forms.Button();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridViewCommon = new System.Windows.Forms.DataGridView();
            this.btnAdminupdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rent Appliance System";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAdminupdate);
            this.groupBox1.Controls.Add(this.btnListofRent);
            this.groupBox1.Controls.Add(this.btnAppliance);
            this.groupBox1.Controls.Add(this.btnApplianceType);
            this.groupBox1.Controls.Add(this.btnBrand);
            this.groupBox1.Controls.Add(this.btnAdminstrator);
            this.groupBox1.Location = new System.Drawing.Point(24, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 430);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnListofRent
            // 
            this.btnListofRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListofRent.Location = new System.Drawing.Point(14, 321);
            this.btnListofRent.Name = "btnListofRent";
            this.btnListofRent.Size = new System.Drawing.Size(257, 44);
            this.btnListofRent.TabIndex = 4;
            this.btnListofRent.Text = "List of Rent";
            this.btnListofRent.UseVisualStyleBackColor = true;
            this.btnListofRent.Click += new System.EventHandler(this.btnListofRent_Click);
            // 
            // btnAppliance
            // 
            this.btnAppliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppliance.Location = new System.Drawing.Point(14, 247);
            this.btnAppliance.Name = "btnAppliance";
            this.btnAppliance.Size = new System.Drawing.Size(257, 44);
            this.btnAppliance.TabIndex = 3;
            this.btnAppliance.Text = "Appliance";
            this.btnAppliance.UseVisualStyleBackColor = true;
            this.btnAppliance.Click += new System.EventHandler(this.btnAppliance_Click);
            // 
            // btnApplianceType
            // 
            this.btnApplianceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplianceType.Location = new System.Drawing.Point(14, 172);
            this.btnApplianceType.Name = "btnApplianceType";
            this.btnApplianceType.Size = new System.Drawing.Size(257, 44);
            this.btnApplianceType.TabIndex = 2;
            this.btnApplianceType.Text = "Appliance Type";
            this.btnApplianceType.UseVisualStyleBackColor = true;
            this.btnApplianceType.Click += new System.EventHandler(this.btnApplianceType_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.Location = new System.Drawing.Point(10, 98);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(257, 44);
            this.btnBrand.TabIndex = 1;
            this.btnBrand.Text = "Brand";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnAdminstrator
            // 
            this.btnAdminstrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminstrator.Location = new System.Drawing.Point(10, 25);
            this.btnAdminstrator.Name = "btnAdminstrator";
            this.btnAdminstrator.Size = new System.Drawing.Size(257, 44);
            this.btnAdminstrator.TabIndex = 0;
            this.btnAdminstrator.Text = "Adminstrator";
            this.btnAdminstrator.UseVisualStyleBackColor = true;
            this.btnAdminstrator.Click += new System.EventHandler(this.btnAdminstrator_Click);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.btnClose);
            this.gbox.Controls.Add(this.btnNew);
            this.gbox.Controls.Add(this.dataGridViewCommon);
            this.gbox.Location = new System.Drawing.Point(336, 107);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(620, 398);
            this.gbox.TabIndex = 2;
            this.gbox.TabStop = false;
            this.gbox.Text = "Administrator Information";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(242, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close(X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(138, 336);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 43);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New (+)";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridViewCommon
            // 
            this.dataGridViewCommon.AllowUserToAddRows = false;
            this.dataGridViewCommon.AllowUserToDeleteRows = false;
            this.dataGridViewCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommon.Location = new System.Drawing.Point(27, 27);
            this.dataGridViewCommon.Name = "dataGridViewCommon";
            this.dataGridViewCommon.ReadOnly = true;
            this.dataGridViewCommon.RowTemplate.Height = 24;
            this.dataGridViewCommon.Size = new System.Drawing.Size(564, 303);
            this.dataGridViewCommon.TabIndex = 4;
            // 
            // btnAdminupdate
            // 
            this.btnAdminupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminupdate.Location = new System.Drawing.Point(14, 380);
            this.btnAdminupdate.Name = "btnAdminupdate";
            this.btnAdminupdate.Size = new System.Drawing.Size(257, 44);
            this.btnAdminupdate.TabIndex = 5;
            this.btnAdminupdate.Text = "Admin Update";
            this.btnAdminupdate.UseVisualStyleBackColor = true;
            this.btnAdminupdate.Click += new System.EventHandler(this.btnAdminupdate_Click);
            // 
            // AdminstratorMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rent_Appliance_System.Properties.Resources.photo_1486406146926_c627a92ad1ab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 546);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AdminstratorMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminstratorMainPage";
            this.Load += new System.EventHandler(this.AdminstratorMainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListofRent;
        private System.Windows.Forms.Button btnAppliance;
        private System.Windows.Forms.Button btnApplianceType;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnAdminstrator;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.DataGridView dataGridViewCommon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdminupdate;
    }
}