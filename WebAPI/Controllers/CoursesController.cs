﻿using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concrete.EntityFramework;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//attribute  Javada: Anotation
    public class CoursesController : ControllerBase
    {
        //Loosely coupled
        //Naming convention
        //IoC Container --> Inversion of Control
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //swagger
            //dependency chain
            var result = _courseService.GetAll();
            if (result.Success)
            {
                return Ok(result);
                
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _courseService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Course course) 
        {
            var result = _courseService.Add(course);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
