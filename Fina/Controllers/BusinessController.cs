using Fina.AvaliacaoTecnica.Domain.Entities;
using Fina.AvaliacaoTecnica.Domain.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fina.Controllers
{
    public class BusinessController : Controller
    {
        private readonly IServiceBusiness _serviceBusiness;
        public BusinessController(IServiceBusiness serviceBusiness)
        {
            _serviceBusiness = serviceBusiness;
        }

        // GET: Business
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Update(Business model)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                try
                {
                    _serviceBusiness.Update(model);
                    if (model.Id != 0)
                    {
                        status = true;
                    }
                    return Json(new { success = status });
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return Json(new
            {
                success = false,
                errors = ModelState.Keys.SelectMany(i => ModelState[i].Errors).Select(m => m.ErrorMessage).ToArray()
            });
        }
        [HttpPost]
        public JsonResult Insert(Business model)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                try
                {
                    _serviceBusiness.Add(model);
                    if (model.Id != 0)
                    {
                        status = true;
                    }
                    return Json(new { success = status });
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return Json(new
            {
                success = false,
                errors = ModelState.Keys.SelectMany(i => ModelState[i].Errors).Select(m => m.ErrorMessage).ToArray()
            });
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            int Count = 10; IEnumerable<object> customers = null;
            try
            {
                object[] parameters = { Count };
                customers = _serviceBusiness.GetAll();
            }
            catch { }
            var x = JsonConvert.SerializeObject(customers.ToList());
            return Json(x, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Delete(List<int> ids)
        {
            bool status = false;
            try
            {
                _serviceBusiness.RemoveAll(ids);
                return Json(new { success = status });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return Json(new
            {
                success = false,
                errors = ModelState.Keys.SelectMany(i => ModelState[i].Errors).Select(m => m.ErrorMessage).ToArray()
            });
        }
    }
}