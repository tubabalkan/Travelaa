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
    public class GaleriManager : IGaleriService
    {
        private readonly IGaleriDal _galeriDal;

        public GaleriManager(IGaleriDal galeriDal)
        {
            _galeriDal = galeriDal;
        }

        public void TDelete(int id)
        {
            _galeriDal.Delete(id);
        }

        public Galeri TGetById(int id)
        {
           return _galeriDal.GetById(id);
        }

        public List<Galeri> TGetListAll()
        {
            return _galeriDal.GetListAll();
        }

        public void TInsert(Galeri entity)
        {
            _galeriDal.Insert(entity);
        }

        public void TUpdate(Galeri entity)
        {
            _galeriDal.Update(entity);
        }
    }
}
