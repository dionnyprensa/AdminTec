using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class TonerService : IToner
    {
        private readonly IRepository<Toner> _repository;

        public TonerService(IRepository<Toner> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<Toner> ToList()
        {
            return _repository.ToList();
        }

        public void Add(Toner entity)
        {
            _repository.Add(entity);
        }

        public Toner Find(Toner entity)
        {
            return _repository.Find(entity);
        }

        public Toner FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(Toner entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Toner entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(Toner entity)
        {
            var validator = new TonerValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(Toner entity)
        {
            var validator = new TonerValidator();
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