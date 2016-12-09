using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class EquipmentService : IEquipment
    {
        private readonly IRepository<Equipment> _repository;

        public EquipmentService(IRepository<Equipment> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<Equipment> ToList
        {
            get
            {
                return _repository.ToList;
            }
        }

        public void Add(Equipment entity)
        {
            _repository.Add(entity);
        }

        public Equipment Find(Equipment entity)
        {
            return _repository.Find(entity);
        }

        public Equipment FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(Equipment entity)
        {
            _repository.Update(entity);
        }

        public void Remove(Equipment entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(Equipment entity)
        {
            var validator = new EquipmentValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(Equipment entity)
        {
            var validator = new EquipmentValidator();
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