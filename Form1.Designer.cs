namespace lab1
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
            this.bAnalys = new System.Windows.Forms.Button();
            this.tBSourceText = new System.Windows.Forms.TextBox();
            this.bSelectFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAnalys
            // 
            this.bAnalys.Enabled = false;
            this.bAnalys.Location = new System.Drawing.Point(306, 550);
            this.bAnalys.Name = "bAnalys";
            this.bAnalys.Size = new System.Drawing.Size(140, 23);
            this.bAnalys.TabIndex = 0;
            this.bAnalys.Text = "Анализировать";
            this.bAnalys.UseVisualStyleBackColor = true;
            this.bAnalys.Click += new System.EventHandler(this.bAnalys_Click);
            // 
            // tBSourceText
            // 
            this.tBSourceText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBSourceText.Location = new System.Drawing.Point(12, 12);
            this.tBSourceText.Multiline = true;
            this.tBSourceText.Name = "tBSourceText";
            this.tBSourceText.ReadOnly = true;
            this.tBSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBSourceText.Size = new System.Drawing.Size(757, 473);
            this.tBSourceText.TabIndex = 1;
            // 
            // bSelectFile
            // 
            this.bSelectFile.Location = new System.Drawing.Point(306, 511);
            this.bSelectFile.Name = "bSelectFile";
            this.bSelectFile.Size = new System.Drawing.Size(140, 23);
            this.bSelectFile.TabIndex = 3;
            this.bSelectFile.Text = "Выбрать файл";
            this.bSelectFile.UseVisualStyleBackColor = true;
            this.bSelectFile.Click += new System.EventHandler(this.bSelectFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(804, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 473);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 632);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bSelectFile);
            this.Controls.Add(this.tBSourceText);
            this.Controls.Add(this.bAnalys);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAnalys;
        private System.Windows.Forms.TextBox tBSourceText;
        private System.Windows.Forms.Button bSelectFile;
        private System.Windows.Forms.TextBox textBox1;
    }
}

