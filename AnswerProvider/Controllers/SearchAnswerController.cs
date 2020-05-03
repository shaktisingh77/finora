using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AnswerProvider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchAnswerController : ControllerBase
    {
       private readonly ILogger<SearchAnswerController> _logger;

        public SearchAnswerController(ILogger<SearchAnswerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            int Category = 0;
            int QuestionType = 0;
            SearchAnswer obj = new SearchAnswer();
            return obj.GetAnswer(Category, QuestionType);
        }

        [HttpGet("{Category}/{QuestionType}")]
        public string Get(int Category, int QuestionType)
        {            
            SearchAnswer obj = new SearchAnswer();
            return obj.GetAnswer(Category, QuestionType);
        }
    }
}
