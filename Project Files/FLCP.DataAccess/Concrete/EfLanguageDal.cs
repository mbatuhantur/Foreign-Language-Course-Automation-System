using FLCP.DataAccess.Abstract;
using FLCP.DataAccess.Model;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Concrete
{
    public class EfLanguageDal : ILanguageDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedLanguage = context.Languages.Find(id);
                context.Languages.Remove(deletedLanguage);
                context.SaveChanges();
            }
        }

        public IEnumerable<Language> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<Language>().ToList();
            }
        }

        public List<LanguageDto> GetAllLanguages()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var languages = from c in context.Languages
                                select new LanguageDto()
                                {
                                    Id = c.Id,
                                    Name = c.Name
                                };
                return languages.ToList();
            }
        }
        public Language GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Languages.Find(id);
            }
        }

        public void Insert(Language language)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Languages.Add(language);
                context.SaveChanges();
            }
        }

        

        public void Update(Language language)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Languages.Update(language);
                context.SaveChanges();
            }
        }
    }
}
