using DogWalkerGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogWalkerGo.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);

    }
}