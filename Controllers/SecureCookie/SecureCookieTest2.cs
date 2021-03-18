using System.Net;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace WebFox.Controllers.SecureCookie
{
    public class SecureCookieTest2
    {
        [HttpGet("{response}")]
        [HttpGet("{request}")]
        // HttpCookie myCookie = new HttpCookie("Sensitive cookie");

        public void Unsafe(HttpWebResponse response, HttpWebRequest request)
        {
            var password = "p-" + RandomNumberGenerator.GetInt32(200000000, 2000000000);
            response.Cookies.Add(new Cookie("password", password));
        }
    }
}