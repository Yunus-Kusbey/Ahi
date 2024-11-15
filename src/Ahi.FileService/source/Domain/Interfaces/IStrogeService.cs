using Ahi.FileService.source.Application.DTOs.Image;

namespace Ahi.FileService.source.Domain.Interfaces
{
    public interface IStrogeService
    {
        Task<bool> SaveImageAsync(ImageDTO image);
        Task<bool> DeleteImageAsync(ImageDTO image);
    }
}
