using _9_11_ProjectPetShop_1.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9_11_ProjectPetShop_1.Repositories
{
    public interface IRepository
    {
        IEnumerable<Categories> GetCategories();
        IEnumerable<Animals> GetAnimalsByCatagory(int CatagoryId);
        IEnumerable<Animals> GetAllAnimals();
        IEnumerable<Comments> GetCommentsOfAnimal(int AnimalId);
        IEnumerable<Animals> GetTwoAnimalsWithMostReviews();
        Animals GetAnimale(int animalId);
        Animals AddComments(Comments comments, int AnimaleId);
        void AddAnimal(Animals animale, int catagoryId);
        void RemoveAnimal(int id);
        void EditAnimal(int id, Animals animale);
        void SaveImages(Image image);
        Image GetImage(int id);
        bool CheckIfFileIsImage(string str);
        void GetFilesAndSaveImageAndAnimale(IFormFile file, Animals animals);
    }
}
