using System.Windows.Forms;
namespace MouseDoubleClickChecker
{
    public class MouseChecker : MouseAction
    {
        private int doubleClickTime;

        public MouseChecker() : base()
        {
            doubleClickTime = SystemInformation.DoubleClickTime;
        }

        public int DoubleClickTime 
        {
            get
            {
                return doubleClickTime;
            }
        }
        public override string DoubleClickCounter()
        {
            base.DoubleClickCounter();
            return "Mouse double-click successfully detected!";
        }
    }
}
