using MunicipalityStaraZagora.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MunicipalityStaraZagora.Interfaces
{
    public interface INewsService
    {
        Task<ICollection<NewsItemViewModel>> GetNewsData(string webRoothPath);
    }
}
