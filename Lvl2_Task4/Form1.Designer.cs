using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lvl2_Task4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtInput;
        private Button btnAdd;
        private Button btnReverse;
        private Button btnReverseInPlace;
        private Button btnReset;
        private ListBox listBoxOriginal;
        private ListBox listBoxReversed;
        private Label lblStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new TextBox();
            this.btnAdd = new Button();
            this.btnReverse = new Button();
            this.btnReverseInPlace = new Button();
            this.btnReset = new Button();
            this.listBoxOriginal = new ListBox();
            this.listBoxReversed = new ListBox();
            this.lblStatus = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(225, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реверс массива";

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(12, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(131, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Введите 5 чисел (1-5):";

            this.txtInput.Location = new Point(15, 60);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new Size(150, 20);
            this.txtInput.TabIndex = 2;

            this.btnAdd.Location = new Point(180, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            this.label2.AutoSize = true;
            this.label2.Location = new Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходный массив:";

            this.listBoxOriginal.FormattingEnabled = true;
            this.listBoxOriginal.Location = new Point(15, 110);
            this.listBoxOriginal.Name = "listBoxOriginal";
            this.listBoxOriginal.Size = new Size(200, 95);
            this.listBoxOriginal.TabIndex = 5;

            this.label3.AutoSize = true;
            this.label3.Location = new Point(230, 90);
            this.label3.Name = "label3";
            this.label3.Size = new Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Реверсированный:";

            this.listBoxReversed.FormattingEnabled = true;
            this.listBoxReversed.Location = new Point(230, 110);
            this.listBoxReversed.Name = "listBoxReversed";
            this.listBoxReversed.Size = new Size(200, 95);
            this.listBoxReversed.TabIndex = 7;

            this.btnReverse.Enabled = false;
            this.btnReverse.Location = new Point(15, 220);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new Size(150, 30);
            this.btnReverse.TabIndex = 8;
            this.btnReverse.Text = "Реверс (новый массив)";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new EventHandler(this.btnReverse_Click);

            this.btnReverseInPlace.Enabled = false;
            this.btnReverseInPlace.Location = new Point(180, 220);
            this.btnReverseInPlace.Name = "btnReverseInPlace";
            this.btnReverseInPlace.Size = new Size(150, 30);
            this.btnReverseInPlace.TabIndex = 9;
            this.btnReverseInPlace.Text = "Реверс (этот массив)";
            this.btnReverseInPlace.UseVisualStyleBackColor = true;
            this.btnReverseInPlace.Click += new EventHandler(this.btnReverseInPlace_Click);

            this.btnReset.Location = new Point(15, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(100, 30);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new EventHandler(this.btnReset_Click);

            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Gray;
            this.label4.Location = new Point(15, 300);
            this.label4.Name = "label4";
            this.label4.Size = new Size(207, 13);
            this.label4.TabIndex = 11;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(454, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReverseInPlace);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.listBoxReversed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Реверс массива";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

