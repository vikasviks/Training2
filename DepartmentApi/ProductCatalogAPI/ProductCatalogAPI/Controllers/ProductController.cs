using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Entities;
using ProductCatalogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
    {
        private readonly DepartmentContext _context;
        private readonly IMapper _mapper;


        public ProductController(DepartmentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet("Product-items")]
        public ProductModel[] getproducts()
        {
          

                IQueryable<Product> query = _context.Product.Include(c => c.Category);

                var result = query.ToArray();
                return _mapper.Map<ProductModel[]>(result);
            

        }

        [HttpGet("Product-items/{id}")]
        public ProductModel[] getEachProduct(int id)
        {
            IQueryable<Product> query = _context.Product.Include(c => c.Category).Where(t => t.ProductId == id);
            var result = query.ToArray();
            return _mapper.Map<ProductModel[]>(result);
        }


        [HttpPost]
        public Product createproduct(ProductPostModel productitem)
        {
            _context.Product.Add(_mapper.Map<Product>( productitem));
            _context.SaveChanges();
            return _mapper.Map<Product>(productitem);
        }

		[HttpPut("Product-items/{id}")]
        
        public Product updateproduct(ProductPostModel productitem, int id)
		{
            var query = _context.Product.Where(i => i.ProductId == id).FirstOrDefault();
			_mapper.Map(productitem, query);
			_context.SaveChanges();
			return null;
		}

	}
}
