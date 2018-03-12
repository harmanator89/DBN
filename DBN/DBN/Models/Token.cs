using System;
using System.Collections.Generic;
using System.Text;

namespace DBN.Models
{
    public class Token
    {
        // Id is actual id from server
        // Access Token String holds actual token string from Server
        // Error description is a place for server to give error if something goes wrong
        // expire date give the data where the token is no longer valid

        public int Id { get; set; }
        public string Access_token { get; set;}
        public string Error_description { get; set; }
        public DateTime Expire_date { get; set; }

        public Token() { }

    }
}
