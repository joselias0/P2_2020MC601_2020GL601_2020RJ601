using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020MC601_2020GL601_2020RJ601.Models;

namespace P2_2020MC601_2020GL601_2020RJ601.Controllers
{
	public class CasosReportadosController : Controller
	{
        private readonly casos_covidContext _CovidContext;

        public CasosReportadosController(casos_covidContext covidContext)
        {
            _CovidContext = covidContext;
        }
        public IActionResult Index()
		{
            var listadoDeDepartamento = (from d in _CovidContext.Departamentos select d).ToList();
            ViewData["listadoDeDepartamento"] = new SelectList(listadoDeDepartamento, "id_departamento", "nombre_departamento");

            var listadoDeGenero = (from g in _CovidContext.Generos select g).ToList();
            ViewData["listadoDeGenero"] = new SelectList(listadoDeGenero, "id_genero", "nombre_genero");

            var listadoDeCasos = (from cr in _CovidContext.CasosReportados join g in _CovidContext.Generos on cr.id_genero equals g.id_genero
                                  join d in _CovidContext.Departamentos on cr.id_departamento equals d.id_departamento
                                  select new
                                  {
                                      departamento = d.nombre_departamento,
                                      genero=g.nombre_genero,
                                      confirmados=cr.casosConfirmados,
                                      recuperados=cr.casosRecuperados,
                                      fallecidos=cr.casosFallecidos
                                  }).ToList();

            ViewData["listadoDeCasos"] = listadoDeCasos;
            return View();
		}
	}
}
