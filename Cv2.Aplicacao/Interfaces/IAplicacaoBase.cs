using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv2.Aplicacao.Interfaces
{
    public interface IAplicacaoBase<TEntidade> where TEntidade : class
    {
        void Incluir(TEntidade obj);
        void Alterar(TEntidade obj);
        void Excluir(Guid id);
        TEntidade ConsultarPorId(Guid id);
        IEnumerable<TEntidade> Listar();
        void Dispose(); 
    }
}
