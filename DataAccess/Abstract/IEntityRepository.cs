using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
                //generic constraint
                //class ---> referans tip
                //IEntity --> IEntity ve implemente eden nesneleri
                //new() --> new lenebilir olmalı bu sayede Ientity devre dışı
     public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
