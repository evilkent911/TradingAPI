using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using MockTradingApi;

namespace InterviewQuestionTradingAPI.Services
{
    public class PriceServices
    {
        private readonly ITradingApi _tradingApi;

        public PriceServices(ITradingApi tradingApi)
        {
            _tradingApi = tradingApi;
        }
    }
}
