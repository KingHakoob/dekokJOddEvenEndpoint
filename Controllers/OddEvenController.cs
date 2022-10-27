// Jacob Dekok
// 10/25/2022
// Odd or Even API
// This program will take a user input and checks if it's a number
// If it is a number then it will let the user know if it's odd or even
//Peer Reviewed By: Pedro Castaneda - I really like the clean code! Looks simple and easy to understand. Great job on the validation!


using Microsoft.AspNetCore.Mvc;

namespace dekokJOddEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddEvenController : ControllerBase
{
    [HttpGet]
    [Route("OddEven/{userNum}")]

    public string OddOrEven(string userNum)
    {
        if(!int.TryParse(userNum, out int num)) return "Not Valid Number";
        if (num % 2 == 0) return $"{num} is even"; else return $"{num} is odd";
    }
}
