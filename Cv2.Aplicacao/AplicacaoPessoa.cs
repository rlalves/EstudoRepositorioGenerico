using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cv2.Dominio.Entidades;
using Cv2.Aplicacao.Interfaces;
using Cv2.Dominio.Interfaces.Servicos;

namespace Cv2.Aplicacao
{
    public class AplicacaoPessoa : AplicacaoBase<Pessoa>, IAplicacaoPessoa
    {
        private readonly IServicoPessoa servico;

        public AplicacaoPessoa(IServicoPessoa _servico)
            :base(_servico)
        {
            servico = _servico;
        }
    }
}
