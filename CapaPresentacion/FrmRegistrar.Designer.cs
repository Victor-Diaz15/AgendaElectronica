
namespace CapaPresentacion
{
    partial class FrmRegistrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            this.FormTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.radiusForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.radiusTxtCelular = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mskTxt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.radiusTxtNombre = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.radiusTxtApellido = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.radiusTxtDireccion = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_fecha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Apellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Direccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FormTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTop
            // 
            this.FormTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.FormTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FormTop.BackgroundImage")));
            this.FormTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormTop.Controls.Add(this.pictureBox2);
            this.FormTop.Controls.Add(this.pictureBox1);
            this.FormTop.Controls.Add(this.bunifuCustomLabel1);
            this.FormTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormTop.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.FormTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.FormTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.FormTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.FormTop.Location = new System.Drawing.Point(0, 0);
            this.FormTop.Name = "FormTop";
            this.FormTop.Quality = 10;
            this.FormTop.Size = new System.Drawing.Size(800, 39);
            this.FormTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(59, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(230, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Formulario de Registro";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.FormTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // radiusForm
            // 
            this.radiusForm.ElipseRadius = 7;
            this.radiusForm.TargetControl = this;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(70, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(151, 30);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Nombre";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radiusTxtCelular
            // 
            this.radiusTxtCelular.ElipseRadius = 5;
            this.radiusTxtCelular.TargetControl = this.mskTxt_Celular;
            // 
            // mskTxt_Celular
            // 
            this.mskTxt_Celular.BackColor = System.Drawing.Color.White;
            this.mskTxt_Celular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTxt_Celular.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxt_Celular.Location = new System.Drawing.Point(254, 285);
            this.mskTxt_Celular.Mask = "000-000-0000";
            this.mskTxt_Celular.Name = "mskTxt_Celular";
            this.mskTxt_Celular.Size = new System.Drawing.Size(147, 20);
            this.mskTxt_Celular.TabIndex = 3;
            // 
            // radiusTxtNombre
            // 
            this.radiusTxtNombre.ElipseRadius = 5;
            this.radiusTxtNombre.TargetControl = this;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(70, 144);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(151, 30);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Apellido";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(70, 188);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(151, 30);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "Direccion";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(43, 231);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(178, 30);
            this.bunifuCustomLabel5.TabIndex = 1;
            this.bunifuCustomLabel5.Text = "Fecha Nacimiento";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(70, 275);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(151, 30);
            this.bunifuCustomLabel6.TabIndex = 1;
            this.bunifuCustomLabel6.Text = "Celular";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radiusTxtApellido
            // 
            this.radiusTxtApellido.ElipseRadius = 5;
            this.radiusTxtApellido.TargetControl = this;
            // 
            // radiusTxtDireccion
            // 
            this.radiusTxtDireccion.ElipseRadius = 5;
            this.radiusTxtDireccion.TargetControl = this;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.BorderRadius = 7;
            this.btn_Guardar.ButtonText = "Guardar";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Iconimage")));
            this.btn_Guardar.Iconimage_right = null;
            this.btn_Guardar.Iconimage_right_Selected = null;
            this.btn_Guardar.Iconimage_Selected = null;
            this.btn_Guardar.IconMarginLeft = 0;
            this.btn_Guardar.IconMarginRight = 0;
            this.btn_Guardar.IconRightVisible = true;
            this.btn_Guardar.IconRightZoom = 0D;
            this.btn_Guardar.IconVisible = true;
            this.btn_Guardar.IconZoom = 90D;
            this.btn_Guardar.IsTab = false;
            this.btn_Guardar.Location = new System.Drawing.Point(290, 363);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Guardar.selected = false;
            this.btn_Guardar.Size = new System.Drawing.Size(267, 48);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.btn_Guardar.TextFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_fecha.HintForeColor = System.Drawing.Color.Empty;
            this.txt_fecha.HintText = "";
            this.txt_fecha.isPassword = false;
            this.txt_fecha.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_fecha.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_fecha.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_fecha.LineThickness = 3;
            this.txt_fecha.Location = new System.Drawing.Point(254, 224);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(338, 37);
            this.txt_fecha.TabIndex = 6;
            this.txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Nombre.HintText = "";
            this.txt_Nombre.isPassword = false;
            this.txt_Nombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Nombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineThickness = 3;
            this.txt_Nombre.Location = new System.Drawing.Point(254, 86);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(338, 44);
            this.txt_Nombre.TabIndex = 7;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Apellido.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Apellido.HintText = "";
            this.txt_Apellido.isPassword = false;
            this.txt_Apellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Apellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Apellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Apellido.LineThickness = 3;
            this.txt_Apellido.Location = new System.Drawing.Point(254, 130);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(338, 44);
            this.txt_Apellido.TabIndex = 7;
            this.txt_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Direccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Direccion.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Direccion.HintText = "";
            this.txt_Direccion.isPassword = false;
            this.txt_Direccion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Direccion.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Direccion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Direccion.LineThickness = 3;
            this.txt_Direccion.Location = new System.Drawing.Point(254, 174);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(338, 44);
            this.txt_Direccion.TabIndex = 8;
            this.txt_Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.mskTxt_Celular);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.FormTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrar";
            this.Load += new System.EventHandler(this.FrmRegistrar_Load);
            this.FormTop.ResumeLayout(false);
            this.FormTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel FormTop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse radiusForm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuElipse radiusTxtCelular;
        private Bunifu.Framework.UI.BunifuElipse radiusTxtNombre;
        private System.Windows.Forms.MaskedTextBox mskTxt_Celular;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuElipse radiusTxtApellido;
        private Bunifu.Framework.UI.BunifuElipse radiusTxtDireccion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Guardar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_fecha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Direccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Apellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nombre;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}