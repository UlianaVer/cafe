﻿using System;
using System.Collections.Generic;

namespace Vereshchagina1.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int RoleId { get; set; }

    public string Status { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<ShiftUser> ShiftUsers { get; set; } = new List<ShiftUser>();
}
