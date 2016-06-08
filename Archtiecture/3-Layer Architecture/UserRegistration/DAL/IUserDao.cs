using DTO;
using System.Collections.Generic;

namespace DAL
{
    // defines methods to access Users.
    // this is a database-independent interface. Implementations are database specific
    // ** DAO Pattern

    public interface IUserDao
    {
        // gets a specific Users
        UserDto GetUser(int id);

        // gets a specific User by email
        UserDto GetUserByEmail(string email);

        // gets a sorted list of all Users
        List<UserDto> GetUsers(string sortExpression = "Id ASC");

        // gets User given an order
        UserDto GetUserByDateOfBirth(string dateTime);

        // gets Users with order statistics in given sort order.
        List<UserDto> GetActiveUsers(string sortExpression = "Id ASC");

        // inserts a new User
        // following insert, User object will contain the new identifier
        void InsertUser(UserDto User);

        // updates a User
        void UpdateUser(UserDto User);

        // deletes a User
        void DeleteUser(UserDto User);
    }
}
