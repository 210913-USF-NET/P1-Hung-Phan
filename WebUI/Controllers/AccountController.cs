﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using StoreBL;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private ICustomerBL _bl;
        public AccountController(ICustomerBL bl)
        {
            _bl = bl;
        }

        // GET: AccountController
        public ActionResult Index()
        {
            List<CCustomers> allCustomers = _bl.GetAllCustomer();
            return View(allCustomers);
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(CCustomers customer)
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CCustomers customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //List<CCustomers> Taken = _bl.GetAllCustomer();
                    //foreach(var user in Taken)
                    //{
                    //    if(user.Username == customer.Username)
                    //    {
                    //        Console.WriteLine("This username already exist.");
                    //        return View();
                    //    }
                    _bl.AddCustomer(customer);
                    return RedirectToAction(nameof(Index));
                    //}
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
