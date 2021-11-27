using PS_server.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_server.BusinesLogic.Core.interfaces
{
    public interface IUserService
    {

        Task<UserInformationBlo> Auth(int phoneNumberPrefix, int phoneNumber, int password);
        Task<UserInformationBlo> Registration(int phoneNumberPrefix, int phoneNumber, int password);
        Task<UserInformationBlo> Get(int UserId);
        Task<UserUpdateBlo> Update(int phoneNumberPrefix, int phoneNumber, int password, UserUpdateBlo userUserUpdateBlo);
        Task<bool> DoesExist(int phoneNumberPrefix, int phoneNumber); 
    }
}   
