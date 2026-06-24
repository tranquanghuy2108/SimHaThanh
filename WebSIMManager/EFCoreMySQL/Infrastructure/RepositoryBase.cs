using EFCoreMySQL.DataContext;
using Microsoft.EntityFrameworkCore;
using Models.Responses;
using System.Linq.Expressions;

namespace EFCoreMySQL.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        #region Properties
        private SIMCenterDbContext dataContext;
        private readonly DbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected SIMCenterDbContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion

        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = (DbSet<T>?)DbContext.Set<T>();
        }

        #region Implementation
        public virtual ResponseDataPagingModel<T> Add(T entity)
        {
            ResponseDataPagingModel<T> response = new ResponseDataPagingModel<T>();
            try
            {
                var result = dbSet.Add(entity).Entity;
                var saveChange = DbContext.SaveChanges();
                if (saveChange > 0)
                {
                    response = new ResponseDataPagingModel<T>()
                    {
                        Code = "1",
                        Message = "Thêm dữ liệu thành công"
                    };
                }
                else
                {
                    response = new ResponseDataPagingModel<T>()
                    {
                        Code = "0",
                        Message = "Thêm dữ liệu thất bại"
                    };
                }
            }
            catch (Exception ex)
            {
                response=new ResponseDataPagingModel<T>() { 
                    Code = "-1",
                    Message = "Thêm dữ liệu bị lỗi"
                };
            }
            return response;
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual T Delete(T entity)
        {
            return dbSet.Remove(entity).Entity;
        }
        public virtual T Delete(int id)
        {
            var entity = dbSet.Find(id);
            return dbSet.Remove(entity).Entity;
        }
        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetSingleById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where, string includes)
        {
            return dbSet.Where(where).ToList();
        }


        public virtual int Count(Expression<Func<T, bool>> where)
        {
            return dbSet.Count(where);
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            //if (includes != null && includes.Count() > 0)
            //{
            //    var query = dataContext.Set<T>().Include(includes.First());
            //    foreach (var include in includes.Skip(1))
            //        query = query.Include(include);
            //    return query.AsQueryable();
            //}

            return dataContext.Set<T>().AsQueryable();
        }

        public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
        {
            //if (includes != null && includes.Count() > 0)
            //{
            //    var query = dataContext.Set<T>().Include(includes.First());
            //    foreach (var include in includes.Skip(1))
            //        query = query.Include(include);
            //    return query.FirstOrDefault(expression);
            //}
            return dataContext.Set<T>().FirstOrDefault(expression);
        }

        public virtual IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            //if (includes != null && includes.Count() > 0)
            //{
            //    var query = dataContext.Set<T>().Include(includes.First());
            //    foreach (var include in includes.Skip(1))
            //        query = query.Include(include);
            //    return query.Where<T>(predicate).AsQueryable<T>();
            //}

            return dataContext.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public virtual IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 20, string[] includes = null)
        {
            //int skipCount = index * size;
            //IQueryable<T> _resetSet;
            //
            ////HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            //if (includes != null && includes.Count() > 0)
            //{
            //    var query = dataContext.Set<T>().Include(includes.First());
            //    foreach (var include in includes.Skip(1))
            //        query = query.Include(include);
            //    _resetSet = predicate != null ? query.Where<T>(predicate).AsQueryable() : query.AsQueryable();
            //}
            //else
            //{
            //    _resetSet = predicate != null ? dataContext.Set<T>().Where<T>(predicate).AsQueryable() : dataContext.Set<T>().AsQueryable();
            //}
            //
            //_resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            //total = _resetSet.Count();
            //return _resetSet.AsQueryable();
            throw new NotImplementedException();
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return dataContext.Set<T>().Count<T>(predicate) > 0;
        }
        #endregion
    }
}
