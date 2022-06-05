using System;
using System.Text;

namespace Entidades
{
    public class Libro : Producto
    {
        #region Atributos
        private string autor;
        private string titulo;
        private int paginas;
        private EGeneroLiterario genero;
        #endregion

        #region Propiedades
        public int Paginas { get => paginas; set => paginas = value; }
        public string Autor { get => autor; set => autor = value; }
        public EGeneroLiterario Genero { get => genero; set => genero = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        #endregion

        #region Constructores
        public Libro()
        {
        }
        public Libro(double precio, int codigo, EOrigen origen, int paginas, EGeneroLiterario genero, string autor, string titulo)
            : base(precio, codigo, origen)
        {
            this.Paginas = paginas;
            this.Genero = genero;
            this.Autor = autor;
            this.Titulo = titulo;
        }
        #endregion

        #region SobreCargas
        public static bool operator ==(Libro a, Libro b)
        {
            return ((Producto)a) == ((Producto)b) &&
                a.Titulo == b.Titulo &&
                a.Autor == b.Autor &&
                a.Genero == b.Genero &&
                a.Paginas == b.Paginas;
        }
        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
        #endregion

        #region SobreEscrituras
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine("Tipo: Libro");
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine($"Paginas: {this.Paginas}");
            sb.AppendLine($"Genero: {this.Genero}");
            sb.AppendLine($"Autor: {this.Autor}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is not null && (obj as Libro) == this;
        }
        #endregion
    }
}
