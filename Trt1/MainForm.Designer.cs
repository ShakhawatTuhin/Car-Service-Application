namespace Trt1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            menuStrip1 = new MenuStrip();
            loadFileTab = new ToolStripMenuItem();
            worksheetTab = new ToolStripMenuItem();
            paymentTab = new ToolStripMenuItem();
            aboutTab = new ToolStripMenuItem();
            exitTab = new ToolStripMenuItem();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadFileTab, worksheetTab, paymentTab, aboutTab, exitTab });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(484, 27);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadFileTab
            // 
            loadFileTab.Name = "loadFileTab";
            loadFileTab.Size = new Size(75, 19);
            loadFileTab.Text = "&Load File...";
            loadFileTab.Click += loadFileToolStripMenuItem_Click;
            // 
            // worksheetTab
            // 
            worksheetTab.Enabled = false;
            worksheetTab.Name = "worksheetTab";
            worksheetTab.Size = new Size(84, 19);
            worksheetTab.Text = "&Worksheet...";
            worksheetTab.Click += worksheetToolStripMenuItem_Click;
            // 
            // paymentTab
            // 
            paymentTab.Enabled = false;
            paymentTab.Name = "paymentTab";
            paymentTab.Size = new Size(66, 19);
            paymentTab.Text = "Payment";
            paymentTab.Click += paymentToolStripMenuItem_Click;
            // 
            // aboutTab
            // 
            aboutTab.Name = "aboutTab";
            aboutTab.Size = new Size(52, 19);
            aboutTab.Text = "&About";
            aboutTab.Click += aboutTab_Click;
            // 
            // exitTab
            // 
            exitTab.Name = "exitTab";
            exitTab.Size = new Size(38, 19);
            exitTab.Text = "E&xit";
            exitTab.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 361);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "Main Form";
            FormClosing += Form1_FormClosing;
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripTextBox toolStripTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadFileTab;
        private ToolStripMenuItem worksheetTab;
        private ToolStripMenuItem paymentTab;
        private ToolStripMenuItem aboutTab;
        private ToolStripMenuItem exitTab;
    }
}