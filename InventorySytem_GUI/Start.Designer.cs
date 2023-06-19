namespace InventorySytem_GUI
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            progressBar1 = new ProgressBar();
            customizedPanel1 = new CustomizedPanel();
            customizedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(616, 26);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // customizedPanel1
            // 
            customizedPanel1.BackColor = Color.White;
            customizedPanel1.BorderRadius = 30;
            customizedPanel1.Controls.Add(progressBar1);
            customizedPanel1.ForeColor = Color.Black;
            customizedPanel1.GradientAngle = 90F;
            customizedPanel1.GradientBottomColor = Color.MediumPurple;
            customizedPanel1.GradientTopColor = Color.Violet;
            customizedPanel1.Location = new Point(323, 605);
            customizedPanel1.Name = "customizedPanel1";
            customizedPanel1.Size = new Size(616, 25);
            customizedPanel1.TabIndex = 1;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1279, 810);
            Controls.Add(customizedPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            Load += Start_Load;
            customizedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private CustomizedPanel customizedPanel1;
    }
}