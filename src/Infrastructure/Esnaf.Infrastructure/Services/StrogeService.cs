using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.DTOs.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Infrastructure.Services
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
