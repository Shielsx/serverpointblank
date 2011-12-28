using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TeamSystem.Data.UnitTesting;

namespace PointBlankServer.src.Services
{
    [TestClass()]
    public class DatabaseSetup
    {

        [AssemblyInitialize()]
        public static void IntializeAssembly(TestContext ctx)
        {
            //   Выполнить настройку базы данных тестирования, используя
            // файл конфигурации
            DatabaseTestClass.TestService.DeployDatabaseProject();
            DatabaseTestClass.TestService.GenerateData();
        }

    }
}
