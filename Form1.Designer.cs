namespace HashF21112017
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbFio = new System.Windows.Forms.TextBox();
            this.lbComment = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(507, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер абонента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия абонента";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(710, 18);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(186, 26);
            this.tbPhone.TabIndex = 3;
            // 
            // tbFio
            // 
            this.tbFio.Location = new System.Drawing.Point(710, 66);
            this.tbFio.Name = "tbFio";
            this.tbFio.Size = new System.Drawing.Size(279, 26);
            this.tbFio.TabIndex = 4;
            // 
            // lbComment
            // 
            this.lbComment.Location = new System.Drawing.Point(551, 162);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(438, 53);
            this.lbComment.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(551, 246);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(212, 47);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Найти абонента";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(551, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить абонента";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(777, 322);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(212, 44);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Удалить абонента";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(551, 396);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(212, 44);
            this.btnFill.TabIndex = 9;
            this.btnFill.Text = "Заполнить таблицу";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(777, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(212, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Завершить работу";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(789, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 460);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.tbFio);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFio;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}

