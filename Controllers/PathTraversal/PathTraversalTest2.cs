﻿using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace WebFox.Controllers.PathTraversal
{
    public class PathTraversalTest2 : ControllerBase
    {
        static readonly string rootFolder = @"C:\Temp\Data\";    
    
        [HttpGet("{userInput}")]
        static void Test(string userInput)    
        {    
            try
            {
                var fullPath = Path.Combine(rootFolder, userInput);
                System.IO.File.Delete(fullPath);
            }    
            catch (IOException ioExp)    
            {    
                Console.WriteLine(ioExp.Message);    
            }
            Console.ReadKey();    
        }
    }
}