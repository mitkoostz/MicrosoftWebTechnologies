using MunicipalityStaraZagora.Interfaces;
using MunicipalityStaraZagora.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MunicipalityStaraZagora.Services
{
    public class GalleryImagesService : IGalleryImagesService
    {
        private const string ImageSplitCharacters = " |-> ";
        public async Task<ICollection<GalleryItemViewModel>> GetGalleryImages(string webRoothPath)
        {
            var galleryImagesData = await File.ReadAllLinesAsync(Path.Combine(webRoothPath, "Gallery/Images.txt"));

            return galleryImagesData
                .Select(url => new GalleryItemViewModel() 
                { 
                    ImageUrl = url.Split(ImageSplitCharacters)[0],
                    Description = url.Split(ImageSplitCharacters)[1]
                }).ToList();
        }
    }
}
