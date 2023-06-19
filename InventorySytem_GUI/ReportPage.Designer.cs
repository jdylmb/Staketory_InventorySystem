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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            mng_reportLabel = new Label();
            MngProductPanel = new CustomizedPanel();
            closeReportButton = new Button();
            TitleLabel = new Label();
            monthlySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            productLowerDockPanel = new CustomizedPanel();
            label1 = new Label();
            customizedPanel1 = new CustomizedPanel();
            topSalesAmount = new Label();
            customizedPanel2 = new CustomizedPanel();
            label2 = new Label();
            customizedPanel3 = new CustomizedPanel();
            label3 = new Label();
            weeklySalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            customizedPanel4 = new CustomizedPanel();
            totalSales = new Label();
            label5 = new Label();
            MngProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monthlySales).BeginInit();
            customizedPanel1.SuspendLayout();
            customizedPanel2.SuspendLayout();
            customizedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weeklySalesChart).BeginInit();
            customizedPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // mng_reportLabel
            // 
            mng_reportLabel.AutoSize = true;
            mng_reportLabel.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            mng_reportLabel.ForeColor = SystemColors.ButtonHighlight;
            mng_reportLabel.Location = new Point(590, 72);
            mng_reportLabel.Name = "mng_reportLabel";
            mng_reportLabel.Size = new Size(135, 29);
            mng_reportLabel.TabIndex = 2;
            mng_reportLabel.Text = "Dashboard";
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
            MngProductPanel.VisibleChanged += MngProductPanel_VisibleChanged;
            MngProductPanel.Paint += MngProductPanel_Paint;
            // 
            // closeReportButton
            // 
            closeReportButton.AccessibleName = "searchBtn";
            closeReportButton.BackColor = Color.Transparent;
            closeReportButton.BackgroundImage = (Image)resources.GetObject("closeReportButton.BackgroundImage");
            closeReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeReportButton.FlatAppearance.BorderSize = 0;
            closeReportButton.FlatStyle = FlatStyle.Flat;
            closeReportButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeReportButton.ForeColor = Color.GhostWhite;
            closeReportButton.ImageAlign = ContentAlignment.MiddleRight;
            closeReportButton.Location = new Point(1224, 2);
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
            TitleLabel.Location = new Point(383, 23);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(520, 36);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Staketory Management System";
            TitleLabel.Click += TitleLabel_Click;
            // 
            // monthlySales
            // 
            monthlySales.BackColor = Color.MediumSlateBlue;
            monthlySales.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            monthlySales.BackgroundImageLayout = ImageLayout.None;
            monthlySales.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            monthlySales.BorderlineColor = Color.Transparent;
            chartArea3.Name = "ChartArea1";
            monthlySales.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            monthlySales.Legends.Add(legend3);
            monthlySales.Location = new Point(460, 228);
            monthlySales.Name = "monthlySales";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            monthlySales.Series.Add(series3);
            monthlySales.Size = new Size(742, 212);
            monthlySales.TabIndex = 34;
            monthlySales.Text = "Total Sales";
            monthlySales.Click += monthlySales_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 128);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 36;
            label1.Text = "Top Product: ";
            label1.Click += label1_Click;
            // 
            // customizedPanel1
            // 
            customizedPanel1.BackColor = Color.White;
            customizedPanel1.BorderRadius = 30;
            customizedPanel1.Controls.Add(topSalesAmount);
            customizedPanel1.Controls.Add(label1);
            customizedPanel1.ForeColor = Color.Black;
            customizedPanel1.GradientAngle = 90F;
            customizedPanel1.GradientBottomColor = Color.MediumPurple;
            customizedPanel1.GradientTopColor = Color.Violet;
            customizedPanel1.Location = new Point(34, 461);
            customizedPanel1.Name = "customizedPanel1";
            customizedPanel1.Size = new Size(350, 200);
            customizedPanel1.TabIndex = 37;
            // 
            // topSalesAmount
            // 
            topSalesAmount.AutoSize = true;
            topSalesAmount.BackColor = Color.Transparent;
            topSalesAmount.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            topSalesAmount.Location = new Point(26, 39);
            topSalesAmount.Name = "topSalesAmount";
            topSalesAmount.Size = new Size(70, 65);
            topSalesAmount.TabIndex = 37;
            topSalesAmount.Text = "P ";
            // 
            // customizedPanel2
            // 
            customizedPanel2.BackColor = Color.White;
            customizedPanel2.BorderRadius = 30;
            customizedPanel2.Controls.Add(label2);
            customizedPanel2.ForeColor = Color.Black;
            customizedPanel2.GradientAngle = 90F;
            customizedPanel2.GradientBottomColor = Color.MediumPurple;
            customizedPanel2.GradientTopColor = Color.Violet;
            customizedPanel2.Location = new Point(481, 150);
            customizedPanel2.Name = "customizedPanel2";
            customizedPanel2.Size = new Size(350, 62);
            customizedPanel2.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 10);
            label2.Name = "label2";
            label2.Size = new Size(183, 37);
            label2.TabIndex = 0;
            label2.Text = "Monthly Sales";
            label2.Click += label2_Click;
            // 
            // customizedPanel3
            // 
            customizedPanel3.BackColor = Color.White;
            customizedPanel3.BorderRadius = 30;
            customizedPanel3.Controls.Add(label3);
            customizedPanel3.ForeColor = Color.Black;
            customizedPanel3.GradientAngle = 90F;
            customizedPanel3.GradientBottomColor = Color.MediumPurple;
            customizedPanel3.GradientTopColor = Color.Violet;
            customizedPanel3.Location = new Point(481, 451);
            customizedPanel3.Name = "customizedPanel3";
            customizedPanel3.Size = new Size(350, 62);
            customizedPanel3.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 10);
            label3.Name = "label3";
            label3.Size = new Size(169, 37);
            label3.TabIndex = 0;
            label3.Text = "Weekly Sales";
            // 
            // weeklySalesChart
            // 
            weeklySalesChart.BackColor = Color.MediumSlateBlue;
            weeklySalesChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            weeklySalesChart.BackgroundImageLayout = ImageLayout.None;
            weeklySalesChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            weeklySalesChart.BorderlineColor = Color.Transparent;
            chartArea4.Name = "ChartArea1";
            weeklySalesChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            weeklySalesChart.Legends.Add(legend4);
            weeklySalesChart.Location = new Point(460, 529);
            weeklySalesChart.Name = "weeklySalesChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            weeklySalesChart.Series.Add(series4);
            weeklySalesChart.Size = new Size(742, 212);
            weeklySalesChart.TabIndex = 39;
            weeklySalesChart.Text = "Total Sales";
            // 
            // customizedPanel4
            // 
            customizedPanel4.BackColor = Color.White;
            customizedPanel4.BorderRadius = 30;
            customizedPanel4.Controls.Add(totalSales);
            customizedPanel4.Controls.Add(label5);
            customizedPanel4.ForeColor = Color.Black;
            customizedPanel4.GradientAngle = 90F;
            customizedPanel4.GradientBottomColor = Color.MediumPurple;
            customizedPanel4.GradientTopColor = Color.Violet;
            customizedPanel4.Location = new Point(34, 150);
            customizedPanel4.Name = "customizedPanel4";
            customizedPanel4.Size = new Size(405, 290);
            customizedPanel4.TabIndex = 38;
            customizedPanel4.Paint += customizedPanel4_Paint;
            // 
            // totalSales
            // 
            totalSales.AutoSize = true;
            totalSales.BackColor = Color.Transparent;
            totalSales.Font = new Font("Segoe UI", 69.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalSales.Location = new Point(0, 38);
            totalSales.Name = "totalSales";
            totalSales.Size = new Size(135, 124);
            totalSales.TabIndex = 37;
            totalSales.Text = "P ";
            totalSales.Click += totalSales_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 192);
            label5.Name = "label5";
            label5.Size = new Size(182, 47);
            label5.TabIndex = 36;
            label5.Text = "Total Sales";
            label5.Click += label5_Click;
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(customizedPanel4);
            Controls.Add(customizedPanel3);
            Controls.Add(customizedPanel2);
            Controls.Add(weeklySalesChart);
            Controls.Add(customizedPanel1);
            Controls.Add(productLowerDockPanel);
            Controls.Add(monthlySales);
            Controls.Add(MngProductPanel);
            Name = "ReportPage";
            Size = new Size(1279, 810);
            Load += ReportPage_Load_1;
            VisibleChanged += ReportPage_VisibleChanged;
            MngProductPanel.ResumeLayout(false);
            MngProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)monthlySales).EndInit();
            customizedPanel1.ResumeLayout(false);
            customizedPanel1.PerformLayout();
            customizedPanel2.ResumeLayout(false);
            customizedPanel2.PerformLayout();
            customizedPanel3.ResumeLayout(false);
            customizedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weeklySalesChart).EndInit();
            customizedPanel4.ResumeLayout(false);
            customizedPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label mng_reportLabel;
        private CustomizedPanel MngProductPanel;
        private Label TitleLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button closeReportButton;
        private CustomizedPanel productLowerDockPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlySales;
        private Label label1;
        private CustomizedPanel customizedPanel1;
        private CustomizedPanel customizedPanel2;
        private Label label2;
        private Label topSalesAmount;
        private CustomizedPanel customizedPanel3;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklySalesChart;
        private CustomizedPanel customizedPanel4;
        private Label totalSales;
        private Label label5;
    }
}
