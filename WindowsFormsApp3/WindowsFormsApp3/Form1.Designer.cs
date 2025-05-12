namespace WindowsFormsApp3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControlTimer1 = new WindowsFormsApp3.UserControlTimer();
            this.userControlTimer21 = new WindowsFormsApp3.UserControlTimer2();
            this.clicButton1 = new WindowsFormsApp3.ClicButton();
            this.SuspendLayout();
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(12, 70);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(42, 22);
            this.userControlTimer1.TabIndex = 0;
            this.userControlTimer1.TimeEnabled = false;
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.Location = new System.Drawing.Point(12, 12);
            this.userControlTimer21.Name = "userControlTimer21";
            this.userControlTimer21.Size = new System.Drawing.Size(75, 23);
            this.userControlTimer21.TabIndex = 1;
            this.userControlTimer21.Text = "userControlTimer21";
            // 
            // clicButton1
            // 
            this.clicButton1.Location = new System.Drawing.Point(12, 41);
            this.clicButton1.Name = "clicButton1";
            this.clicButton1.Size = new System.Drawing.Size(75, 23);
            this.clicButton1.TabIndex = 2;
            this.clicButton1.Text = "clicButton1";
            this.clicButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clicButton1);
            this.Controls.Add(this.userControlTimer21);
            this.Controls.Add(this.userControlTimer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControlTimer userControlTimer1;
        private UserControlTimer2 userControlTimer21;
        private ClicButton clicButton1;
    }
}

