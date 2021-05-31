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
	public class DepartmentController : ControllerBase
	{
        private readonly DepartmentContext _context;
        private readonly IMapper _mapper;


        public DepartmentController(DepartmentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("staff-members")]
        public StaffModel[] getStaff()
        {

            IQueryable<Staff> query = _context.Staff.Include(c => c.Address).Include(r => r.Role);
			
			var result = query.ToArray();
			return _mapper.Map<StaffModel[]>(result);
		}

        [HttpGet("staff-members/{id}")]
        public StaffModel GetBycode(int id, bool isAddress = false, string name = "")
        {

            IQueryable<Staff> query = _context.Staff
            .Include(t => t.Role);
            if (isAddress)
            {
                query = query.Include(r => r.Address);
            }
            query.Where(x => x.staffId == id);

            var result = query.FirstOrDefault();
            return _mapper.Map<StaffModel>(result);

        }

        //Adding a new staff

        [HttpPost]
        public Staff createstaff(StaffPostModel staffitem)
        {
            _context.Staff.Add(_mapper.Map<Staff>(staffitem));
            _context.SaveChanges();
            return null;
        }

         [HttpPut("staff-members/{id}")]
        public Staff updateStaff(StaffPostModel staffitem, int id)
        {
            var query = _context.Staff.Where(i => i.staffId == id).FirstOrDefault();
            _mapper.Map(staffitem, query);
            _context.SaveChanges();
            return null;
        }

    }
}
