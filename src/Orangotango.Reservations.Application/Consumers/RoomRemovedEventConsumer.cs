﻿using MassTransit;
using Orangotango.Core.Abstractions;
using Orangotango.Core.Bus;
using Orangotango.Events.Rooms;

namespace Orangotango.Reservations.Application.Consumers;

public class RoomRemovedEventConsumer : ConsumerBase<RoomRemovedEvent>
{
    private readonly ILoggerService _loggerService;

    public RoomRemovedEventConsumer(ILoggerService loggerService) =>
        _loggerService = loggerService;

    public override async Task Consume(ConsumeContext<RoomRemovedEvent> context)
    {
        _loggerService.Information("RoomRemovedEventConsumer", context.Message.AggregateId.ToString(), context.Message.TranceId);

        await Task.CompletedTask;
    }
}