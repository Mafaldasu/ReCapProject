using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstaract
{
    public interface IUserService
    {
        IResult Add(User user);
        IDataResult <List<User>> GetByFirstName(string userName);
        IDataResult<List<User>> GetAll();
    }
}
