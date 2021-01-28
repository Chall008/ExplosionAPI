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
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explode(string who)
        {

            var answer = "";

            // for each letter in the string given
            for (int index = 0; index < who.Length; index++)
            {
                var letter = who[index];

                //   if the letter is a '1' then
                if (letter == '1')
                {
                    answer += "1";
                }
                if (letter == '2')
                {
                    answer += "22";
                }
                if (letter == '3')
                {
                    answer += "333";
                }
                if (letter == '4')
                {
                    answer += "4444";
                }
                if (letter == '5')
                {
                    answer += "55555";
                }
                if (letter == '6')
                {
                    answer += "666666";
                }
                if (letter == '7')
                {
                    answer += "7777777";
                }
                if (letter == '8')
                {
                    answer += "88888888";
                }
                if (letter == '9')
                {
                    answer += "999999999";
                }
            }

            return answer;



        }

    }

}