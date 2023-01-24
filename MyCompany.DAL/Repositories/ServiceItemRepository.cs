using Company.DAL.Interfaces;
using Company.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Repositories
{
    public class ServiceItemRepository : IServiceItemRepository
    {
        private readonly AppDbContext context;
        public ServiceItemRepository(AppDbContext context) => this.context = context;

        public IQueryable<ServiceItem> GetServiceItems() => context.serviceItems;

        public ServiceItem GetServiceItemById(Guid id) =>
            context.serviceItems.FirstOrDefault(x => x.Id == id);

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.serviceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
