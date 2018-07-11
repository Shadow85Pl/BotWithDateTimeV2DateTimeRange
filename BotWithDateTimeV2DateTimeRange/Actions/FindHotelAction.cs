using Microsoft.Bot.Builder.CognitiveServices.LuisActionBinding;
using System;
using System.Threading.Tasks;

namespace BotWithDateTimeV2DateTimeRange.Actions
{
    [Serializable]
    [LuisActionBinding("FindHotel", FriendlyName = "FindHotel")]
    public class FindHotelAction : BaseLuisAction
    {
        [LuisActionBindingParam(BuiltinType = BuiltInDatetimeV2Types.DateTimeRange, Order = 1)]
        public DateTime? When { get; set; }

        public override Task<object> FulfillAsync()
        {
            return Task.FromResult<object>(this);
        }
    }
}