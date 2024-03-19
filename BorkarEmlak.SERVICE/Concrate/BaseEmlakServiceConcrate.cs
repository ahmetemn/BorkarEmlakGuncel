using BorkarEmlak.DATA.Abstract;
using BorkarEmlak.DATA.Enums;
using BorkarEmlak.REPO.Abstract;
using BorkarEmlak.SERVICE.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.SERVICE.Concrate
{
    public class BaseEmlakServiceConcrate<T> : IBaseEmlakService<T> where T : BaseEmlak

    {

        private readonly IBaseEmlakREPO<T>  _baseEmlakREPO;


        public BaseEmlakServiceConcrate(IBaseEmlakREPO<T> baseEmlakREPO)
        {
            this._baseEmlakREPO = baseEmlakREPO; 
        }

        public int Create(T entity)
        {
                
            return _baseEmlakREPO.Create(entity);   

        }

        public async  Task<int> Delete(int id)
        {
            
            var data = await _baseEmlakREPO.GetByIdAsync(id);

            data.Status = Status.Silindi; 
            data.DeletedDate = DateTime.Now;    
            return _baseEmlakREPO.Delete(data); 
             

        }

      

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
