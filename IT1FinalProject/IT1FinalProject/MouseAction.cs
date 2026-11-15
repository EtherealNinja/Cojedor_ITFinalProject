using System;

namespace MouseDoubleClickChecker
{
    public class MouseAction
    {
        private int doubleClickCount;
        private int normalClickCount;

        public MouseAction()
        {
            doubleClickCount = 0;
            normalClickCount = 0;
        }

        public int DoubleClickCount
        {
            get
            {
                return doubleClickCount;
            }
        }

        public int NormalClickCount
        {
            get
            {
                return normalClickCount;
            }
        }

        public virtual string DoubleClickCounter()
        {
            doubleClickCount++;
            return "Mouse double-click detected!";
        }

        public int NormalClickCounter()
        {
            normalClickCount++;
            return normalClickCount++;
        }

        public void ResetCounter()
        {
            doubleClickCount = 0;
            normalClickCount = 0;
        }

    }


}