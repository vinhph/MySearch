using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace MySearch.Models
{
    public class SearchField : ISearchField
    {
        private string _Name = string.Empty;

        /// <summary>Gets or sets the attributes.</summary>
        /// <value>The attributes.</value>
        public string[] Attributes { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return this._Name; }
            set { this._Name = value?.ToLower(); }
        }

        /// <summary>Gets or sets the value.</summary>
        /// <value>The value.</value>
        public object[] Values { get; set; }

        /// <summary>Gets the value.</summary>
        /// <value>The value.</value>
        public object Value
        {
            get
            {
                if (this.Values != null && this.Values.Length != 0)
                    return this.Values[0];
                return (object) null;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Mediachase.Search.Extensions.SearchField" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public SearchField(string name, object value)
        {
            this.Name = name;
            this.Values = new object[1] {value};
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Mediachase.Search.Extensions.SearchField" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public SearchField(string name, object[] value)
        {
            this.Name = name;
            this.Values = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Mediachase.Search.Extensions.SearchField" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="attributes">The attributes.</param>
        public SearchField(string name, object value, string[] attributes)
        {
            this.Name = name;
            this.Values = new object[1] {value};
            this.Attributes = attributes;
        }

        /// <summary>
        /// Determines whether the specified value contains value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value contains value; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsValue(string value)
        {
            if (this.Values == null || this.Values.Length == 0)
                return false;
            return ((IEnumerable<object>) this.Values).Where<object>((Func<object, bool>) (val => val != null))
                .Any<object>((Func<object, bool>) (val =>
                    val.ToString().Equals(value, StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>
        /// Determines whether the specified value contains attribute.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value contains attribute; otherwise, <c>false</c>.
        /// </returns>
        public bool ContainsAttribute(string value)
        {
            if (this.Attributes == null || this.Attributes.Length == 0)
                return false;
            return ((IEnumerable<string>) this.Attributes).Where<string>((Func<string, bool>) (val => val != null))
                .Any<string>((Func<string, bool>) (val => val.Equals(value, StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>Adds the value.</summary>
        /// <param name="value">The value.</param>
        public void AddValue(object value)
        {
            this.Values = new List<object>((IEnumerable<object>) this.Values)
            {
                value
            }.ToArray();
        }

        /// <summary>Defines how to index/analyse the value.</summary>
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct Index
        {
            /// <summary>Values are parsed to tokens</summary>
            public const string TOKENIZED = "Index.Token";

            /// <summary>Values are indexed as is</summary>
            public const string UN_TOKENIZED = "Index.NoToken";

            /// <summary>Values are not indexed</summary>
            public const string NO = "Index.No";
        }

        /// <summary>Defines how the field it stored.</summary>
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct Store
        {
            /// <summary>Values are stored in the index</summary>
            public const string YES = "Store.Yes";

            /// <summary>Values are not stored</summary>
            public const string NO = "Store.No";
        }

        /// <summary>
        /// Defines if the field should be included in the default text search.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct IncludeInDefaultSearch
        {
            /// <summary>Value is included in the default text search.</summary>
            public const string YES = "IncludeInDefaultSearch.Yes";

            /// <summary>Value is not included in the default text search.</summary>
            public const string NO = "IncludeInDefaultSearch.No";
        }
    }
}
