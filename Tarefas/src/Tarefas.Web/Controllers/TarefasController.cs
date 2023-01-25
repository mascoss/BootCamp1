
using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Web.Controllers;

public class TarefasController: Controller
{ 
    public IActionResult Create()
    {
        return View();
    }
}

public IActionResult Index()
{
    var listaDeTarefas = new List<TarefaViewModel>()
    {
        new TarefaViewModel() {Titulo = "Escovar os Dentes", Descricao = "Usar sensodine"},
        new TarefaViewModel() {Titulo = "Arrumar cama"},
        new TarefaViewModel() {Titulo = "Colocar o lixo para fora", Descricao = "somente às terças"},
    };
    return View(listaDeTarefas);
}