namespace EstreucturaSeleccionMultipleVentana
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
            label1 = new Label();
            label2 = new Label();
            cmbfrutas = new ComboBox();
            button1 = new Button();
            txtkm = new TextBox();
            lblresultado = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(178, 19);
            label1.TabIndex = 0;
            label1.Text = "Tipo de fruta a transportar : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(180, 19);
            label2.TabIndex = 1;
            label2.Text = "Distancia a recorrer en km : ";
            // 
            // cmbfrutas
            // 
            cmbfrutas.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbfrutas.FormattingEnabled = true;
            cmbfrutas.Items.AddRange(new object[] { "1", "2", "3" });
            cmbfrutas.Location = new Point(196, 24);
            cmbfrutas.Name = "cmbfrutas";
            cmbfrutas.Size = new Size(202, 27);
            cmbfrutas.TabIndex = 2;
            cmbfrutas.Text = "Escoge del 1 al 3 ";
            cmbfrutas.SelectedIndexChanged += cmbfrutas_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 219);
            button1.Name = "button1";
            button1.Size = new Size(106, 44);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtkm
            // 
            txtkm.Location = new Point(277, 96);
            txtkm.Name = "txtkm";
            txtkm.Size = new Size(121, 23);
            txtkm.TabIndex = 4;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblresultado.Location = new Point(12, 172);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(162, 21);
            lblresultado.TabIndex = 5;
            lblresultado.Text = "EL total a pagar es : ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(196, 219);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(106, 44);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 266);
            Controls.Add(btnLimpiar);
            Controls.Add(lblresultado);
            Controls.Add(txtkm);
            Controls.Add(button1);
            Controls.Add(cmbfrutas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "btnCalcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbfrutas;
        private Button button1;
        private TextBox txtkm;
        private Label lblresultado;
        private Button btnLimpiar;
    }
}