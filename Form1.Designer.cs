
namespace scoslab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEndY = new System.Windows.Forms.TextBox();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStartY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEndX = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMainSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUnder = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 313);
            this.panel1.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(702, 305);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.buttonDraw);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(709, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 326);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBoxA2);
            this.panel4.Controls.Add(this.textBoxF1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBoxF2);
            this.panel4.Controls.Add(this.textBoxA1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(4, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 177);
            this.panel4.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 34);
            this.label9.TabIndex = 14;
            this.label9.Text = "Амплитуды \r\nсинусойд:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ф2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "А2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ф1:";
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(67, 56);
            this.textBoxA2.Multiline = true;
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(40, 20);
            this.textBoxA2.TabIndex = 16;
            this.textBoxA2.Text = "1";
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(8, 153);
            this.textBoxF1.Multiline = true;
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(40, 20);
            this.textBoxF1.TabIndex = 10;
            this.textBoxF1.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "А1:";
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(67, 153);
            this.textBoxF2.Multiline = true;
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(40, 20);
            this.textBoxF2.TabIndex = 11;
            this.textBoxF2.Text = "1";
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(8, 56);
            this.textBoxA1.Multiline = true;
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(40, 20);
            this.textBoxA1.TabIndex = 15;
            this.textBoxA1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Частоты\r\nсинусойд:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDraw.Location = new System.Drawing.Point(20, 280);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(86, 23);
            this.buttonDraw.TabIndex = 10;
            this.buttonDraw.Text = "Построить";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxEndY);
            this.panel3.Controls.Add(this.textBoxStartX);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxStartY);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxEndX);
            this.panel3.Location = new System.Drawing.Point(4, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 90);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Диапазон\r\nкоординат:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEndY
            // 
            this.textBoxEndY.Location = new System.Drawing.Point(74, 63);
            this.textBoxEndY.Multiline = true;
            this.textBoxEndY.Name = "textBoxEndY";
            this.textBoxEndY.Size = new System.Drawing.Size(40, 20);
            this.textBoxEndY.TabIndex = 5;
            this.textBoxEndY.Text = "5";
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Location = new System.Drawing.Point(28, 37);
            this.textBoxStartX.Multiline = true;
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(40, 20);
            this.textBoxStartX.TabIndex = 2;
            this.textBoxStartX.Text = "-5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y:";
            // 
            // textBoxStartY
            // 
            this.textBoxStartY.Location = new System.Drawing.Point(28, 63);
            this.textBoxStartY.Multiline = true;
            this.textBoxStartY.Name = "textBoxStartY";
            this.textBoxStartY.Size = new System.Drawing.Size(40, 20);
            this.textBoxStartY.TabIndex = 4;
            this.textBoxStartY.Text = "-5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "X:";
            // 
            // textBoxEndX
            // 
            this.textBoxEndX.Location = new System.Drawing.Point(74, 37);
            this.textBoxEndX.Multiline = true;
            this.textBoxEndX.Name = "textBoxEndX";
            this.textBoxEndX.Size = new System.Drawing.Size(40, 20);
            this.textBoxEndX.TabIndex = 3;
            this.textBoxEndX.Text = "5";
            // 
            // menuStrip1
            // 
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
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(51, 20);
            this.ToolStripMenuItemInfo.Text = "Инфо";
            // 
            // toolStripMenuItemPlus
            // 
            this.toolStripMenuItemPlus.Name = "toolStripMenuItemPlus";
            this.toolStripMenuItemPlus.Size = new System.Drawing.Size(27, 20);
            this.toolStripMenuItemPlus.Text = "+";
            this.toolStripMenuItemPlus.Click += new System.EventHandler(this.toolStripMenuItemPlus_Click);
            // 
            // toolStripMenuItemMinus
            // 
            this.toolStripMenuItemMinus.Name = "toolStripMenuItemMinus";
            this.toolStripMenuItemMinus.Size = new System.Drawing.Size(29, 20);
            this.toolStripMenuItemMinus.Text = "--";
            // 
            // ToolStripMenuItemMainSize
            // 
            this.ToolStripMenuItemMainSize.Name = "ToolStripMenuItemMainSize";
            this.ToolStripMenuItemMainSize.Size = new System.Drawing.Size(76, 20);
            this.ToolStripMenuItemMainSize.Text = "Исходный";
            // 
            // toolStripMenuItemLeft
            // 
            this.toolStripMenuItemLeft.Name = "toolStripMenuItemLeft";
            this.toolStripMenuItemLeft.Size = new System.Drawing.Size(32, 20);
            this.toolStripMenuItemLeft.Text = "<-";
            // 
            // toolStripMenuItemRight
            // 
            this.toolStripMenuItemRight.Name = "toolStripMenuItemRight";
            this.toolStripMenuItemRight.Size = new System.Drawing.Size(32, 20);
            this.toolStripMenuItemRight.Text = "->";
            // 
            // ToolStripMenuItemUp
            // 
            this.ToolStripMenuItemUp.Name = "ToolStripMenuItemUp";
            this.ToolStripMenuItemUp.Size = new System.Drawing.Size(51, 20);
            this.ToolStripMenuItemUp.Text = "Вверх";
            // 
            // ToolStripMenuItemUnder
            // 
            this.ToolStripMenuItemUnder.Name = "ToolStripMenuItemUnder";
            this.ToolStripMenuItemUnder.Size = new System.Drawing.Size(45, 20);
            this.ToolStripMenuItemUnder.Text = "Вниз";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(844, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(860, 380);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Определение спектральных характеристик сигнала";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEndX;
        private System.Windows.Forms.TextBox textBoxStartY;
        private System.Windows.Forms.TextBox textBoxEndY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPlus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMinus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMainSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLeft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRight;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUnder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
    }
}

