namespace SemaforoSP
{
    partial class Semaforo
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnPreventivo = new System.Windows.Forms.Button();
            this.lblST1_1_Verde = new System.Windows.Forms.Label();
            this.lblST1_1_Amarillo = new System.Windows.Forms.Label();
            this.lblST1_1_Rojo = new System.Windows.Forms.Label();
            this.lblST1_2_Rojo = new System.Windows.Forms.Label();
            this.lblST1_2_Amarillo = new System.Windows.Forms.Label();
            this.lblST1_2_Verde = new System.Windows.Forms.Label();
            this.lblST2_1_Rojo = new System.Windows.Forms.Label();
            this.lblST2_1_Amarillo = new System.Windows.Forms.Label();
            this.lblST2_1_Verde = new System.Windows.Forms.Label();
            this.lblST2_2_Rojo = new System.Windows.Forms.Label();
            this.lblST2_2_Amarillo = new System.Windows.Forms.Label();
            this.lblST2_2_Verde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimer.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(254, 230);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(90, 50);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(253, 281);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(90, 36);
            this.btnComenzar.TabIndex = 7;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnPreventivo
            // 
            this.btnPreventivo.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreventivo.Location = new System.Drawing.Point(253, 318);
            this.btnPreventivo.Name = "btnPreventivo";
            this.btnPreventivo.Size = new System.Drawing.Size(90, 23);
            this.btnPreventivo.TabIndex = 8;
            this.btnPreventivo.Text = "Preventivo";
            this.btnPreventivo.UseVisualStyleBackColor = true;
            this.btnPreventivo.Click += new System.EventHandler(this.btnPreventivo_Click);
            // 
            // lblST1_1_Verde
            // 
            this.lblST1_1_Verde.BackColor = System.Drawing.Color.Transparent;
            this.lblST1_1_Verde.Image = global::SemaforoSP.Properties.Resources.semaforo_sur_color;
            this.lblST1_1_Verde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblST1_1_Verde.Location = new System.Drawing.Point(197, 384);
            this.lblST1_1_Verde.Name = "lblST1_1_Verde";
            this.lblST1_1_Verde.Size = new System.Drawing.Size(44, 30);
            this.lblST1_1_Verde.TabIndex = 13;
            // 
            // lblST1_1_Amarillo
            // 
            this.lblST1_1_Amarillo.BackColor = System.Drawing.Color.Transparent;
            this.lblST1_1_Amarillo.Image = global::SemaforoSP.Properties.Resources.semaforo_sur_color;
            this.lblST1_1_Amarillo.Location = new System.Drawing.Point(237, 384);
            this.lblST1_1_Amarillo.Name = "lblST1_1_Amarillo";
            this.lblST1_1_Amarillo.Size = new System.Drawing.Size(34, 30);
            this.lblST1_1_Amarillo.TabIndex = 14;
            // 
            // lblST1_1_Rojo
            // 
            this.lblST1_1_Rojo.BackColor = System.Drawing.Color.Transparent;
            this.lblST1_1_Rojo.Image = global::SemaforoSP.Properties.Resources.semaforo_sur_color;
            this.lblST1_1_Rojo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblST1_1_Rojo.Location = new System.Drawing.Point(271, 384);
            this.lblST1_1_Rojo.Name = "lblST1_1_Rojo";
            this.lblST1_1_Rojo.Size = new System.Drawing.Size(42, 30);
            this.lblST1_1_Rojo.TabIndex = 15;
            // 
            // lblST1_2_Rojo
            // 
            this.lblST1_2_Rojo.BackColor = System.Drawing.Color.Transparent;
            this.lblST1_2_Rojo.Image = global::SemaforoSP.Properties.Resources.semaforo_norte_color;
            this.lblST1_2_Rojo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblST1_2_Rojo.Location = new System.Drawing.Point(288, 183);
            this.lblST1_2_Rojo.Name = "lblST1_2_Rojo";
            this.lblST1_2_Rojo.Size = new System.Drawing.Size(40, 31);
            this.lblST1_2_Rojo.TabIndex = 18;
            // 
            // lblST1_2_Amarillo
            // 
            this.lblST1_2_Amarillo.BackColor = System.Drawing.Color.Transparent;
            this.lblST1_2_Amarillo.Image = global::SemaforoSP.Properties.Resources.semaforo_norte_color;
            this.lblST1_2_Amarillo.Location = new System.Drawing.Point(330, 183);
            this.lblST1_2_Amarillo.Name = "lblST1_2_Amarillo";
            this.lblST1_2_Amarillo.Size = new System.Drawing.Size(30, 31);
            this.lblST1_2_Amarillo.TabIndex = 17;
            // 
            // lblST1_2_Verde
            // 
            this.lblST1_2_Verde.BackColor = System.Drawing.Color.Transparent;
            this.lblST1_2_Verde.Image = global::SemaforoSP.Properties.Resources.semaforo_norte_color;
            this.lblST1_2_Verde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblST1_2_Verde.Location = new System.Drawing.Point(362, 183);
            this.lblST1_2_Verde.Name = "lblST1_2_Verde";
            this.lblST1_2_Verde.Size = new System.Drawing.Size(42, 31);
            this.lblST1_2_Verde.TabIndex = 16;
            // 
            // lblST2_1_Rojo
            // 
            this.lblST2_1_Rojo.BackColor = System.Drawing.Color.Transparent;
            this.lblST2_1_Rojo.Image = global::SemaforoSP.Properties.Resources.semaforo_oeste_color;
            this.lblST2_1_Rojo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblST2_1_Rojo.Location = new System.Drawing.Point(181, 271);
            this.lblST2_1_Rojo.Name = "lblST2_1_Rojo";
            this.lblST2_1_Rojo.Size = new System.Drawing.Size(34, 42);
            this.lblST2_1_Rojo.TabIndex = 21;
            // 
            // lblST2_1_Amarillo
            // 
            this.lblST2_1_Amarillo.BackColor = System.Drawing.Color.Transparent;
            this.lblST2_1_Amarillo.Image = global::SemaforoSP.Properties.Resources.semaforo_oeste_color;
            this.lblST2_1_Amarillo.Location = new System.Drawing.Point(179, 237);
            this.lblST2_1_Amarillo.Name = "lblST2_1_Amarillo";
            this.lblST2_1_Amarillo.Size = new System.Drawing.Size(38, 34);
            this.lblST2_1_Amarillo.TabIndex = 20;
            // 
            // lblST2_1_Verde
            // 
            this.lblST2_1_Verde.BackColor = System.Drawing.Color.Transparent;
            this.lblST2_1_Verde.Image = global::SemaforoSP.Properties.Resources.semaforo_oeste_color;
            this.lblST2_1_Verde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblST2_1_Verde.Location = new System.Drawing.Point(181, 197);
            this.lblST2_1_Verde.Name = "lblST2_1_Verde";
            this.lblST2_1_Verde.Size = new System.Drawing.Size(35, 40);
            this.lblST2_1_Verde.TabIndex = 19;
            this.lblST2_1_Verde.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblST2_2_Rojo
            // 
            this.lblST2_2_Rojo.BackColor = System.Drawing.Color.Transparent;
            this.lblST2_2_Rojo.Image = global::SemaforoSP.Properties.Resources.semaforo_este_color;
            this.lblST2_2_Rojo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblST2_2_Rojo.Location = new System.Drawing.Point(383, 286);
            this.lblST2_2_Rojo.Name = "lblST2_2_Rojo";
            this.lblST2_2_Rojo.Size = new System.Drawing.Size(34, 40);
            this.lblST2_2_Rojo.TabIndex = 24;
            // 
            // lblST2_2_Amarillo
            // 
            this.lblST2_2_Amarillo.BackColor = System.Drawing.Color.Transparent;
            this.lblST2_2_Amarillo.Image = global::SemaforoSP.Properties.Resources.semaforo_este_color;
            this.lblST2_2_Amarillo.Location = new System.Drawing.Point(384, 328);
            this.lblST2_2_Amarillo.Name = "lblST2_2_Amarillo";
            this.lblST2_2_Amarillo.Size = new System.Drawing.Size(32, 30);
            this.lblST2_2_Amarillo.TabIndex = 23;
            // 
            // lblST2_2_Verde
            // 
            this.lblST2_2_Verde.BackColor = System.Drawing.Color.Transparent;
            this.lblST2_2_Verde.Image = global::SemaforoSP.Properties.Resources.semaforo_este_color;
            this.lblST2_2_Verde.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblST2_2_Verde.Location = new System.Drawing.Point(385, 361);
            this.lblST2_2_Verde.Name = "lblST2_2_Verde";
            this.lblST2_2_Verde.Size = new System.Drawing.Size(30, 41);
            this.lblST2_2_Verde.TabIndex = 22;
            // 
            // Semaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SemaforoSP.Properties.Resources.mapa1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lblST2_2_Rojo);
            this.Controls.Add(this.lblST2_2_Amarillo);
            this.Controls.Add(this.lblST2_2_Verde);
            this.Controls.Add(this.lblST2_1_Rojo);
            this.Controls.Add(this.lblST2_1_Amarillo);
            this.Controls.Add(this.lblST2_1_Verde);
            this.Controls.Add(this.lblST1_2_Rojo);
            this.Controls.Add(this.lblST1_2_Amarillo);
            this.Controls.Add(this.lblST1_2_Verde);
            this.Controls.Add(this.lblST1_1_Rojo);
            this.Controls.Add(this.lblST1_1_Amarillo);
            this.Controls.Add(this.lblST1_1_Verde);
            this.Controls.Add(this.btnPreventivo);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblTimer);
            this.Name = "Semaforo";
            this.Text = "Semaforo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnPreventivo;
        private System.Windows.Forms.Label lblST1_1_Verde;
        private System.Windows.Forms.Label lblST1_1_Amarillo;
        private System.Windows.Forms.Label lblST1_1_Rojo;
        private System.Windows.Forms.Label lblST1_2_Rojo;
        private System.Windows.Forms.Label lblST1_2_Amarillo;
        private System.Windows.Forms.Label lblST1_2_Verde;
        private System.Windows.Forms.Label lblST2_1_Rojo;
        private System.Windows.Forms.Label lblST2_1_Amarillo;
        private System.Windows.Forms.Label lblST2_1_Verde;
        private System.Windows.Forms.Label lblST2_2_Rojo;
        private System.Windows.Forms.Label lblST2_2_Amarillo;
        private System.Windows.Forms.Label lblST2_2_Verde;
    }
}

