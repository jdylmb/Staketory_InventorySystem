using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySytem_GUI
{
    public partial class Start : Form
    {
        private Thread workerThread;

        public Start()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Start the worker thread to perform initialization work
            workerThread = new Thread(PerformInitialization);
            workerThread.Start();
        }

        private void PerformInitialization()
        {
            // Simulate initialization work
            for (int progress = 0; progress <= 100; progress++)
            {
                // Update the progress bar on the UI thread
                Invoke(new Action(() => progressBar1.Value = progress));

                // Simulate some work being done
                Thread.Sleep(50);
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);

            //// Start the worker thread to perform initialization work
            //workerThread = new Thread(PerformInitialization);
            //workerThread.Start();
        }

        private void logoStart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
