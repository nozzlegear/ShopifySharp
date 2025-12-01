#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ShopifySharp.Infrastructure;

/// <summary>The GraphQL query builder interface.</summary>
public interface IQueryStringBuilder
{
    /// <summary>Clears the string builder.</summary>
    void Clear();

    /// <summary>Builds the query.</summary>
    /// <param name="query">The query.</param>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    string Build<TSource>(IQuery<TSource> query);
}

/// <summary>The GraphQL query builder class.</summary>
public class QueryStringBuilder : IQueryStringBuilder
{
    /// <summary>The property name formatter.</summary>
    protected readonly Func<PropertyInfo, string>? Formatter;

    /// <summary>The query string builder.</summary>
    public StringBuilder QueryString { get; } = new();

    /// <summary>Initializes a new instance of the <see cref="QueryStringBuilder" /> class.</summary>
    public QueryStringBuilder() { }

    /// <summary>Initializes a new instance of the <see cref="QueryStringBuilder" /> class.</summary>
    /// <param name="formatter">The property name formatter</param>
    public QueryStringBuilder(Func<PropertyInfo, string> formatter)
    {
        Formatter = formatter;
    }

    /// <summary>Builds the query.</summary>
    /// <param name="query">The query.</param>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    public string Build<TSource>(IQuery<TSource> query)
    {
        if (!string.IsNullOrWhiteSpace(query.AliasName))
        {
            QueryString.Append($"{query.AliasName}:");
        }

        QueryString.Append(query.Name);

        if (query.Arguments.Count > 0)
        {
            QueryString.Append("(");
            AddParams(query);
            QueryString.Append(")");
        }

        if (query.SelectList.Count > 0)
        {
            QueryString.Append("{");
            AddFields(query);
            QueryString.Append("}");
        }

        return QueryString.ToString();
    }

    /// <summary>Clears the string builder.</summary>
    public void Clear()
    {
        QueryString.Clear();
    }

    /// <summary>
    /// Formats query param.
    ///
    /// Returns:
    ///   <list type="bullet">
    ///     <item>
    ///       <term>null</term>
    ///       <description><c>null</c></description>
    ///     </item>
    ///     <item>
    ///       <term>String</term>
    ///       <description><c>"foo"</c></description>
    ///     </item>
    ///     <item>
    ///       <term>Number</term>
    ///       <description><c>10</c></description>
    ///     </item>
    ///     <item>
    ///       <term>Boolean</term>
    ///       <description><c>true</c> or <c>false</c></description>
    ///     </item>
    ///     <item>
    ///       <term>Enum</term>
    ///       <description><c>EnumValue</c></description>
    ///     </item>
    ///     <item>
    ///       <term>DateTime</term>
    ///       <description><c>"2024-06-15T13:45:30.0000000Z"</c></description>
    ///     </item>
    ///     <item>
    ///       <term>Key value pair</term>
    ///       <description><c>foo:"bar"</c> or <c>foo:10</c> ...</description>
    ///     </item>
    ///     <item>
    ///       <term>List</term>
    ///       <description><c>["foo","bar"]</c> or <c>[1,2]</c> ...</description>
    ///     </item>
    ///     <item>
    ///       <term>Dictionary</term>
    ///       <description><c>{foo:"bar",b:10}</c></description>
    ///     </item>
    ///     <item>
    ///       <term>Object</term>
    ///       <description><c>{foo:"bar",b:10}</c></description>
    ///     </item>
    ///   </list>
    /// </summary>
    /// <param name="value"></param>
    /// <returns>The formatted query param.</returns>
    /// <exception cref="InvalidDataException">Invalid Object Type in Param List</exception>
    protected internal virtual string FormatQueryParam(object? value)
    {
        while (true)
        {
            switch (value)
            {
                case null:
                    return "null";

                case string strValue:
                    var encoded = strValue.Replace("\"", "\\\"");
                    return $"\"{encoded}\"";

                case char charValue:
                    return $"\"{charValue}\"";

                case byte byteValue:
                    return byteValue.ToString();

                case sbyte sbyteValue:
                    return sbyteValue.ToString();

                case short shortValue:
                    return shortValue.ToString();

                case ushort ushortValue:
                    return ushortValue.ToString();

                case int intValue:
                    return intValue.ToString();

                case uint uintValue:
                    return uintValue.ToString();

                case long longValue:
                    return longValue.ToString();

                case ulong ulongValue:
                    return ulongValue.ToString();

                case float floatValue:
                    return floatValue.ToString(CultureInfo.CreateSpecificCulture("en-us"));

                case double doubleValue:
                    return doubleValue.ToString(CultureInfo.CreateSpecificCulture("en-us"));

                case decimal decimalValue:
                    return decimalValue.ToString(CultureInfo.CreateSpecificCulture("en-us"));

                case bool booleanValue:
                    return booleanValue ? "true" : "false";

                case Enum enumValue:
                    return enumValue.ToString();

                case DateTime dateTimeValue:
                    value = dateTimeValue.ToString("o");
                    continue;

                case KeyValuePair<string, object> kvValue:
                    return $"{kvValue.Key}:{FormatQueryParam(kvValue.Value)}";

                case IDictionary<string, object> dictValue:
                    return $"{{{string.Join(",", dictValue.Select(e => FormatQueryParam(e)))}}}";

                case IEnumerable enumerableValue:
                    List<string> items = [];
                    items.AddRange(enumerableValue.Cast<object?>().Select(FormatQueryParam));

                    return $"[{string.Join(",", items)}]";

                case { } objectValue:
                    var dictionary = ObjectToDictionary(objectValue);
                    value = dictionary;
                    continue;
            }
        }
    }

    /// <summary>Adds query params to the query string.</summary>
    /// <param name="query">The query.</param>
    protected internal void AddParams<TSource>(IQuery<TSource> query)
    {
        RequiredArgument.NotNull(query, nameof(query));

        foreach (KeyValuePair<string, object?> param in query.Arguments)
        {
            QueryString.Append($"{param.Key}:{FormatQueryParam(param.Value)},");
        }

        if (query.Arguments.Count > 0)
        {
            QueryString.Length--;
        }
    }

    /// <summary>Adds fields to the query sting.</summary>
    /// <param name="query">The query.</param>
    /// <exception cref="ArgumentException">Invalid Object in Field List</exception>
    protected internal void AddFields<TSource>(IQuery<TSource> query)
    {
        foreach (object? item in query.SelectList)
        {
            switch (item)
            {
                case string field:
                    QueryString.Append($"{field} ");
                    break;

                case IQuery subQuery:
                    QueryString.Append($"{subQuery.Build()} ");
                    break;

                default:
                    throw new ArgumentException("Invalid Field Type Specified, must be `string` or `Query`");
            }
        }

        if (query.SelectList.Count > 0)
        {
            QueryString.Length--;
        }
    }

    /// <summary>Convert object into dictionary.</summary>
    /// <param name="object">The object.</param>
    /// <returns>The object as dictionary.</returns>
    private Dictionary<string, object> ObjectToDictionary(object @object) =>
        @object
            .GetType()
            .GetProperties()
            .Where(property => property.GetValue(@object) != null)
            .Select(property =>
                new KeyValuePair<string, object>(
                    Formatter is not null ? Formatter.Invoke(property) : property.Name,
                    property.GetValue(@object)))
            .OrderBy(property => property.Key)
            .ToDictionary(property => property.Key, property => property.Value);
}
