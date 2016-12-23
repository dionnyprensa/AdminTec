using AdminTec.Application.Interfaces;
using AdminTec.Application.Validators;
using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminTec.Application.Concrete
{
    public class UserService : IUser
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> Repository)
        {
            _repository = Repository;
        }

        public IEnumerable<User> ToList()
        {
            return _repository.ToList();
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

        public User SignIn(string username, string pass)
        {
            var users = ToList().ToList();

            if (users != null)
            {
                foreach (var user in users)
                {
                    if (user.UserName == username)
                        if (Decrypt(pass, user.Password))
                            return user;
                }
            }

            return null;
        }

        public string Encrypt(string pass)
        {
            byte[] passToBytes = Encoding.UTF8.GetBytes(pass);
            string BytesToEncrypt = Convert.ToBase64String(passToBytes);

            BytesToEncrypt = BytesToEncrypt.Replace("+", "A");
            BytesToEncrypt = BytesToEncrypt.Replace(@"\", "B");
            BytesToEncrypt = BytesToEncrypt.Replace(@"/", "C");

            passToBytes = Encoding.UTF8.GetBytes(BytesToEncrypt);
            BytesToEncrypt += Convert.ToBase64String(passToBytes);
            
            return BytesToEncrypt;
        }

        public bool Decrypt(string passLogin, string passDb)
        {
            /*
            byte[] DecryptBytes = Convert.FromBase64String(passDb);
            string DecryptedText = Encoding.UTF8.GetString(DecryptBytes);

            DecryptedText = DecryptedText.Replace("A", "+");
            DecryptedText = DecryptedText.Replace("B", @"\");
            DecryptedText = DecryptedText.Replace("B", @"/");

            return DecryptedText == Encrypt(passLogin) ? true : false;
             */

            return passDb == Encrypt(passLogin) ? true : false;
        }
    }
}