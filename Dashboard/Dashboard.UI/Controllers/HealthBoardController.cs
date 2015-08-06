using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dashboard.Domain.Abstract;
using Dashboard.Domain.Entities;

namespace Dashboard.UI.Controllers
{
    public class HealthBoardController : Controller
    {
        private IHealthBoardRepository respository;

        public HealthBoardController(IHealthBoardRepository healthBoardRepository)
        {
            this.respository = healthBoardRepository;
        }

        public ViewResult List()
        {
            return View(respository.HealthBoards);
        }
        
    }
}