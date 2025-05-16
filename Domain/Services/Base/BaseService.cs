using AutoMapper;
using clean_code_refactor.Domain.Bases;

namespace clean_code_refactor.Domain.Services.Base
{
    public abstract class BaseService<T, TViewModel> : IBaseService<T, TViewModel> where T : Identificador
    {
        protected IBaseRepository<T> Rep;
        protected IMapper Mapper;
        public BaseService(IBaseRepository<T> rep, IMapper mapper)
        {
            Rep = rep;
            Mapper = mapper;
        }

        public async Task<IList<T>> Recuperar() => await Rep.ObterTodosAsync();

        public async Task<T> Recuperar(int id) => await Rep.ObterPorIdAsync(id);

        public virtual async Task<T> Inserir(TViewModel viewModel)
        {
            var entity = Mapper.Map<T>(viewModel);

            return await Rep.AdicionarAsync(entity);
        }
    }
}
