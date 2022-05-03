
namespace scoslab2
{
    partial class FormDPF
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMainSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUnder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPlus,
            this.toolStripMenuItemMinus,
            this.ToolStripMenuItemMainSize,
            this.toolStripMenuItemLeft,
            this.toolStripMenuItemRight,
            this.ToolStripMenuItemUp,
            this.ToolStripMenuItemUnder,
            this.ToolStripMenuItemInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(884, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemPlus
            // 
            this.toolStripMenuItemPlus.Name = "toolStripMenuItemPlus";
            this.toolStripMenuItemPlus.Size = new System.Drawing.Size(29, 21);
            this.toolStripMenuItemPlus.Text = "+";
            // 
            // toolStripMenuItemMinus
            // 
            this.toolStripMenuItemMinus.Name = "toolStripMenuItemMinus";
            this.toolStripMenuItemMinus.Size = new System.Drawing.Size(28, 21);
            this.toolStripMenuItemMinus.Text = "--";
            // 
            // ToolStripMenuItemMainSize
            // 
            this.ToolStripMenuItemMainSize.Name = "ToolStripMenuItemMainSize";
            this.ToolStripMenuItemMainSize.Size = new System.Drawing.Size(86, 21);
            this.ToolStripMenuItemMainSize.Text = "Исходный";
            // 
            // toolStripMenuItemLeft
            // 
            this.toolStripMenuItemLeft.Name = "toolStripMenuItemLeft";
            this.toolStripMenuItemLeft.Size = new System.Drawing.Size(32, 21);
            this.toolStripMenuItemLeft.Text = "<-";
            // 
            // toolStripMenuItemRight
            // 
            this.toolStripMenuItemRight.Name = "toolStripMenuItemRight";
            this.toolStripMenuItemRight.Size = new System.Drawing.Size(32, 21);
            this.toolStripMenuItemRight.Text = "->";
            // 
            // ToolStripMenuItemUp
            // 
            this.ToolStripMenuItemUp.Name = "ToolStripMenuItemUp";
            this.ToolStripMenuItemUp.Size = new System.Drawing.Size(56, 21);
            this.ToolStripMenuItemUp.Text = "Вверх";
            // 
            // ToolStripMenuItemUnder
            // 
            this.ToolStripMenuItemUnder.Name = "ToolStripMenuItemUnder";
            this.ToolStripMenuItemUnder.Size = new System.Drawing.Size(49, 21);
            this.ToolStripMenuItemUnder.Text = "Вниз";
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(61, 21);
            this.ToolStripMenuItemInfo.Text = "Инфо";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(747, 315);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 323);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Частота \r\nдискретизации:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "FormDPF";
            this.Text = "Дискретное преобразование Фурье";
            this.Load += new System.EventHandler(this.FormDPF_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMinus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMainSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLeft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRight;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUnder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}