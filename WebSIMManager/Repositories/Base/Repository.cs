using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Base
{
    public interface IRepository
    {
        ResponseDataPagingModel<string> Create<T>(T request);
        ResponseDataPagingModel<string> Update<T>(T request); 
        ResponseDataPagingModel<string> Delete<T>(int Id);
        ResponseDataPagingModel<string> DeleteMulti<T>(Expression<Func<T, bool>> where);
        T GetById<T>(int id);
        ResponseDataPagingModel<T> GetAll<T>();
        ResponseDataPagingModel<T> GetAll<T>(GetPagingRequest request);
        void Save();
    }
    public class Repository
    {

    }
}
