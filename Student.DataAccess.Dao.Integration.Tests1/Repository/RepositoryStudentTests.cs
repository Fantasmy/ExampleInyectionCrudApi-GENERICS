using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student.Business.Logi.Modules;
using Student.DataAccess.Dao.Contracts;
using Student.DataAccess.Dao.Integration.Tests1.Utils;
using Student.DataAccess.Dao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccess.Dao.Repository.Integration.Tests
{
    [TestClass()]
    public class RepositoryStudentTests :
        IoCSupportedTest<BusinessLogicModule>
    {
        private IRepository repositoryStoreProcedureStudent;

        [TestInitialize()]
        public void Setup()
        {
            this.repositoryStoreProcedureStudent = Resolve<IRepository>();
        }

        [TestMethod()]
        public void RepositoryStudentTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddAlumnoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.IsTrue(4 == 4);
            Assert.IsNotNull(repositoryStoreProcedureStudent);
        }

        [TestCleanup()]
        public void TearDown()
        {
            repositoryStoreProcedureStudent = null;
            ShutdownIoC();
        }

        [TestMethod()]
        public void RemoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}