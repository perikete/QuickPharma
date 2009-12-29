using NHibernate.Cfg;
using System.Reflection;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Data;
using System.IO;

namespace QuickPharma.Infrastructure.NHibernate
{
    public static class NHibernateHelper
    {
        private static ISession _session = null;
        private static ISessionFactory _sessionFactory = null;
        private static Configuration _cfg = null;
        
        public static void Configure(string pathToConfig, Assembly mappingsAssembly)
        { 
            _cfg = new Configuration();
            _cfg.Configure(pathToConfig);
            _cfg.AddAssembly(mappingsAssembly);
            _cfg.BuildMappings();
            _sessionFactory = _cfg.BuildSessionFactory();
        }

        public static void CreateSchema()
        {
            var sw = new StringWriter();
            IDbConnection connection = CreateSession().Connection;
            new SchemaExport(_cfg).Execute(true, true, false, connection, sw);
            sw.Flush();            
        }

        public static void DropSchema()
        {
            IDbConnection connection = CreateSession().Connection;
            new SchemaExport(_cfg).Execute(true, true, true, connection, null);
        }

        public static ISession CreateSession()
        {
            return _sessionFactory.OpenSession();
        }        
    }
}
