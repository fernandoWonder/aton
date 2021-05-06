﻿using Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Interfaces.Repositories
{
    public interface IRemission : IBaseRepository<Permission>
    {
        Permission getForIdUser(int idUser);
    }
}