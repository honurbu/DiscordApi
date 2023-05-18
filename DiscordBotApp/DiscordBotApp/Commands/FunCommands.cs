using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotApp.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("test")]
        public async Task TestCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Bir şeye ihtiyacın var mı gardaşım !");
        }


        [Command("topla")]
        public async Task ToplaCommand(CommandContext ctx, float num1, float num2)
        {
            float sum = num1 + num2;
            await ctx.Channel.SendMessageAsync($"Bunu mu toplayamadın cahil {num1} + {num2} = {sum}");
        }


        [Command("cikar")]
        public async Task CikarCommand(CommandContext ctx, float num1, float num2)
        {
            float minus = num1 - num2;
            await ctx.Channel.SendMessageAsync($"Bunu mu çıkaramadın cahil {num1} - {num2} = {minus}");
        }

        [Command("carp")]
        public async Task CarpCommand(CommandContext ctx, float num1, float num2)
        {
            float multiplication = num1 * num2;
            await ctx.Channel.SendMessageAsync($"Sana çarpar gibi çarptım ve sonuç {num1} x {num2} = {multiplication}");
        }

        [Command("bolme")]
        public async Task BolCommand(CommandContext ctx, float num1, float num2)
        {
            float division = num1 / num2;
            await ctx.Channel.SendMessageAsync($"Seni böle bölerim {num1} / {num2} = {division}");
        }
    }
}
