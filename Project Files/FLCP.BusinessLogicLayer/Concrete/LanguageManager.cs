using FLCP.BusinessLogicLayer.Abstract;
using FLCP.DataAccess.Abstract;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Concrete
{
    public class LanguageManager : ILanguageService
    {
        ILanguageDal _languageDal;
        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }
        public void Delete(int id)
        {
            _languageDal.Delete(id);
        }

        public IEnumerable<Language> GetAll()
        {
            return _languageDal.GetAll();
        }

        public List<LanguageDto> GetAllLanguages()
        {
            return _languageDal.GetAllLanguages();
        }

        public Language GetById(int id)
        {
            return _languageDal.GetById(id);
        }

        public void Insert(Language language)
        {
            _languageDal.Insert(language);
        }


        public void Update(Language language)
        {
            _languageDal.Update(language);
        }
    }
}
