using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cv2.Dominio.Entidades;
using Cv2.Dominio.Interfaces.Servicos;
using Cv2.Dominio.Interfaces.Repositorios;

namespace Cv2.Dominio.Servicos
{
    public class ServicoPessoa : ServicoBase<Pessoa>, IServicoPessoa
    {
        private readonly IRepositorioPessoa repositorio;

        public ServicoPessoa(IRepositorioPessoa _repositorio)
            : base(_repositorio)
        {
            repositorio = _repositorio;
        }
    }
}
