using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class TechnicianService : ITechnician
    {
        private readonly IRepository<Technician> _repository;

        public TechnicianService(IRepository<Technician> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<Technician> ToList
        {
            get
            {
                return _repository.ToList;
            }
        }

        public void Add(Technician entity)
        {
            _repository.Add(entity);
        }

        public Technician Find(Technician entity)
        {
            return _repository.Find(entity);
        }

        public Technician FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(Technician entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Technician entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(Technician entity)
        {
            var validator = new TechnicianValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(Technician entity)
        {
            var validator = new TechnicianValidator();
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