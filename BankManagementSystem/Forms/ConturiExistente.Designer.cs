
namespace BankManagementSystem.Forms
{
    partial class ConturiExistente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRaport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InapoiButton = new System.Windows.Forms.Button();
            this.USDLabel = new System.Windows.Forms.Label();
            this.EURLabel = new System.Windows.Forms.Label();
            this.RONLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRaport)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRaport
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRaport.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartRaport.Legends.Add(legend4);
            this.chartRaport.Location = new System.Drawing.Point(676, 171);
            this.chartRaport.Name = "chartRaport";
            this.chartRaport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Raport";
            this.chartRaport.Series.Add(series4);
            this.chartRaport.Size = new System.Drawing.Size(421, 365);
            this.chartRaport.TabIndex = 11;
            this.chartRaport.Text = "chartRaport";
            // 
            // InapoiButton
            // 
            this.InapoiButton.Location = new System.Drawing.Point(8, 505);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(94, 31);
            this.InapoiButton.TabIndex = 10;
            this.InapoiButton.Text = "Inapoi";
            this.InapoiButton.UseVisualStyleBackColor = true;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // USDLabel
            // 
            this.USDLabel.AutoSize = true;
            this.USDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USDLabel.Location = new System.Drawing.Point(8, 171);
            this.USDLabel.Name = "USDLabel";
            this.USDLabel.Size = new System.Drawing.Size(328, 24);
            this.USDLabel.TabIndex = 9;
            this.USDLabel.Text = "Conturi existenta in banca in USD:";
            // 
            // EURLabel
            // 
            this.EURLabel.AutoSize = true;
            this.EURLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EURLabel.Location = new System.Drawing.Point(8, 127);
            this.EURLabel.Name = "EURLabel";
            this.EURLabel.Size = new System.Drawing.Size(329, 24);
            this.EURLabel.TabIndex = 8;
            this.EURLabel.Text = "Conturi existenta in banca in EUR:";
            // 
            // RONLabel
            // 
            this.RONLabel.AutoSize = true;
            this.RONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RONLabel.Location = new System.Drawing.Point(8, 81);
            this.RONLabel.Name = "RONLabel";
            this.RONLabel.Size = new System.Drawing.Size(332, 24);
            this.RONLabel.TabIndex = 7;
            this.RONLabel.Text = "Conturi existenta in banca in RON:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(8, 34);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(258, 24);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Conutir existenta in banca:";
            // 
            // ConturiExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 552);
            this.Controls.Add(this.chartRaport);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.USDLabel);
            this.Controls.Add(this.EURLabel);
            this.Controls.Add(this.RONLabel);
            this.Controls.Add(this.TotalLabel);
            this.Name = "ConturiExistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConturiExistente";
            this.Load += new System.EventHandler(this.ConturiExistente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRaport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRaport;
        private System.Windows.Forms.Button InapoiButton;
        private System.Windows.Forms.Label USDLabel;
        private System.Windows.Forms.Label EURLabel;
        private System.Windows.Forms.Label RONLabel;
        private System.Windows.Forms.Label TotalLabel;
    }
}