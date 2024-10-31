namespace Trt1
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.workCountLabel = new System.Windows.Forms.Label();
            this.matCostLabel = new System.Windows.Forms.Label();
            this.timeCostLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.sheetsCount = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.invoicedServiceTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered WorkSheets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Material Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Service Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Payment Count";
            // 
            // workCountLabel
            // 
            this.workCountLabel.AutoSize = true;
            this.workCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.workCountLabel.Location = new System.Drawing.Point(234, 45);
            this.workCountLabel.Name = "workCountLabel";
            this.workCountLabel.Size = new System.Drawing.Size(19, 20);
            this.workCountLabel.TabIndex = 4;
            this.workCountLabel.Text = "0";
            // 
            // matCostLabel
            // 
            this.matCostLabel.AutoSize = true;
            this.matCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matCostLabel.ForeColor = System.Drawing.Color.Teal;
            this.matCostLabel.Location = new System.Drawing.Point(235, 78);
            this.matCostLabel.Name = "matCostLabel";
            this.matCostLabel.Size = new System.Drawing.Size(19, 20);
            this.matCostLabel.TabIndex = 5;
            this.matCostLabel.Text = "0";
            // 
            // timeCostLabel
            // 
            this.timeCostLabel.AutoSize = true;
            this.timeCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeCostLabel.ForeColor = System.Drawing.Color.Maroon;
            this.timeCostLabel.Location = new System.Drawing.Point(235, 113);
            this.timeCostLabel.Name = "timeCostLabel";
            this.timeCostLabel.Size = new System.Drawing.Size(19, 20);
            this.timeCostLabel.TabIndex = 6;
            this.timeCostLabel.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.totalLabel.Location = new System.Drawing.Point(234, 179);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(20, 24);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "0";
            // 
            // sheetsCount
            // 
            this.sheetsCount.AutoSize = true;
            this.sheetsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sheetsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sheetsCount.Location = new System.Drawing.Point(235, 18);
            this.sheetsCount.Name = "sheetsCount";
            this.sheetsCount.Size = new System.Drawing.Size(19, 20);
            this.sheetsCount.TabIndex = 8;
            this.sheetsCount.Text = "0";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(48, 244);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 9;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(187, 244);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel Payment";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Invoiced Service Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Registered Works";
            // 
            // invoicedServiceTimeLabel
            // 
            this.invoicedServiceTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.invoicedServiceTimeLabel.Location = new System.Drawing.Point(233, 142);
            this.invoicedServiceTimeLabel.Name = "invoicedServiceTimeLabel";
            this.invoicedServiceTimeLabel.Size = new System.Drawing.Size(88, 20);
            this.invoicedServiceTimeLabel.TabIndex = 13;
            this.invoicedServiceTimeLabel.Text = "0";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 289);
            this.ControlBox = false;
            this.Controls.Add(this.invoicedServiceTimeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.sheetsCount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.timeCostLabel);
            this.Controls.Add(this.matCostLabel);
            this.Controls.Add(this.workCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentForm_FormClosing);
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label workCountLabel;
        private Label matCostLabel;
        private Label timeCostLabel;
        private Label totalLabel;
        private Label sheetsCount;
        private Button payButton;
        private Button CancelBtn;
        private Label label5;
        private Label label6;
        private Label invoicedServiceTimeLabel;
    }
}