namespace ООП_ЛР_24__Чеботарьов_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.randomNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.firstThreadStart = new System.Windows.Forms.Button();
            this.firstThreadStop = new System.Windows.Forms.Button();
            this.secondThreadStop = new System.Windows.Forms.Button();
            this.secondThreadStart = new System.Windows.Forms.Button();
            this.thirdThreadStop = new System.Windows.Forms.Button();
            this.thirdThreadStart = new System.Windows.Forms.Button();
            this.allThreadStop = new System.Windows.Forms.Button();
            this.allThreadStart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.plainTextBox1 = new System.Windows.Forms.RichTextBox();
            this.encryptedTextBox1 = new System.Windows.Forms.RichTextBox();
            this.encryptedTextBox2 = new System.Windows.Forms.RichTextBox();
            this.plainTextBox2 = new System.Windows.Forms.RichTextBox();
            this.encryptedTextBox3 = new System.Windows.Forms.RichTextBox();
            this.plainTextBox3 = new System.Windows.Forms.RichTextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 216);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(272, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 216);
            this.panel2.TabIndex = 1;
            // 
            // randomNumberTextBox
            // 
            this.randomNumberTextBox.Location = new System.Drawing.Point(526, 20);
            this.randomNumberTextBox.Name = "randomNumberTextBox";
            this.randomNumberTextBox.Size = new System.Drawing.Size(224, 216);
            this.randomNumberTextBox.TabIndex = 2;
            this.randomNumberTextBox.Text = "";
            // 
            // firstThreadStart
            // 
            this.firstThreadStart.Location = new System.Drawing.Point(32, 242);
            this.firstThreadStart.Name = "firstThreadStart";
            this.firstThreadStart.Size = new System.Drawing.Size(146, 23);
            this.firstThreadStart.TabIndex = 3;
            this.firstThreadStart.Text = "Запустити";
            this.firstThreadStart.UseVisualStyleBackColor = true;
            // 
            // firstThreadStop
            // 
            this.firstThreadStop.Location = new System.Drawing.Point(32, 271);
            this.firstThreadStop.Name = "firstThreadStop";
            this.firstThreadStop.Size = new System.Drawing.Size(146, 23);
            this.firstThreadStop.TabIndex = 4;
            this.firstThreadStop.Text = "Зупинити";
            this.firstThreadStop.UseVisualStyleBackColor = true;
            // 
            // secondThreadStop
            // 
            this.secondThreadStop.Location = new System.Drawing.Point(309, 271);
            this.secondThreadStop.Name = "secondThreadStop";
            this.secondThreadStop.Size = new System.Drawing.Size(146, 23);
            this.secondThreadStop.TabIndex = 6;
            this.secondThreadStop.Text = "Зупинити";
            this.secondThreadStop.UseVisualStyleBackColor = true;
            // 
            // secondThreadStart
            // 
            this.secondThreadStart.Location = new System.Drawing.Point(309, 242);
            this.secondThreadStart.Name = "secondThreadStart";
            this.secondThreadStart.Size = new System.Drawing.Size(146, 23);
            this.secondThreadStart.TabIndex = 5;
            this.secondThreadStart.Text = "Запустити";
            this.secondThreadStart.UseVisualStyleBackColor = true;
            // 
            // thirdThreadStop
            // 
            this.thirdThreadStop.Location = new System.Drawing.Point(565, 271);
            this.thirdThreadStop.Name = "thirdThreadStop";
            this.thirdThreadStop.Size = new System.Drawing.Size(146, 23);
            this.thirdThreadStop.TabIndex = 8;
            this.thirdThreadStop.Text = "Зупинити";
            this.thirdThreadStop.UseVisualStyleBackColor = true;
            // 
            // thirdThreadStart
            // 
            this.thirdThreadStart.Location = new System.Drawing.Point(565, 242);
            this.thirdThreadStart.Name = "thirdThreadStart";
            this.thirdThreadStart.Size = new System.Drawing.Size(146, 23);
            this.thirdThreadStart.TabIndex = 7;
            this.thirdThreadStart.Text = "Запустити";
            this.thirdThreadStart.UseVisualStyleBackColor = true;
            // 
            // allThreadStop
            // 
            this.allThreadStop.Location = new System.Drawing.Point(221, 366);
            this.allThreadStop.Name = "allThreadStop";
            this.allThreadStop.Size = new System.Drawing.Size(308, 23);
            this.allThreadStop.TabIndex = 10;
            this.allThreadStop.Text = "Зупинити процеси завдання 1";
            this.allThreadStop.UseVisualStyleBackColor = true;
            // 
            // allThreadStart
            // 
            this.allThreadStart.Location = new System.Drawing.Point(221, 337);
            this.allThreadStart.Name = "allThreadStart";
            this.allThreadStart.Size = new System.Drawing.Size(308, 23);
            this.allThreadStart.TabIndex = 9;
            this.allThreadStart.Text = "Запустити процеси завдання 1";
            this.allThreadStart.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.randomNumberTextBox);
            this.tabPage1.Controls.Add(this.thirdThreadStop);
            this.tabPage1.Controls.Add(this.allThreadStop);
            this.tabPage1.Controls.Add(this.thirdThreadStart);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.allThreadStart);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.firstThreadStart);
            this.tabPage1.Controls.Add(this.firstThreadStop);
            this.tabPage1.Controls.Add(this.secondThreadStop);
            this.tabPage1.Controls.Add(this.secondThreadStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.RunButton);
            this.tabPage2.Controls.Add(this.encryptedTextBox3);
            this.tabPage2.Controls.Add(this.plainTextBox3);
            this.tabPage2.Controls.Add(this.encryptedTextBox2);
            this.tabPage2.Controls.Add(this.plainTextBox2);
            this.tabPage2.Controls.Add(this.encryptedTextBox1);
            this.tabPage2.Controls.Add(this.plainTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // plainTextBox1
            // 
            this.plainTextBox1.Location = new System.Drawing.Point(25, 23);
            this.plainTextBox1.Name = "plainTextBox1";
            this.plainTextBox1.Size = new System.Drawing.Size(226, 122);
            this.plainTextBox1.TabIndex = 0;
            this.plainTextBox1.Text = "";
            // 
            // encryptedTextBox1
            // 
            this.encryptedTextBox1.Location = new System.Drawing.Point(25, 172);
            this.encryptedTextBox1.Name = "encryptedTextBox1";
            this.encryptedTextBox1.Size = new System.Drawing.Size(226, 122);
            this.encryptedTextBox1.TabIndex = 1;
            this.encryptedTextBox1.Text = "";
            // 
            // encryptedTextBox2
            // 
            this.encryptedTextBox2.Location = new System.Drawing.Point(293, 172);
            this.encryptedTextBox2.Name = "encryptedTextBox2";
            this.encryptedTextBox2.Size = new System.Drawing.Size(226, 122);
            this.encryptedTextBox2.TabIndex = 3;
            this.encryptedTextBox2.Text = "";
            // 
            // plainTextBox2
            // 
            this.plainTextBox2.Location = new System.Drawing.Point(293, 23);
            this.plainTextBox2.Name = "plainTextBox2";
            this.plainTextBox2.Size = new System.Drawing.Size(226, 122);
            this.plainTextBox2.TabIndex = 2;
            this.plainTextBox2.Text = "";
            // 
            // encryptedTextBox3
            // 
            this.encryptedTextBox3.Location = new System.Drawing.Point(548, 172);
            this.encryptedTextBox3.Name = "encryptedTextBox3";
            this.encryptedTextBox3.Size = new System.Drawing.Size(226, 122);
            this.encryptedTextBox3.TabIndex = 5;
            this.encryptedTextBox3.Text = "";
            // 
            // plainTextBox3
            // 
            this.plainTextBox3.Location = new System.Drawing.Point(548, 23);
            this.plainTextBox3.Name = "plainTextBox3";
            this.plainTextBox3.Size = new System.Drawing.Size(226, 122);
            this.plainTextBox3.TabIndex = 4;
            this.plainTextBox3.Text = "";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(252, 359);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(311, 31);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Запустити процеси завдання 2";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введіть звичайний текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Шифрування REDOC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введіть звичайний текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Хешування SHA256(MCD-2 не підтримується)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введіть звичайний текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Шифрування AES(PKZIP не підтримується)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox randomNumberTextBox;
        private System.Windows.Forms.Button firstThreadStart;
        private System.Windows.Forms.Button firstThreadStop;
        private System.Windows.Forms.Button secondThreadStop;
        private System.Windows.Forms.Button secondThreadStart;
        private System.Windows.Forms.Button thirdThreadStop;
        private System.Windows.Forms.Button thirdThreadStart;
        private System.Windows.Forms.Button allThreadStop;
        private System.Windows.Forms.Button allThreadStart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.RichTextBox encryptedTextBox3;
        private System.Windows.Forms.RichTextBox plainTextBox3;
        private System.Windows.Forms.RichTextBox encryptedTextBox2;
        private System.Windows.Forms.RichTextBox plainTextBox2;
        private System.Windows.Forms.RichTextBox encryptedTextBox1;
        private System.Windows.Forms.RichTextBox plainTextBox1;
    }
}

