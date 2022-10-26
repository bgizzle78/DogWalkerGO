using DogWalkerGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogWalkerGo.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);

    }
}