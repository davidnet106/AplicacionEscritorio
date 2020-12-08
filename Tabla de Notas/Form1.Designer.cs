namespace Tabla_de_Notas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuIconos = new System.Windows.Forms.ToolStrip();
            this.tsSearchUser = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.tsSaveFile = new System.Windows.Forms.ToolStripButton();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombreIn = new System.Windows.Forms.TextBox();
            this.txtcorreoIn = new System.Windows.Forms.TextBox();
            this.txtcodigoIn = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.dgtablaDatos = new System.Windows.Forms.DataGridView();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsEditUser = new System.Windows.Forms.ToolStripButton();
            this.tsAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsOpenFile = new System.Windows.Forms.ToolStripButton();
            this.menuIconos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // menuIconos
            // 
            this.menuIconos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuIconos.GripMargin = new System.Windows.Forms.Padding(25, 10, 10, 10);
            this.menuIconos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenFile,
            this.tsAddUser,
            this.tsSearchUser,
            this.tsEditUser,
            this.tsDeleteUser,
            this.tsSaveFile,
            this.tsExit});
            this.menuIconos.Location = new System.Drawing.Point(0, 0);
            this.menuIconos.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.menuIconos.Name = "menuIconos";
            this.menuIconos.Padding = new System.Windows.Forms.Padding(5);
            this.menuIconos.Size = new System.Drawing.Size(848, 124);
            this.menuIconos.TabIndex = 0;
            this.menuIconos.Text = "toolStrip1";
            this.menuIconos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsSearchUser
            // 
            this.tsSearchUser.AutoSize = false;
            this.tsSearchUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchUser.Image")));
            this.tsSearchUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSearchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchUser.Margin = new System.Windows.Forms.Padding(6);
            this.tsSearchUser.Name = "tsSearchUser";
            this.tsSearchUser.Padding = new System.Windows.Forms.Padding(2);
            this.tsSearchUser.Size = new System.Drawing.Size(94, 94);
            this.tsSearchUser.Text = "toolStripButton3";
            this.tsSearchUser.ToolTipText = "Busca un estudiante";
            this.tsSearchUser.Click += new System.EventHandler(this.tsSearchUser_Click);
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.AutoSize = false;
            this.tsDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteUser.Enabled = false;
            this.tsDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteUser.Image")));
            this.tsDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteUser.Margin = new System.Windows.Forms.Padding(6);
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Padding = new System.Windows.Forms.Padding(2);
            this.tsDeleteUser.Size = new System.Drawing.Size(94, 94);
            this.tsDeleteUser.Text = "toolStripButton5";
            this.tsDeleteUser.ToolTipText = "Borrar datos del Edtudiante";
            this.tsDeleteUser.Click += new System.EventHandler(this.tsDeleteUser_Click);
            // 
            // tsSaveFile
            // 
            this.tsSaveFile.AutoSize = false;
            this.tsSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveFile.Image")));
            this.tsSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveFile.Margin = new System.Windows.Forms.Padding(6);
            this.tsSaveFile.Name = "tsSaveFile";
            this.tsSaveFile.Padding = new System.Windows.Forms.Padding(2);
            this.tsSaveFile.Size = new System.Drawing.Size(94, 94);
            this.tsSaveFile.Text = "toolStripButton6";
            this.tsSaveFile.ToolTipText = "Guardar archivo XML";
            this.tsSaveFile.Click += new System.EventHandler(this.tsSaveFile_Click);
            // 
            // tsExit
            // 
            this.tsExit.AutoSize = false;
            this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Margin = new System.Windows.Forms.Padding(10);
            this.tsExit.Name = "tsExit";
            this.tsExit.Padding = new System.Windows.Forms.Padding(10);
            this.tsExit.Size = new System.Drawing.Size(94, 94);
            this.tsExit.Text = "toolStripButton7";
            this.tsExit.ToolTipText = "Salir";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nota 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nota 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nota 4";
            // 
            // txtnombreIn
            // 
            this.txtnombreIn.Location = new System.Drawing.Point(224, 231);
            this.txtnombreIn.Name = "txtnombreIn";
            this.txtnombreIn.Size = new System.Drawing.Size(509, 26);
            this.txtnombreIn.TabIndex = 9;
            // 
            // txtcorreoIn
            // 
            this.txtcorreoIn.Location = new System.Drawing.Point(224, 281);
            this.txtcorreoIn.Name = "txtcorreoIn";
            this.txtcorreoIn.Size = new System.Drawing.Size(509, 26);
            this.txtcorreoIn.TabIndex = 10;
            // 
            // txtcodigoIn
            // 
            this.txtcodigoIn.Location = new System.Drawing.Point(599, 172);
            this.txtcodigoIn.Name = "txtcodigoIn";
            this.txtcodigoIn.Size = new System.Drawing.Size(134, 26);
            this.txtcodigoIn.TabIndex = 11;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(154, 337);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(75, 26);
            this.txtNota1.TabIndex = 12;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(326, 337);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(75, 26);
            this.txtNota2.TabIndex = 13;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(492, 337);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(75, 26);
            this.txtNota3.TabIndex = 14;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(658, 337);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(75, 26);
            this.txtNota4.TabIndex = 15;
            // 
            // dgtablaDatos
            // 
            this.dgtablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtablaDatos.Location = new System.Drawing.Point(94, 391);
            this.dgtablaDatos.Name = "dgtablaDatos";
            this.dgtablaDatos.Size = new System.Drawing.Size(639, 243);
            this.dgtablaDatos.TabIndex = 16;
            this.dgtablaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtablaDatos_CellContentClick);
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // tsEditUser
            // 
            this.tsEditUser.AutoSize = false;
            this.tsEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditUser.Enabled = false;
            this.tsEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsEditUser.Image")));
            this.tsEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditUser.Margin = new System.Windows.Forms.Padding(6);
            this.tsEditUser.Name = "tsEditUser";
            this.tsEditUser.Padding = new System.Windows.Forms.Padding(2);
            this.tsEditUser.Size = new System.Drawing.Size(94, 94);
            this.tsEditUser.Text = "toolStripButton4";
            this.tsEditUser.ToolTipText = "Editar Estudiante";
            this.tsEditUser.Click += new System.EventHandler(this.tsEditUser_Click);
            // 
            // tsAddUser
            // 
            this.tsAddUser.AutoSize = false;
            this.tsAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsAddUser.Image")));
            this.tsAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddUser.Margin = new System.Windows.Forms.Padding(6);
            this.tsAddUser.Name = "tsAddUser";
            this.tsAddUser.Padding = new System.Windows.Forms.Padding(2);
            this.tsAddUser.Size = new System.Drawing.Size(94, 94);
            this.tsAddUser.Text = "toolStripButton2";
            this.tsAddUser.ToolTipText = "Agregar estudiante";
            this.tsAddUser.Click += new System.EventHandler(this.tsAddUser_Click);
            // 
            // tsOpenFile
            // 
            this.tsOpenFile.AutoSize = false;
            this.tsOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsOpenFile.Image")));
            this.tsOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenFile.Margin = new System.Windows.Forms.Padding(6);
            this.tsOpenFile.Name = "tsOpenFile";
            this.tsOpenFile.Padding = new System.Windows.Forms.Padding(5);
            this.tsOpenFile.Size = new System.Drawing.Size(94, 94);
            this.tsOpenFile.Text = "toolStripButton1";
            this.tsOpenFile.ToolTipText = "Abre el archivo XML";
            this.tsOpenFile.Click += new System.EventHandler(this.tsOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 663);
            this.Controls.Add(this.dgtablaDatos);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtcodigoIn);
            this.Controls.Add(this.txtcorreoIn);
            this.Controls.Add(this.txtnombreIn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuIconos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculo Notas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuIconos.ResumeLayout(false);
            this.menuIconos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuIconos;
        private System.Windows.Forms.ToolStripButton tsSearchUser;
        private System.Windows.Forms.ToolStripButton tsDeleteUser;
        private System.Windows.Forms.ToolStripButton tsSaveFile;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombreIn;
        private System.Windows.Forms.TextBox txtcorreoIn;
        private System.Windows.Forms.TextBox txtcodigoIn;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.DataGridView dgtablaDatos;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.ToolStripButton tsOpenFile;
        private System.Windows.Forms.ToolStripButton tsAddUser;
        private System.Windows.Forms.ToolStripButton tsEditUser;
    }
}

