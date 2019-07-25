using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFormsVsModelBinding.Models
{
    public static class ProTeamDB
    {
        /// <summary>
        /// Registers a proteam
        /// </summary>
        /// <param name="pro"> Pro Team to be registered</param>
        /// <exception cref="SqlException"></exception>
        public static void Register(ProTeam pro)
        {
            throw new NotImplementedException();

            SqlConnection con = new SqlConnection("con string");
            SqlCommand cmd = new SqlCommand("query here...", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
