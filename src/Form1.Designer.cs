using Paintufla.src;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace Paintufla
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.comboBoxAncho = new System.Windows.Forms.ComboBox();
            this.groupBoxHerramientas = new System.Windows.Forms.GroupBox();
            this.panelColorActual = new System.Windows.Forms.Panel();
            this.tiraColores = new System.Windows.Forms.Panel();
            this.panelColor9 = new System.Windows.Forms.Panel();
            this.panelColor8 = new System.Windows.Forms.Panel();
            this.panelColor7 = new System.Windows.Forms.Panel();
            this.panelColor6 = new System.Windows.Forms.Panel();
            this.panelColor5 = new System.Windows.Forms.Panel();
            this.panelColor4 = new System.Windows.Forms.Panel();
            this.panelColor3 = new System.Windows.Forms.Panel();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.buttonColorNuevo = new System.Windows.Forms.Button();
            this.labelAncho = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.groupBoxHerramientas.SuspendLayout();
            this.tiraColores.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.verToolStripMenuItem,
            this.imagenToolStripMenuItem,
            this.coloresToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItemClick);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItemClick);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItemClick);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItemClick);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItemClick);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.coloresToolStripMenuItem.Text = "Colores";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // fondo
            // 
            this.fondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fondo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fondo.BackgroundImage = global::Paintufla.Properties.Resources.estre;
            this.fondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fondo.Location = new System.Drawing.Point(10, 33);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(722, 290);
            this.fondo.TabIndex = 1;
            this.fondo.TabStop = false;
            this.fondo.Click += new System.EventHandler(this.fondo_Click);
            this.fondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fondoMouseDown);
            this.fondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fondoMouseMove);
            this.fondo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fondoMouseUp);
            // 
            // comboBoxAncho
            // 
            this.comboBoxAncho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAncho.FormattingEnabled = true;
            this.comboBoxAncho.Location = new System.Drawing.Point(99, 19);
            this.comboBoxAncho.Name = "comboBoxAncho";
            this.comboBoxAncho.Size = new System.Drawing.Size(51, 21);
            this.comboBoxAncho.TabIndex = 5;
            this.comboBoxAncho.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnchoSelectedIndexChanged);
            // 
            // groupBoxHerramientas
            // 
            this.groupBoxHerramientas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHerramientas.Controls.Add(this.panelColorActual);
            this.groupBoxHerramientas.Controls.Add(this.tiraColores);
            this.groupBoxHerramientas.Controls.Add(this.labelAncho);
            this.groupBoxHerramientas.Controls.Add(this.comboBoxAncho);
            this.groupBoxHerramientas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxHerramientas.Location = new System.Drawing.Point(10, 329);
            this.groupBoxHerramientas.Name = "groupBoxHerramientas";
            this.groupBoxHerramientas.Size = new System.Drawing.Size(722, 50);
            this.groupBoxHerramientas.TabIndex = 7;
            this.groupBoxHerramientas.TabStop = false;
            this.groupBoxHerramientas.Text = "Cosas";
            // 
            // panelColorActual
            // 
            this.panelColorActual.BackColor = System.Drawing.Color.Red;
            this.panelColorActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColorActual.Location = new System.Drawing.Point(359, 21);
            this.panelColorActual.Name = "panelColorActual";
            this.panelColorActual.Size = new System.Drawing.Size(18, 18);
            this.panelColorActual.TabIndex = 17;
            // 
            // tiraColores
            // 
            this.tiraColores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiraColores.Controls.Add(this.panelColor9);
            this.tiraColores.Controls.Add(this.panelColor8);
            this.tiraColores.Controls.Add(this.panelColor7);
            this.tiraColores.Controls.Add(this.panelColor6);
            this.tiraColores.Controls.Add(this.panelColor5);
            this.tiraColores.Controls.Add(this.panelColor4);
            this.tiraColores.Controls.Add(this.panelColor3);
            this.tiraColores.Controls.Add(this.panelColor2);
            this.tiraColores.Controls.Add(this.panelColor1);
            this.tiraColores.Controls.Add(this.buttonColorNuevo);
            this.tiraColores.Location = new System.Drawing.Point(170, 20);
            this.tiraColores.Name = "tiraColores";
            this.tiraColores.Size = new System.Drawing.Size(182, 20);
            this.tiraColores.TabIndex = 8;
            // 
            // panelColor9
            // 
            this.panelColor9.BackColor = System.Drawing.Color.White;
            this.panelColor9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor9.Location = new System.Drawing.Point(144, 0);
            this.panelColor9.Name = "panelColor9";
            this.panelColor9.Size = new System.Drawing.Size(18, 18);
            this.panelColor9.TabIndex = 16;
            this.panelColor9.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor8
            // 
            this.panelColor8.BackColor = System.Drawing.Color.Black;
            this.panelColor8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor8.Location = new System.Drawing.Point(126, 0);
            this.panelColor8.Name = "panelColor8";
            this.panelColor8.Size = new System.Drawing.Size(18, 18);
            this.panelColor8.TabIndex = 15;
            this.panelColor8.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor7
            // 
            this.panelColor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelColor7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor7.Location = new System.Drawing.Point(108, 0);
            this.panelColor7.Name = "panelColor7";
            this.panelColor7.Size = new System.Drawing.Size(18, 18);
            this.panelColor7.TabIndex = 14;
            this.panelColor7.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor6
            // 
            this.panelColor6.BackColor = System.Drawing.Color.Fuchsia;
            this.panelColor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor6.Location = new System.Drawing.Point(90, 0);
            this.panelColor6.Name = "panelColor6";
            this.panelColor6.Size = new System.Drawing.Size(18, 18);
            this.panelColor6.TabIndex = 13;
            this.panelColor6.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor5
            // 
            this.panelColor5.BackColor = System.Drawing.Color.Blue;
            this.panelColor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor5.Location = new System.Drawing.Point(72, 0);
            this.panelColor5.Name = "panelColor5";
            this.panelColor5.Size = new System.Drawing.Size(18, 18);
            this.panelColor5.TabIndex = 12;
            this.panelColor5.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor4
            // 
            this.panelColor4.BackColor = System.Drawing.Color.Cyan;
            this.panelColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor4.Location = new System.Drawing.Point(54, 0);
            this.panelColor4.Name = "panelColor4";
            this.panelColor4.Size = new System.Drawing.Size(18, 18);
            this.panelColor4.TabIndex = 11;
            this.panelColor4.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor3
            // 
            this.panelColor3.BackColor = System.Drawing.Color.Lime;
            this.panelColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor3.Location = new System.Drawing.Point(36, 0);
            this.panelColor3.Name = "panelColor3";
            this.panelColor3.Size = new System.Drawing.Size(18, 18);
            this.panelColor3.TabIndex = 10;
            this.panelColor3.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.Yellow;
            this.panelColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor2.Location = new System.Drawing.Point(18, 0);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(18, 18);
            this.panelColor2.TabIndex = 9;
            this.panelColor2.Click += new System.EventHandler(this.panelColorClick);
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.Color.Red;
            this.panelColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor1.Location = new System.Drawing.Point(0, 0);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(18, 18);
            this.panelColor1.TabIndex = 8;
            this.panelColor1.Click += new System.EventHandler(this.panelColorClick);
            // 
            // buttonColorNuevo
            // 
            this.buttonColorNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorNuevo.ForeColor = System.Drawing.Color.Black;
            this.buttonColorNuevo.Location = new System.Drawing.Point(162, 0);
            this.buttonColorNuevo.Name = "buttonColorNuevo";
            this.buttonColorNuevo.Size = new System.Drawing.Size(18, 18);
            this.buttonColorNuevo.TabIndex = 8;
            this.buttonColorNuevo.Text = "+";
            this.buttonColorNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonColorNuevo.UseCompatibleTextRendering = true;
            this.buttonColorNuevo.UseVisualStyleBackColor = true;
            this.buttonColorNuevo.Click += new System.EventHandler(this.buttonColorNuevoClick);
            // 
            // labelAncho
            // 
            this.labelAncho.Location = new System.Drawing.Point(19, 19);
            this.labelAncho.Name = "labelAncho";
            this.labelAncho.Size = new System.Drawing.Size(74, 21);
            this.labelAncho.TabIndex = 7;
            this.labelAncho.Text = "Ancho Pincel";
            this.labelAncho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Portable Network Graphics (PNG)|*.png";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckPathExists = false;
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.Filter = "Portable Network Graphics (PNG)|*.png";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(742, 388);
            this.Controls.Add(this.groupBoxHerramientas);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Paintufla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainFormFormClosing);
            this.Load += new System.EventHandler(this.mainFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainFormKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.groupBoxHerramientas.ResumeLayout(false);
            this.tiraColores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        
    }
}

