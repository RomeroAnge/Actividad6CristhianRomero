namespace GestionDeVenta.VISTA.VentasVistas
{
    partial class RegistrarVentaVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(194, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 46);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "FECHA DE VENTA:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(615, 92);
            button1.Name = "button1";
            button1.Size = new Size(40, 29);
            button1.TabIndex = 5;
            button1.Text = "➕";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 289);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 6;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 294);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 8;
            label3.Text = "TOTAL DE VENTA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 294);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 9;
            label4.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "CLIENTE:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(615, 12);
            button3.Name = "button3";
            button3.Size = new Size(40, 29);
            button3.TabIndex = 12;
            button3.Text = "➕";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RegistrarVentaVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 392);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "RegistrarVentaVista";
            Text = "RegistrarVentaVista";
            Load += RegistrarVentaVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
    }
}