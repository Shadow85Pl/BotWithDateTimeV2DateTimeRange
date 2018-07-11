using BotWithDateTimeV2DateTimeRange.Actions;
using Microsoft.Bot.Builder.CognitiveServices.LuisActionBinding.Bot;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace BotWithDateTimeV2DateTimeRange.Dialogs
{
    [Serializable]
    public class RootDialog : LuisActionDialog<object>
    {
        public RootDialog(IEnumerable<Assembly> assemblies, params ILuisService[] services) : base(assemblies, services)
        {
        }

        protected override async Task NoActionDetectedAsync(IDialogContext context, IMessageActivity message)
        {
            await context.PostAsync("I dont understand");
        }

        [LuisIntent("FindHotel")]
        public async Task FindHotelIntent(IDialogContext context, object result)
        {
            var res = result as FindHotelAction;
            await context.PostAsync($"{res.When}");
        }
    }
}