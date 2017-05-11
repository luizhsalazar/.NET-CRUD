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
    class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<ClientAddressViewModel, Client>();
            CreateMap<AddressViewModel, Address>();
            CreateMap<ClientAddressViewModel, Address>();
        }
    }
}
