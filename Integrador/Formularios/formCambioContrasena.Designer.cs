
namespace Integrador.Formularios
{
    partial class formCambioContrasena
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.txtConfirmacionContrasena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cambiar Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña Nueva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Contraseña Nueva";
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(125, 313);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(161, 23);
            this.txtNuevaContrasena.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Seguir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.Location = new System.Drawing.Point(125, 220);
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.PasswordChar = '*';
            this.txtContrasenaActual.Size = new System.Drawing.Size(161, 23);
            this.txtContrasenaActual.TabIndex = 15;
            // 
            // txtConfirmacionContrasena
            // 
            this.txtConfirmacionContrasena.Location = new System.Drawing.Point(125, 392);
            this.txtConfirmacionContrasena.Name = "txtConfirmacionContrasena";
            this.txtConfirmacionContrasena.PasswordChar = '*';
            this.txtConfirmacionContrasena.Size = new System.Drawing.Size(161, 23);
            this.txtConfirmacionContrasena.TabIndex = 16;
            // 
            // formCambioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 651);
            this.Controls.Add(this.txtConfirmacionContrasena);
            this.Controls.Add(this.txtContrasenaActual);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formCambioContrasena";
            this.Text = "formCambioContrasena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtContrasenaActual;
        private System.Windows.Forms.TextBox txtConfirmacionContrasena;
    }
}