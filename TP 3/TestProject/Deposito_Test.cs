using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestProject
{
    [TestClass]
    public class Deposito_Test
    {
        [TestMethod]
        public void NoDeberiaDejarAgregarElUltimoLibro()
        {
            // Arrange
            Deposito<Libro> depo = new Deposito<Libro>(2);
            Libro l1 = new Libro(3050, 1, EOrigen.Importado, 400, EGeneroLiterario.Historia, "Michael Foucault", "ludwig binswanger y el análisis existencial");
            Libro l2 = new Libro(4000, 2, EOrigen.Importado, 400, EGeneroLiterario.Novela, "Eduardo Galeano","los hijos de los días");
            Libro l3 = new Libro(6050, 3, EOrigen.Importado, 400, EGeneroLiterario.Ciencias, "Stanislas Dehaene", "¿como aprendemos?");
            
            // Act
            depo.Agregar(l1);
            depo.Agregar(l2);

            // Assert
            Assert.IsFalse(depo.Agregar(l3));
        }

        [TestMethod]
        public void ElLibroNosePuedeRemoverPorqueNoestaEnElDeposito()
        {
            // Arrange
            Deposito<Libro> depo = new Deposito<Libro>(2);
            Libro l1 = new Libro(3050, 1, EOrigen.Importado, 400, EGeneroLiterario.Historia, "Michael Foucault", "ludwig binswanger y el análisis existencial");
            Libro l2 = new Libro(4000, 2, EOrigen.Importado, 400, EGeneroLiterario.Novela, "Eduardo Galeano", "los hijos de los días");

            // Act 
            depo.Agregar(l1);

            // Assert
            Assert.IsFalse(depo.Remover(l2));
        }
    }
}
