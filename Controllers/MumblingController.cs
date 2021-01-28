using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        // Make a new answer/result string Variable
        // FOR each letter (and index) in the string provided
        // Append to our result the Capitalization of the current letter
        // Loop FOR the amount of the index(from the for each)
        // Append to our result the lowercase letter
        // IF we’re at anything that is not the last letter append a “-”
        // Return the answer/result

        [HttpGet]
        public string Mumbling(string s)
        {
            string answer = "";

            for (var index = 0; index < s.Length; index++)
            {
                var letter = s[index];

                for (var counter = 0; counter < index + 1; counter++)
                {
                    if (counter == 0)
                    {
                        answer += $"{letter}".ToUpper();
                    }
                    else
                    {
                        answer += $"{letter}".ToLower();
                    }
                }

                if (index != s.Length - 1)
                {
                    answer += "-";

                }
            }

            return answer;



        }


    }
}