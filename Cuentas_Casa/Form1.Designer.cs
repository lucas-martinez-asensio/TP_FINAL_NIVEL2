namespace Cuentas_Casa
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
            dgvRegistro = new System.Windows.Forms.DataGridView();
            pbxRegistro = new System.Windows.Forms.PictureBox();
            btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxRegistro).BeginInit();
            SuspendLayout();
            // 
            // dgvRegistro
            // 
            dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Location = new System.Drawing.Point(0, 0);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.RowTemplate.Height = 25;
            dgvRegistro.Size = new System.Drawing.Size(532, 333);
            dgvRegistro.TabIndex = 0;
            dgvRegistro.CellContentClick += dgvRegistro_CellContentClick;
            dgvRegistro.SelectionChanged += dgvRegistro_SelectionChanged;
            // 
            // pbxRegistro
            // 
            pbxRegistro.Location = new System.Drawing.Point(538, 0);
            pbxRegistro.Name = "pbxRegistro";
            pbxRegistro.Size = new System.Drawing.Size(173, 158);
            pbxRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbxRegistro.TabIndex = 1;
            pbxRegistro.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(36, 353);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(pbxRegistro);
            Controls.Add(dgvRegistro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxRegistro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.PictureBox pbxRegistro;
        private System.Windows.Forms.Button btnAgregar;
    }
}
