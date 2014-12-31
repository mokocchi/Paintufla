using Paintufla.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Paintufla
{
    public partial class MainForm : Form
    {
        #region variables logicas
        private Dibujador pincel;
        private List<Point> lineaActual;
        private bool pinta = false;
        private bool cambio = false;
        private int x = 20;
        private int y = 20;
        private string filename;
        private FileStream stream;
        #endregion
        #region variables_form
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem imagenToolStripMenuItem;
        private ToolStripMenuItem coloresToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private PictureBox fondo;
        private GroupBox groupBoxHerramientas;
        private Label labelAncho;
        private ComboBox comboBoxAncho;
        private Panel tiraColores;
        private Panel panelColor1;
        private Panel panelColor9;
        private Panel panelColor2;
        private Panel panelColor3;
        private Panel panelColor4;
        private Panel panelColor5;
        private Panel panelColor6;
        private Panel panelColor7;
        private Panel panelColor8;
        private Button buttonColorNuevo;
        private Panel panelColorActual;
        // no visibles
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        #endregion

        // Methods
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void mainFormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Add:
                    this.pincel.Ancho++;
                    break;

                case Keys.Subtract:
                    if (this.pincel.Ancho > 1)
                    {
                        this.pincel.Ancho--;
                    }
                    break;

                case Keys.Oemplus:
                    this.pincel.Ancho++;
                    break;

                case Keys.OemMinus:
                    if (this.pincel.Ancho > 1)
                    {
                        this.pincel.Ancho--;
                    }
                    break;
            }
        }

        private void mainFormLoad(object sender, EventArgs e)
        {
            this.fondo.Image = new Bitmap(this.fondo.Width, this.fondo.Height);
            this.pincel = new Dibujador(this.fondo.Image as Bitmap, Color.Black, 2);
            for (int i = 1; i <= 5; i++)
            {
                this.comboBoxAncho.Items.Add(i);
            }
            this.comboBoxAncho.SelectedIndex = 1;
            this.panelColorActual.BackColor = Color.Black;
            hojaNueva();
        }

        private void hojaNueva()
        {
            this.pincel.Color = Color.White;
            this.pincel.Ancho = 2;
            this.pincel.Hoja = this.fondo.Image as Bitmap;
            using (Bitmap rec = this.pincel.crearRectangulo(this.fondo.Image.Size, true))
            {
                this.pincel.pegarDibujo(rec, new Point(0));
            }
            this.pincel.Color = Color.Black;

        }

        private void panelColorClick(object sender, EventArgs e)
        {
            this.pincel.Color = (sender as Panel).BackColor;
            this.panelColorActual.BackColor = (sender as Panel).BackColor;
        }

        private void fondoMouseDown(object sender, MouseEventArgs e)
        {
            this.pinta = true;
            this.lineaActual = new List<Point>();
            this.x = this.fondo.PointToClient(Control.MousePosition).X;
            this.y = this.fondo.PointToClient(Control.MousePosition).Y;
            this.lineaActual.Add(new Point(this.x, this.y));
        }

        private void fondoMouseUp(object sender, MouseEventArgs e)
        {
            this.pinta = false;
            this.x = this.fondo.PointToClient(Control.MousePosition).X;
            this.y = this.fondo.PointToClient(Control.MousePosition).Y;
            this.lineaActual.Add(new Point(this.x, this.y));
        }

        private void comboBoxAnchoSelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                this.pincel.Ancho = (int)(sender as ComboBox).SelectedItem;
        }

        private void buttonColorNuevoClick(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.pincel.Color = this.colorDialog1.Color;
                this.panelColorActual.BackColor = this.colorDialog1.Color;
            }
        }

        private void nuevoToolStripMenuItemClick(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.No;
            if (this.cambio)
            {
                res = confirmarGuardar();
            }
            if (res != DialogResult.Cancel)
            {
                this.fondo.Image.Dispose();
                this.fondo.Image = new Bitmap(this.fondo.Width, this.fondo.Height);
                hojaNueva();
                this.filename = null;
                this.cambio = false;
            }
        }

        private void guardarComoToolStripMenuItemClick(object sender, EventArgs e)
        {
            guardarComo();
        }

        private void guardarComo()
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filename = this.saveFileDialog1.FileName;
                this.fondo.Image.Save(this.filename, System.Drawing.Imaging.ImageFormat.Png);
                this.cambio = false;
            }
        }

        private void mainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cambio)
            {
                DialogResult res = confirmarGuardar();
                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void guardarToolStripMenuItemClick(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            this.fondo.Image.Save(this.filename, System.Drawing.Imaging.ImageFormat.Png);
            this.cambio = false;
        }

        private void archivoToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.guardarToolStripMenuItem.Enabled = (filename != null && this.cambio);
        }

        private void abrirToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.cambio)
                {
                    DialogResult res = confirmarGuardar();
                    if (res != DialogResult.Cancel)
                    {
                        abrir();
                    }
                }
                else
                {
                    abrir();
                }
            }
        }

        private System.Windows.Forms.DialogResult confirmarGuardar()
        {
            DialogResult res = MessageBox.Show("¿Desea guardar los cambios?", "Paintufla", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                if (this.filename != null)
                {
                    guardar();
                }
                else
                {
                    guardarComo();
                }
            }
            return res;
        }

        private void abrir()
        {
            this.filename = this.openFileDialog1.FileName;
            this.stream = new FileStream(this.filename, FileMode.Open, FileAccess.Read);
            this.fondo.Image = new Bitmap(this.stream);
            this.stream.Close();
            this.fondo.Image.Save(Path.GetTempFileName());
            this.pincel.Hoja = this.fondo.Image as Bitmap;
            this.comboBoxAncho.SelectedIndex = 1;
            this.panelColorActual.BackColor = Color.Black;
            this.cambio = false;
        }

        private void fondoMouseMove(object sender, MouseEventArgs e)
        {
            if (this.pinta)
            {
                this.x = this.fondo.PointToClient(Control.MousePosition).X;
                this.y = this.fondo.PointToClient(Control.MousePosition).Y;
                this.lineaActual.Add(new Point(this.x, this.y));
                using (Bitmap bmp = this.pincel.crearLinea(this.lineaActual.ToArray(), new Size(this.fondo.Width, this.fondo.Height)))
                {
                    this.pincel.pegarDibujo(bmp, new Point(0));
                };
                cambio = true;
            }
            this.fondo.Refresh();
        }
    }
}
