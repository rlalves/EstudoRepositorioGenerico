using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cv2.Dominio.Interfaces.Repositorios;
using Cv2.Persistencia.Contexto;
using System.Data.Entity;

namespace Cv2.Persistencia.Repositorio
{
    public class RepositorioBase<TEntidade> : IDisposable, IRepositorioBase<TEntidade> where TEntidade : class
    {
        protected Modelo db = new Modelo();

        public void Incluir(TEntidade obj)
        {
            db.Set<TEntidade>().Add(obj);
            db.SaveChanges();
        }

        public void Alterar(TEntidade obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Guid id)
        {
            db.Set<TEntidade>().Remove(this.ConsultarPorId(id));
            db.SaveChanges();
        }

        public TEntidade ConsultarPorId(Guid id)
        {
            return db.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> Listar()
        {
            return db.Set<TEntidade>().ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
