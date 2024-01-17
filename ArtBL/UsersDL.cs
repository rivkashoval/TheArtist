using ArtDL.Modelsa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtDL
{
    public class UsersDL : IUsersDL
    {
        private ArtProjectContext _ArtProjectContext;

        public UsersDL(ArtProjectContext artProjectContext)
        {
            _ArtProjectContext = artProjectContext;
        }
        //get
        public async Task<List<User>> GetUsers()
        {
            try
            {
                //רק מסטר
                List<User> users =await  _ArtProjectContext.Users.Where(x=>x.LevelId==2).ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<User> Login(string email, string password)
        {
           User user= await _ArtProjectContext.Users.FirstOrDefaultAsync(x=>x.Mail==email&& x.Password==password);
            return user;

        }
        //הוספה
        public async Task<bool> AddUsers(User user)
        {
            try
            {
               await _ArtProjectContext.Users.AddAsync(user);
                 await _ArtProjectContext.SaveChangesAsync();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        //מחיקה
        public async Task<bool> RemoveUsers(int userId)
        {
            try
            {
                
                User user =await _ArtProjectContext.Users.FirstOrDefaultAsync(item => item.Id == userId);
                _ArtProjectContext.Users.Remove(user);
               await _ArtProjectContext.SaveChangesAsync();
                return true;
            }

            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        //עדכון
        public async Task<bool> UpdateUsers(User user, int userId)

        {
            try
            {

                User userToUpdate = await _ArtProjectContext.Users.Where(item => item.Id == userId).FirstOrDefaultAsync();


                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.Phone=user.Phone;
                userToUpdate.Mail=user.Mail;
                userToUpdate.Password=user.Password;
                userToUpdate.LevelId = user.LevelId;
                userToUpdate.Desc=user.Desc;    
                _ArtProjectContext.Users.Update(userToUpdate);

                await _ArtProjectContext.SaveChangesAsync();
                return true;

            }

            catch (Exception ex)

            {

                throw ex;

            }


        }


    }
}
