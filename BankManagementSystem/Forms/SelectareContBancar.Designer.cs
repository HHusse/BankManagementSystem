
namespace BankManagementSystem.Forms
{
    partial class SelectareContBancar
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
            this.Conturi = new System.Windows.Forms.ListBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.InapoiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Conturi
            // 
            this.Conturi.FormattingEnabled = true;
            this.Conturi.ItemHeight = 16;
            this.Conturi.Location = new System.Drawing.Point(133, 67);
            this.Conturi.Name = "Conturi";
            this.Conturi.Size = new System.Drawing.Size(193, 292);
            this.Conturi.TabIndex = 0;
            this.Conturi.SelectedIndexChanged += new System.EventHandler(this.Conturi_SelectedIndexChanged);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(365, 395);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(106, 33);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // InapoiButton
            // 
            this.InapoiButton.Location = new System.Drawing.Point(12, 395);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(106, 33);
            this.InapoiButton.TabIndex = 3;
            this.InapoiButton.Text = "Inapoi";
            this.InapoiButton.UseVisualStyleBackColor = true;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // SelectareContBancar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Conturi);
            this.Name = "SelectareContBancar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectareContBancar";
            this.Load += new System.EventHandler(this.SelectareContBancar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Conturi;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button InapoiButton;
    }
}