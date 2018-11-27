using System.Collections.Generic;

namespace DependencyInversionPrincipal
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
