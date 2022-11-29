
namespace BankManagementSystem.Forms
{
    partial class SumeTotale
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.RONLabel = new System.Windows.Forms.Label();
            this.EURLabel = new System.Windows.Forms.Label();
            this.USDLabel = new System.Windows.Forms.Label();
            this.InapoiButton = new System.Windows.Forms.Button();
            this.chartRaport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRaport)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(12, 29);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(299, 24);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Suma totala existenta in banca:";
            // 
            // RONLabel
            // 
            this.RONLabel.AutoSize = true;
            this.RONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RONLabel.Location = new System.Drawing.Point(12, 76);
            this.RONLabel.Name = "RONLabel";
            this.RONLabel.Size = new System.Drawing.Size(373, 24);
            this.RONLabel.TabIndex = 1;
            this.RONLabel.Text = "Suma totala existenta in banca in RON:";
            // 
            // EURLabel
            // 
            this.EURLabel.AutoSize = true;
            this.EURLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EURLabel.Location = new System.Drawing.Point(12, 122);
            this.EURLabel.Name = "EURLabel";
            this.EURLabel.Size = new System.Drawing.Size(370, 24);
            this.EURLabel.TabIndex = 2;
            this.EURLabel.Text = "Suma totala existenta in banca in EUR:";
            // 
            // USDLabel
            // 
            this.USDLabel.AutoSize = true;
            this.USDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USDLabel.Location = new System.Drawing.Point(12, 166);
            this.USDLabel.Name = "USDLabel";
            this.USDLabel.Size = new System.Drawing.Size(369, 24);
            this.USDLabel.TabIndex = 3;
            this.USDLabel.Text = "Suma totala existenta in banca in USD:";
            // 
            // InapoiButton
            // 
            this.InapoiButton.Location = new System.Drawing.Point(12, 500);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(94, 31);
            this.InapoiButton.TabIndex = 4;
            this.InapoiButton.Text = "Inapoi";
            this.InapoiButton.UseVisualStyleBackColor = true;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // chartRaport
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRaport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRaport.Legends.Add(legend1);
            this.chartRaport.Location = new System.Drawing.Point(680, 166);
            this.chartRaport.Name = "chartRaport";
            this.chartRaport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Raport";
            this.chartRaport.Series.Add(series1);
            this.chartRaport.Size = new System.Drawing.Size(421, 365);
            this.chartRaport.TabIndex = 5;
            this.chartRaport.Text = "chartRaport";
            // 
            // SumeTotale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 543);
            this.Controls.Add(this.chartRaport);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.USDLabel);
            this.Controls.Add(this.EURLabel);
            this.Controls.Add(this.RONLabel);
            this.Controls.Add(this.TotalLabel);
            this.Name = "SumeTotale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SumeTotale";
            this.Load += new System.EventHandler(this.SumeTotale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRaport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label RONLabel;
        private System.Windows.Forms.Label EURLabel;
        private System.Windows.Forms.Label USDLabel;
        private System.Windows.Forms.Button InapoiButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRaport;
    }
}