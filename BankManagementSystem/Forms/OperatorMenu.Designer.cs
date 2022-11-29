
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
            this.SumeButton = new System.Windows.Forms.Button();
            this.ConutriExistenteButton = new System.Windows.Forms.Button();
            this.DepunereButton = new System.Windows.Forms.Button();
            this.Retragere = new System.Windows.Forms.Button();
            this.RaportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(212, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "xxxxxxxxxxxxxxxxxxxx";
            // 
            // TranzactiiButton
            // 
            this.TranzactiiButton.Location = new System.Drawing.Point(283, 107);
            this.TranzactiiButton.Name = "TranzactiiButton";
            this.TranzactiiButton.Size = new System.Drawing.Size(238, 28);
            this.TranzactiiButton.TabIndex = 1;
            this.TranzactiiButton.Text = "Verificare Tranzactii";
            this.TranzactiiButton.UseVisualStyleBackColor = true;
            this.TranzactiiButton.Click += new System.EventHandler(this.TranzactiiButton_Click);
            // 
            // SumeButton
            // 
            this.SumeButton.Location = new System.Drawing.Point(283, 158);
            this.SumeButton.Name = "SumeButton";
            this.SumeButton.Size = new System.Drawing.Size(238, 28);
            this.SumeButton.TabIndex = 3;
            this.SumeButton.Text = "Verificare total sume existente";
            this.SumeButton.UseVisualStyleBackColor = true;
            this.SumeButton.Click += new System.EventHandler(this.SumeButton_Click);
            // 
            // ConutriExistenteButton
            // 
            this.ConutriExistenteButton.Location = new System.Drawing.Point(283, 210);
            this.ConutriExistenteButton.Name = "ConutriExistenteButton";
            this.ConutriExistenteButton.Size = new System.Drawing.Size(238, 28);
            this.ConutriExistenteButton.TabIndex = 4;
            this.ConutriExistenteButton.Text = "Verificare total conturi existente";
            this.ConutriExistenteButton.UseVisualStyleBackColor = true;
            this.ConutriExistenteButton.Click += new System.EventHandler(this.ConutriExistenteButton_Click);
            // 
            // DepunereButton
            // 
            this.DepunereButton.Location = new System.Drawing.Point(283, 316);
            this.DepunereButton.Name = "DepunereButton";
            this.DepunereButton.Size = new System.Drawing.Size(238, 28);
            this.DepunereButton.TabIndex = 5;
            this.DepunereButton.Text = "Depunere";
            this.DepunereButton.UseVisualStyleBackColor = true;
            // 
            // Retragere
            // 
            this.Retragere.Location = new System.Drawing.Point(283, 371);
            this.Retragere.Name = "Retragere";
            this.Retragere.Size = new System.Drawing.Size(238, 28);
            this.Retragere.TabIndex = 6;
            this.Retragere.Text = "Retragere";
            this.Retragere.UseVisualStyleBackColor = true;
            // 
            // RaportButton
            // 
            this.RaportButton.Location = new System.Drawing.Point(283, 263);
            this.RaportButton.Name = "RaportButton";
            this.RaportButton.Size = new System.Drawing.Size(238, 28);
            this.RaportButton.TabIndex = 7;
            this.RaportButton.Text = "Raport Tranzactii";
            this.RaportButton.UseVisualStyleBackColor = true;
            this.RaportButton.Click += new System.EventHandler(this.RaportButton_Click);
            // 
            // OperatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RaportButton);
            this.Controls.Add(this.Retragere);
            this.Controls.Add(this.DepunereButton);
            this.Controls.Add(this.ConutriExistenteButton);
            this.Controls.Add(this.SumeButton);
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
        private System.Windows.Forms.Button SumeButton;
        private System.Windows.Forms.Button ConutriExistenteButton;
        private System.Windows.Forms.Button DepunereButton;
        private System.Windows.Forms.Button Retragere;
        private System.Windows.Forms.Button RaportButton;
    }
}