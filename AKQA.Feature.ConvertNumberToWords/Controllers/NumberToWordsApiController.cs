using AKQA.Feature.ConvertNumberToWords.Repositories;
using System;
using System.Web.Http;

namespace AKQA.Feature.ConvertNumberToWords.Controllers
{
    [RoutePrefix("api/numbertowords")]
    public class NumberToWordsApiController : ApiController
    {
        [Route("convertnumbertowords/{number}")]
        [HttpGet]
        public string ConvertNumberToResult(string number)
        {
            string result = string.Empty;
            try
            {
                decimal amount;
                var isNumber = decimal.TryParse(number, out amount);
                // Can use any dependency injection framework instead of creating object using new keyword
                NumberToWordsRepository numberToWordObject = new NumberToWordsRepository();
                return isNumber ? numberToWordObject.GetWordsFromAmount(amount) : "Number is invalid";              
            }
            catch (Exception ex)
            {
                result = "Problem in coverting number to words " + ex.Message;

            }
            return result;
        }

    }

}
