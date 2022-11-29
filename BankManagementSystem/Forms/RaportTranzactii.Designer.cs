
namespace BankManagementSystem.Forms
{
    partial class RaportTranzactii
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataPicker = new System.Windows.Forms.DateTimePicker();
            this.TranzactiiLabel = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.InapoiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPicker
            // 
            this.DataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataPicker.Location = new System.Drawing.Point(12, 24);
            this.DataPicker.Name = "DataPicker";
            this.DataPicker.Size = new System.Drawing.Size(129, 22);
            this.DataPicker.TabIndex = 0;
            this.DataPicker.ValueChanged += new System.EventHandler(this.DataPicker_ValueChanged);
            // 
            // TranzactiiLabel
            // 
            this.TranzactiiLabel.AutoSize = true;
            this.TranzactiiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranzactiiLabel.Location = new System.Drawing.Point(195, 22);
            this.TranzactiiLabel.Name = "TranzactiiLabel";
            this.TranzactiiLabel.Size = new System.Drawing.Size(90, 24);
            this.TranzactiiLabel.TabIndex = 1;
            this.TranzactiiLabel.Text = "xxxxxxxx";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(12, 62);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(1055, 351);
            this.GridView.TabIndex = 2;
            // 
            // InapoiButton
            // 
            this.InapoiButton.Location = new System.Drawing.Point(12, 437);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(94, 31);
            this.InapoiButton.TabIndex = 11;
            this.InapoiButton.Text = "Inapoi";
            this.InapoiButton.UseVisualStyleBackColor = true;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // RaportTranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 488);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.TranzactiiLabel);
            this.Controls.Add(this.DataPicker);
            this.Name = "RaportTranzactii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaportTranzactii";
            this.Load += new System.EventHandler(this.RaportTranzactii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataPicker;
        private System.Windows.Forms.Label TranzactiiLabel;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button InapoiButton;
    }
}