using AutoMapper;
using ProductCatalogAPI.Entities;
using ProductCatalogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Mapping
{
	public class ModelMapping: Profile
	{
		public  ModelMapping() 
		{
			this.CreateMap<Staff, StaffModel>();
			this.CreateMap<Staff, StaffPostModel>().ReverseMap();
			this.CreateMap<Address, AddressModel>();
			this.CreateMap<Role, RoleModel>();
			this.CreateMap<Product, ProductModel>().ReverseMap();
			this.CreateMap<Product, ProductPostModel>().ReverseMap();
			this.CreateMap<Category, CategoryModel>();

		}
	}
}
