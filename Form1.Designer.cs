
namespace p_clase
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.agregarPersona = new System.Windows.Forms.Button();
            this.textPersonas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrar.Location = new System.Drawing.Point(126, 271);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(246, 38);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(126, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre de usuario";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombre.Location = new System.Drawing.Point(126, 142);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(246, 29);
            this.textNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(126, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "apellido";
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textApellido.Location = new System.Drawing.Point(126, 216);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(246, 29);
            this.textApellido.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.agregarPersona);
            this.panel1.Location = new System.Drawing.Point(61, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 359);
            this.panel1.TabIndex = 5;
            // 
            // agregarPersona
            // 
            this.agregarPersona.BackColor = System.Drawing.SystemColors.HotTrack;
            this.agregarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarPersona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.agregarPersona.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.agregarPersona.Location = new System.Drawing.Point(65, 269);
            this.agregarPersona.Name = "agregarPersona";
            this.agregarPersona.Size = new System.Drawing.Size(246, 38);
            this.agregarPersona.TabIndex = 6;
            this.agregarPersona.Text = "Agregar persona";
            this.agregarPersona.UseVisualStyleBackColor = false;
            this.agregarPersona.Click += new System.EventHandler(this.agregarPersona_Click);
            // 
            // textPersonas
            // 
            this.textPersonas.FormattingEnabled = true;
            this.textPersonas.ItemHeight = 15;
            this.textPersonas.Location = new System.Drawing.Point(497, 142);
            this.textPersonas.Name = "textPersonas";
            this.textPersonas.Size = new System.Drawing.Size(261, 184);
            this.textPersonas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textPersonas);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mi app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button agregarPersona;
        private System.Windows.Forms.ListBox textPersonas;
    }
}

