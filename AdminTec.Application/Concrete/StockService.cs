using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class StockService : IStock
    {
        private readonly IRepository<Stock> _repository;

        public StockService(IRepository<Stock> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<Stock> ToList()
        {
            return _repository.ToList();
        }

        public void Add(Stock entity)
        {
            _repository.Add(entity);
        }

        public Stock Find(Stock entity)
        {
            return _repository.Find(entity);
        }

        public Stock FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(Stock entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Stock entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(Stock entity)
        {
            var validator = new StockValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(Stock entity)
        {
            var validator = new StockValidator();
            var result = validator.Validate(entity);
            var errors = new List<ErrorMessage>();

            foreach (var item in result.Errors)
            {
                errors.Add(new ErrorMessage { Key = item.PropertyName, Error = item.ErrorMessage });
            }

            return errors;
        }
    }
}