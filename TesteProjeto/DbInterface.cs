using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Sql;
using System.Web.Configuration;


namespace TesteProjeto
{

    public class DbInterface
    {

        public abstract class AbstractRepository<TEntity, TKey> where TEntity : class
        {
            protected string StringConnection { get; } = WebConfigurationManager.ConnectionStrings["bdcadastro"].ConnectionString;

            public abstract List<TEntity> GetAll();
            public abstract TEntity GetById(TKey id);
            public abstract void Save(TEntity entity);
            public abstract void Update(TEntity entity);
            public abstract void Delete(TEntity entity);
            public abstract void DeleteById(TKey id);

        }


    }
}