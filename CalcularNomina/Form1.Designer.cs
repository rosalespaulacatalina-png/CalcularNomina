namespace CalcularNomina
{
    partial class txtDevengado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtIdentificacaion = new TextBox();
            txtAsignacaionDia = new TextBox();
            txtDiasLaborados = new TextBox();
            btnAlmacenaregistro = new Button();
            btnCalcularsalario = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            btnNuevo = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 36);
            label1.Name = "label1";
            label1.Size = new Size(693, 54);
            label1.TabIndex = 0;
            label1.Text = "Calculo de la nomina del trabajador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 137);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 194);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 2;
            label3.Text = "Identificacaion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 257);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 3;
            label4.Text = "Asignacion salrio dia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 321);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 4;
            label5.Text = "Dias laborados";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 31);
            textBox1.TabIndex = 5;
            // 
            // txtIdentificacaion
            // 
            txtIdentificacaion.Location = new Point(447, 188);
            txtIdentificacaion.Name = "txtIdentificacaion";
            txtIdentificacaion.Size = new Size(315, 31);
            txtIdentificacaion.TabIndex = 6;
            // 
            // txtAsignacaionDia
            // 
            txtAsignacaionDia.Location = new Point(447, 251);
            txtAsignacaionDia.Name = "txtAsignacaionDia";
            txtAsignacaionDia.Size = new Size(315, 31);
            txtAsignacaionDia.TabIndex = 7;
            // 
            // txtDiasLaborados
            // 
            txtDiasLaborados.Location = new Point(447, 315);
            txtDiasLaborados.Name = "txtDiasLaborados";
            txtDiasLaborados.Size = new Size(315, 31);
            txtDiasLaborados.TabIndex = 8;
            // 
            // btnAlmacenaregistro
            // 
            btnAlmacenaregistro.Location = new Point(413, 368);
            btnAlmacenaregistro.Name = "btnAlmacenaregistro";
            btnAlmacenaregistro.Size = new Size(379, 49);
            btnAlmacenaregistro.TabIndex = 9;
            btnAlmacenaregistro.Text = "Guardar registro de empleado";
            btnAlmacenaregistro.UseVisualStyleBackColor = true;
            btnAlmacenaregistro.Click += btnAlmacenaregistro_Click;
            // 
            // btnCalcularsalario
            // 
            btnCalcularsalario.Location = new Point(413, 434);
            btnCalcularsalario.Name = "btnCalcularsalario";
            btnCalcularsalario.Size = new Size(379, 28);
            btnCalcularsalario.TabIndex = 10;
            btnCalcularsalario.Text = "Calcular Salario";
            btnCalcularsalario.UseVisualStyleBackColor = true;
            btnCalcularsalario.Click += btnCalcularsalario_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 501);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 11;
            label6.Text = "Valor total Devengado";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(432, 495);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 31);
            textBox2.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(200, 560);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(198, 45);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(691, 560);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(190, 45);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtDevengado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 653);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(btnCalcularsalario);
            Controls.Add(btnAlmacenaregistro);
            Controls.Add(txtDiasLaborados);
            Controls.Add(txtAsignacaionDia);
            Controls.Add(txtIdentificacaion);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "txtDevengado";
            Text = "Form1";
            Load += txtNombre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtIdentificacaion;
        private TextBox txtAsignacaionDia;
        private TextBox txtDiasLaborados;
        private Button btnAlmacenaregistro;
        private Button btnCalcularsalario;
        private Label label6;
        private TextBox textBox2;
        private Button btnNuevo;
        private Button btnSalir;
    }
}
