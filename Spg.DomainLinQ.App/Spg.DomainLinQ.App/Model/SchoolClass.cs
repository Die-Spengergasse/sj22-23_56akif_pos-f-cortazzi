using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {


        public string Name { get; set; } = string.Empty;
        public string Department => Name.Substring(0, 2);
        public string Guid { get; private set; } = string.Empty;

        protected SchoolClass() { }
        public SchoolClass(string name, string guid)
        {
            Name = name;
            Guid = guid;
        }
    }
}
