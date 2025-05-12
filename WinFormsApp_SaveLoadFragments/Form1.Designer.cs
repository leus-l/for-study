namespace WinFormsApp_SaveLoadFragments
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.radioButton_SaveAs = new System.Windows.Forms.RadioButton();
            this.radioButton_Load = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(507, 280);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // radioButton_SaveAs
            // 
            this.radioButton_SaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_SaveAs.AutoSize = true;
            this.radioButton_SaveAs.Location = new System.Drawing.Point(12, 298);
            this.radioButton_SaveAs.Name = "radioButton_SaveAs";
            this.radioButton_SaveAs.Size = new System.Drawing.Size(152, 17);
            this.radioButton_SaveAs.TabIndex = 1;
            this.radioButton_SaveAs.TabStop = true;
            this.radioButton_SaveAs.Text = "Сохранить фрагмент как";
            this.radioButton_SaveAs.UseVisualStyleBackColor = true;
            // 
            // radioButton_Load
            // 
            this.radioButton_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Load.AutoSize = true;
            this.radioButton_Load.Location = new System.Drawing.Point(170, 298);
            this.radioButton_Load.Name = "radioButton_Load";
            this.radioButton_Load.Size = new System.Drawing.Size(130, 17);
            this.radioButton_Load.TabIndex = 2;
            this.radioButton_Load.TabStop = true;
            this.radioButton_Load.Text = "Загрузить фргамент";
            this.radioButton_Load.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(401, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_Load);
            this.Controls.Add(this.radioButton_SaveAs);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton radioButton_SaveAs;
        private System.Windows.Forms.RadioButton radioButton_Load;
        private System.Windows.Forms.Button button1;
    }
}

