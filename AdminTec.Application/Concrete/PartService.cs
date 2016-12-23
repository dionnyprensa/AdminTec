using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class PartService : IPart
    {
        private readonly IRepository<Part> _repository;

        public PartService(IRepository<Part> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<Part> ToList()
        {
            return _repository.ToList();
        }

        public void Add(Part entity)
        {
            _repository.Add(entity);
        }

        public Part Find(Part entity)
        {
            return _repository.Find(entity);
        }

        public Part FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(Part entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Part entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(Part entity)
        {
            var validator = new PartValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(Part entity)
        {
            var validator = new PartValidator();
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