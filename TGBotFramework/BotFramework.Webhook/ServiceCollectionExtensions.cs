﻿using BotFramework.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace BotFramework.Webhook;

public static class ServiceCollectionExtensions
{
    public static void AddTelegramBotWebhookUpdateProvider(this IServiceCollection collection)
    {
        collection.AddSingleton<IUpdateProvider, WebhookUpdateProvider>();
    }

    public static void AddTelegramBotWebhook(this IServiceCollection collection)
    {
        collection.AddTelegramBotWebhookUpdateProvider();
        collection.AddTelegramBot();
    }
}
