namespace InventorySytem_GUI
{
    partial class ReportPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mng_reportLabel = new Label();
            MngProductPanel = new CustomizedPanel();
            closeReportButton = new Button();
            TitleLabel = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            productLowerDockPanel = new CustomizedPanel();
            MngProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // mng_reportLabel
            // 
            mng_reportLabel.AutoSize = true;
            mng_reportLabel.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mng_reportLabel.ForeColor = SystemColors.ButtonHighlight;
            mng_reportLabel.Location = new Point(497, 72);
            mng_reportLabel.Name = "mng_reportLabel";
            mng_reportLabel.Size = new Size(184, 29);
            mng_reportLabel.TabIndex = 2;
            mng_reportLabel.Text = "Manage Report";
            // 
            // MngProductPanel
            // 
            MngProductPanel.BackColor = Color.Transparent;
            MngProductPanel.BorderRadius = 30;
            MngProductPanel.Controls.Add(closeReportButton);
            MngProductPanel.Controls.Add(TitleLabel);
            MngProductPanel.Controls.Add(mng_reportLabel);
            MngProductPanel.Dock = DockStyle.Top;
            MngProductPanel.ForeColor = Color.Black;
            MngProductPanel.GradientAngle = 90F;
            MngProductPanel.GradientBottomColor = Color.MediumPurple;
            MngProductPanel.GradientTopColor = Color.Violet;
            MngProductPanel.Location = new Point(0, 0);
            MngProductPanel.Name = "MngProductPanel";
            MngProductPanel.Size = new Size(1279, 110);
            MngProductPanel.TabIndex = 33;
            // 
            // closeReportButton
            // 
            closeReportButton.AccessibleName = "searchBtn";
            closeReportButton.BackColor = Color.Transparent;
            closeReportButton.BackgroundImage = (Image)resources.GetObject("closeReportButton.BackgroundImage");
            closeReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeReportButton.FlatStyle = FlatStyle.Popup;
            closeReportButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeReportButton.ForeColor = Color.GhostWhite;
            closeReportButton.ImageAlign = ContentAlignment.MiddleRight;
            closeReportButton.Location = new Point(1242, 2);
            closeReportButton.Margin = new Padding(3, 2, 3, 2);
            closeReportButton.Name = "closeReportButton";
            closeReportButton.Size = new Size(34, 32);
            closeReportButton.TabIndex = 44;
            closeReportButton.UseVisualStyleBackColor = false;
            closeReportButton.Click += closeReportButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Indigo;
            TitleLabel.Location = new Point(332, 23);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(520, 36);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Staketory Management System";
            // 
            // chart1
            // 
            chart1.BackgroundImageLayout = ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(40, 184);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(626, 364);
            chart1.TabIndex = 34;
            chart1.Text = "chart1";
            // 
            // productLowerDockPanel
            // 
            productLowerDockPanel.BackColor = Color.White;
            productLowerDockPanel.BorderRadius = 30;
            productLowerDockPanel.Dock = DockStyle.Bottom;
            productLowerDockPanel.ForeColor = Color.Black;
            productLowerDockPanel.GradientAngle = 90F;
            productLowerDockPanel.GradientBottomColor = Color.Violet;
            productLowerDockPanel.GradientTopColor = Color.MediumPurple;
            productLowerDockPanel.Location = new Point(0, 747);
            productLowerDockPanel.Name = "productLowerDockPanel";
            productLowerDockPanel.Size = new Size(1279, 63);
            productLowerDockPanel.TabIndex = 35;
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(productLowerDockPanel);
            Controls.Add(chart1);
            Controls.Add(MngProductPanel);
            Name = "ReportPage";
            Size = new Size(1279, 810);
            MngProductPanel.ResumeLayout(false);
            MngProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label mng_reportLabel;
        private CustomizedPanel MngProductPanel;
        private Label TitleLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button closeReportButton;
        private CustomizedPanel productLowerDockPanel;
    }
}
