using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NetFw.Servico
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IServicoWCF" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServicoWCF
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<PacienteTO> GetMeusPacientes();//IdentificacaoProfissional ip)

        [OperationContract]
        PacienteTO GetPacientePorId(int id);//IdentificacaoProfissional ip)

        [OperationContract]
        void AtualizaPaciente(PacienteTO paciente);
       
    }
}
