namespace Trt1
{
    public partial class PaymentForm : Form
    {
        public string TotalMaterialCost
        {
            get
            { return matCostLabel.Text; }
            set
            { matCostLabel.Text = value.ToString(); }
        }
        public string TotalTimeCost
        {
            get
            { return timeCostLabel.Text; }
            set
            { timeCostLabel.Text = value.ToString(); }
        }
        int Minutes = 0;
        int Hours = 0;
        public int TotalInvoicedTime
        {
            get { return int.Parse(invoicedServiceTimeLabel.Text); }
            set
            {
                if (value >= 60)
                {
                    Hours = value / 60;
                    Minutes = value % 60;
                    invoicedServiceTimeLabel.Text = Hours.ToString() + "h " + Minutes.ToString() + "m";
                }
                else { invoicedServiceTimeLabel.Text = value.ToString() + "m"; Minutes = value; }
                //invoicedServiceTimeLabel.Text = value.ToString();
            }
        }


        public int SheetsCount
        {
            get { return int.Parse(sheetsCount.Text); }
            set { sheetsCount.Text = value.ToString(); }
        }

        public int WorkCount
        {
            get { return int.Parse(workCountLabel.Text); }
            set { workCountLabel.Text = value.ToString(); }
        }

        public PaymentForm()
        {
            InitializeComponent();
        }
        public void Totals(int Material, int Time)
        {
            TotalMaterialCost += Material;
            TotalTimeCost += Time;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            totalLabel.Text = (int.Parse(TotalMaterialCost) + int.Parse(TotalTimeCost)).ToString();

        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    DialogResult result = MessageBox.Show("Do you want to exit?", "Closing", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        //e.Cancel = true;
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Done Successfully");
            WorksheetForm.TotMatCost = 0;
            WorksheetForm.TotTimCost = 0;
            WorksheetForm.registeredSheetsCount = 0;
            WorksheetForm.workCount = 0;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Worksheets Deleted");
            WorksheetForm.TotMatCost = 0;
            WorksheetForm.TotTimCost = 0;
            WorksheetForm.registeredSheetsCount = 0;
            WorksheetForm.workCount = 0;
            this.Close();
        }
    }
}
