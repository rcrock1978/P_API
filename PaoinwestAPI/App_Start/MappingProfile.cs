using AutoMapper;
using PaoinwestAPI.Core.Dtos;
using PaoinwestAPI.Persistence;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaoinwestAPI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CustomerDto, Customer>()
                 .ForMember(c => c.Orders, option => option.Ignore()));
            Mapper.Initialize(cfg => cfg.CreateMap<Customer, CustomerDto>());

         }
    }
}