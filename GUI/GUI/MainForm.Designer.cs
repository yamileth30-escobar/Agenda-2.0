namespace AgendaContactos.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCerrarsesión = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnUbicaciones = new System.Windows.Forms.Button();
            this.btnCantactos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarsesión
            // 
            this.btnCerrarsesión.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrarsesión.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesión.ForeColor = System.Drawing.Color.White;
            this.btnCerrarsesión.Location = new System.Drawing.Point(19, 597);
            this.btnCerrarsesión.Name = "btnCerrarsesión";
            this.btnCerrarsesión.Size = new System.Drawing.Size(138, 32);
            this.btnCerrarsesión.TabIndex = 44;
            this.btnCerrarsesión.Text = "Cerrar Sesión ";
            this.btnCerrarsesión.UseVisualStyleBackColor = false;
            this.btnCerrarsesión.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 68);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(567, 21);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(151, 25);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "\"Bienvenid@...\"\r\n";
            this.lblBienvenida.Click += new System.EventHandler(this.MainForm_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMART CONTACTS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCategorias, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUbicaciones, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCantactos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReportes, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(195, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCategorias.BackgroundImage")));
            this.btnCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategorias.Location = new System.Drawing.Point(253, 3);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(244, 244);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUbicaciones.BackgroundImage")));
            this.btnUbicaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUbicaciones.Location = new System.Drawing.Point(3, 253);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(244, 244);
            this.btnUbicaciones.TabIndex = 2;
            this.btnUbicaciones.UseVisualStyleBackColor = true;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // btnCantactos
            // 
            this.btnCantactos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCantactos.BackgroundImage")));
            this.btnCantactos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCantactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCantactos.Location = new System.Drawing.Point(3, 3);
            this.btnCantactos.Name = "btnCantactos";
            this.btnCantactos.Size = new System.Drawing.Size(244, 244);
            this.btnCantactos.TabIndex = 0;
            this.btnCantactos.UseVisualStyleBackColor = true;
            this.btnCantactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.BackgroundImage")));
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportes.Location = new System.Drawing.Point(253, 253);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(244, 244);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(582, 607);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(195, 13);
            this.lblHora.TabIndex = 47;
            this.lblHora.Text = "Hora Actual: 00: 00: 00 AM | Sábado...\"\r\n";
            this.lblHora.Click += new System.EventHandler(this.timerHora_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 641);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrarsesión);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Smart Contacts | Menu Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarsesión;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnUbicaciones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCantactos;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}