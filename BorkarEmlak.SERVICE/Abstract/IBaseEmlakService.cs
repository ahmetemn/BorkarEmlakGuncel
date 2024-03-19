using BorkarEmlak.DATA.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.SERVICE.Abstract
{
    public interface IBaseEmlakService<T> where T : BaseEmlak
    {



        int Create(T entity);

        Task<int> UpdateStatus(int id);

        int Update(T entity);

        Task<int> Delete(int id);

        Task<T> GetById(int id);

        Task<List<T>> GetAll();

        Task<List<T>> GetAllActive();


         



      


    }
}
