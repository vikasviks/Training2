using DStore.Data;
using DStore.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DStore.UI
{
    public class EFQuery
    {
        public static void StaffDetail()
        {
            using (DStoreContext context = new DStoreContext())
            {
                var query = from stafff in context.Set<Staff>()
                            join roles in context.Set<Role>() on stafff.RoleId equals roles.RoleId
                            join address in context.Set<Address>() on stafff.AddressId equals address.AddressId
                            where roles.RoleName == "Manager"
                            select new
                            {
                                stafff.FirstName,
                                stafff.LastName,
                                stafff.Gender,
                                stafff.PhoneNumber,
                                stafff.Salary,
                                address.AddressLine1,
                                address.AddressLine2,
                                address.City,
                                address.Pincode,
                                roles.RoleName,
                                roles.Description
                            };

                foreach (var staff in query)
                {
                    Console.WriteLine($"{staff.FirstName},{staff.LastName},{staff.Gender},{staff.AddressLine1},{staff.AddressLine2}," +
                        $"{staff.Salary},{staff.PhoneNumber},{staff.City}{staff.Pincode}");
                }
            }

        }


    }
}
