namespace crudusuario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtContra = new TextBox();
            txtNombre = new TextBox();
            txtPrimerApp = new TextBox();
            txtSegundoApp = new TextBox();
            txtCorreo = new TextBox();
            txtTipoUsu = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label8 = new Label();
            txtID = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(40, 72);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(140, 27);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 49);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 102);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 102);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 4;
            label4.Text = "Primer apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 155);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 5;
            label5.Text = "Segundo apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 155);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 6;
            label6.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 208);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 7;
            label7.Text = "Tipo de ususario";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(199, 72);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(138, 27);
            txtContra.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 27);
            txtNombre.TabIndex = 10;
            // 
            // txtPrimerApp
            // 
            txtPrimerApp.Location = new Point(199, 125);
            txtPrimerApp.Name = "txtPrimerApp";
            txtPrimerApp.Size = new Size(138, 27);
            txtPrimerApp.TabIndex = 11;
            // 
            // txtSegundoApp
            // 
            txtSegundoApp.Location = new Point(40, 178);
            txtSegundoApp.Name = "txtSegundoApp";
            txtSegundoApp.Size = new Size(140, 27);
            txtSegundoApp.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(199, 178);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(138, 27);
            txtCorreo.TabIndex = 13;
            // 
            // txtTipoUsu
            // 
            txtTipoUsu.Location = new Point(40, 231);
            txtTipoUsu.Name = "txtTipoUsu";
            txtTipoUsu.Size = new Size(140, 27);
            txtTipoUsu.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(40, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(356, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(432, 426);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button2
            // 
            button2.Location = new Point(50, 338);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 212);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 19;
            label8.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(205, 237);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(50, 386);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 21;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtTipoUsu);
            Controls.Add(txtCorreo);
            Controls.Add(txtSegundoApp);
            Controls.Add(txtPrimerApp);
            Controls.Add(txtNombre);
            Controls.Add(txtContra);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtContra;
        private TextBox txtNombre;
        private TextBox txtPrimerApp;
        private TextBox txtSegundoApp;
        private TextBox txtCorreo;
        private TextBox txtTipoUsu;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label8;
        private TextBox txtID;
        private Button button3;
    }
}