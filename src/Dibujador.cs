using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Paintufla.src
{
    /// <summary>
    /// Objeto para dibujar figuras sobre una hoja con un color fijo y tamaño variable.
    /// </summary>
    public class Dibujador
    {
        private Pen pen;
        private Bitmap hoja;
        public Color Color
        {
            get { return pen.Color; }
            set { pen.Color = value; }
        }
        public int Ancho
        {
            get { return (int)pen.Width; }
            set { pen.Width = value; }
        }

        /// <summary>
        /// Crea una instancia para dibujar en la hoja especificada, con un color y un ancho
        /// </summary>
        /// <param name="hoja">Imagen sobre la que se quiere trabajar</param>
        /// <param name="c">Color de este dibujador</param>
        /// <param name="anchoInicial">Ancho del trazo</param>
        public Dibujador(Bitmap hoja, Color c, float anchoInicial)
        {
            this.hoja = hoja;
            this.pen = new Pen(new SolidBrush(c), anchoInicial);
        }

        /// <summary>
        /// Crea un cuadrado
        /// </summary>
        /// <param name="lado">Longitud en pixeles</param>
        /// <param name="relleno">Si el cuadrado debe pintarse por dentro</param>
        /// <returns>un cuadrado para pegar en la hoja</returns>
        public Bitmap crearRectangulo(int lado, bool relleno)
        {
            return this.crearRectangulo(lado, lado, relleno);
        }

        /// <summary>
        /// Crea un rectangulo con el alto y ancho especificados
        /// </summary>
        /// <param name="ancho">Ancho del rectangulo</param>
        /// <param name="alto">Alto del rectangulo</param>
        /// <param name="relleno">Si el rectangulo debe pintarse por dentro</param>
        /// <returns>un rectangulo para pegar en la hoja</returns>
        public Bitmap crearRectangulo(int ancho, int alto, bool relleno)
        {
            Bitmap bmp = new Bitmap(ancho, alto);
            using (Graphics graf = Graphics.FromImage(bmp))
            {
                if (relleno)
                {
                    graf.FillRectangle(pen.Brush, 0, 0, ancho, alto);
                }
                else
                {
                    graf.DrawRectangle(pen, 0, 0, ancho, alto);
                }
            }
            return bmp;
        }

        /// <summary>
        /// Crea un rectangulo con las dimensiones especificadas
        /// </summary>
        /// <param name="dimensiones">Dimensiones del rectangulo</param>
        /// <param name="relleno">Si el rectangulo debe pintarse por dentro</param>
        /// <returns>un rectangulo para pegar en la hoja</returns>
        public Bitmap crearRectangulo(Size dimensiones, bool relleno)
        {
            return this.crearRectangulo(dimensiones.Width, dimensiones.Height, relleno);
        }

        /// <summary>
        /// Pega el dibujo provisto en la hoja a la cual pertenece el Dibujador, en la posicion especificada
        /// </summary>
        /// <param name="dibujo">Dibujo a pegar</param>
        /// <param name="posicion">Esquina superior izquierda del dibujo en la hoja</param>
        public void pegarDibujo(Bitmap dibujo, Point posicion)
        {
            using (Graphics graf = Graphics.FromImage(hoja))
            {
                graf.DrawImageUnscaled(dibujo, posicion);
            }
        }

    }
}
