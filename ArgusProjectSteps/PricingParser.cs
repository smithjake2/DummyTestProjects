using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArgusProjectSteps.Context;
using Newtonsoft.Json.Linq;

namespace ArgusProjectSteps
{
    public class PricingParser
    {
        public PricingContext GetJSON()
        {
            using StreamReader reader = new("Configuration\\priceConfig.json");
            var json = reader.ReadToEnd();
            var jArray = JArray.Parse(json);
            PricingContext pricingContext = jArray[0].ToObject<PricingContext>();
            return pricingContext;
        }
    }
}
