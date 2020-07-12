
using Data.Entity;
using Data.UnitOfWork;
using Service.Dto;
using Service.Service.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProductService : IProuductService
    {
        private IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       

        public int add(ProductDto dto)
        {
            Product model = new Product();
            model.Id = dto.Id;
            model.Name = dto.Name;
            model.Description = dto.Description;
            model.Price = dto.Price;


            _unitOfWork.Product.Add(model);
            _unitOfWork.SaveChanges();
            return model.Id;
        }


    }
}
