using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDomain
{
    public sealed class NhibernateHelper
    {
        private static readonly ISessionFactory _sessionFactory;

        static NhibernateHelper()
        {
            _sessionFactory = new Configuration().Configure().BuildSessionFactory();
        }        public static ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }        public static void CloseSession()
        {
            GetSession().Close();
        }        public static void CloseSessionFactory()
        {
            if(_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }
    }
}
