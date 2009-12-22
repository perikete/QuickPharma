using NHibernate.Cfg;
using System;
using System.Reflection;
using NHibernate;

namespace QuickPharma.Infrastructure.NHibernate
{
    public static class NHibernateHelper
    {
        private static ISession _session = null;
        private static Configuration _cfg = null;
        
        public static void Configure(string pathToConfig, Assembly assembly)
        { 
            _cfg = new Configuration();
            _cfg.AddAssembly(assembly);
            _cfg.Configure(pathToConfig);
        }

        public static ISession GetSession()
        {
            _session = _cfg.BuildSessionFactory().OpenSession();
            return _session;
        }
    }
}
