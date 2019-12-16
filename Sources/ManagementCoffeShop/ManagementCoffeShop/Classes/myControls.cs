namespace ManagementCoffeShop.Classes
{
    using System.Windows.Forms;

    public class myControls
    {
        private static myControls instance;

        public static myControls Instance
        {
            get
            {
                if (instance == null) return instance = new myControls();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void addCotrolTableToOrder(Control controlFirst, Control controlSecond)
        {
            controlFirst.Dock = DockStyle.Fill;
            controlSecond.Controls.Clear();
            controlSecond.Controls.Add(controlFirst);
            //controlFirst.BringToFront();
        }

    }
}
