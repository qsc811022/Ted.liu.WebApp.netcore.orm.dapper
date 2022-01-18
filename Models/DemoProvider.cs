using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
    public class DemoProvider
    {
        public List<FoodModel> GetllData()
        {
            List<FoodModel> result;
            using (var conn = new SqlConnection(DataAccessService.connectionStr))
            {
                var sql ="select * from FoodTable";
                result=conn.Query<FoodModel>(sql).ToList();
                return result;
            }

        }

        public void Create(FoodModel model)
        {
            using (var conn = new SqlConnection(DataAccessService.connectionStr))
            {
                var sql = "INSERT INTO FoodTable(FoodName,FoodPrice,dep,Name) VALUES(@FoodName,@FoodPrice,@dep,@Name)";
                conn.Execute(sql,model);
            }
        }

        public FoodModel GetId(int id)
        {
            using (var conn = new SqlConnection(DataAccessService.connectionStr))
            {
                var sql = "select * from FoodTable where id =@id";
                return conn.QuerySingleOrDefault<FoodModel>(sql,new{id});
            }
        }

        public void Edit(int id,FoodModel model)
        {
            using (var conn = new SqlConnection(DataAccessService.connectionStr))
            {
                var sql = "Update FoodTable SET FoodName=@FoodName,FoodPrice=@FoodPrice,dep=@dep,Name=@Name where id =@id";
                conn.Execute(sql,model);
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection(DataAccessService.connectionStr))
            {
                var sql = "Delete from FoodTable where id =@id";
                conn.Execute(sql,new{id });
            }
        }

    }
}
