using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travelaa.BusinessLayer.Abstract;
using Travelaa.DataAccessLayer.Abstract;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public int TAdminCount()
        {
           return _adminDal.AdminCount();
        }

        public void TDelete(int id)
        {
            _adminDal.Delete(id);
        }

        public Admin TGetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> TGetListAll()
        {
            return _adminDal.GetListAll();
        }

        public void TInsert(Admin entity)
        {
            _adminDal.Insert(entity);
        }

        public void TUpdate(Admin entity)
        {
            _adminDal.Update(entity);
        }
    }
}
