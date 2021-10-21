
namespace GraphViewer2
{
    partial class GraphViewer2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graph3Button = new System.Windows.Forms.Button();
            this.graph2Button = new System.Windows.Forms.Button();
            this.graph1Button = new System.Windows.Forms.Button();
            this.graphField = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.graph3Button);
            this.groupBox1.Controls.Add(this.graph2Button);
            this.groupBox1.Controls.Add(this.graph1Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Графики";
            // 
            // graph3Button
            // 
            this.graph3Button.Location = new System.Drawing.Point(381, 22);
            this.graph3Button.Name = "graph3Button";
            this.graph3Button.Size = new System.Drawing.Size(157, 23);
            this.graph3Button.TabIndex = 2;
            this.graph3Button.Text = "y = 2 * tan(x)";
            this.graph3Button.UseVisualStyleBackColor = true;
            this.graph3Button.Click += new System.EventHandler(this.graph3Button_Click);
            // 
            // graph2Button
            // 
            this.graph2Button.Location = new System.Drawing.Point(196, 22);
            this.graph2Button.Name = "graph2Button";
            this.graph2Button.Size = new System.Drawing.Size(157, 23);
            this.graph2Button.TabIndex = 1;
            this.graph2Button.Text = "y = 2 * cos(x)";
            this.graph2Button.UseVisualStyleBackColor = true;
            this.graph2Button.Click += new System.EventHandler(this.graph2Button_Click);
            // 
            // graph1Button
            // 
            this.graph1Button.Location = new System.Drawing.Point(6, 22);
            this.graph1Button.Name = "graph1Button";
            this.graph1Button.Size = new System.Drawing.Size(157, 23);
            this.graph1Button.TabIndex = 0;
            this.graph1Button.Text = "y = 2";
            this.graph1Button.UseVisualStyleBackColor = true;
            this.graph1Button.Click += new System.EventHandler(this.graph1Button_Click);
            // 
            // graphField
            // 
            this.graphField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphField.BackColor = System.Drawing.Color.White;
            this.graphField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphField.Location = new System.Drawing.Point(12, 70);
            this.graphField.Name = "graphField";
            this.graphField.Size = new System.Drawing.Size(544, 368);
            this.graphField.TabIndex = 1;
            this.graphField.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(563, 70);
            this.trackBar.Maximum = 20;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 368);
            this.trackBar.TabIndex = 3;
            this.trackBar.Value = 10;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.graphField);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GraphViewer2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button graph3Button;
        private System.Windows.Forms.Button graph2Button;
        private System.Windows.Forms.Button graph1Button;
        private System.Windows.Forms.PictureBox graphField;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

