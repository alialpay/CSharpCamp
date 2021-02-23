using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
        // where ile T'ye verilebilecek nesneler için bir standart oluşturmaya çalışıyoruz...
        // Tyi sınırlandırıyoruz. mesela int yazdığımızda kabul etmesin, generic constraint
        // where T:class dediğimizde artık int yazılamaz. sadece class yazılabilir. Yani "T bir referans tip olmalı" şartı koyduk
        // ,IEntity ile T'yi ya IEntity yada IEntityden implemente eden bir şey olabileceğini şart koşuyoruz. Bunu koymasak Exception classlarını yazabiliyorduk.
        // IEntity soyut bir nesne olduğu için onu istemiyoruz. Onu devre dışı bırakmak için new() koyduk. IEntity interface olduğu için new'lemez olduğundan IEntity'i saf dışı bıraktık.
        // Artık sistemimiz gerçekten bir veri tabanı nesleneleriyle çalışan bir repository oldu.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // burası filtreler yazabilmemizi sağlar. Expression yapısını araştır...
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
