using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class SinhVienController : ControllerBase
    {
        public static List<SinhVienVM> lstsinhvien = new List<SinhVienVM>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(lstsinhvien);       
        }        

        [HttpPost]
        public IActionResult Insert(SinhVienVM svm)
        {
           var sv = new SinhVienVM
           {
                MaSV = svm.MaSV,
                HoTenSV = svm.HoTenSV,
                Lop = svm.Lop            
           };             
         lstsinhvien.Add(sv);
         return Ok(sv);
        }
    }
}