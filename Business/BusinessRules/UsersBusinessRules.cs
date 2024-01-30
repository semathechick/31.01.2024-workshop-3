

using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class UsersBusinessRules
       
    {
        public readonly IUserDal _userDal;
         public UsersBusinessRules(IUserDal userdal) 
        {
            _userDal = userdal;
        }
        public void CheckIfUserNameExists(string userName)
        {
            bool exists = _userDal.Get(Users => Users.FirstName == userName) is not null;
            if (!exists)
            {
                throw new BusinessException("Username is already exists.");
            }
        }
        public void CheckIfUserLastNameExists(string lastName)
        {
            bool exists = _userDal.Get(Users => Users.LastName == lastName) is not null;
            if (!exists)
            {
                throw new BusinessException("Name is already exists.");
            }
        }
        public void CheckIfUserNameLengthIsLongerThan1Letter(string userName)
        {
            
            if (userName.Length<=1)
            {
                throw new BusinessException("Name is too short, Please enter a name longer than 1 letter .");
            }
        }
        public void CheckIfUserNameLengthIsShorterThan50Letters(string userName)
        {

            if (userName.Length >= 50)
            {
                throw new BusinessException("Name shold be shorter than 50 letters.");
            }
        }
        public static void CheckIfNameContainsLetters(string name) 
        {
            foreach(char character in name)
            {
                if(!char.IsLetter(character))
                {
                    throw new BusinessException("Name should not contain special characters.");
                }
            }
        }


    }
}
