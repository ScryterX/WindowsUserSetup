namespace WindowsUserSetup
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxUILanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxInputLocale = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeZone = new System.Windows.Forms.ComboBox();
            this.checkBoxAutoLogon = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUILanguage
            // 
            this.comboBoxUILanguage.FormattingEnabled = true;
            this.comboBoxUILanguage.Location = new System.Drawing.Point(12, 12);
            this.comboBoxUILanguage.Name = "comboBoxUILanguage";
            this.comboBoxUILanguage.Size = new System.Drawing.Size(260, 21);
            this.comboBoxUILanguage.TabIndex = 0;
            // 
            // comboBoxInputLocale
            // 
            this.comboBoxInputLocale.FormattingEnabled = true;
            this.comboBoxInputLocale.Location = new System.Drawing.Point(12, 39);
            this.comboBoxInputLocale.Name = "comboBoxInputLocale";
            this.comboBoxInputLocale.Size = new System.Drawing.Size(260, 21);
            this.comboBoxInputLocale.TabIndex = 1;
            // 
            // comboBoxTimeZone
            // 
            this.comboBoxTimeZone.FormattingEnabled = true;
            this.comboBoxTimeZone.Location = new System.Drawing.Point(12, 66);
            this.comboBoxTimeZone.Name = "comboBoxTimeZone";
            this.comboBoxTimeZone.Size = new System.Drawing.Size(260, 21);
            this.comboBoxTimeZone.TabIndex = 2;
            // 
            // checkBoxAutoLogon
            // 
            this.checkBoxAutoLogon.AutoSize = true;
            this.checkBoxAutoLogon.Location = new System.Drawing.Point(12, 93);
            this.checkBoxAutoLogon.Name = "checkBoxAutoLogon";
            this.checkBoxAutoLogon.Size = new System.Drawing.Size(79, 17);
            this.checkBoxAutoLogon.TabIndex = 3;
            this.checkBoxAutoLogon.Text = "Auto Logon";
            this.checkBoxAutoLogon.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(197, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxAutoLogon);
            this.Controls.Add(this.comboBoxTimeZone);
            this.Controls.Add(this.comboBoxInputLocale);
            this.Controls.Add(this.comboBoxUILanguage);
            this.Name = "Form1";
            this.Text = "Windows User Setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxUILanguage;
        private System.Windows.Forms.ComboBox comboBoxInputLocale;
        private System.Windows.Forms.ComboBox comboBoxTimeZone;
        private System.Windows.Forms.CheckBox checkBoxAutoLogon;
        private System.Windows.Forms.Button buttonSave;
    }
}
