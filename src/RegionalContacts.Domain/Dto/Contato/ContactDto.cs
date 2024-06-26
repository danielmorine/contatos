﻿namespace RegionalContacts.Domain.Dto.Contato;

public class ContactDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public short RegionNumber { get; set; }
}
