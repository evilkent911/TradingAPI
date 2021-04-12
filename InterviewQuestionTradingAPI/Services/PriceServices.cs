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
            _tradingApi.OnPricing += TradingApi_OnPricing;
            foreach (var symbol in _tradingApi.GetSymbols())
            {
                _tradingApi.SubscribeSymbol(symbol.Name);
            }
        }

        private void TradingApi_OnPricing(object sender, Price e)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Symbol> GetSymbols()
        {
            return _tradingApi.GetSymbols();
        }
    }
}
