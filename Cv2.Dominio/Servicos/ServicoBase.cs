using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cv2.Dominio.Interfaces.Servicos;
using Cv2.Dominio.Interfaces.Repositorios;

namespace Cv2.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IDisposable, IServicoBase<TEntidade> where TEntidade : class
    {
        private readonly IRepositorioBase<TEntidade> repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> _repositorio)
        {
            repositorio = _repositorio;
        }

        public void Incluir(TEntidade obj)
        {
            repositorio.Incluir(obj);
        }

        public void Alterar(TEntidade obj)
        {
            repositorio.Alterar(obj);
        }

        public void Excluir(Guid id)
        {
            repositorio.Excluir(id);
        }

        public TEntidade ConsultarPorId(Guid id)
        {
            return repositorio.ConsultarPorId(id);
        }

        public IEnumerable<TEntidade> Listar()
        {
            return repositorio.Listar();
        }

        public void Dispose()
        {
            repositorio.Dispose();
        }
    }
}