using Ahi.FileService.source.Application.DTOs.Image;
using Ahi.FileService.source.Domain.Interfaces;

namespace Ahi.FileService.source.Infrastructure
{
    public class StrogeService : IStrogeService
    {
        public Task<bool> DeleteImageAsync(ImageDTO image)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveImageAsync(ImageDTO image)
        {
            throw new NotImplementedException();
        }
    }
}
