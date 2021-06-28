using SupportLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data.AuthData
{
    public class IdentitySQLDataAccess : IIdentityDataAccess
    {
        private readonly ISQLDataAccess _dataAccess;

        public IdentitySQLDataAccess(ISQLDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IList<T>> FetchUser<T>()
        {
            var rows = await _dataAccess.LoadData<T, dynamic>("spFetchUsers", new { }, "DefaultConnection");

            return rows.ToList<T>();
        }

    }
}
