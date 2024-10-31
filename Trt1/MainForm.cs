namespace Trt1
{
    public partial class MainForm : Form
    {
        //For Showing the Current Date
        DateTime dateTime = DateTime.UtcNow.Date;

        //Lists Creation
        public static List<string> lines = new List<string>();

        public static List<string> workName = new List<string>();
        public static List<int> reqTime = new List<int>();
        public static List<int> matCost = new List<int>();

        public MainForm()
        {
            InitializeComponent();
        }
        //Uploading The Text File And Proccessing The Data Inside
        public void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;

                worksheetTab.Enabled = true;

                lines = File.ReadAllLines(path).ToList();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    workName.Add(parts[0]);
                    reqTime.Add(int.Parse(parts[1]));
                    matCost.Add(int.Parse(parts[2]));
                }
            }
        }

        public void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorksheetForm workSheetfrm = new WorksheetForm();
            workSheetfrm.ShowDialog();
            paymentTab.Enabled = true;
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm frm = new PaymentForm();
            frm.ShowDialog();
        }


       



        private void aboutForm_Load(object sender, EventArgs e)
        {
            // Setting the text for the label "Name"

        }
        //Closing the Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Confirmation Window for Closing the Application
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "Closing", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        //Enabling Payment Tab when Registering A Sheet (Doesn't Work)
        private static MainForm mainForm = null;
        private delegate void EnablePaymentTabDelegate(bool enable);

        public static void EnableStatic(bool enable)
        {
            if (mainForm != null)
                mainForm.EnablePayementTab(enable);
        }
        private void EnablePayementTab(bool enable)
        {
            if (InvokeRequired)
            {
                this.Invoke(new EnablePaymentTabDelegate(EnablePayementTab), new object[] { enable });
                return;
            }
            paymentTab.Enabled = enable;
        }

        private void aboutTab_Click(object sender, EventArgs e)
        {
            aboutForm aboutform = new aboutForm ();
            aboutform.ShowDialog();
        }
    }
}