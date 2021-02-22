using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace IEntityRepository
{
    public class Repository : IRepository, IDisposable
    {

        protected DbContext Context;
        

        public Repository(DbContext context,
            bool autoDetectChanceEnable = false,
            bool proxyCreationEnable = false)
        {

            this.Context = context;

            this.Context.Configuration.AutoDetectChangesEnabled =
                autoDetectChanceEnable;

            this.Context.Configuration.ProxyCreationEnabled =
                proxyCreationEnable;


        }

        public TEntity Create<TEntity>(TEntity newEntity) where TEntity : class
        {

            TEntity Result = null;


            try
            {

                Result = Context.Set<TEntity>().Add(newEntity);

                TrySaveChances();
            }
            catch(Exception e)
            {
                throw (e);
            }



            return Result;

        }

        protected virtual int TrySaveChances()
        {
           return Context.SaveChanges();
        }





        public bool Delete<TEntity>(TEntity deletedEntity) where TEntity : class
        {
            bool Result = false;
            try
            {

                Context.Set<TEntity>().Attach(deletedEntity);

                Context.Set<TEntity>().Remove(deletedEntity);
                   
                Result = TrySaveChances() > 0;


            }
            catch (Exception e)
            {
                throw (e);
            }



            return Result;
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
            }
        }

        public TEntity FindEntity<TEntity>(
            System.Linq.Expressions.Expression<Func<TEntity, bool>> criterial) where TEntity : class
        {
            TEntity Result = null;

            try
            {

                Result = Context.Set<TEntity>().FirstOrDefault(criterial);
            }
            catch (Exception e)
            {
                throw (e);
            }



            return Result;
        }

        public IEnumerable<TEntity> FindEntitySet<TEntity>(
           System.Linq.Expressions.Expression<Func<TEntity, bool>> criterial) where TEntity : class
        {



            List<TEntity> Result = null;

            try
            {

                Result = Context.Set<TEntity>().Where(criterial).ToList();
            }
            catch (Exception e)
            {
                throw (e);
            }



            return Result;



        }





        public bool Update<TEntity>(TEntity modifiedEntity) where TEntity : class
        {

            bool Result = false;
            try
            {

                Context.Set<TEntity>().Attach(modifiedEntity);

                Context.Entry<TEntity>(modifiedEntity).State =
                     EntityState.Modified;
                Result = TrySaveChances() > 0;

                
            }
            catch (Exception e)
            {
                throw (e);
            }



            return Result;
        }
    }
}
