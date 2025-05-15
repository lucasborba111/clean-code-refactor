using clean_code_refactor.Domain.Bases;

namespace clean_code_refactor.Domain.Services.Base
{
    public interface IBaseService<T> where T : Identificador
    {
        Task<IList<T>> Recuperar();
        Task<T> Recuperar(int id);
    }
}
