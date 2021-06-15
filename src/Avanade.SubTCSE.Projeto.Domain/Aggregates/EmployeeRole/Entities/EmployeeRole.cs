using System;
using System.Collections.Generic;
using System.Text;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; private set; }

        public string RoleName { get; set; }
        
    }
}
