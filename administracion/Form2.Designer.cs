namespace administracion
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgv = new DataGridView();
            lstfruta = new ListBox();
            listpro = new ListBox();
            btnAnadir = new Button();
            btnPedidoFac = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button7 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 1001);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(-2, 260);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(264, 55);
            button1.TabIndex = 1;
            button1.Text = "Nuevo Producto";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(-2, 323);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(264, 55);
            button2.TabIndex = 2;
            button2.Text = "Facturacion";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(-2, 385);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(264, 55);
            button3.TabIndex = 3;
            button3.Text = "Pedidos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(-2, 448);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(264, 55);
            button4.TabIndex = 4;
            button4.Text = "Fidelización clientes";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(2, 511);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(264, 55);
            button5.TabIndex = 5;
            button5.Text = "Stock";
            button5.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(711, 4);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(725, 373);
            dgv.TabIndex = 6;
            // 
            // lstfruta
            // 
            lstfruta.BackColor = Color.Silver;
            lstfruta.FormattingEnabled = true;
            lstfruta.ItemHeight = 20;
            lstfruta.Location = new Point(291, 16);
            lstfruta.Margin = new Padding(3, 4, 3, 4);
            lstfruta.Name = "lstfruta";
            lstfruta.Size = new Size(154, 364);
            lstfruta.TabIndex = 7;
            lstfruta.Visible = false;
            // 
            // listpro
            // 
            listpro.BackColor = Color.Silver;
            listpro.FormattingEnabled = true;
            listpro.ItemHeight = 20;
            listpro.Location = new Point(507, 16);
            listpro.Margin = new Padding(3, 4, 3, 4);
            listpro.Name = "listpro";
            listpro.Size = new Size(151, 364);
            listpro.TabIndex = 8;
            listpro.Visible = false;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(390, 431);
            btnAnadir.Margin = new Padding(3, 4, 3, 4);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(183, 49);
            btnAnadir.TabIndex = 9;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Visible = false;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // btnPedidoFac
            // 
            btnPedidoFac.Location = new Point(929, 431);
            btnPedidoFac.Margin = new Padding(3, 4, 3, 4);
            btnPedidoFac.Name = "btnPedidoFac";
            btnPedidoFac.Size = new Size(160, 49);
            btnPedidoFac.TabIndex = 10;
            btnPedidoFac.Text = "Generar factura";
            btnPedidoFac.UseVisualStyleBackColor = true;
            btnPedidoFac.Visible = false;
            btnPedidoFac.Click += btnPedidoFac_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Location = new Point(303, 733);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(215, 44);
            button6.TabIndex = 11;
            button6.Text = "Obtener venta por hora";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 668);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 27);
            textBox1.TabIndex = 12;
            textBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 629);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 13;
            label2.Text = "Hora";
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Location = new Point(631, 812);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(213, 40);
            button7.TabIndex = 14;
            button7.Text = "Entre Fechas";
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(610, 668);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 27);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(610, 747);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(261, 27);
            dateTimePicker2.TabIndex = 16;
            dateTimePicker2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(711, 629);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 17;
            label3.Text = "Desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(713, 717);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 18;
            label4.Text = "Hasta";
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Location = new Point(1027, 588);
            button8.Name = "button8";
            button8.Size = new Size(339, 39);
            button8.TabIndex = 19;
            button8.Text = "Clientes que superan la media de puntos";
            button8.UseVisualStyleBackColor = false;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1439, 999);
            Controls.Add(button8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(btnPedidoFac);
            Controls.Add(btnAnadir);
            Controls.Add(listpro);
            Controls.Add(lstfruta);
            Controls.Add(dgv);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dgv;
        private ListBox lstfruta;
        private ListBox listpro;
        private Button btnAnadir;
        private Button btnPedidoFac;
        private Button button6;
        private TextBox textBox1;
        private Label label2;
        private Button button7;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private Button button8;
    }
}