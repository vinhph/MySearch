using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.Search
{
    public interface ISearchDocument
    {
        /// <summary>Gets the field count.</summary>
        /// <value>The field count.</value>
        int FieldCount { get; }

        /// <summary>Adds the specified field.</summary>
        /// <param name="field">The field.</param>
        void Add(ISearchField field);

        /// <summary>Removes the field.</summary>
        /// <param name="name">The name.</param>
        void RemoveField(string name);

        /// <summary>
        /// Gets the <see cref="T:Mediachase.Search.ISearchField" /> at the specified index.
        /// </summary>
        /// <value></value>
        ISearchField this[int index] { get; }

        /// <summary>
        /// Gets the <see cref="T:Mediachase.Search.ISearchField" /> with the specified name.
        /// </summary>
        /// <value></value>
        ISearchField this[string name] { get; }
    }
}
