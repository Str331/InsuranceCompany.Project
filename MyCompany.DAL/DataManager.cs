using Company.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DAL
{
    public class DataManager
    {
        public ITextFieldRepository textFields { get; set; }
        public IServiceItemRepository serviceItems { get; set; }

        public DataManager(ITextFieldRepository textFieldRepository, IServiceItemRepository serviceItemRepository)
        {
            textFields = textFieldRepository;
            serviceItems = serviceItemRepository;
        }
    }
}
