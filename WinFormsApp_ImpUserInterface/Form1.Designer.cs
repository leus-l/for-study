namespace WinFormsApp_ImpUserInterface
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
            this.panel_Output = new System.Windows.Forms.Panel();
            this.vScrollBar_InputValue = new System.Windows.Forms.VScrollBar();
            this.textBox_InputValue = new System.Windows.Forms.TextBox();
            this.label_Output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Formula = new System.Windows.Forms.PictureBox();
            this.label_inputTaskNum = new System.Windows.Forms.Label();
            this.comboBox_TaskNum = new System.Windows.Forms.ComboBox();
            this.button_EvaluateVariant = new System.Windows.Forms.Button();
            this.button_EvaluateAllDefault = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Output
            // 
            this.panel_Output.Controls.Add(this.vScrollBar_InputValue);
            this.panel_Output.Controls.Add(this.textBox_InputValue);
            this.panel_Output.Controls.Add(this.label_Output);
            this.panel_Output.Controls.Add(this.label1);
            this.panel_Output.Controls.Add(this.pictureBox_Formula);
            this.panel_Output.Location = new System.Drawing.Point(190, 12);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(415, 270);
            this.panel_Output.TabIndex = 0;
            // 
            // vScrollBar_InputValue
            // 
            this.vScrollBar_InputValue.Location = new System.Drawing.Point(186, 131);
            this.vScrollBar_InputValue.Name = "vScrollBar_InputValue";
            this.vScrollBar_InputValue.Size = new System.Drawing.Size(17, 20);
            this.vScrollBar_InputValue.TabIndex = 4;
            // 
            // textBox_InputValue
            // 
            this.textBox_InputValue.Location = new System.Drawing.Point(83, 131);
            this.textBox_InputValue.Name = "textBox_InputValue";
            this.textBox_InputValue.ReadOnly = true;
            this.textBox_InputValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_InputValue.TabIndex = 3;
            this.textBox_InputValue.TextChanged += new System.EventHandler(this.textBox_InputValue_TextChanged);
            // 
            // label_Output
            // 
            this.label_Output.Location = new System.Drawing.Point(10, 154);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(391, 99);
            this.label_Output.TabIndex = 2;
            this.label_Output.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение n:";
            // 
            // pictureBox_Formula
            // 
            this.pictureBox_Formula.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_Formula.Name = "pictureBox_Formula";
            this.pictureBox_Formula.Size = new System.Drawing.Size(388, 108);
            this.pictureBox_Formula.TabIndex = 0;
            this.pictureBox_Formula.TabStop = false;
            // 
            // label_inputTaskNum
            // 
            this.label_inputTaskNum.AutoSize = true;
            this.label_inputTaskNum.Location = new System.Drawing.Point(9, 14);
            this.label_inputTaskNum.Name = "label_inputTaskNum";
            this.label_inputTaskNum.Size = new System.Drawing.Size(137, 13);
            this.label_inputTaskNum.TabIndex = 1;
            this.label_inputTaskNum.Text = "Выберите номер задания";
            // 
            // comboBox_TaskNum
            // 
            this.comboBox_TaskNum.FormattingEnabled = true;
            this.comboBox_TaskNum.Items.AddRange(new object[] {
            "Task 1",
            "Task 2",
            "Task 3"});
            this.comboBox_TaskNum.Location = new System.Drawing.Point(12, 39);
            this.comboBox_TaskNum.Name = "comboBox_TaskNum";
            this.comboBox_TaskNum.Size = new System.Drawing.Size(134, 21);
            this.comboBox_TaskNum.TabIndex = 2;
            this.comboBox_TaskNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_TaskNum_SelectedIndexChanged);
            // 
            // button_EvaluateVariant
            // 
            this.button_EvaluateVariant.Location = new System.Drawing.Point(12, 86);
            this.button_EvaluateVariant.Name = "button_EvaluateVariant";
            this.button_EvaluateVariant.Size = new System.Drawing.Size(172, 47);
            this.button_EvaluateVariant.TabIndex = 3;
            this.button_EvaluateVariant.Text = "Выполнить расчет";
            this.button_EvaluateVariant.UseVisualStyleBackColor = true;
            this.button_EvaluateVariant.Click += new System.EventHandler(this.button_EvaluateVariant_Click);
            // 
            // button_EvaluateAllDefault
            // 
            this.button_EvaluateAllDefault.Location = new System.Drawing.Point(12, 159);
            this.button_EvaluateAllDefault.Name = "button_EvaluateAllDefault";
            this.button_EvaluateAllDefault.Size = new System.Drawing.Size(172, 45);
            this.button_EvaluateAllDefault.TabIndex = 4;
            this.button_EvaluateAllDefault.Text = "Все расчеты со значением по умолчанию";
            this.button_EvaluateAllDefault.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 234);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(172, 48);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 312);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_EvaluateAllDefault);
            this.Controls.Add(this.button_EvaluateVariant);
            this.Controls.Add(this.comboBox_TaskNum);
            this.Controls.Add(this.label_inputTaskNum);
            this.Controls.Add(this.panel_Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Formula;
        private System.Windows.Forms.VScrollBar vScrollBar_InputValue;
        private System.Windows.Forms.TextBox textBox_InputValue;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_inputTaskNum;
        private System.Windows.Forms.ComboBox comboBox_TaskNum;
        private System.Windows.Forms.Button button_EvaluateVariant;
        private System.Windows.Forms.Button button_EvaluateAllDefault;
        private System.Windows.Forms.Button button_Close;
    }
}

