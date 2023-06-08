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
            logoStart = new Panel();
            SuspendLayout();
            // 
            // logoStart
            // 
            logoStart.BackColor = Color.White;
            logoStart.BackgroundImage = (Image)resources.GetObject("logoStart.BackgroundImage");
            logoStart.BackgroundImageLayout = ImageLayout.Stretch;
            logoStart.Location = new Point(297, 186);
            logoStart.Name = "logoStart";
            logoStart.Size = new Size(654, 408);
            logoStart.TabIndex = 0;
            logoStart.Paint += logoStart_Paint;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1279, 810);
            Controls.Add(logoStart);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Start";
            Text = "Start";
            Load += Start_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel logoStart;
    }
}