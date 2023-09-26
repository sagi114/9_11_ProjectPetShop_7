using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using _9_11_ProjectPetShop_1.Models;
using _9_11_ProjectPetShop_1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _9_11_ProjectPetShop_1.Controllers
{
    public class HomeController : Controller
    {
        public IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            ViewBag.caunter = 1;
            IEnumerable<Animals> favoriteAnimals=_repository.GetTwoAnimalsWithMostReviews().ToList();
            
            return View(favoriteAnimals);
        }
        public IActionResult Catalog(int CatagorySelect = 0)
        {
            ViewBag.Caunter = 1;
            var c = GetAnimalsAsAsked(CatagorySelect).ToList();
            if (CatagorySelect != 0)
                ViewBag.TitleOfCatalog = c[0].Category.Name;
            else ViewBag.TitleOfCatalog = "";
            return View(c);
        }
        public IActionResult Administrator(int CatagorySelect = 0)
        {
            var c = GetAnimalsAsAsked(CatagorySelect).ToList();
            if (CatagorySelect != 0)
                ViewBag.TitleOfCatalog = c[0].Category.Name;
            else ViewBag.TitleOfCatalog = "";
            ViewBag.Caunter = 1;
           return View(c);
        }
        public IEnumerable<Animals>GetAnimalsAsAsked(int CatagorySelect = 0)
        {
            ViewBag.CatagortList = _repository.GetCategories();
            return (CatagorySelect == 0) ? _repository.GetAllAnimals() : _repository.GetAnimalsByCatagory(CatagorySelect);
        }
        public IActionResult Details(int animaleId)
        {
            ViewBag.Caunter = 1;
            ViewBag.Animale = _repository.GetAnimale(animaleId);
            return View();
        }
        public IActionResult AddAComment(Comments comments, int animaleId)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Animale = _repository.AddComments(comments, animaleId);
            }
            else
            {
                ViewBag.Animale = _repository.GetAnimale(animaleId);
            }
            ViewBag.Caunter = 1;
            return View("Details");
        }
        public IActionResult Edit(int animaleId)
        {
            ViewBag.isValid = true;
            return View(_repository.GetAnimale(animaleId));
        }
        public IActionResult SendToEdit(Animals animals)
        {
            if (ModelState.IsValid)
            {
                _repository.EditAnimal(animals.Id, animals);
                return RedirectToAction("Administrator");
            }
            else
            {
                ViewBag.isValid = false;
                return View("Edit", _repository.GetAnimale(animals.Id));
            }
        }
        public IActionResult Delete(int animaleId)
        {
            _repository.RemoveAnimal(animaleId);
            return RedirectToAction("Administrator");
        }
        public IActionResult AddAnimale()
        {
            ViewBag.isValid = true;
            ViewBag.CatagortList = _repository.GetCategories();
            return View();
        }
        public IActionResult UploadAnimalWithImage(Animals animals)
        {
            if (ModelState.IsValid)
            {
                foreach (var file in Request.Form.Files)
                {
                    if (!_repository.CheckIfFileIsImage(file.FileName))
                        break;
                    _repository.GetFilesAndSaveImageAndAnimale(file, animals);
                    return RedirectToAction("Administrator");
                }
            }
            ViewBag.isValid = false;
            ViewBag.CatagortList = _repository.GetCategories();
            return View("AddAnimale");
        }
    }
}