using NetFW.ServicoSoapPaciente;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NetFW.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {

            ServicoSOAPSoapClient sServico = new ServicoSOAPSoapClient();
            List<PacienteTO> pto  = sServico.GetMeusPacientes().ToList();
            ViewBag.Luiz = "luiz";
            return View(pto);
        }

        public ActionResult Editar(int id)
        {
            
            ServicoSOAPSoapClient sServico = new ServicoSOAPSoapClient();
            return View(sServico.GetPacientePorId(id));
        }

        [HttpPost]
        public ActionResult Editar(PacienteTO paciente)
        {
            ServicoSOAPSoapClient sServico = new ServicoSOAPSoapClient();
            sServico.AtualizaPaciente(paciente);
            return View("Sucesso");
        }

    }
}