namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przebieg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Nazwa = new System.Windows.Forms.TextBox();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.tb_Wartosc = new System.Windows.Forms.TextBox();
            this.tb_Kolor = new System.Windows.Forms.TextBox();
            this.tb_Przebieg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(890, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Uruchom zapytanie!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wynik zapytania:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodaj auto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(890, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Usuń auto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nazwa,
            this.Model,
            this.Wartosc,
            this.Kolor,
            this.Przebieg});
            this.dataGridView1.Location = new System.Drawing.Point(15, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 316);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.MinimumWidth = 6;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Width = 125;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // Wartosc
            // 
            this.Wartosc.HeaderText = "Wartość";
            this.Wartosc.MinimumWidth = 6;
            this.Wartosc.Name = "Wartosc";
            this.Wartosc.Width = 125;
            // 
            // Kolor
            // 
            this.Kolor.HeaderText = "Kolor";
            this.Kolor.MinimumWidth = 6;
            this.Kolor.Name = "Kolor";
            this.Kolor.Width = 125;
            // 
            // Przebieg
            // 
            this.Przebieg.HeaderText = "Przebieg";
            this.Przebieg.MinimumWidth = 6;
            this.Przebieg.Name = "Przebieg";
            this.Przebieg.Width = 125;
            // 
            // tb_Nazwa
            // 
            this.tb_Nazwa.Location = new System.Drawing.Point(333, 384);
            this.tb_Nazwa.Name = "tb_Nazwa";
            this.tb_Nazwa.Size = new System.Drawing.Size(100, 22);
            this.tb_Nazwa.TabIndex = 7;
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(439, 384);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.Size = new System.Drawing.Size(100, 22);
            this.tb_Model.TabIndex = 8;
            // 
            // tb_Wartosc
            // 
            this.tb_Wartosc.Location = new System.Drawing.Point(545, 384);
            this.tb_Wartosc.Name = "tb_Wartosc";
            this.tb_Wartosc.Size = new System.Drawing.Size(100, 22);
            this.tb_Wartosc.TabIndex = 9;
            // 
            // tb_Kolor
            // 
            this.tb_Kolor.Location = new System.Drawing.Point(651, 384);
            this.tb_Kolor.Name = "tb_Kolor";
            this.tb_Kolor.Size = new System.Drawing.Size(100, 22);
            this.tb_Kolor.TabIndex = 10;
            // 
            // tb_Przebieg
            // 
            this.tb_Przebieg.Location = new System.Drawing.Point(757, 384);
            this.tb_Przebieg.Name = "tb_Przebieg";
            this.tb_Przebieg.Size = new System.Drawing.Size(100, 22);
            this.tb_Przebieg.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Wartość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kolor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(773, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Przebieg";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(890, 112);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(152, 22);
            this.tb_ID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(930, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Podaj ID: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Przebieg);
            this.Controls.Add(this.tb_Kolor);
            this.Controls.Add(this.tb_Wartosc);
            this.Controls.Add(this.tb_Model);
            this.Controls.Add(this.tb_Nazwa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przebieg;
        private System.Windows.Forms.TextBox tb_Nazwa;
        private System.Windows.Forms.TextBox tb_Model;
        private System.Windows.Forms.TextBox tb_Wartosc;
        private System.Windows.Forms.TextBox tb_Kolor;
        private System.Windows.Forms.TextBox tb_Przebieg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label2;
    }
}

