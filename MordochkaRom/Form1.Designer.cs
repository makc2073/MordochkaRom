
namespace MordochkaRom
{
    partial class FormClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.topAll = new System.Windows.Forms.Button();
            this.top100 = new System.Windows.Forms.Button();
            this.top50 = new System.Windows.Forms.Button();
            this.top10 = new System.Windows.Forms.Button();
            this.labelcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(770, 579);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewClients);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 614);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelcount);
            this.groupBox2.Controls.Add(this.btnForward);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.topAll);
            this.groupBox2.Controls.Add(this.top100);
            this.groupBox2.Controls.Add(this.top50);
            this.groupBox2.Controls.Add(this.top10);
            this.groupBox2.Location = new System.Drawing.Point(12, 634);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Панель управления";
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnForward.Location = new System.Drawing.Point(201, 19);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(31, 25);
            this.btnForward.TabIndex = 8;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(164, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 25);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // topAll
            // 
            this.topAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.topAll.Location = new System.Drawing.Point(123, 19);
            this.topAll.Name = "topAll";
            this.topAll.Size = new System.Drawing.Size(35, 25);
            this.topAll.TabIndex = 6;
            this.topAll.Text = "Все";
            this.topAll.UseVisualStyleBackColor = false;
            this.topAll.Click += new System.EventHandler(this.topAll_Click);
            // 
            // top100
            // 
            this.top100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.top100.Location = new System.Drawing.Point(80, 19);
            this.top100.Name = "top100";
            this.top100.Size = new System.Drawing.Size(37, 25);
            this.top100.TabIndex = 5;
            this.top100.Text = "100";
            this.top100.UseVisualStyleBackColor = false;
            this.top100.Click += new System.EventHandler(this.top100_Click);
            // 
            // top50
            // 
            this.top50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.top50.Location = new System.Drawing.Point(43, 19);
            this.top50.Name = "top50";
            this.top50.Size = new System.Drawing.Size(31, 25);
            this.top50.TabIndex = 4;
            this.top50.Text = "50";
            this.top50.UseVisualStyleBackColor = false;
            this.top50.Click += new System.EventHandler(this.top50_Click);
            // 
            // top10
            // 
            this.top10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.top10.Location = new System.Drawing.Point(6, 19);
            this.top10.Name = "top10";
            this.top10.Size = new System.Drawing.Size(31, 25);
            this.top10.TabIndex = 3;
            this.top10.Text = "10";
            this.top10.UseVisualStyleBackColor = false;
            this.top10.Click += new System.EventHandler(this.top10_Click);
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(238, 25);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(24, 13);
            this.labelcount.TabIndex = 4;
            this.labelcount.Text = "0/0";
            this.labelcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClients";
            this.Text = "Mordochka\'s Clients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button topAll;
        private System.Windows.Forms.Button top100;
        private System.Windows.Forms.Button top50;
        private System.Windows.Forms.Button top10;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelcount;
    }
}

