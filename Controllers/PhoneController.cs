using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartphone_Shop.Models;
using Smartphone_Shop.Models.BusinessModel;
using Smartphone_Shop.Models.Repositories;
using Smartphone_Shop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone_Shop.Controllers
{
    public class PhoneController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly IPhoneRepository _phoneRepository;

        public PhoneController(AppDbContext db, IMapper mapper, IPhoneRepository phoneRepository)
        {
            _db = db;
            _mapper = mapper;
            _phoneRepository = phoneRepository;
        }

        [HttpGet]
        public IActionResult List(string price, int? id)
        {
            var phoneList = _phoneRepository.getAllPhones(id);

            if(price == "asc")
            {
                phoneList = phoneList.OrderBy(p => p.Price).ToList();
            }
            else if(price == "desc")
            {
                phoneList = phoneList.OrderByDescending(p => p.Price).ToList();
            }
            
            var allBrands = _phoneRepository.allBrands;
            var result = _mapper.Map<PhoneListViewModel>(phoneList);
            result = _mapper.Map(allBrands, result);
            if (id != null)
            {
                ViewData["currentBrand"] = _db.Brand.Find(id).Name;
            }

            return View(result);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var phoneDM = _phoneRepository.getPhoneById(id);
            var result = _mapper.Map<PhoneBM>(phoneDM);

            return View(result);
        }

        [HttpGet]
        public IActionResult CreatePhone()
        {
            if (User.IsInRole("Admin"))
            {
                ViewData["Brands"] = _db.Brand.ToList();
                ViewData["Cpus"] = _db.Cpu.ToList();
                ViewData["SimTypes"] = _db.SimType.ToList();
                ViewData["UsbTypes"] = _db.UsbType.ToList();
                ViewData["DisplayTypes"] = _db.DisplayType.ToList();
                ViewData["OpSystems"] = _db.OpSystem.ToList();
                ViewData["Colors"] = _db.Color.ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home", ViewBag.AccessErrorMsg = "Access denied");
            }
        }

        [HttpPost]
        public IActionResult CreatePhone(Phone obj)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Brands"] = _db.Brand.ToList();
                ViewData["Cpus"] = _db.Cpu.ToList();
                ViewData["SimTypes"] = _db.SimType.ToList();
                ViewData["UsbTypes"] = _db.UsbType.ToList();
                ViewData["DisplayTypes"] = _db.DisplayType.ToList();
                ViewData["OpSystems"] = _db.OpSystem.ToList();
                ViewData["Colors"] = _db.Color.ToList();
                return View(obj);
            }
            else
            {
                _phoneRepository.AddNewPhone(obj);
                return RedirectToAction("List");
            }
        }

        [HttpGet]
        public IActionResult CreateCpu()
        {
            if (User.IsInRole("Admin"))
            {
                Cpu cpu = new Cpu();
                return View(cpu);
            }
            else
            {
                return RedirectToAction("Index", "Home", ViewBag.AccessErrorMsg = "Access to admin options denied!");
            }
        }

        [HttpPost]
        public IActionResult CreateCpu(Cpu cpu)
        {
            if (!ModelState.IsValid)
            {
                return View(cpu);
            }
            else
            {
                _db.Cpu.Add(cpu);
                _db.SaveChanges();
                return RedirectToAction("CreatePhone");
            }
        }

        [HttpGet]
        public IActionResult CreateBrand()
        {
            if (User.IsInRole("Admin"))
            {
                Brand brand = new Brand();
                return View(brand);
            }
            else
            {
                return RedirectToAction("Index", "Home", ViewBag.AccessErrorMsg = "Access to admin options denied!");
            }
        }

        [HttpPost]
        public IActionResult CreateBrand(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View(brand);
            }
            else
            {
                _db.Brand.Add(brand);
                _db.SaveChanges();
                return RedirectToAction("CreatePhone");
            }
        }

        public IActionResult DeletePhone(int id)
        {
            _phoneRepository.DeletePhone(id);
            return RedirectToAction("List");
        }
    }
}
