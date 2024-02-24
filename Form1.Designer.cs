namespace Aquarium
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
            this.components = new System.ComponentModel.Container();
            this.pnl_aqua = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.rdbKarp = new System.Windows.Forms.RadioButton();
            this.rdbPike = new System.Windows.Forms.RadioButton();
            this.delBtn = new System.Windows.Forms.Button();
            this.NUDOrder = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUDOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_aqua
            // 
            this.pnl_aqua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_aqua.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_aqua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_aqua.Location = new System.Drawing.Point(12, 12);
            this.pnl_aqua.Name = "pnl_aqua";
            this.pnl_aqua.Size = new System.Drawing.Size(400, 400);
            this.pnl_aqua.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(418, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.toolTip1.SetToolTip(this.button2, "Добавить Карп");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdbKarp
            // 
            this.rdbKarp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbKarp.AutoSize = true;
            this.rdbKarp.Checked = true;
            this.rdbKarp.Location = new System.Drawing.Point(418, 12);
            this.rdbKarp.Name = "rdbKarp";
            this.rdbKarp.Size = new System.Drawing.Size(50, 17);
            this.rdbKarp.TabIndex = 4;
            this.rdbKarp.TabStop = true;
            this.rdbKarp.Text = "Карп";
            this.toolTip1.SetToolTip(this.rdbKarp, "Карп");
            this.rdbKarp.UseVisualStyleBackColor = true;
            this.rdbKarp.CheckedChanged += new System.EventHandler(this.rdbKarp_CheckedChanged);
            // 
            // rdbPike
            // 
            this.rdbPike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbPike.AutoSize = true;
            this.rdbPike.Location = new System.Drawing.Point(418, 35);
            this.rdbPike.Name = "rdbPike";
            this.rdbPike.Size = new System.Drawing.Size(52, 17);
            this.rdbPike.TabIndex = 5;
            this.rdbPike.Text = "Щука";
            this.toolTip1.SetToolTip(this.rdbPike, "Щука");
            this.rdbPike.UseVisualStyleBackColor = true;
            this.rdbPike.CheckedChanged += new System.EventHandler(this.rdbPike_CheckedChanged);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(418, 116);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(52, 52);
            this.delBtn.TabIndex = 6;
            this.delBtn.Text = "-";
            this.toolTip1.SetToolTip(this.delBtn, "Убрать Карп 0");
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // NUDOrder
            // 
            this.NUDOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUDOrder.Location = new System.Drawing.Point(419, 174);
            this.NUDOrder.Name = "NUDOrder";
            this.NUDOrder.ReadOnly = true;
            this.NUDOrder.Size = new System.Drawing.Size(50, 29);
            this.NUDOrder.TabIndex = 7;
            this.toolTip1.SetToolTip(this.NUDOrder, "Выбрать Карп");
            this.NUDOrder.ValueChanged += new System.EventHandler(this.NUDOrder_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 428);
            this.Controls.Add(this.NUDOrder);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.rdbPike);
            this.Controls.Add(this.rdbKarp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnl_aqua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Aquarium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.NUDOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_aqua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbKarp;
        private System.Windows.Forms.RadioButton rdbPike;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.NumericUpDown NUDOrder;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

