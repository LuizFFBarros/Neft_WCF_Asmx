using NetFw.Negocio;
using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NetFw.Servico
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ServicoWCF" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ServicoWCF.svc ou ServicoWCF.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ServicoWCF : IServicoWCF
    {
        public void DoWork()
        {
        }
        public List<PacienteTO> GetMeusPacientes()//IdentificacaoProfissional ip)
        {
            PacienteNegocio nPaciente = new PacienteNegocio();
            return nPaciente.GetMeusPacientes();
        }

        public PacienteTO GetPacientePorId(int id)//IdentificacaoProfissional ip)
        {
            PacienteNegocio nPaciente = new PacienteNegocio();
            return nPaciente.GetPacientePorId(id);
        }

        public void AtualizaPaciente(PacienteTO paciente)
        {
            PacienteNegocio nPaciente = new PacienteNegocio();
            nPaciente.AtualizaPaciente(paciente);
        }
    }
}
