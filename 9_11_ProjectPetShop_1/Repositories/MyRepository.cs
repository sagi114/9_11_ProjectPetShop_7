using _9_11_ProjectPetShop_1.DB;
using _9_11_ProjectPetShop_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _9_11_ProjectPetShop_1.Repositories
{
    public class MyRepository: IRepository
    {
        private PetsDbContext _context;
        public MyRepository(PetsDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categories>GetCategories()
        {
           return _context.Categories;
        }
        public IEnumerable<Animals>GetAnimalsByCatagory(int CatagoryId)
        {
            return _context.Animals.Where(a => a.CategoryId == CatagoryId);
        }
        public IEnumerable<Animals> GetAllAnimals()
        {
            return _context.Animals;
        }
        public IEnumerable<Comments> GetCommentsOfAnimal(int AnimalId)
        {
            return _context.Comments.Where(c => c.AnimaleId == AnimalId);
        }
        public IEnumerable<Animals> GetTwoAnimalsWithMostReviews()
        {
            return _context.Animals.OrderByDescending(a => a.Comments.Count()).Take(2);
        }
        public Animals GetAnimale(int animalId)
        {
            return _context.Animals.FirstOrDefault(a => a.Id == animalId);
        }
        public Animals AddComments(Comments comments,int AnimaleId)
        {
            var Animale = GetAnimale(AnimaleId);
            comments.Animale = Animale;
            comments.AnimaleId = AnimaleId;
            Animale.Comments.Add(comments);
            _context.SaveChanges();
            return Animale;
        }
        public void AddAnimal(Animals animale,int catagoryId)
        {
            _context.Categories.FirstOrDefault(c => c.Id == catagoryId).Animals.Add(animale);
            _context.SaveChanges();
        }
        public void RemoveAnimal(int id)
        {
            var Animal = _context.Animals.SingleOrDefault(A => A.Id == id);
            _context.images.Remove(Animal.Image);
            _context.Animals.Remove(Animal);
            _context.SaveChanges();
        }
        public void EditAnimal(int id,Animals animale)
        {
            var Animal = _context.Animals.SingleOrDefault(A => A.Id == id);
            Animal.Age = animale.Age;
            Animal.Name = animale.Name;
            Animal.Description = animale.Description;
            _context.SaveChanges();
            var item=_context.Animals.Find(id);
        }
        public void SaveImages(Image image)
        {
            _context.images.Add(image);
            _context.SaveChanges();
        }
        public Image GetImage(int id)
        {
            return _context.images.FirstOrDefault(i => i.AnimaleId==id);
        }
        public bool CheckIfFileIsImage(string str)
        {
            return (str.EndsWith(".jpg") || str.EndsWith(".jpeg"));
        }
        public void GetFilesAndSaveImageAndAnimale(IFormFile file,Animals animals)
        {
            Image img = new Image();
            img.ImageTitle = animals.Name;

            img.AnimaleId = animals.Id;
            img.Animals = animals;

            MemoryStream ms = new MemoryStream();
            file.CopyTo(ms);
            img.ImageData = ms.ToArray();

            ms.Close();
            ms.Dispose();

            animals.Image = img;
            AddAnimal(animals, animals.CategoryId);
        }
    }
}
