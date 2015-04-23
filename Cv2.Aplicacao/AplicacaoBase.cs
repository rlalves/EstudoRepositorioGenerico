using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cv2.Aplicacao.Interfaces;
using Cv2.Dominio.Interfaces.Servicos;

namespace Cv2.Aplicacao
{
    public class AplicacaoBase<TEntidade> : IAplicacaoBase<TEntidade> where TEntidade : class
    {
        private readonly IServicoBase<TEntidade> servico;

        public AplicacaoBase(IServicoBase<TEntidade> _servico)
        {
            servico = _servico;
        }

        public void Incluir(TEntidade obj)
        {
            servico.Incluir(obj);
        }

        public void Alterar(TEntidade obj)
        {
            servico.Alterar(obj);
        }

        public void Excluir(Guid id)
        {
            servico.Excluir(id);
        }

        public TEntidade ConsultarPorId(Guid id)
        {
            return servico.ConsultarPorId(id);
        }

        public IEnumerable<TEntidade> Listar()
        {
            return servico.Listar();
        }

        public void Dispose()
        {
            servico.Dispose();
        }
    }
}
