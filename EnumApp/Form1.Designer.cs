
namespace EnumApp
{
    partial class enumSwitch
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
            this.cmbSwitchBox = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSwitchBox
            // 
            this.cmbSwitchBox.FormattingEnabled = true;
            this.cmbSwitchBox.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cmbSwitchBox.Location = new System.Drawing.Point(268, 171);
            this.cmbSwitchBox.Name = "cmbSwitchBox";
            this.cmbSwitchBox.Size = new System.Drawing.Size(201, 21);
            this.cmbSwitchBox.TabIndex = 0;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(268, 231);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(201, 34);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // enumSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.cmbSwitchBox);
            this.Name = "enumSwitch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSwitchBox;
        private System.Windows.Forms.Button btnSwitch;
    }
}

