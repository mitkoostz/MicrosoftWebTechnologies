using MunicipalityStaraZagora.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MunicipalityStaraZagora.Interfaces
{
    public interface IGalleryImagesService
    {
        Task<ICollection<GalleryItemViewModel>> GetGalleryImages(string webRoothPath);
    }
}
