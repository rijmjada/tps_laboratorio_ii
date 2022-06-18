using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestProject
{
    [TestClass]
    public class Libro_Test
    {
        [TestMethod]

        public void LibrosDeberianSerEquals()
        {
            // Arrange
            Libro l1; 
            Libro l2;

            // Act
            l1  = new Libro(3050, 1, EOrigen.Nacional, 400, EGeneroLiterario.Historia, "Michael Foucault", "ludwig binswanger y el análisis existencial");
            l2  = new Libro(3100, 1, EOrigen.Importado, 400, EGeneroLiterario.Historia, "Michael Foucault", "ludwig binswanger y el análisis existencial");

            // Assert
            Assert.AreEqual(l1, l2);
        }
    }
}
