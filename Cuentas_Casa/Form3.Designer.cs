namespace Cuentas_Casa
{
    partial class Form3
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtDescr = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            cbFDP = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripción";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 121);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(39, 181);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Forma de Pago";
            // 
            // txtDescr
            // 
            txtDescr.Location = new System.Drawing.Point(132, 66);
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new System.Drawing.Size(100, 23);
            txtDescr.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(132, 121);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(62, 243);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(230, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // cbFDP
            // 
            cbFDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFDP.FormattingEnabled = true;
            cbFDP.Location = new System.Drawing.Point(132, 178);
            cbFDP.Name = "cbFDP";
            cbFDP.Size = new System.Drawing.Size(121, 23);
            cbFDP.TabIndex = 8;
            cbFDP.SelectedIndexChanged += cbFDP_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(377, 293);
            Controls.Add(cbFDP);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbFDP;
    }
}