using DAL;
using DTO;
using ExternalSystem.Service;
using System;

namespace BLL
{
    public class UserBll
    {
        private UserDao _userDAO = new UserDao();
        private Service _service = new Service();

        public UserDto GetUser(int id)
        {
            return _userDAO.GetUser(id);
        }

        public string AddUser(UserDto user)
        {
            /* validate business logic */

            if (_service.IsLoginIdExist(user.LoginId))
            {
                return "Login Id already taken by another user. Please try a different one.";
            }

            //if (_userDAO.IsEmailExist(user.Email))
            //{
            //    return "Email Address already exists";
            //}

            try
            {
                _userDAO.InsertUser(user);
                return "Ok";
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateUser(UserDto user)
        {
            try
            {
                _userDAO.UpdateUser(user);
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(UserDto user)
        {
            try
            {
                _userDAO.DeleteUser(user);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
