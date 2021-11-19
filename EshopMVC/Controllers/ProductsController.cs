﻿using EshopMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace EshopMVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public async Task<ActionResult> Index()
        {
            var http = new HttpClient();
            var products = await http.GetFromJsonAsync<List<Product>>("https://eshop-webapi.azurewebsites.net/api/Products");
            return View(products);
        }

        // GET: ProductsController/Details/5
        public async Task<ActionResult> Details(int id)
        {

            var http = new HttpClient();
            var product = await http.GetFromJsonAsync<Product>($"https://eshop-webapi.azurewebsites.net/api/Products/{id}");
            return View(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            try
            {
                var client = new HttpClient();
                await client.PostAsJsonAsync("https://eshop-webapi.azurewebsites.net/api/Products", product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
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

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
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