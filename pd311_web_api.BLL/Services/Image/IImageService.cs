﻿using Microsoft.AspNetCore.Http;
using pd311_web_api.DAL.Entities;

namespace pd311_web_api.BLL.Services.Image
{
    public interface IImageService
    {
        Task<string?> SaveImageAsync(IFormFile image, string directoryPath);
       
        void CreateImagesDirectory(string path);
        Task<List<CarImage>> SaveCarImagesAsync(IEnumerable<IFormFile> images, string directoryPath);
        void DeleteCarImages(List<CarImage> carImages);
        void DeleteImage(string imagePath);
        void DeleteCarImages(ICollection<CarImage> images);
    }

}
