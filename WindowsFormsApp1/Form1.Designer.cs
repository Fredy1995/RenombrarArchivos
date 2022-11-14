
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.txtIni = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClonar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPathSalida = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtPath.Location = new System.Drawing.Point(160, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(340, 29);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\compartida\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UBICACIÓN:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciar.FlatAppearance.BorderSize = 5;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnIniciar.Location = new System.Drawing.Point(12, 74);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(271, 39);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "RENOMBRAR ARCHIVOS";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.BackColor = System.Drawing.SystemColors.Desktop;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.SystemColors.Info;
            this.LblMensaje.Location = new System.Drawing.Point(170, 246);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(294, 18);
            this.LblMensaje.TabIndex = 3;
            this.LblMensaje.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // txtIni
            // 
            this.txtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIni.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtIni.Location = new System.Drawing.Point(20, 29);
            this.txtIni.Name = "txtIni";
            this.txtIni.Size = new System.Drawing.Size(52, 29);
            this.txtIni.TabIndex = 4;
            this.txtIni.Text = "0";
            // 
            // txtFin
            // 
            this.txtFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtFin.Location = new System.Drawing.Point(102, 25);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(46, 29);
            this.txtFin.TabIndex = 5;
            this.txtFin.Text = "7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(506, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(98, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "De";
            // 
            // btnClonar
            // 
            this.btnClonar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnClonar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClonar.FlatAppearance.BorderSize = 5;
            this.btnClonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClonar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClonar.Location = new System.Drawing.Point(12, 131);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(271, 39);
            this.btnClonar.TabIndex = 8;
            this.btnClonar.Text = "COPIADOR XD";
            this.btnClonar.UseVisualStyleBackColor = false;
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "UBICACIÓN SALIDA:";
            // 
            // txtPathSalida
            // 
            this.txtPathSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathSalida.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtPathSalida.Location = new System.Drawing.Point(247, 179);
            this.txtPathSalida.Name = "txtPathSalida";
            this.txtPathSalida.Size = new System.Drawing.Size(340, 29);
            this.txtPathSalida.TabIndex = 9;
            this.txtPathSalida.Text = "C:\\compartida\\Salida";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(695, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPathSalida);
            this.Controls.Add(this.btnClonar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOR LAZY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.TextBox txtIni;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPathSalida;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

