using MediatR;
using Microsoft.AspNetCore.Mvc;
using OZTF.EducationManageSys.Application.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        //private readonly IMediator _mediator;
        public StudentController(IHttpClientFactory httpClientFactory
            )
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            
            return View();
        }
    }
}
