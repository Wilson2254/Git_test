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
            this.SuspendLayout();
            // 
            // bCreateBD
            // 
            this.bCreateBD.BackColor = System.Drawing.Color.White;
            this.bCreateBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateBD.Location = new System.Drawing.Point(12, 12);
            this.bCreateBD.Name = "bCreateBD";
            this.bCreateBD.Size = new System.Drawing.Size(109, 23);
            this.bCreateBD.TabIndex = 0;
            this.bCreateBD.Text = "СОЗДАТЬ БД";
            this.bCreateBD.UseVisualStyleBackColor = false;
            this.bCreateBD.Click += new System.EventHandler(this.bCreateBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // bCreateT
            // 
            this.bCreateT.BackColor = System.Drawing.Color.White;
            this.bCreateT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateT.Location = new System.Drawing.Point(12, 68);
            this.bCreateT.Name = "bCreateT";
            this.bCreateT.Size = new System.Drawing.Size(109, 39);
            this.bCreateT.TabIndex = 3;
            this.bCreateT.Text = "СОЗДАТЬ ТАБЛИЦЫ";
            this.bCreateT.UseVisualStyleBackColor = false;
            this.bCreateT.Click += new System.EventHandler(this.bCreateT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // bGetSP
            // 
            this.bGetSP.BackColor = System.Drawing.Color.White;
            this.bGetSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGetSP.Location = new System.Drawing.Point(12, 136);
            this.bGetSP.Name = "bGetSP";
            this.bGetSP.Size = new System.Drawing.Size(109, 39);
            this.bGetSP.TabIndex = 6;
            this.bGetSP.Text = "ПОЛУЧЕНИЕ СПИСКА ТАБЛИЦЫ БД";
            this.bGetSP.UseVisualStyleBackColor = false;
            this.bGetSP.Click += new System.EventHandler(this.bGetSP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Таблицы: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 527);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bGetSP);
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
    }
}

