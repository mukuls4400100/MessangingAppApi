using MessangingAppApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.EntityFrameworkCore;
using System.Web;


namespace MessangingAppApi1.Controllers
{
    [RoutePrefix("Api/login")]
    public class LoginController : ApiController
    {
        MessangingAppApiEntities1 db = new MessangingAppApiEntities1();

        [Route("InsertEmployee")]
        [HttpPost]
        public object InsertEmployee(Login l)

        {

            try

            {


                user EL = new user();

                if (EL.UserId == 0)
                {

                    EL.Username = l.Name;

                    EL.Region = l.Region;

                    EL.Email = l.Email;

                    EL.Password = l.Password;

                    EL.CreatedAt = DateTime.Now;

                    db.users.Add(EL);

                    db.SaveChanges();
                    return new Response

                    { Status = "Success", Message = "Record SuccessFully Saved." };

                }

            }

            catch (Exception)

            {
    
                throw;
    
            }

            return new Response

            { Status = "Error", Message = "Invalid Data." };

        }

        [Route("Login")]

        [HttpPost]

        public Response employeeLogin(Login login)
        {

            var log = db.users.Where(x => x.Email.Equals(login.Email) && x.Password.Equals(login.Password)).FirstOrDefault();
            var res1 = db.users.Where(item => item.Email == login.Email).ToList();

            if (res1.Count() == 0)
            {
                return new Response { Status = "Invalid", Message = "Not have an account" };

            }
            else if (log!=null)
            {
                return new Response { Status = "Success", Message = "Login Successfully", name= log.Username, userId= log.UserId };
            }
            else
            {
                return new Response { Status = "Error", Message = "Invalid Password" };
            }


        }
    }
}
