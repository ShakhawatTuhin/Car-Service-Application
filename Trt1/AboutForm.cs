using System.Xml;

namespace Trt1
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {

            InitializeComponent();
            this.Load += aboutForm_Load;
        }

        private void forName_Click(object sender, EventArgs e)
        {

        }
       private void aboutForm_Load (object sender, EventArgs e) {
            forDateCurrent.Text = DateTime.Now.ToString();
            forNeptun.Text = "VSCOP7";

        }
    }
}

/* MessageBox.Show("ahdf");
            forDateCurrent.Text = DateTime.Now.ToString(); */