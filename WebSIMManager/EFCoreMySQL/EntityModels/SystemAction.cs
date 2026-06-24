using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMySQL.EntityModels
{
    public class SystemAction : EntityCommon
    {
        public string ActionName { get; set; }
        public string? ActionDesc { get; set; }
        public string? Note { get; set; }
    }
}
