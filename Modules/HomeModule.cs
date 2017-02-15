using Nancy;
using System.Collections.Generic;
using PalindromesApp.Objects;

namespace PalindromesApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/"] = _ => {
                Palindromes newPalindromes = new Palindromes(Request.Form["word"]);
                newPalindromes.SetReverseString();
                return View["index.cshtml", newPalindromes];
            };
        }
    }
}
