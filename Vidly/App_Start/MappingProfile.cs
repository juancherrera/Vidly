using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>(); //Creates a mapping configuration between two types - source and target
            Mapper.CreateMap<CustomerDto, Customer>(); //Creates a mapping configuration between two types - source and target

            Mapper.CreateMap<Movie, MovieDto>(); //Creates a mapping configuration between two types - source and target
            Mapper.CreateMap<MovieDto, Movie>(); //Creates a mapping configuration between two types - source and target
        }
    }
}