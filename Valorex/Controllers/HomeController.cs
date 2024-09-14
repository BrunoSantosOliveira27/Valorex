using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Valorex.Data;
using Valorex.Models;
using Microsoft.EntityFrameworkCore;
using Valorex.ViewModels;

namespace Valorex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

        //Injeção de dependência
    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Categorias = _context.Categorias.ToList(),
            Personagems = _context.Personagems
            .Include(p => p.Categoria)
            .ThenInclude(p => p.Nome)
            .ToList()
        };
        return View(home);
    }

    public IActionResult Details(int id)
    {
        Personagem personagem = _context.Personagems
            .Where(p => p.Id == id)
            .Include(p => p.Categoria)
            .ThenInclude(c => c.Cor)
            .Include(p => p.Origem)
            .Include(p => p.Genero)
            .SingleOrDefault();  //pegar apenas um registro
        DetailsVM details = new()
        {
            Atual = personagem,
            Anterior = _context.Personagems
                .OrderByDescending(p => p.Id)
                .FirstOrDefault(p => p.Id < id),
            Proximo = _context.Personagems
                .OrderBy(p => p.Id)
                .FirstOrDefault(p => p.Id > id)
        };
        return View(details);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}