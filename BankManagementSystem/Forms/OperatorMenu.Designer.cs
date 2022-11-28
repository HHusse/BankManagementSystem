
namespace BankManagementSystem.Forms
{
    partial class OperatorMenu
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
            this.Label = new System.Windows.Forms.Label();
            this.TranzactiiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(13, 13);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(212, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "xxxxxxxxxxxxxxxxxxxx";
            // 
            // TranzactiiButton
            // 
            this.TranzactiiButton.Location = new System.Drawing.Point(13, 100);
            this.TranzactiiButton.Name = "TranzactiiButton";
            this.TranzactiiButton.Size = new System.Drawing.Size(94, 27);
            this.TranzactiiButton.TabIndex = 1;
            this.TranzactiiButton.Text = "Verificare Tranzactii";
            this.TranzactiiButton.UseVisualStyleBackColor = true;
            // 
            // OperatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TranzactiiButton);
            this.Controls.Add(this.Label);
            this.Name = "OperatorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperatorMenu";
            this.Load += new System.EventHandler(this.OperatorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button TranzactiiButton;
    }
}