namespace Git_test
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
            this.bCreateBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bCreateT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bGetSP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tStreets = new System.Windows.Forms.TextBox();
            this.tHouses = new System.Windows.Forms.TextBox();
            this.bZapolnenie = new System.Windows.Forms.Button();
            this.bDeleteT = new System.Windows.Forms.Button();
            this.bZapros = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bCreateBD
            // 
            this.bCreateBD.BackColor = System.Drawing.Color.White;
            this.bCreateBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateBD.Location = new System.Drawing.Point(12, 12);
            this.bCreateBD.Name = "bCreateBD";
            this.bCreateBD.Size = new System.Drawing.Size(109, 39);
            this.bCreateBD.TabIndex = 0;
            this.bCreateBD.Text = "Создание БД";
            this.bCreateBD.UseVisualStyleBackColor = false;
            this.bCreateBD.Click += new System.EventHandler(this.bCreateBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Инфо";
            // 
            // bCreateT
            // 
            this.bCreateT.BackColor = System.Drawing.Color.White;
            this.bCreateT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateT.Location = new System.Drawing.Point(12, 57);
            this.bCreateT.Name = "bCreateT";
            this.bCreateT.Size = new System.Drawing.Size(109, 39);
            this.bCreateT.TabIndex = 3;
            this.bCreateT.Text = "Создание таблиц";
            this.bCreateT.UseVisualStyleBackColor = false;
            this.bCreateT.Click += new System.EventHandler(this.bCreateT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Инфо";
            // 
            // bGetSP
            // 
            this.bGetSP.BackColor = System.Drawing.Color.White;
            this.bGetSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGetSP.Location = new System.Drawing.Point(12, 102);
            this.bGetSP.Name = "bGetSP";
            this.bGetSP.Size = new System.Drawing.Size(109, 39);
            this.bGetSP.TabIndex = 6;
            this.bGetSP.Text = "Получение списка таблиц";
            this.bGetSP.UseVisualStyleBackColor = false;
            this.bGetSP.Click += new System.EventHandler(this.bGetSP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Таблицы: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Инфо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(318, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите количество улиц и \r\nдомов: ";
            // 
            // tStreets
            // 
            this.tStreets.Location = new System.Drawing.Point(321, 47);
            this.tStreets.Name = "tStreets";
            this.tStreets.Size = new System.Drawing.Size(109, 20);
            this.tStreets.TabIndex = 10;
            // 
            // tHouses
            // 
            this.tHouses.Location = new System.Drawing.Point(321, 73);
            this.tHouses.Name = "tHouses";
            this.tHouses.Size = new System.Drawing.Size(109, 20);
            this.tHouses.TabIndex = 11;
            // 
            // bZapolnenie
            // 
            this.bZapolnenie.BackColor = System.Drawing.Color.White;
            this.bZapolnenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZapolnenie.Location = new System.Drawing.Point(321, 102);
            this.bZapolnenie.Name = "bZapolnenie";
            this.bZapolnenie.Size = new System.Drawing.Size(109, 39);
            this.bZapolnenie.TabIndex = 12;
            this.bZapolnenie.Text = "Заполнение БД";
            this.bZapolnenie.UseVisualStyleBackColor = false;
            this.bZapolnenie.Click += new System.EventHandler(this.bZapolnenie_Click);
            // 
            // bDeleteT
            // 
            this.bDeleteT.BackColor = System.Drawing.Color.White;
            this.bDeleteT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteT.Location = new System.Drawing.Point(12, 147);
            this.bDeleteT.Name = "bDeleteT";
            this.bDeleteT.Size = new System.Drawing.Size(109, 39);
            this.bDeleteT.TabIndex = 14;
            this.bDeleteT.Text = "Удаление таблиц";
            this.bDeleteT.UseVisualStyleBackColor = false;
            this.bDeleteT.Click += new System.EventHandler(this.bDeleteT_Click);
            // 
            // bZapros
            // 
            this.bZapros.BackColor = System.Drawing.Color.White;
            this.bZapros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZapros.Location = new System.Drawing.Point(321, 147);
            this.bZapros.Name = "bZapros";
            this.bZapros.Size = new System.Drawing.Size(109, 39);
            this.bZapros.TabIndex = 15;
            this.bZapros.Text = "Выполнение запроса";
            this.bZapros.UseVisualStyleBackColor = false;
            this.bZapros.Click += new System.EventHandler(this.bZapros_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Инфо";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Улица (<)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Дом (>)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(496, 160);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 393);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bZapros);
            this.Controls.Add(this.bDeleteT);
            this.Controls.Add(this.bZapolnenie);
            this.Controls.Add(this.tHouses);
            this.Controls.Add(this.tStreets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bGetSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCreateT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCreateBD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCreateBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCreateT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bGetSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tStreets;
        private System.Windows.Forms.TextBox tHouses;
        private System.Windows.Forms.Button bZapolnenie;
        private System.Windows.Forms.Button bDeleteT;
        private System.Windows.Forms.Button bZapros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}

