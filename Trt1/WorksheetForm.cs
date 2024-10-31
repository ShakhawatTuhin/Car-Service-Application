//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Trt1
{
    public partial class WorksheetForm : Form
    {
        //Variables Initialization
        public static int matCost = 0;
        public static int timeCost = 0;
        public static int TotMatCost = 0;
        public static int TotTimCost = 0;

        public static int TotInvoicedTime = 0;

        public static int registeredSheetsCount = 0;
        public static int workCount = 0;

        public bool Registered = false;

        List<CheckBox> CheckBoxesList = new List<CheckBox>();
        PaymentForm paymentForm = new PaymentForm();

        //private static WorksheetForm wsf;
        public int TotalMaterialCost
        {
            get
            { return int.Parse(matCostLabel.Text); }
            set
            { matCostLabel.Text = value.ToString(); }
        }

        private int _totTimeInvoiced;
        public int TotalTimeInvoiced
        {
            get
            { return _totTimeInvoiced; }
            set
            { _totTimeInvoiced = value; }
        }
        public int TotalTimeCost
        {
            get
            { return int.Parse(timeCostLabel.Text); }
            set
            { timeCostLabel.Text = value.ToString(); }
        }

        private int _workNum;

        public int WorkNum
        {
            get { return _workNum; }
            set { _workNum = value; }
        }


        public WorksheetForm()
        {
            InitializeComponent();
            //wsf = this;

        }
        private void WorksheetForm_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        public void populateItems()
        {
            int timeInHours = 0;
            int timeInMinutes = 0;
            int time = 0;
            CustomControlsPallet[] customControlsPallet = new CustomControlsPallet[MainForm.lines.Count];
            for (int i = 0; i < MainForm.lines.Count; i++)
            {
                string timeText = "";
                time = MainForm.reqTime.ElementAt(i);
                timeInHours = 0;
                timeInMinutes = 0;

                if (time >= 60)
                {
                    timeInHours = time / 60;
                    timeInMinutes = time % 60;
                    timeText = timeInHours.ToString() + "h " + timeInMinutes.ToString() + "m";
                }
                else { timeText = time.ToString() + "m"; timeInMinutes = time; }

                int timeCost;
                if (timeInMinutes != 0)
                {
                    timeCost = ((timeInHours * 15000) + (0 < timeInMinutes && timeInMinutes <= 30 ? 7500 : 15000));
                }
                else timeCost = (timeInHours * 15000);

                customControlsPallet[i] = new CustomControlsPallet(this);
                customControlsPallet[i].WorkName = MainForm.workName[i];
                customControlsPallet[i].MatCost = MainForm.matCost[i];
                customControlsPallet[i].Time = timeText;
                customControlsPallet[i].InvoicedTime = time;
                customControlsPallet[i].TimeCost = timeCost;
                flowLayoutPanel.Controls.Add(customControlsPallet[i]);
                CheckBoxesList.Add(customControlsPallet[i].CBox);
            }

        }
        public void RegisterBtnEnabling()
        {
            registerButton.Enabled = true;
        }
        public void RegisterBtnDisabling()
        {
            registerButton.Enabled = false;
        }

        //Registeration Proccess
        public void registerButton_Click(object sender, EventArgs e)
        {
            if (TotalTimeCost != 0)
            {
                MainForm.EnableStatic(true); //Doesn't Work

                registeredSheetsCount++;
                Registered = true;

                TotMatCost += CustomControlsPallet.matCostSum;
                TotTimCost += CustomControlsPallet.timeCostSum;
                TotInvoicedTime += CustomControlsPallet.invoicedTimeSum;
                workCount += CustomControlsPallet.numberOfWorks;

                DialogResult selection =
                    MessageBox.Show(string.Format
                    ("    Worksheet Has been Registered\n\n    Do you want to register a new one?"),
                        "confirmation", MessageBoxButtons.YesNo);

                if (selection == DialogResult.Yes)
                {
                    CustomControlsPallet.matCostSum = 0;
                    CustomControlsPallet.timeCostSum = 0;
                    CustomControlsPallet.numberOfWorks = 0;

                    this.Controls.Clear();
                    this.InitializeComponent();
                    this.populateItems();
                }
                else
                {
                    paymentForm.SheetsCount = registeredSheetsCount;
                    paymentForm.TotalMaterialCost = TotMatCost.ToString();
                    paymentForm.TotalTimeCost = TotTimCost.ToString();
                    paymentForm.TotalInvoicedTime = TotalTimeInvoiced;
                    paymentForm.WorkCount = workCount;
                    this.Close();
                    paymentForm.ShowDialog();
                }
            }
            else { MessageBox.Show("Please Choose at least One Service to Register"); }

        }
        private void WorksheetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (Registered == false)
                {

                    DialogResult result = MessageBox.Show("Worksheet Haven't Been Registered!\n\n    Do You Still Want To Exit?", "Note", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void WorksheetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomControlsPallet.matCostSum = 0;
            CustomControlsPallet.timeCostSum = 0;
            CustomControlsPallet.invoicedTimeSum = 0;
            CustomControlsPallet.numberOfWorks = 0;

            Registered = false;
        }
    }
}



