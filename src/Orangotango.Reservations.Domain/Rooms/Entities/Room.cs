﻿using Orangotango.Core.Abstractions;
using Orangotango.Core.Domain;

namespace Orangotango.Reservations.Domain.Rooms.Aggregates;

public sealed class Room : EntityBase, IAggregateRoot
{
    public string Name { get; private set; }
    public int Number { get; private set; }
    public Guid CategoryId { get; private set; }
    public Category Category { get; private set; }

    public Room(Guid id,
        string name,
        int number,
        Guid categoryId)
    {
        Id = id;
        Name = name;
        Number = number;
        CategoryId = categoryId;
    }

    public Room SetName(string name)
    {
        Name = name;
        return this;
    }

    public Room SetNumber(int number)
    {
        Number = number;
        return this;
    }

    public Room SetCategoryId(Guid categoryId)
    {
        CategoryId = categoryId;
        return this;
    }
}
