namespace Trt1
{
    partial class aboutForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Name1 = new Label();
            forName = new Label();
            Neptun = new Label();
            forNeptun = new Label();
            DateCurrent = new Label();
            forDateCurrent = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Bisque;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Name1, 0, 0);
            tableLayoutPanel1.Controls.Add(forName, 1, 0);
            tableLayoutPanel1.Controls.Add(Neptun, 0, 1);
            tableLayoutPanel1.Controls.Add(forNeptun, 1, 1);
            tableLayoutPanel1.Controls.Add(DateCurrent, 0, 2);
            tableLayoutPanel1.Controls.Add(forDateCurrent, 1, 2);
            tableLayoutPanel1.Location = new Point(127, 59);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(200, 172);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Name1
            // 
            Name1.Anchor = AnchorStyles.None;
            Name1.AutoSize = true;
            Name1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name1.ForeColor = SystemColors.ControlText;
            Name1.Location = new Point(19, 16);
            Name1.Name = "Name1";
            Name1.Size = new Size(62, 25);
            Name1.TabIndex = 0;
            Name1.Text = "Name";
            Name1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // forName
            // 
            forName.Anchor = AnchorStyles.None;
            forName.AutoSize = true;
            forName.Location = new Point(110, 14);
            forName.Name = "forName";
            forName.Size = new Size(79, 30);
            forName.TabIndex = 1;
            forName.Text = "Shakawat Hussen Tuhin";
            forName.TextAlign = ContentAlignment.MiddleCenter;
            forName.Click += forName_Click;
            // 
            // Neptun
            // 
            Neptun.Anchor = AnchorStyles.None;
            Neptun.AutoSize = true;
            Neptun.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Neptun.ForeColor = SystemColors.ControlText;
            Neptun.Location = new Point(12, 73);
            Neptun.Name = "Neptun";
            Neptun.Size = new Size(75, 25);
            Neptun.TabIndex = 2;
            Neptun.Text = "Neptun";
            Neptun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // forNeptun
            // 
            forNeptun.Anchor = AnchorStyles.None;
            forNeptun.AutoSize = true;
            forNeptun.Location = new Point(149, 78);
            forNeptun.Name = "forNeptun";
            forNeptun.Size = new Size(0, 15);
            forNeptun.TabIndex = 3;
            forNeptun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateCurrent
            // 
            DateCurrent.Anchor = AnchorStyles.None;
            DateCurrent.AutoSize = true;
            DateCurrent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateCurrent.Location = new Point(24, 130);
            DateCurrent.Name = "DateCurrent";
            DateCurrent.Size = new Size(51, 25);
            DateCurrent.TabIndex = 4;
            DateCurrent.Text = "Date";
            DateCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // forDateCurrent
            // 
            forDateCurrent.Anchor = AnchorStyles.None;
            forDateCurrent.AutoSize = true;
            forDateCurrent.Location = new Point(149, 135);
            forDateCurrent.Name = "forDateCurrent";
            forDateCurrent.Size = new Size(0, 15);
            forDateCurrent.TabIndex = 5;
            // 
            // aboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(467, 303);
            Controls.Add(tableLayoutPanel1);
            Name = "aboutForm";
            Text = "Form2";
            Load += aboutForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Name1;
        private Label forName;
        private Label Neptun;
        private Label forNeptun;
        private Label DateCurrent;
        private Label forDateCurrent;
    }
}