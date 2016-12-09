using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Bot001.Language
{
    // from publish screen in luis
    [Serializable]
    [LuisModel("8aae4872-d0b3-43b7-905f-cbd5cc6f268e", "701cb6dc237a46428f5ad2737b9229a2")]
    public class LandlordDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            string message = "unknown";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            string message = "greeting";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }

        [LuisIntent("Agree")]
        public async Task Agree(IDialogContext context, LuisResult result)
        {
            string message = "agree";
            await context.PostAsync(message);
            context.Wait(MessageReceived);
        }


    }
}