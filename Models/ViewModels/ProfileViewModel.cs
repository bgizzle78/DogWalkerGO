using DogWalkerGo.Models;
using System;
using System.Collections.Generic;

namespace DogWalkerGo.Models.ViewModels
{
    public class ProfileViewModel
    {
        public Owner Owner { get; set; }
        public List<Walker> Walkers { get; set; }
        public List<Dog> Dogs { get; set; }
    }
}