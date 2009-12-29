using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using QuickPharma.Core.Model;
using QuickPharma.Infrastructure.NHibernate.Repositories;

namespace QuickPharma.Infrastructure.NHibernate.Tests
{
    [TestClass]
    public class NHibernateRepositoryTests
    {
        [ClassInitialize]
        public static void SetUp(TestContext context)
        { 
            var ass = Assembly.GetAssembly(typeof(DrugRepository));
            NHibernateHelper.Configure("nhibernate.cfg.xml", ass);
            NHibernateHelper.CreateSchema();
        }         
        
        [TestMethod]
        public void Repository_Can_Add_Entity()
        {
            var labRepo = new LaboratoryRepository();
            var expectedName = "Test Lab";
            var lab = new Laboratory(expectedName);

            labRepo.Add(lab);

            var insertedLab = labRepo.GetAll().First();
            Assert.IsNotNull(insertedLab);
            Assert.AreEqual(expectedName, insertedLab.Name);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            NHibernateHelper.DropSchema();
        }
    }
}
