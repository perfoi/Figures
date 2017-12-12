namespace Figures
{
    partial class FormTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRhombus = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonDrawFigure = new System.Windows.Forms.Button();
            this.buttonDeleteLastFigure = new System.Windows.Forms.Button();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.buttonNewRow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 327);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRectangle);
            this.groupBox1.Controls.Add(this.radioButtonTriangle);
            this.groupBox1.Controls.Add(this.radioButtonRhombus);
            this.groupBox1.Controls.Add(this.radioButtonCircle);
            this.groupBox1.Controls.Add(this.radioButtonSquare);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что будем рисовать?";
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(299, 19);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(105, 17);
            this.radioButtonRectangle.TabIndex = 5;
            this.radioButtonRectangle.Text = "Прямоугольник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(203, 19);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(90, 17);
            this.radioButtonTriangle.TabIndex = 4;
            this.radioButtonTriangle.Text = "Треугольник";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonRhombus
            // 
            this.radioButtonRhombus.AutoSize = true;
            this.radioButtonRhombus.Location = new System.Drawing.Point(145, 19);
            this.radioButtonRhombus.Name = "radioButtonRhombus";
            this.radioButtonRhombus.Size = new System.Drawing.Size(52, 17);
            this.radioButtonRhombus.TabIndex = 3;
            this.radioButtonRhombus.Text = "Ромб";
            this.radioButtonRhombus.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(91, 19);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCircle.TabIndex = 2;
            this.radioButtonCircle.Text = "Круг";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.AutoSize = true;
            this.radioButtonSquare.Checked = true;
            this.radioButtonSquare.Location = new System.Drawing.Point(18, 19);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSquare.TabIndex = 1;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = "Квадрат";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // buttonDrawFigure
            // 
            this.buttonDrawFigure.Location = new System.Drawing.Point(561, 12);
            this.buttonDrawFigure.Name = "buttonDrawFigure";
            this.buttonDrawFigure.Size = new System.Drawing.Size(188, 69);
            this.buttonDrawFigure.TabIndex = 1;
            this.buttonDrawFigure.Text = "Нарисовать фигуру";
            this.buttonDrawFigure.UseVisualStyleBackColor = true;
            this.buttonDrawFigure.Click += new System.EventHandler(this.buttonDrawFigure_Click);
            // 
            // buttonDeleteLastFigure
            // 
            this.buttonDeleteLastFigure.Location = new System.Drawing.Point(755, 12);
            this.buttonDeleteLastFigure.Name = "buttonDeleteLastFigure";
            this.buttonDeleteLastFigure.Size = new System.Drawing.Size(186, 69);
            this.buttonDeleteLastFigure.TabIndex = 2;
            this.buttonDeleteLastFigure.Text = "Удалить последнюю ";
            this.buttonDeleteLastFigure.UseVisualStyleBackColor = true;
            this.buttonDeleteLastFigure.Click += new System.EventHandler(this.buttonDeleteLastFigure_Click);
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(431, 12);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(124, 23);
            this.buttonChooseColor.TabIndex = 3;
            this.buttonChooseColor.Text = "Выберите цвет";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // buttonNewRow
            // 
            this.buttonNewRow.Location = new System.Drawing.Point(431, 39);
            this.buttonNewRow.Name = "buttonNewRow";
            this.buttonNewRow.Size = new System.Drawing.Size(124, 42);
            this.buttonNewRow.TabIndex = 4;
            this.buttonNewRow.Text = "Перейти на другую строку";
            this.buttonNewRow.UseVisualStyleBackColor = true;
            this.buttonNewRow.Click += new System.EventHandler(this.buttonNewRow_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 426);
            this.Controls.Add(this.buttonNewRow);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.buttonDeleteLastFigure);
            this.Controls.Add(this.buttonDrawFigure);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTask";
            this.Text = "Фигуры";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonRhombus;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonSquare;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonDrawFigure;
        private System.Windows.Forms.Button buttonDeleteLastFigure;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.Button buttonNewRow;
    }
}

