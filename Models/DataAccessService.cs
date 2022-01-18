using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class DataAccessService
    {
        /// <summary>
        /// 連線字串
        /// </summary>
        private static string _connectionStr = "Data Source=TEDLIUCOMPUTER\\SQLEXPRESS;Initial Catalog=DemoProject;Integrated Security=True";

        /// <summary>
        /// 全域的資料庫連線字串
        /// </summary>
        public static string connectionStr { get { return _connectionStr; } }
    }
}
