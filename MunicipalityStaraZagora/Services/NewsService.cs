using MunicipalityStaraZagora.Interfaces;
using MunicipalityStaraZagora.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MunicipalityStaraZagora.Services
{
    public class NewsService : INewsService
    {
        //CITY|NAME|DATE|DESCRIPTION|IMAGE
        private const string NewsSplitCharacter = "|";
        public async Task<ICollection<NewsItemViewModel>> GetNewsData(string webRoothPath)
        {
            var newsData = await File.ReadAllLinesAsync(Path.Combine(webRoothPath, "News/News.txt"));

            return newsData
                .Select(n => new NewsItemViewModel()
                {
                    CityName = n.Split(NewsSplitCharacter)[0],
                    Name = n.Split(NewsSplitCharacter)[1],
                    Date = n.Split(NewsSplitCharacter)[2],
                    Description = n.Split(NewsSplitCharacter)[3],
                    Image = n.Split(NewsSplitCharacter)[4],
                    ForwardLink = n.Split(NewsSplitCharacter)[5]
                }).ToList();
        }
    }
}
