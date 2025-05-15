using clean_code_refactor.Domain.Bases;

namespace clean_code_refactor.Domain.Services.Base
{
    public abstract class BaseService<T> : IBaseService<T> where T : Identificador
    {
        protected IBaseRepository<T> Rep;
        public BaseService(IBaseRepository<T> rep)
        {
            Rep = rep;
        }

        public async Task<IList<T>> Recuperar() => await Rep.ObterTodosAsync();

        public async Task<T> Recuperar(int id) => await Rep.ObterPorIdAsync(id);
    }
}
