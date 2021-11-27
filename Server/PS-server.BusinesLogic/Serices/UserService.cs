using PS_server.BusinesLogic.Core.interfaces;
using PS_server.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_server.BusinesLogic.Serices
{
    public class UserService : IUserService
    {
        public Task<UserInformationBlo> Auth(int phoneNumberPrefix, int phoneNumber, int password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int phoneNumberPrefix, int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Registration(int phoneNumberPrefix, int phoneNumber, int password)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdateBlo> Update(int phoneNumberPrefix, int phoneNumber, int password, UserUpdateBlo userUserUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
