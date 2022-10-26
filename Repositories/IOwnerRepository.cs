using DogWalkerGo.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DogWalkerGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        Owner AddOwner(Owner owner);
        Owner UpdateOwner(Owner owner);
        Owner DeleteOwner(int id);
    }
}