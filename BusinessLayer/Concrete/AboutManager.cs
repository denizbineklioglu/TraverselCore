using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAbout2Service
    {
        IAbout2Dal _aboutDal;

        //Dependency Injection 
        public AboutManager(IAbout2Dal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About2 t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About2 t)
        {
            _aboutDal.Delete(t);
        }

        public About2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About2> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About2 t)
        {
            _aboutDal.Update(t);
        }
    }
}
