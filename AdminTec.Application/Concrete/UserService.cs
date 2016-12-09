using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Concrete
{
    public class UserService : IUser
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<User> ToList
        {
            get
            {
                return _repository.ToList;
            }
        }

        public void Add(User entity)
        {
            _repository.Add(entity);
        }

        public User Find(User entity)
        {
            return _repository.Find(entity);
        }

        public User FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Update(User entity)
        {
            _repository.Update(entity);
        }

        public void Remove(User entity)
        {
            _repository.Remove(entity);
        }

        public bool isValid(User entity)
        {
            var validator = new UserValidator();
            var result = validator.Validate(entity);

            return result.IsValid;
        }

        public IList<ErrorMessage> Errors(User entity)
        {
            var validator = new UserValidator();
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