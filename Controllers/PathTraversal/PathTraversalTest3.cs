using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace WebFox.Controllers.PathTraversal
{
    public class PathTraversalTest3 : ControllerBase
    {
        private const string RootFolder = @"C:\Temp\Data\"; 
        
        [HttpGet("{userInput}")]
        public void Test(string userInput)    
        {
            var reader = new StreamReader(RootFolder + userInput);
            reader.ReadToEnd();
        }
    }
}