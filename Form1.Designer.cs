namespace Aplicacion_estudiantes
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
            this.lblcarnet = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbCarnet = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorCarnet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcarnet.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcarnet.Location = new System.Drawing.Point(112, 185);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(81, 28);
            this.lblcarnet.TabIndex = 0;
            this.lblcarnet.Text = "Carnet:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(204, 81);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(270, 27);
            this.txtbNombre.TabIndex = 1;
            this.txtbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clinic);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(97, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 28);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtbCarnet
            // 
            this.txtbCarnet.Location = new System.Drawing.Point(204, 188);
            this.txtbCarnet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbCarnet.Name = "txtbCarnet";
            this.txtbCarnet.Size = new System.Drawing.Size(270, 27);
            this.txtbCarnet.TabIndex = 3;
            this.txtbCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clinic1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(416, 389);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 48);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(112, 372);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(53, 17);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(220, 134);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(41, 20);
            this.lblErrorNombre.TabIndex = 6;
            this.lblErrorNombre.Text = "Error";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorCarnet
            // 
            this.lblErrorCarnet.AutoSize = true;
            this.lblErrorCarnet.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCarnet.Location = new System.Drawing.Point(220, 240);
            this.lblErrorCarnet.Name = "lblErrorCarnet";
            this.lblErrorCarnet.Size = new System.Drawing.Size(41, 20);
            this.lblErrorCarnet.TabIndex = 7;
            this.lblErrorCarnet.Text = "Error";
            this.lblErrorCarnet.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(602, 553);
            this.Controls.Add(this.lblErrorCarnet);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtbCarnet);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblcarnet);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcarnet;
        private TextBox txtbNombre;
        private Label lblNombre;
        private TextBox txtbCarnet;
        private Button btnGuardar;
        private Label lblError;
        private Label lblErrorNombre;
        private Label lblErrorCarnet;
    }
}