using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcheggio.clases
{
    public class Usuario
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }


        public Usuario(int _id, string _name, string _username, string _password, string _confirmPassword)
        {
            id = _id;
            name = _name;
            username = _username;
            password = _password;
            confirmPassword = _confirmPassword;
        }
    }
}
