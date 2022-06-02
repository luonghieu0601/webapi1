using api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<Hanghoa> hangHoas = new List<Hanghoa>();
        [HttpGet]
        public IActionResult Getall()
        {
            return Ok(hangHoas);
        }

        [HttpPost]
        public IActionResult Create(Hanghoa hangHoaVM)
        {
            var hanghoa = new Hanghoa
            {
                ID = hangHoaVM.ID,

                Name = hangHoaVM.Name,
                DonGia = hangHoaVM.DonGia,    
                
            };
            hangHoas.Add(hanghoa);
            return Ok(new
            {
                Success = true,
                Data = hanghoa
            });
            
        }
        [HttpPut("{id}")]
        public IActionResult Edit(int id, Hanghoa hanghoaedit)
        {
            try
            {
                var hanghoa = hangHoas.FirstOrDefault(hh => hh.ID == id);
                if (hanghoa == null)
                {
                    return NotFound();
                }
                if(id != hanghoa.ID)
                {
                    return BadRequest();
                }
                hanghoa.Name = hanghoaedit.Name;
                hanghoa.DonGia = hanghoaedit.DonGia;
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
            
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                var hanghoa = hangHoas.FirstOrDefault(hh => hh.ID == id);
                if (hanghoa == null)
                {
                    return NotFound();
                }
                if (id != hanghoa.ID)
                {
                    return BadRequest();
                }
                hangHoas.Remove(hanghoa);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        
    }
}
