using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController: Controller
{
    public List<TarefaViewModel> listaDeTarefas {get; set;}

    public TarefasController()
    {
        listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel() {Id = 1, Titulo = "Escovar os Dentes", Descricao = "Usar Sensodine"},
            new TarefaViewModel() {Id = 2, Titulo = "Arrumar Cama"},
            new TarefaViewModel() {Id = 3, Titulo = "Colocar o lixo para fora", Descricao = "Terças, Quinta, Sábado"}
        };
    }

    public IActionResult Create()
    {
        return View();    
    }

    public IActionResult Index()
    {
        return View(listaDeTarefas);
    }
    public IActionResult Details(int id)
    {
        var Tarefas = listaDeTarefas.Find(Tarefas => Tarefas.Id==id);
        return View(Tarefas);
    }
};
