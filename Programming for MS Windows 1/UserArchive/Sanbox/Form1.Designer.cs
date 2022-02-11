namespace UserArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.chkLanguages = new System.Windows.Forms.CheckBox();
            this.chkDriving = new System.Windows.Forms.CheckBox();
            this.chkProgramming = new System.Windows.Forms.CheckBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.lblCity = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblAction = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSkills);
            this.groupBox1.Controls.Add(this.chkLanguages);
            this.groupBox1.Controls.Add(this.chkDriving);
            this.groupBox1.Controls.Add(this.chkProgramming);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.rdFemale);
            this.groupBox1.Controls.Add(this.rdMale);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lstCity);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblSkills
            // 
            resources.ApplyResources(this.lblSkills, "lblSkills");
            this.lblSkills.Name = "lblSkills";
            // 
            // chkLanguages
            // 
            resources.ApplyResources(this.chkLanguages, "chkLanguages");
            this.chkLanguages.Name = "chkLanguages";
            this.chkLanguages.UseVisualStyleBackColor = true;
            // 
            // chkDriving
            // 
            resources.ApplyResources(this.chkDriving, "chkDriving");
            this.chkDriving.Name = "chkDriving";
            this.chkDriving.UseVisualStyleBackColor = true;
            // 
            // chkProgramming
            // 
            resources.ApplyResources(this.chkProgramming, "chkProgramming");
            this.chkProgramming.Name = "chkProgramming";
            this.chkProgramming.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            // 
            // rdFemale
            // 
            resources.ApplyResources(this.rdFemale, "rdFemale");
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.TabStop = true;
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            resources.ApplyResources(this.rdMale, "rdMale");
            this.rdMale.Name = "rdMale";
            this.rdMale.TabStop = true;
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.Name = "lblCity";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Items.AddRange(new object[] {
            resources.GetString("lstCity.Items"),
            resources.GetString("lstCity.Items1"),
            resources.GetString("lstCity.Items2")});
            resources.ApplyResources(this.lstCity, "lstCity");
            this.lstCity.Name = "lstCity";
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // txtSurname
            // 
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // lblSurname
            // 
            resources.ApplyResources(this.lblSurname, "lblSurname");
            this.lblSurname.Name = "lblSurname";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            resources.ApplyResources(this.btnImport, "btnImport");
            this.btnImport.Name = "btnImport";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblAction
            // 
            resources.ApplyResources(this.lblAction, "lblAction");
            this.lblAction.Name = "lblAction";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLang
            // 
            resources.ApplyResources(this.lblLang, "lblLang");
            this.lblLang.Name = "lblLang";
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.CheckBox chkLanguages;
        private System.Windows.Forms.CheckBox chkDriving;
        private System.Windows.Forms.CheckBox chkProgramming;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Button btnAbout;
    }
}

