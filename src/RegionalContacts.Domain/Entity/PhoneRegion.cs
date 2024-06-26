﻿namespace RegionalContacts.Domain.Entity;

public class PhoneRegion : EntityBase
{
    public short RegionNumber { get; set; }
    public ICollection<Contact> Contacts { get; set; } = [];
}
