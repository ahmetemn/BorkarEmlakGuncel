using BorkarEmlak.DATA.Abstract;
using BorkarEmlak.DATA.Enums;
using BorkarEmlak.REPO.Abstract;
using BorkarEmlak.SERVICE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.SERVICE.Concrate
{
    public class BaseEmlakSERVICE<T> : IBaseEmlakService<T> where T : BaseEmlak
    {
        public readonly IBaseEmlakREPO<T> _context;
        public BaseEmlakSERVICE(IBaseEmlakREPO <T> context)
        {
            _context = context;
        }
        public int Create(T entity)
        {
            return _context.Create(entity);
        }

        public async Task<int> Delete(int id)
        {
           var data=await _context.GetByIdAsync(id);
            data.Status = Status.Silindi;
            data.DeletedDate = DateTime.Now;
            return _context.Delete(data);
        }

        public async Task<List<T>> GetAll()
        {
           var data=await _context.GetAllAsync();
            return data;
        }

        public async Task<List<T>> GetAllActive()
        {
             return  await _context.GetAllWhere(x => x.Status != Status.Silindi);
           
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateStatus(int id)
        {
            throw new NotImplementedException();
        }
    }
}
