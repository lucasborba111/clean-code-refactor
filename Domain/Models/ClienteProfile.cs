using AutoMapper;
using clean_code_refactor.Domain.ViewModels;

namespace clean_code_refactor.Domain.Models
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CriarClienteViewModel, Cliente>();
            CreateMap<Cliente, CriarClienteViewModel>();
        }
    }
}
