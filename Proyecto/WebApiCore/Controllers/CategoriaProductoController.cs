﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiCore.Controllers
{
    public class CategoriaProductoController : Controller
    {
        // GET: CategoriaProducto
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoriaProducto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriaProducto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaProducto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaProducto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
             

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaProducto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
