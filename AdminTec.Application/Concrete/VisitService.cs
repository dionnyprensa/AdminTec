using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class VisitService : IVisit
    {
        private readonly IRepository<Visit> _repository;

        public VisitService(IRepository<Visit> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<Visit> ToList()
        {
            return _repository.ToList();
        }

        public void Add(Visit entity)
        {
            _repository.Add(entity);
        }

        public Visit Find(Visit entity)
        {
            return _repository.Find(entity);
        }

        public Visit FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(Visit entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Visit entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(Visit entity)
        {
            var validator = new VisitValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(Visit entity)
        {
            var validator = new VisitValidator();
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