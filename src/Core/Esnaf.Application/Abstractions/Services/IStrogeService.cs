using Esnaf.Application.DTOs.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services
{
    public interface IStrogeService
    {
        Task<bool> SaveImageAsync(ImageDTO image);
        Task<bool> DeleteImageAsync(ImageDTO image);
    }
}
