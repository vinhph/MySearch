using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySearch.Models
{
    public interface ISearchField
    {
        /// <summary>Adds the value.</summary>
        /// <param name="value">The value.</param>
        void AddValue(object value);

        /// <summary>Gets or sets the attributes.</summary>
        /// <value>The attributes.</value>
        string[] Attributes { get; set; }

        /// <summary>
        /// Determines whether the specified value contains attribute.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value contains attribute; otherwise, <c>false</c>.
        /// </returns>
        bool ContainsAttribute(string value);

        /// <summary>
        /// Determines whether the specified value contains value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value contains value; otherwise, <c>false</c>.
        /// </returns>
        bool ContainsValue(string value);

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        string Name { get; set; }

        /// <summary>Gets the value.</summary>
        /// <value>The value.</value>
        object Value { get; }

        /// <summary>Gets or sets the values.</summary>
        /// <value>The values.</value>
        object[] Values { get; set; }
    }
}
