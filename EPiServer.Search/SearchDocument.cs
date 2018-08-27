using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.Search
{
    public class SearchDocument : ISearchDocument
    {
        private readonly List<ISearchField> _fields = new List<ISearchField>();

        /// <summary>Gets the field count.</summary>
        /// <value>The field count.</value>
        public virtual int FieldCount
        {
            get
            {
                return this._fields.Count;
            }
        }

        /// <summary>
        /// Gets the <see cref="T:Mediachase.Search.ISearchField" /> at the specified index.
        /// </summary>
        /// <value></value>
        public virtual ISearchField this[int index]
        {
            get
            {
                return this._fields[index];
            }
        }

        /// <summary>
        /// Gets the <see cref="T:Mediachase.Search.ISearchField" /> with the specified name.
        /// </summary>
        /// <value></value>
        public virtual ISearchField this[string name]
        {
            get
            {
                int index = this.IndexForName(name);
                if (index < 0)
                    return (ISearchField)null;
                return this._fields[index];
            }
        }

        /// <summary>Adds the specified field.</summary>
        /// <param name="field">The field.</param>
        public virtual void Add(ISearchField field)
        {
            this._fields.Add(field);
        }

        /// <summary>Removes the field.</summary>
        /// <param name="name">The name.</param>
        public virtual void RemoveField(string name)
        {
            int index = this.IndexForName(name);
            if (index < 0)
                return;
            this._fields.RemoveAt(index);
        }

        private int IndexForName(string name)
        {
            return this._fields.FindIndex((Predicate<ISearchField>)(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
