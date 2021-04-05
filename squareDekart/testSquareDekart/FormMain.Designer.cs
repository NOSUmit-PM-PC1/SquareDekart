namespace testSquareDekart
{
    partial class FormMain
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
            this.labelTitleI = new System.Windows.Forms.Label();
            this.listBoxAnswersI = new System.Windows.Forms.ListBox();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.buttonEditAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleI
            // 
            this.labelTitleI.AutoSize = true;
            this.labelTitleI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleI.Location = new System.Drawing.Point(41, 43);
            this.labelTitleI.Name = "labelTitleI";
            this.labelTitleI.Size = new System.Drawing.Size(86, 31);
            this.labelTitleI.TabIndex = 0;
            this.labelTitleI.Text = "label1";
            // 
            // listBoxAnswersI
            // 
            this.listBoxAnswersI.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAnswersI.FormattingEnabled = true;
            this.listBoxAnswersI.ItemHeight = 31;
            this.listBoxAnswersI.Location = new System.Drawing.Point(41, 81);
            this.listBoxAnswersI.Name = "listBoxAnswersI";
            this.listBoxAnswersI.Size = new System.Drawing.Size(453, 252);
            this.listBoxAnswersI.TabIndex = 1;
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAnswer.Location = new System.Drawing.Point(41, 377);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(443, 51);
            this.buttonAddAnswer.TabIndex = 2;
            this.buttonAddAnswer.Text = "Добавить ответ";
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // buttonEditAnswer
            // 
            this.buttonEditAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditAnswer.Location = new System.Drawing.Point(41, 455);
            this.buttonEditAnswer.Name = "buttonEditAnswer";
            this.buttonEditAnswer.Size = new System.Drawing.Size(443, 51);
            this.buttonEditAnswer.TabIndex = 3;
            this.buttonEditAnswer.Text = "Редактировать ответ";
            this.buttonEditAnswer.UseVisualStyleBackColor = true;
            this.buttonEditAnswer.Click += new System.EventHandler(this.buttonEditAnswer_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 530);
            this.Controls.Add(this.buttonEditAnswer);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.listBoxAnswersI);
            this.Controls.Add(this.labelTitleI);
            this.Name = "FormMain";
            this.Text = "Квадрат Декарта";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleI;
        private System.Windows.Forms.ListBox listBoxAnswersI;
        private System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.Button buttonEditAnswer;
    }
}

