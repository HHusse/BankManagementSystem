
namespace BankManagementSystem.Forms
{
    partial class CautareConturi
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
            this.CNPBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.CNPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CNPBox
            // 
            this.CNPBox.Location = new System.Drawing.Point(54, 51);
            this.CNPBox.Name = "CNPBox";
            this.CNPBox.Size = new System.Drawing.Size(336, 22);
            this.CNPBox.TabIndex = 0;
            this.CNPBox.TextChanged += new System.EventHandler(this.CNPBox_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(54, 94);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(336, 292);
            this.listBox.TabIndex = 1;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // CNPLabel
            // 
            this.CNPLabel.AutoSize = true;
            this.CNPLabel.Location = new System.Drawing.Point(54, 28);
            this.CNPLabel.Name = "CNPLabel";
            this.CNPLabel.Size = new System.Drawing.Size(36, 17);
            this.CNPLabel.TabIndex = 2;
            this.CNPLabel.Text = "CNP";
            // 
            // CautareConturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.CNPLabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CNPBox);
            this.Name = "CautareConturi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CautareConturi";
            this.Load += new System.EventHandler(this.CautareConturi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CNPBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label CNPLabel;
    }
}