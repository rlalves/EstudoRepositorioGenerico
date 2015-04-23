using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cv2.Dominio.Entidades;
using Cv2.Dominio.Interfaces.Repositorios;

namespace Cv2.Persistencia.Repositorio
{
    public class RepositorioPessoa : RepositorioBase<Pessoa>, IRepositorioPessoa
    {
    }
}
