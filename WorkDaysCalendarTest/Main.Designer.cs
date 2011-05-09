namespace WorkDaysCalendarTest
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestSingleDay = new System.Windows.Forms.Button();
            this.dateTestPicker = new System.Windows.Forms.DateTimePicker();
            this.TestSingleDayResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestSingleDay
            // 
            this.TestSingleDay.Location = new System.Drawing.Point(174, 10);
            this.TestSingleDay.Name = "TestSingleDay";
            this.TestSingleDay.Size = new System.Drawing.Size(89, 23);
            this.TestSingleDay.TabIndex = 0;
            this.TestSingleDay.Text = "TestSingleDay";
            this.TestSingleDay.UseVisualStyleBackColor = true;
            this.TestSingleDay.Click += new System.EventHandler(this.TestSingleDay_Click);
            // 
            // dateTestPicker
            // 
            this.dateTestPicker.Location = new System.Drawing.Point(12, 12);
            this.dateTestPicker.Name = "dateTestPicker";
            this.dateTestPicker.Size = new System.Drawing.Size(144, 20);
            this.dateTestPicker.TabIndex = 1;
            // 
            // TestSingleDayResult
            // 
            this.TestSingleDayResult.Location = new System.Drawing.Point(12, 38);
            this.TestSingleDayResult.Name = "TestSingleDayResult";
            this.TestSingleDayResult.Size = new System.Drawing.Size(251, 20);
            this.TestSingleDayResult.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 351);
            this.Controls.Add(this.TestSingleDayResult);
            this.Controls.Add(this.dateTestPicker);
            this.Controls.Add(this.TestSingleDay);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestSingleDay;
        private System.Windows.Forms.DateTimePicker dateTestPicker;
        private System.Windows.Forms.TextBox TestSingleDayResult;
    }
}

