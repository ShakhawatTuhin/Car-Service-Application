namespace Trt1
{
    partial class CustomControlsPallet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workNameLabel = new System.Windows.Forms.Label();
            this.matCostLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.checkBoxCust = new System.Windows.Forms.CheckBox();
            this.timeCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workNameLabel
            // 
            this.workNameLabel.AutoSize = true;
            this.workNameLabel.Location = new System.Drawing.Point(14, 19);
            this.workNameLabel.Name = "workNameLabel";
            this.workNameLabel.Size = new System.Drawing.Size(93, 15);
            this.workNameLabel.TabIndex = 0;
            this.workNameLabel.Text = "workNameLabel";
            // 
            // matCostLabel
            // 
            this.matCostLabel.AutoSize = true;
            this.matCostLabel.Location = new System.Drawing.Point(211, 19);
            this.matCostLabel.Name = "matCostLabel";
            this.matCostLabel.Size = new System.Drawing.Size(80, 15);
            this.matCostLabel.TabIndex = 1;
            this.matCostLabel.Text = "matCostLabel";
            this.matCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(336, 19);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 15);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "timeLabel";
            // 
            // checkBoxCust
            // 
            this.checkBoxCust.AutoSize = true;
            this.checkBoxCust.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCust.Location = new System.Drawing.Point(417, 18);
            this.checkBoxCust.Name = "checkBoxCust";
            this.checkBoxCust.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCust.TabIndex = 3;
            this.checkBoxCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCust.UseVisualStyleBackColor = false;
            this.checkBoxCust.CheckedChanged += new System.EventHandler(this.checkBoxCust_CheckedChanged);
            // 
            // timeCostLabel
            // 
            this.timeCostLabel.AutoSize = true;
            this.timeCostLabel.Location = new System.Drawing.Point(449, 19);
            this.timeCostLabel.Name = "timeCostLabel";
            this.timeCostLabel.Size = new System.Drawing.Size(83, 15);
            this.timeCostLabel.TabIndex = 4;
            this.timeCostLabel.Text = "timeCostLabel";
            this.timeCostLabel.Visible = false;
            // 
            // CustomControlsPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeCostLabel);
            this.Controls.Add(this.checkBoxCust);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.matCostLabel);
            this.Controls.Add(this.workNameLabel);
            this.Name = "CustomControlsPallet";
            this.Size = new System.Drawing.Size(542, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label workNameLabel;
        private Label matCostLabel;
        private Label timeLabel;
        private CheckBox checkBoxCust;
        private Label timeCostLabel;
    }
}
