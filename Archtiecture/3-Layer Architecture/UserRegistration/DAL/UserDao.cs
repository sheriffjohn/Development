using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class UserDao : IUserDao
    {
        private Db db = new Db();
        private MapperHelper<UserEntity, UserDto> mapper = new MapperHelper<UserEntity, UserDto>();

        public void DeleteUser(UserDto User)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetActiveUsers(string sortExpression = "Id ASC")
        {
            throw new NotImplementedException();
        }

        public UserDto GetUser(int Id)
        {
            string sql =
            @" SELECT Id, FirstName, LastName, Email, Birthday, Gender , Password
                 FROM [User]
                WHERE Id = @UserId";

            object[] parms = { "@UserId", Id };

            var source = db.Read(sql, Make, parms).FirstOrDefault();

            return mapper.MapToDto(source);
        }

        public UserDto GetUserByDateOfBirth(string dateTime)
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetUsers(string sortExpression = "Id ASC")
        {
            throw new NotImplementedException();
        }

        public void InsertUser(UserDto User)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDto User)
        {
            throw new NotImplementedException();
        }

        // creates a User object based on DataReader
        static Func<IDataReader, UserEntity> Make = reader =>
           new UserEntity
           {
               Id = reader["Id"].AsId(),
               FirstName = reader["FirstName"].AsString(),
               LastName = reader["LastName"].AsString(),
               Email = reader["Email"].AsString(),
               BirthDay = reader["BirthDay"].AsDateTime(),
               Gender = reader["Gender"].AsString(),
               Password = reader["Password"].AsString(),
           };

        // creates a User object with overrided  lastname based on DataReader
        static Func<IDataReader, UserEntity> MakeWithFixedValues = reader =>
        {
            var user = Make(reader);
            user.LastName = "Awesome";

            return user;
        };
    }
}
