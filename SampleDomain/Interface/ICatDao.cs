using SampleDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDomain.Interface
{
    public interface ICatDao
    {
        long SaveCat(Cat cat);
        long SaveCatWithWrongValue(Cat cat);
        Cat GetCatById(long id);
        
    }
}
