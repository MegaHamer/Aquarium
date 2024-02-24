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
            this.pnl_aqua = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdbKarp = new System.Windows.Forms.RadioButton();
            this.rdbPike = new System.Windows.Forms.RadioButton();
            this.delBtn = new System.Windows.Forms.Button();
            this.NUDOrder = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_aqua
            // 
            this.pnl_aqua.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_aqua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_aqua.Location = new System.Drawing.Point(12, 12);
            this.pnl_aqua.Name = "pnl_aqua";
            this.pnl_aqua.Size = new System.Drawing.Size(400, 400);
            this.pnl_aqua.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Начать движ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить рыбку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdbKarp
            // 
            this.rdbKarp.AutoSize = true;
            this.rdbKarp.Checked = true;
            this.rdbKarp.Location = new System.Drawing.Point(418, 94);
            this.rdbKarp.Name = "rdbKarp";
            this.rdbKarp.Size = new System.Drawing.Size(62, 17);
            this.rdbKarp.TabIndex = 4;
            this.rdbKarp.TabStop = true;
            this.rdbKarp.Text = "Карп(0)";
            this.rdbKarp.UseVisualStyleBackColor = true;
            // 
            // rdbPike
            // 
            this.rdbPike.AutoSize = true;
            this.rdbPike.Location = new System.Drawing.Point(485, 94);
            this.rdbPike.Name = "rdbPike";
            this.rdbPike.Size = new System.Drawing.Size(64, 17);
            this.rdbPike.TabIndex = 5;
            this.rdbPike.Text = "Щука(0)";
            this.rdbPike.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(418, 146);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(92, 23);
            this.delBtn.TabIndex = 6;
            this.delBtn.Text = "Удалить рыбку";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // NUDOrder
            // 
            this.NUDOrder.Location = new System.Drawing.Point(516, 147);
            this.NUDOrder.Name = "NUDOrder";
            this.NUDOrder.Size = new System.Drawing.Size(33, 20);
            this.NUDOrder.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 428);
            this.Controls.Add(this.NUDOrder);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.rdbPike);
            this.Controls.Add(this.rdbKarp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_aqua);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdbKarp;
        private System.Windows.Forms.RadioButton rdbPike;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.NumericUpDown NUDOrder;
    }
}

