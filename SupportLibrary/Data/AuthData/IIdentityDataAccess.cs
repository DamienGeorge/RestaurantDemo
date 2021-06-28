using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLibrary.Data.AuthData
{
    public interface IIdentityDataAccess
    {
        Task<IList<T>> FetchUser<T>();
    }
}