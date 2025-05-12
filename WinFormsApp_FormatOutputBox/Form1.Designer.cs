namespace WinFormsApp_FormatOutputBox
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
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.pictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).BeginInit();
            this.groupBox_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.ReadOnly = true;
            this.richTextBox_Output.Size = new System.Drawing.Size(433, 239);
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(305, 28);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 20);
            this.textBox_A.TabIndex = 1;
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(294, 126);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(100, 20);
            this.textBox_B.TabIndex = 2;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(207, 31);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(81, 13);
            this.label_A.TabIndex = 3;
            this.label_A.Text = "Переменная А";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(207, 129);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(81, 13);
            this.label_B.TabIndex = 4;
            this.label_B.Text = "Переменная B";
            // 
            // pictureBox_Preview
            // 
            this.pictureBox_Preview.Location = new System.Drawing.Point(210, 61);
            this.pictureBox_Preview.Name = "pictureBox_Preview";
            this.pictureBox_Preview.Size = new System.Drawing.Size(150, 50);
            this.pictureBox_Preview.TabIndex = 5;
            this.pictureBox_Preview.TabStop = false;
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.pictureBox_Preview);
            this.groupBox_Input.Controls.Add(this.listBox_Input);
            this.groupBox_Input.Controls.Add(this.label_A);
            this.groupBox_Input.Controls.Add(this.label_B);
            this.groupBox_Input.Controls.Add(this.textBox_A);
            this.groupBox_Input.Controls.Add(this.textBox_B);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 257);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(433, 152);
            this.groupBox_Input.TabIndex = 6;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "Выбор исходных данных";
            // 
            // listBox_Input
            // 
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.Location = new System.Drawing.Point(6, 31);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(195, 108);
            this.listBox_Input.TabIndex = 7;
            this.listBox_Input.SelectedIndexChanged += new System.EventHandler(this.listBox_Input_SelectedIndexChanged);
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(12, 415);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(201, 23);
            this.button_Evaluate.TabIndex = 7;
            this.button_Evaluate.Text = "Выполнить расчет";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(262, 415);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(183, 23);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Evaluate);
            this.Controls.Add(this.richTextBox_Output);
            this.Controls.Add(this.groupBox_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).EndInit();
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.PictureBox pictureBox_Preview;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.Button button_Clear;
    }
}

