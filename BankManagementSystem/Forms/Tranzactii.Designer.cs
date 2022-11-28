
namespace BankManagementSystem.Forms
{
    partial class Tranzactii
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.NrContBox = new System.Windows.Forms.TextBox();
            this.nrContLabel = new System.Windows.Forms.Label();
            this.CautareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(12, 87);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(1143, 351);
            this.GridView.TabIndex = 0;
            // 
            // NrContBox
            // 
            this.NrContBox.Location = new System.Drawing.Point(12, 39);
            this.NrContBox.Name = "NrContBox";
            this.NrContBox.Size = new System.Drawing.Size(208, 22);
            this.NrContBox.TabIndex = 2;
            this.NrContBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nrContLabel
            // 
            this.nrContLabel.AutoSize = true;
            this.nrContLabel.Location = new System.Drawing.Point(12, 19);
            this.nrContLabel.Name = "nrContLabel";
            this.nrContLabel.Size = new System.Drawing.Size(83, 17);
            this.nrContLabel.TabIndex = 4;
            this.nrContLabel.Text = "Numar Cont";
            // 
            // CautareButton
            // 
            this.CautareButton.Location = new System.Drawing.Point(916, 32);
            this.CautareButton.Name = "CautareButton";
            this.CautareButton.Size = new System.Drawing.Size(238, 29);
            this.CautareButton.TabIndex = 5;
            this.CautareButton.Text = "Cauta conturi dupa CNP";
            this.CautareButton.UseVisualStyleBackColor = true;
            this.CautareButton.Click += new System.EventHandler(this.CautareButton_Click);
            // 
            // Tranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.CautareButton);
            this.Controls.Add(this.nrContLabel);
            this.Controls.Add(this.NrContBox);
            this.Controls.Add(this.GridView);
            this.Name = "Tranzactii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tranzactii";
            this.Load += new System.EventHandler(this.Tranzactii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox NrContBox;
        private System.Windows.Forms.Label nrContLabel;
        private System.Windows.Forms.Button CautareButton;
    }
}