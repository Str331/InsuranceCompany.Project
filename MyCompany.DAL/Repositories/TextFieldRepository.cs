using Company.DAL.Interfaces;
using Company.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL.Repositories
{
    public class TextFieldRepository : ITextFieldRepository
    {
        private readonly AppDbContext context;
        public TextFieldRepository(AppDbContext context) => this.context = context;

        public IQueryable<TextField> GetTextFields() => context.textFields;

        public TextField GetTextFieldById(Guid id) =>
            context.textFields.FirstOrDefault(x => x.Id == id);

        public TextField GetTextFieldByCodeword(string codeWord) =>
            context.textFields.FirstOrDefault(x => x.CodeWord == codeWord);

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        
        public void DeleteTextField(Guid id)
        {
            context.textFields.Remove(new TextField() { Id = id });
            context.SaveChanges();
        }
    }
}
