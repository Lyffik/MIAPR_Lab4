namespace Laba4
{
    partial class Form1
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.numericUpDownClassCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownObjectsInClassCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAttributesCount = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBoxFunctions = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectsInClassCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAttributesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(7, 138);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 43);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать \r\nобучающу выборку";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownClassCount
            // 
            this.numericUpDownClassCount.Location = new System.Drawing.Point(7, 17);
            this.numericUpDownClassCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownClassCount.Name = "numericUpDownClassCount";
            this.numericUpDownClassCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownClassCount.TabIndex = 2;
            this.numericUpDownClassCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownObjectsInClassCount
            // 
            this.numericUpDownObjectsInClassCount.Location = new System.Drawing.Point(7, 63);
            this.numericUpDownObjectsInClassCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownObjectsInClassCount.Name = "numericUpDownObjectsInClassCount";
            this.numericUpDownObjectsInClassCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownObjectsInClassCount.TabIndex = 3;
            this.numericUpDownObjectsInClassCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownAttributesCount
            // 
            this.numericUpDownAttributesCount.Location = new System.Drawing.Point(7, 103);
            this.numericUpDownAttributesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAttributesCount.Name = "numericUpDownAttributesCount";
            this.numericUpDownAttributesCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAttributesCount.TabIndex = 4;
            this.numericUpDownAttributesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тестовая выборка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Классов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Объектов в классе:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Признаков объекта:";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(133, 17);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(229, 276);
            this.listBox.TabIndex = 10;
            // 
            // listBoxFunctions
            // 
            this.listBoxFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFunctions.FormattingEnabled = true;
            this.listBoxFunctions.ItemHeight = 16;
            this.listBoxFunctions.Location = new System.Drawing.Point(368, 18);
            this.listBoxFunctions.Name = "listBoxFunctions";
            this.listBoxFunctions.ScrollAlwaysVisible = true;
            this.listBoxFunctions.Size = new System.Drawing.Size(476, 276);
            this.listBoxFunctions.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Подобрать класс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxFunctions);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDownAttributesCount);
            this.Controls.Add(this.numericUpDownObjectsInClassCount);
            this.Controls.Add(this.numericUpDownClassCount);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПЕРСЕПТРОН";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectsInClassCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAttributesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown numericUpDownClassCount;
        private System.Windows.Forms.NumericUpDown numericUpDownObjectsInClassCount;
        private System.Windows.Forms.NumericUpDown numericUpDownAttributesCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBoxFunctions;
        private System.Windows.Forms.Button button1;
    }
}

