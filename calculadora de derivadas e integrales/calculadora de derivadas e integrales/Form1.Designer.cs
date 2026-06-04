
namespace calculadora_de_derivadas_e_integrales
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblInferior = new System.Windows.Forms.Label();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.txtLimInf = new System.Windows.Forms.TextBox();
            this.txtLimSup = new System.Windows.Forms.TextBox();
            this.btnDerivar = new System.Windows.Forms.Button();
            this.btnIntegral = new System.Windows.Forms.Button();
            this.btnIntegralDef = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA DE DERIVADAS E INTEGRALES";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncion.Location = new System.Drawing.Point(12, 60);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(91, 16);
            this.lblFuncion.TabIndex = 1;
            this.lblFuncion.Text = "Funcion f(x):";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(15, 88);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(773, 35);
            this.txtFuncion.TabIndex = 2;
            // 
            // lblInferior
            // 
            this.lblInferior.AutoSize = true;
            this.lblInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInferior.Location = new System.Drawing.Point(12, 145);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(135, 16);
            this.lblInferior.TabIndex = 3;
            this.lblInferior.Text = "LIMITE INFERIOR:";
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(491, 145);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(142, 16);
            this.lblSuperior.TabIndex = 4;
            this.lblSuperior.Text = "LIMITE SUPERIOR:";
            // 
            // txtLimInf
            // 
            this.txtLimInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimInf.Location = new System.Drawing.Point(153, 142);
            this.txtLimInf.Name = "txtLimInf";
            this.txtLimInf.Size = new System.Drawing.Size(134, 22);
            this.txtLimInf.TabIndex = 5;
            // 
            // txtLimSup
            // 
            this.txtLimSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimSup.Location = new System.Drawing.Point(639, 139);
            this.txtLimSup.Name = "txtLimSup";
            this.txtLimSup.Size = new System.Drawing.Size(149, 22);
            this.txtLimSup.TabIndex = 6;
            // 
            // btnDerivar
            // 
            this.btnDerivar.Location = new System.Drawing.Point(60, 189);
            this.btnDerivar.Name = "btnDerivar";
            this.btnDerivar.Size = new System.Drawing.Size(132, 39);
            this.btnDerivar.TabIndex = 7;
            this.btnDerivar.Text = "DERIVAR";
            this.btnDerivar.UseVisualStyleBackColor = true;
            this.btnDerivar.Click += new System.EventHandler(this.btnDerivar_Click);
            // 
            // btnIntegral
            // 
            this.btnIntegral.Location = new System.Drawing.Point(321, 189);
            this.btnIntegral.Name = "btnIntegral";
            this.btnIntegral.Size = new System.Drawing.Size(137, 39);
            this.btnIntegral.TabIndex = 8;
            this.btnIntegral.Text = "INTEGRAL";
            this.btnIntegral.UseVisualStyleBackColor = true;
            this.btnIntegral.Click += new System.EventHandler(this.btnIntegral_Click);
            // 
            // btnIntegralDef
            // 
            this.btnIntegralDef.Location = new System.Drawing.Point(609, 189);
            this.btnIntegralDef.Name = "btnIntegralDef";
            this.btnIntegralDef.Size = new System.Drawing.Size(141, 39);
            this.btnIntegralDef.TabIndex = 9;
            this.btnIntegralDef.Text = "INTEGRAL DEFINIDA";
            this.btnIntegralDef.UseVisualStyleBackColor = true;
            this.btnIntegralDef.Click += new System.EventHandler(this.btnIntegralDef_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 249);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(104, 16);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "RESULTADO:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 278);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResultado.Size = new System.Drawing.Size(764, 77);
            this.txtResultado.TabIndex = 11;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(12, 370);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(228, 16);
            this.lblHistorial.TabIndex = 12;
            this.lblHistorial.Text = "HISTORIAL DE OPERACIONES:";
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(15, 399);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(761, 69);
            this.lstHistorial.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(46, 474);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 49);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(639, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 49);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 535);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnIntegralDef);
            this.Controls.Add(this.btnIntegral);
            this.Controls.Add(this.btnDerivar);
            this.Controls.Add(this.txtLimSup);
            this.Controls.Add(this.txtLimInf);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.lblInferior);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label lblInferior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.TextBox txtLimInf;
        private System.Windows.Forms.TextBox txtLimSup;
        private System.Windows.Forms.Button btnDerivar;
        private System.Windows.Forms.Button btnIntegral;
        private System.Windows.Forms.Button btnIntegralDef;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

