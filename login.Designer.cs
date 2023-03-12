
namespace Desafio_1
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txContraseña = new System.Windows.Forms.TextBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBUser = new System.Windows.Forms.Label();
            this.LBcontra = new System.Windows.Forms.Label();
            this.boton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(242, 183);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(294, 20);
            this.txNombre.TabIndex = 0;
            // 
            // txContraseña
            // 
            this.txContraseña.Location = new System.Drawing.Point(242, 260);
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.Size = new System.Drawing.Size(294, 20);
            this.txContraseña.TabIndex = 1;
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(242, 329);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(144, 40);
            this.boton1.TabIndex = 2;
            this.boton1.Text = "Registrar";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio de sesion!";
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUser.Location = new System.Drawing.Point(238, 160);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(71, 20);
            this.LBUser.TabIndex = 4;
            this.LBUser.Text = "Usuario";
            // 
            // LBcontra
            // 
            this.LBcontra.AutoSize = true;
            this.LBcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcontra.Location = new System.Drawing.Point(238, 237);
            this.LBcontra.Name = "LBcontra";
            this.LBcontra.Size = new System.Drawing.Size(102, 20);
            this.LBcontra.TabIndex = 5;
            this.LBcontra.Text = "Contraseña";
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(392, 329);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(144, 40);
            this.boton2.TabIndex = 6;
            this.boton2.Text = "Iniciar sesion";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.LBcontra);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.txContraseña);
            this.Controls.Add(this.txNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txContraseña;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.Label LBcontra;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}