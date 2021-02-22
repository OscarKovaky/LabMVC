using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Repository;

namespace IEntityRepository
{
    public class RepositoryUoW: Repository,IRepository,IUnitOfWorkcs,IDisposable
    {

        public RepositoryUoW(DbContext context,
            bool autoDetectChanceEnable = false,
            bool proxyCreationEnable = false):
            base(context, autoDetectChanceEnable,proxyCreationEnable)
        {

          


        }


        protected override int TrySaveChances()
        {
            return 0;
        }


        int IUnitOfWorkcs.Save()
        {
            int Result = 0;



            try
            {
                Result = Context.SaveChanges();
            }
            catch(Exception e)
            {
                throw (e);
            }

            return Result;
        }
    }
}
