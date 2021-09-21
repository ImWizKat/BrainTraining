
namespace BrainTraining
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dificultad = new System.Windows.Forms.NumericUpDown();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.num1 = new System.Windows.Forms.Label();
            this.operador = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.contador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dificultad)).BeginInit();
            this.SuspendLayout();
            // 
            // Dificultad
            // 
            this.Dificultad.Location = new System.Drawing.Point(268, 32);
            this.Dificultad.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Dificultad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Dificultad.Name = "Dificultad";
            this.Dificultad.Size = new System.Drawing.Size(160, 20);
            this.Dificultad.TabIndex = 1;
            this.Dificultad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Dificultad.ValueChanged += new System.EventHandler(this.Dificultad_ValueChanged);
            // 
            // labelPuntos
            // 
            this.labelPuntos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.BackColor = System.Drawing.Color.Lime;
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.Location = new System.Drawing.Point(301, 65);
            this.labelPuntos.MaximumSize = new System.Drawing.Size(40, 40);
            this.labelPuntos.MinimumSize = new System.Drawing.Size(100, 100);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(100, 100);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "0";
            this.labelPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPuntos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // num1
            // 
            this.num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.Lime;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(166, 228);
            this.num1.MaximumSize = new System.Drawing.Size(40, 40);
            this.num1.MinimumSize = new System.Drawing.Size(100, 100);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 100);
            this.num1.TabIndex = 3;
            this.num1.Text = "0";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operador
            // 
            this.operador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.operador.AutoSize = true;
            this.operador.BackColor = System.Drawing.Color.Lime;
            this.operador.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operador.Location = new System.Drawing.Point(301, 228);
            this.operador.MaximumSize = new System.Drawing.Size(40, 40);
            this.operador.MinimumSize = new System.Drawing.Size(100, 100);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(100, 100);
            this.operador.TabIndex = 4;
            this.operador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.Lime;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(437, 228);
            this.num2.MaximumSize = new System.Drawing.Size(40, 40);
            this.num2.MinimumSize = new System.Drawing.Size(100, 100);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 100);
            this.num2.TabIndex = 5;
            this.num2.Text = "0";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contador
            // 
            this.contador.AutoSize = true;
            this.contador.BackColor = System.Drawing.Color.Lime;
            this.contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador.Location = new System.Drawing.Point(567, 65);
            this.contador.Margin = new System.Windows.Forms.Padding(0);
            this.contador.MaximumSize = new System.Drawing.Size(40, 40);
            this.contador.MinimumSize = new System.Drawing.Size(100, 100);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(100, 100);
            this.contador.TabIndex = 6;
            this.contador.Text = "30";
            this.contador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contador.Click += new System.EventHandler(this.contador_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // respuesta
            // 
            this.respuesta.Location = new System.Drawing.Point(297, 185);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(104, 20);
            this.respuesta.TabIndex = 8;
            this.respuesta.TextChanged += new System.EventHandler(this.respuesta_TextChanged);
            this.respuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.respuesta_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contador);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.Dificultad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dificultad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Dificultad;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label operador;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox respuesta;
    }
}

