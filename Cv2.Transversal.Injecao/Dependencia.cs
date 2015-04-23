using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;
using Cv2.Dominio.Servicos;
using Cv2.Dominio.Interfaces.Servicos;
using Cv2.Dominio.Interfaces.Repositorios;
using Cv2.Persistencia.Repositorio;
using Cv2.Aplicacao.Interfaces;
using Cv2.Aplicacao;

namespace Cv2.Transversal.Injecao
{
    public static class Dependencia
    {
        public static void Injetar(IKernel kernel)
        {
            kernel.Bind(typeof(IAplicacaoBase<>)).To(typeof(AplicacaoBase<>));
            kernel.Bind<IAplicacaoPessoa>().To<AplicacaoPessoa>();

            kernel.Bind(typeof(IServicoBase<>)).To(typeof(ServicoBase<>));
            kernel.Bind<IServicoPessoa>().To<ServicoPessoa>();

            kernel.Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
            kernel.Bind<IRepositorioPessoa>().To<RepositorioPessoa>();
        }
    }
}
