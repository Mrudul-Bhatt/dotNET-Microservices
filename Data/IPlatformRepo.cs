using System.Collections.Generic;
using dotNET_Microservices.Models;

namespace dotNET_Microservices.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}