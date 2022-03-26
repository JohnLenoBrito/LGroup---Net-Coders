using SondaIT.SuperSisAmigos.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.SuperSisAmigos.Repository.Abstracts
{

    // abstract : FAZ COM QUE A CLASSE SÓ POSSA SER ACESSADA ATRÁVEZ DE HERANÇA
    // HERDAMOS AS NOSSAS INTERFACES DE LEITURA E GRAVAÇÃO E FIZEMOS A IMPLEMENTAÇÃO
    // DOS MESMO EM FORMA DE METODOS, COM NOSSO RESPOSITORIO É GENERICO ISSO FAZ COM QUE QUALQUER
    // REPOSITORIO DERIVADO POSSO UTILIZA-LO PASSANDO APENAS A CLASSE  MODEL, QUE SUBSTITUIRÁ  O TEntity
    
    public abstract class BaseRepository<TEntity> 
        : Base.IReading<TEntity>,Base.IRecording<TEntity>,
        IDisposable where TEntity: class
    {
        // CRIAMOS UM ONJETO DO TIPO AmigosContext, QUE É A NOSSA CLASSSE DE CONEXÃO
        private AmigosContext _context = null;

        // OBJETO DO TIPO GENERICO, NÃO SABEMOS AINDA QUAL CLASSE MODELO SERÁ PASSADA
        private DbSet<TEntity> _entity = null;

        // CRIAMOS O METODO CONSTRUTOR PARA GERAR A INSTANCIA DA NOSSA CLASSE DE CONEXÃO
        // E PARA NOSSO OBJETO _entity RECEBER OS DADOS SETADOS NO CONTEXTO
        public BaseRepository()
        {
                _context = new AmigosContext();
                _entity = _context.Set<TEntity>();
        }

        // METODO DE LISTAGEM DE REGISTROS
        public virtual List<TEntity> GetAll()
        {
            //CRIAMOS UMA VARIAVEL query PARA RECEBEER O VALOR RETORNADO DA _entity 
            var query = _entity.ToList();
            return query;
        }

        public virtual List<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate)
        {
            // METODO QUE IRÁ TRAZER UMA LISATA FILTRADA DE ACORDO COM A 
            // EXPRESSÃO LAMBDA QUE O DESENVOLVEDOR IRÁ PASSAR
            var query = _entity.Where(Predicate).ToList();
            return query;
        }

        public virtual TEntity Find(int ID)
        {
            // METODO PARA FILTRAR PELA PRIMARY KEY, UTILIZAMOS O METODO Find PARA ISSO
            // ESSE METODO  FILTRA PELA PK E SÓ RETORNA 1 REGISTRO
            var query = _entity.Find(ID);
            return query;
        }

        public virtual void Add(TEntity entity)
        {
           
            _entity.Add(entity);
            _context.SaveChanges();

        }

        public virtual void Delete(TEntity entity)
        {
            _entity.Remove(entity);
            _context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public  void Dispose()
        {
            // FIZEMOS UM IF PARA VERIFICAR SE O _context ESTA DIFERENTE DE NUll
            // SE ESTIVER DAMOS UM DISPOSE, ANULAMOS O OBJETO, E INVOCAMOS 
            // GARBAGE COLLECTOR (coletor de lixo)
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
                _entity = null;
                GC.SuppressFinalize(_context);
            }
        }
    }
}
