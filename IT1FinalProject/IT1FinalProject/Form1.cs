using System;
using System.Windows.Forms;

namespace MouseDoubleClickChecker
{
    public partial class Form1 : Form
    {
        MouseAction action = new MouseChecker();

        public Form1()
        {
            InitializeComponent();

            MouseChecker checker = (MouseChecker)action;

            lblTime.Text = "Double-click time: "
                + checker.DoubleClickTime + " ms";

            lblResult.Text = "Waiting for mouse input...";
        }

        private void pnlClickArea_MouseDown(object sender, MouseEventArgs e)
        {

            lblClickCount.Text = "Total Clicks: " + action.NormalClickCounter();
        }

        private void pnlClickArea_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string message = action.RegisterDoubleClick();

            lblCount.Text = "Double-click count: "
                + action.DoubleClickCount;

            lblResult.Text = message;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            action.ResetCounter();

            lblCount.Text = "Double-click count: 0";
            lblClickCount.Text = "Total Clicks: 0";

            lblResult.Text = "Counters have been reset.";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}