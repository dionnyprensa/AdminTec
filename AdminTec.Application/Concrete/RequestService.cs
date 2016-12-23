using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class RequestService : IRequest
    {
        private readonly IRepository<Request> _repository;

        public RequestService(IRepository<Request> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<Request> ToList()
        {
            return _repository.ToList();
        }

        public void Add(Request entity)
        {
            _repository.Add(entity);
        }

        public Request Find(Request entity)
        {
            return _repository.Find(entity);
        }

        public Request FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(Request entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Request entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(Request entity)
        {
            var validator = new RequestValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(Request entity)
        {
            var validator = new RequestValidator();
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