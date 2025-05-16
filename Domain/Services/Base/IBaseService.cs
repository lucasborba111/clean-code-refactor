using clean_code_refactor.Domain.Bases;

namespace clean_code_refactor.Domain.Services.Base
{
    public interface IBaseService<T, TViewModel> where T : Identificador
    {
        Task<T> Inserir(TViewModel viewModel);
        Task<IList<T>> Recuperar();
        Task<T> Recuperar(int id);
    }
}
