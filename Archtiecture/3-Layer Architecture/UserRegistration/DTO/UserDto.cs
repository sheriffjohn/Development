using System;

namespace DTO
{
    public class UserDto
    {
        private int _id;

        private string _loginId;

        private string _password;

        private string _firstName;

        private string _lastName;

        private DateTime _dateOfBirth;

        private string _gender;

        private string _email;

        private string _userType;

        private DateTime _registeredDate;

        private bool _isActive;

        private string _resetPasswordKey;

        public int Id

        {

            get { return _id; }

            set { _id = value; }
        }

        public string LoginId

        {

            get { return _loginId; }

            set { _loginId = value; }

        }

        public string Password

        {

            get { return _password; }

            set { _password = value; }

        }

        public string FirstName

        {

            get { return _firstName; }

            set { _firstName = value; }

        }

        public string LastName

        {

            get { return _lastName; }

            set { _lastName = value; }

        }

        public DateTime DateOfBirth

        {

            get { return _dateOfBirth; }

            set { _dateOfBirth = value; }

        }

        public string Gender

        {

            get { return _gender; }

            set { _gender = value; }

        }

        public string Email

        {

            get { return _email; }

            set { _email = value; }

        }

        public string UserType

        {

            get { return _userType; }

            set { _userType = value; }

        }

        public DateTime RegisteredDate

        {

            get { return _registeredDate; }

            set { _registeredDate = value; }

        }

        public bool IsActive

        {

            get { return _isActive; }

            set { _isActive = value; }

        }

        public string ResetPasswordKey

        {

            get { return _resetPasswordKey; }

            set { _resetPasswordKey = value; }

        }

    }
}
