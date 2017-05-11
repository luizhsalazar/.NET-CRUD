using AutoMapper;
using CRUD.Application.ViewModels;
using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Client, ClientAddressViewModel>();
            CreateMap<Address, AddressViewModel>();
            CreateMap<Address, ClientAddressViewModel>();
        }
    }
}
