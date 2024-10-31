using System.ComponentModel;

namespace Trt1
{
    public partial class CustomControlsPallet : UserControl
    {

        public static int matCostSum = 0;
        public static int timeCostSum = 0;
        public static int invoicedTimeSum = 0;
        public static int numberOfWorks = 0;

        WorksheetForm worksheet;
        public CustomControlsPallet(WorksheetForm wrk)
        {
            InitializeComponent();
            worksheet = wrk;
        }

        #region Properties

        private string _WorkName;
        private int _matCost;
        private string _time;
        private int _invoicedTime;
        private int _timeCost;
        private CheckBox _cBox;

        [Category("Custom Props")]
        public string WorkName
        {
            get { return _WorkName; }
            set { _WorkName = value; workNameLabel.Text = value; }
        }

        [Category("Custom Props")]
        public int MatCost
        {
            get { return _matCost; }
            set { _matCost = value; matCostLabel.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string Time
        {
            get { return _time; }
            set { _time = value; timeLabel.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public CheckBox CBox
        {
            get { return _cBox; }
            set { _cBox = value; checkBoxCust = value; }
        }


        [Category("Custom Props")]
        public int TimeCost
        {
            get { return _timeCost; }
            set { _timeCost = value; timeCostLabel.Text = value.ToString(); }
        }


        [Category("Custom Props")]
        public int InvoicedTime
        {
            get { return _invoicedTime; }
            set { _invoicedTime = value; }
        }


        #endregion

        private void checkBoxCust_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCust.Checked)
            {

                timeCostLabel.Visible = true;


                matCostSum += int.Parse(matCostLabel.Text);
                worksheet.TotalMaterialCost = matCostSum;

                timeCostSum += int.Parse(timeCostLabel.Text);
                worksheet.TotalTimeCost = timeCostSum;

                invoicedTimeSum += InvoicedTime;
                worksheet.TotalTimeInvoiced = invoicedTimeSum;

                numberOfWorks++;
                worksheet.WorkNum = numberOfWorks;

                worksheet.RegisterBtnEnabling();
            }
            else
            {
                timeCostLabel.Visible = false;

                matCostSum -= int.Parse(matCostLabel.Text);
                worksheet.TotalMaterialCost = matCostSum;

                timeCostSum -= int.Parse(timeCostLabel.Text);
                worksheet.TotalTimeCost = timeCostSum;

                invoicedTimeSum -= InvoicedTime;
                worksheet.TotalTimeInvoiced = invoicedTimeSum;

                numberOfWorks--;
                worksheet.WorkNum = numberOfWorks;

                if (timeCostSum == 0)
                {
                    worksheet.RegisterBtnDisabling();

                }
            }
        }
    }
}
