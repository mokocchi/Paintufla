using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Paintufla
{
    public partial class MainForm : Form
    {

        private ToolStripMenuItem abrirToolStripMenuItem;
        private int ancho = 2;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private Button button2;
        private Color colorActual = Color.Black;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem coloresToolStripMenuItem;
        private ComboBox comboBox1;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private GroupBox groupBox1;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem imagenToolStripMenuItem;
        private Label label2;
        private Panel labelColorAct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private Panel panel1;
        private Panel panel10;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private PictureBox pictureBox1;
        private bool pinta = false;
        private Timer timer1;
        private Panel tiraColores;
        private ToolStripMenuItem verToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private int x = 20;
        private int y = 20;
        private string filename;
        private FileStream stream;
        private bool cambio = false;

        // Methods
        public MainForm()
        {
            this.InitializeComponent();
        }

        private bool enRango(int pX, int pY)
        {
            if (pX < 0)
            {
                return false;
            }
            if (pX >= this.pictureBox1.Width)
            {
                return false;
            }
            if (pY < 0)
            {
                return false;
            }
            if (pY >= this.pictureBox1.Height)
            {
                return false;
            }
            return true;
        }

        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Add:
                    this.ancho += 2;
                    break;

                case Keys.Subtract:
                    if (this.ancho >= 0)
                    {
                        this.ancho -= 2;
                    }
                    break;

                case Keys.Oemplus:
                    this.ancho += 2;
                    break;

                case Keys.OemMinus:
                    if (this.ancho >= 0)
                    {
                        this.ancho -= 2;
                    }
                    break;
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            this.pictureBox1.Image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            for (int i = 0; i <= 40; i++)
            {
                this.comboBox1.Items.Add(i);
            }
            this.comboBox1.SelectedIndex = 4;
            this.labelColorAct.BackColor = Color.Black;
        }

        private void Panel1Click(object sender, EventArgs e)
        {
            this.colorActual = (sender as Panel).BackColor;
            this.labelColorAct.BackColor = (sender as Panel).BackColor;
        }

        private void PictureBox1MouseDown(object sender, MouseEventArgs e)
        {
            this.pinta = true;
        }

        private void PictureBox1MouseUp(object sender, MouseEventArgs e)
        {
            this.pinta = false;
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            if (this.pinta)
            {
                this.x = this.pictureBox1.PointToClient(Control.MousePosition).X;
                this.y = this.pictureBox1.PointToClient(Control.MousePosition).Y;
                for (int i = 0; i < (this.ancho * this.ancho); i++)
                {
                    int pX = (this.x - (this.ancho / 2)) + (i / this.ancho);
                    int pY = (this.y - (this.ancho / 2)) + (i % this.ancho);
                    if (this.enRango(pX, pY))
                    {
                        (this.pictureBox1.Image as Bitmap).SetPixel(pX, pY, this.colorActual);
                        this.cambio = true;
                    }
                }
            }
            this.pictureBox1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                this.ancho = (int)(sender as ComboBox).SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                this.colorActual = this.colorDialog1.Color;
                this.labelColorAct.BackColor = this.colorDialog1.Color;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = confirmarGuardar();
            if (res != DialogResult.Cancel)
            {
                this.pictureBox1.Image.Dispose();
                this.pictureBox1.Image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
                this.filename = null;
                this.cambio = false;
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        private void guardarComo()
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filename = this.saveFileDialog1.FileName;
                this.pictureBox1.Image.Save(this.filename, System.Drawing.Imaging.ImageFormat.Png);
                this.cambio = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            this.pictureBox1.Image.Save(this.filename, System.Drawing.Imaging.ImageFormat.Png);
            this.cambio = false;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.guardarToolStripMenuItem.Enabled = (filename != null && this.cambio);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
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
            this.pictureBox1.Image = new Bitmap(this.stream);
            this.stream.Close();
            this.pictureBox1.Image.Save(Path.GetTempFileName());
            this.cambio = false;
        }
    }
}
