using GestionLivres.Datas;
using GestionLivres.Entities;
using GestionLivres.Repository.Autors;
using GestionLivres.Repository.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace TestProject.Repository
{
    [TestClass]
    public class CategorieRepositoryTest
    {
        [TestMethod]
        public void GetAllCategorie_ReturnsAllCategories()
        {
            // Arrange
            var categories = new List<Categorie>
            {
                new Categorie { CategorieId = 1, libelle = "Category 1" },
                new Categorie { CategorieId = 2, libelle = "Category 2" },
                // Add more categories as needed
            };

            var mockContext = new Mock<ApplicationsContext>();
            mockContext.Setup(c => c.Categories).Returns(categories);

            var repository = new CategorieRepository(mockContext.Object);

            // Act
            var result = repository.GetAllCategorie();

            // Assert
            Assert.AreEqual(categories.Count, result.Count());
            Assert.IsTrue(result.All(c => categories.Any(expected => expected.CategorieId == c.CategorieId && expected.libelle == c.libelle)));
        }

    }
}
