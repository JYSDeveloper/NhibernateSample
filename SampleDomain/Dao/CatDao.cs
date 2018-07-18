using NHibernate;
using SampleDomain.Entities;
using SampleDomain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDomain.Dao
{
    public class CatDao : ICatDao
    {
        public CatDao()
        {

        }
        public Cat GetCatById(long id)
        {
            ISession session = NhibernateHelper.GetSession();
            Cat result = session.Get<Cat>(id);
            return result;
        }

        public long SaveCat(Cat cat)
        {
            ISession session = NhibernateHelper.GetSession();
            session.Save(cat);
            session.Flush();
            return cat.Id.Value;
        }

        public long SaveCatWithWrongValue(Cat cat)
        {
            ISession session = NhibernateHelper.GetSession();
            session.Save(cat);
            cat.Name = "Wrong" + cat.Id;
            session.Flush();
            return cat.Id.Value;
        }
    }
}
