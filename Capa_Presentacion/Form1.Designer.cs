namespace Capa_Presentacion
{
    partial class Form_Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Presentacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTopFormulario = new System.Windows.Forms.Panel();
            this.ExitPresentacion = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TextBuscar = new System.Windows.Forms.TextBox();
            this.BuscarContacto = new System.Windows.Forms.PictureBox();
            this.TablaContactos = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditarContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardarContacto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TextCode = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelTopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopFormulario
            // 
            this.PanelTopFormulario.BackColor = System.Drawing.Color.Teal;
            this.PanelTopFormulario.Controls.Add(this.ExitPresentacion);
            this.PanelTopFormulario.Controls.Add(this.bunifuCustomLabel1);
            this.PanelTopFormulario.Controls.Add(this.pictureBox1);
            this.PanelTopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopFormulario.Location = new System.Drawing.Point(0, 0);
            this.PanelTopFormulario.Name = "PanelTopFormulario";
            this.PanelTopFormulario.Size = new System.Drawing.Size(800, 86);
            this.PanelTopFormulario.TabIndex = 0;
            // 
            // ExitPresentacion
            // 
            this.ExitPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("ExitPresentacion.Image")));
            this.ExitPresentacion.Location = new System.Drawing.Point(712, 12);
            this.ExitPresentacion.Name = "ExitPresentacion";
            this.ExitPresentacion.Size = new System.Drawing.Size(64, 64);
            this.ExitPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitPresentacion.TabIndex = 3;
            this.ExitPresentacion.TabStop = false;
            this.ExitPresentacion.Click += new System.EventHandler(this.ExitPresentacion_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(95, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(160, 33);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Contactos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.PanelTopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // TextBuscar
            // 
            this.TextBuscar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBuscar.Location = new System.Drawing.Point(77, 117);
            this.TextBuscar.Multiline = true;
            this.TextBuscar.Name = "TextBuscar";
            this.TextBuscar.Size = new System.Drawing.Size(398, 48);
            this.TextBuscar.TabIndex = 1;
            this.TextBuscar.TextChanged += new System.EventHandler(this.TextBuscar_TextChanged);
            // 
            // BuscarContacto
            // 
            this.BuscarContacto.BackColor = System.Drawing.Color.Teal;
            this.BuscarContacto.Image = ((System.Drawing.Image)(resources.GetObject("BuscarContacto.Image")));
            this.BuscarContacto.Location = new System.Drawing.Point(30, 117);
            this.BuscarContacto.Name = "BuscarContacto";
            this.BuscarContacto.Size = new System.Drawing.Size(48, 48);
            this.BuscarContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BuscarContacto.TabIndex = 4;
            this.BuscarContacto.TabStop = false;
            // 
            // TablaContactos
            // 
            this.TablaContactos.AllowUserToAddRows = false;
            this.TablaContactos.AllowUserToDeleteRows = false;
            this.TablaContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaContactos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaContactos.BackgroundColor = System.Drawing.Color.White;
            this.TablaContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TablaContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaContactos.ColumnHeadersVisible = false;
            this.TablaContactos.Location = new System.Drawing.Point(30, 238);
            this.TablaContactos.Name = "TablaContactos";
            this.TablaContactos.ReadOnly = true;
            this.TablaContactos.RowHeadersVisible = false;
            this.TablaContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaContactos.Size = new System.Drawing.Size(476, 202);
            this.TablaContactos.TabIndex = 5;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(35, 199);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(84, 24);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Código";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(163, 197);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(92, 24);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Nombre";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(302, 199);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(94, 24);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Apellido";
            // 
            // btnAddContacto
            // 
            this.btnAddContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnAddContacto.BackColor = System.Drawing.Color.Teal;
            this.btnAddContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddContacto.BorderRadius = 7;
            this.btnAddContacto.ButtonText = "Agregar Contacto";
            this.btnAddContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddContacto.Iconimage")));
            this.btnAddContacto.Iconimage_right = null;
            this.btnAddContacto.Iconimage_right_Selected = null;
            this.btnAddContacto.Iconimage_Selected = null;
            this.btnAddContacto.IconMarginLeft = 0;
            this.btnAddContacto.IconMarginRight = 0;
            this.btnAddContacto.IconRightVisible = true;
            this.btnAddContacto.IconRightZoom = 0D;
            this.btnAddContacto.IconVisible = true;
            this.btnAddContacto.IconZoom = 90D;
            this.btnAddContacto.IsTab = false;
            this.btnAddContacto.Location = new System.Drawing.Point(30, 459);
            this.btnAddContacto.Name = "btnAddContacto";
            this.btnAddContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnAddContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddContacto.selected = false;
            this.btnAddContacto.Size = new System.Drawing.Size(171, 48);
            this.btnAddContacto.TabIndex = 8;
            this.btnAddContacto.Text = "Agregar Contacto";
            this.btnAddContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContacto.Textcolor = System.Drawing.Color.White;
            this.btnAddContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContacto.Click += new System.EventHandler(this.btnAddContacto_Click);
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnEditarContacto.BackColor = System.Drawing.Color.Teal;
            this.btnEditarContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarContacto.BorderRadius = 7;
            this.btnEditarContacto.ButtonText = "Editar Contacto";
            this.btnEditarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditarContacto.Iconimage")));
            this.btnEditarContacto.Iconimage_right = null;
            this.btnEditarContacto.Iconimage_right_Selected = null;
            this.btnEditarContacto.Iconimage_Selected = null;
            this.btnEditarContacto.IconMarginLeft = 0;
            this.btnEditarContacto.IconMarginRight = 0;
            this.btnEditarContacto.IconRightVisible = true;
            this.btnEditarContacto.IconRightZoom = 0D;
            this.btnEditarContacto.IconVisible = true;
            this.btnEditarContacto.IconZoom = 90D;
            this.btnEditarContacto.IsTab = false;
            this.btnEditarContacto.Location = new System.Drawing.Point(223, 459);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnEditarContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnEditarContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarContacto.selected = false;
            this.btnEditarContacto.Size = new System.Drawing.Size(162, 48);
            this.btnEditarContacto.TabIndex = 9;
            this.btnEditarContacto.Text = "Editar Contacto";
            this.btnEditarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarContacto.Textcolor = System.Drawing.Color.White;
            this.btnEditarContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarContacto.BorderRadius = 7;
            this.btnEliminarContacto.ButtonText = "Eliminar Contacto";
            this.btnEliminarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarContacto.Iconimage")));
            this.btnEliminarContacto.Iconimage_right = null;
            this.btnEliminarContacto.Iconimage_right_Selected = null;
            this.btnEliminarContacto.Iconimage_Selected = null;
            this.btnEliminarContacto.IconMarginLeft = 0;
            this.btnEliminarContacto.IconMarginRight = 0;
            this.btnEliminarContacto.IconRightVisible = true;
            this.btnEliminarContacto.IconRightZoom = 0D;
            this.btnEliminarContacto.IconVisible = true;
            this.btnEliminarContacto.IconZoom = 90D;
            this.btnEliminarContacto.IsTab = false;
            this.btnEliminarContacto.Location = new System.Drawing.Point(403, 459);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnEliminarContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarContacto.selected = false;
            this.btnEliminarContacto.Size = new System.Drawing.Size(171, 48);
            this.btnEliminarContacto.TabIndex = 10;
            this.btnEliminarContacto.Text = "Eliminar Contacto";
            this.btnEliminarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarContacto.Textcolor = System.Drawing.Color.White;
            this.btnEliminarContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnGuardarContacto
            // 
            this.btnGuardarContacto.Activecolor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarContacto.BorderRadius = 7;
            this.btnGuardarContacto.ButtonText = "Guardar Contacto";
            this.btnGuardarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarContacto.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarContacto.Enabled = false;
            this.btnGuardarContacto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarContacto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarContacto.Iconimage")));
            this.btnGuardarContacto.Iconimage_right = null;
            this.btnGuardarContacto.Iconimage_right_Selected = null;
            this.btnGuardarContacto.Iconimage_Selected = null;
            this.btnGuardarContacto.IconMarginLeft = 0;
            this.btnGuardarContacto.IconMarginRight = 0;
            this.btnGuardarContacto.IconRightVisible = true;
            this.btnGuardarContacto.IconRightZoom = 0D;
            this.btnGuardarContacto.IconVisible = true;
            this.btnGuardarContacto.IconZoom = 90D;
            this.btnGuardarContacto.IsTab = false;
            this.btnGuardarContacto.Location = new System.Drawing.Point(596, 459);
            this.btnGuardarContacto.Name = "btnGuardarContacto";
            this.btnGuardarContacto.Normalcolor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.OnHovercolor = System.Drawing.Color.Teal;
            this.btnGuardarContacto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarContacto.selected = false;
            this.btnGuardarContacto.Size = new System.Drawing.Size(171, 48);
            this.btnGuardarContacto.TabIndex = 11;
            this.btnGuardarContacto.Text = "Guardar Contacto";
            this.btnGuardarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarContacto.Textcolor = System.Drawing.Color.White;
            this.btnGuardarContacto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarContacto.Click += new System.EventHandler(this.btnGuardarContacto_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Activecolor = System.Drawing.Color.Teal;
            this.btnImprimir.BackColor = System.Drawing.Color.Teal;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.BorderRadius = 7;
            this.btnImprimir.ButtonText = " Imprimir";
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Iconimage")));
            this.btnImprimir.Iconimage_right = null;
            this.btnImprimir.Iconimage_right_Selected = null;
            this.btnImprimir.Iconimage_Selected = null;
            this.btnImprimir.IconMarginLeft = 0;
            this.btnImprimir.IconMarginRight = 0;
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconRightZoom = 0D;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.IconZoom = 90D;
            this.btnImprimir.IsTab = false;
            this.btnImprimir.Location = new System.Drawing.Point(508, 105);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Normalcolor = System.Drawing.Color.Teal;
            this.btnImprimir.OnHovercolor = System.Drawing.Color.Teal;
            this.btnImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimir.selected = false;
            this.btnImprimir.Size = new System.Drawing.Size(134, 62);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = " Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Textcolor = System.Drawing.Color.White;
            this.btnImprimir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.Teal;
            this.btnExcel.BackColor = System.Drawing.Color.Teal;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.BorderRadius = 7;
            this.btnExcel.ButtonText = "Excel";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExcel.Iconimage")));
            this.btnExcel.Iconimage_right = null;
            this.btnExcel.Iconimage_right_Selected = null;
            this.btnExcel.Iconimage_Selected = null;
            this.btnExcel.IconMarginLeft = 0;
            this.btnExcel.IconMarginRight = 0;
            this.btnExcel.IconRightVisible = true;
            this.btnExcel.IconRightZoom = 0D;
            this.btnExcel.IconVisible = true;
            this.btnExcel.IconZoom = 90D;
            this.btnExcel.IsTab = false;
            this.btnExcel.Location = new System.Drawing.Point(648, 105);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Normalcolor = System.Drawing.Color.Teal;
            this.btnExcel.OnHovercolor = System.Drawing.Color.Teal;
            this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcel.selected = false;
            this.btnExcel.Size = new System.Drawing.Size(110, 60);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // TextCode
            // 
            this.TextCode.Enabled = false;
            this.TextCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCode.Location = new System.Drawing.Point(537, 226);
            this.TextCode.Multiline = true;
            this.TextCode.Name = "TextCode";
            this.TextCode.Size = new System.Drawing.Size(239, 30);
            this.TextCode.TabIndex = 14;
            // 
            // TextNombre
            // 
            this.TextNombre.Enabled = false;
            this.TextNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNombre.Location = new System.Drawing.Point(537, 305);
            this.TextNombre.Multiline = true;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(239, 28);
            this.TextNombre.TabIndex = 15;
            // 
            // TextApellido
            // 
            this.TextApellido.Enabled = false;
            this.TextApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextApellido.Location = new System.Drawing.Point(537, 385);
            this.TextApellido.Multiline = true;
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(239, 30);
            this.TextApellido.TabIndex = 16;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(533, 199);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(75, 22);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "Código";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(533, 278);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(83, 22);
            this.bunifuCustomLabel6.TabIndex = 18;
            this.bunifuCustomLabel6.Text = "Nombre";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(533, 358);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(85, 22);
            this.bunifuCustomLabel7.TabIndex = 19;
            this.bunifuCustomLabel7.Text = "Apellido";
            // 
            // Form_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.TextApellido);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TextCode);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardarContacto);
            this.Controls.Add(this.btnEliminarContacto);
            this.Controls.Add(this.btnEditarContacto);
            this.Controls.Add(this.btnAddContacto);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.TablaContactos);
            this.Controls.Add(this.BuscarContacto);
            this.Controls.Add(this.TextBuscar);
            this.Controls.Add(this.PanelTopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Presentacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Presentacion_Load);
            this.PanelTopFormulario.ResumeLayout(false);
            this.PanelTopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ExitPresentacion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private System.Windows.Forms.TextBox TextBuscar;
        private System.Windows.Forms.PictureBox BuscarContacto;
        private System.Windows.Forms.DataGridView TablaContactos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddContacto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarContacto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarContacto;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarContacto;
        private Bunifu.Framework.UI.BunifuFlatButton btnImprimir;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private System.Windows.Forms.TextBox TextCode;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}

