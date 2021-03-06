﻿using AutoMapper;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Persistence
{
    /// <summary>
    /// A class the initializes a method that makes CRUD operations possible throughout the entire program.
    /// </summary>
    public static class AutomapperBootstrapper
    {
        /// <summary>
        /// Creates the road maps for CRUD operations throughout the entire program
        /// </summary>
        public static void Initialize()
        {
            Mapper.CreateMap<openTill.Persistence.Product, ProductDTO>();
            Mapper.CreateMap<openTill.Persistence.Brand, BrandDTO>();
            Mapper.CreateMap<openTill.Persistence.Category, CategoryDTO>();
            Mapper.CreateMap<openTill.Persistence.Employee, EmployeeDTO>();
            Mapper.CreateMap<ProductDTO, openTill.Persistence.Product>();
            Mapper.CreateMap<BrandDTO, openTill.Persistence.Brand>();
            Mapper.CreateMap<CategoryDTO, openTill.Persistence.Category>();
            Mapper.CreateMap<EmployeeDTO, openTill.Persistence.Employee>();
        }
    }
}
