using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;

[ApiController]
[Route ("[controller]")]

public class NhacungCapsController : ControllerBase

{
    private readonly ontapContext _context;
    public NhacungCapsController(ontapContext ctx)
    {
        _context = ctx;        
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Nhacungcaps.ToList());
    }
    
}
