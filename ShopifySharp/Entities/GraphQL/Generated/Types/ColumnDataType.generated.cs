#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The data type of a column.
/// </summary>
public enum ColumnDataType
{
    UNSPECIFIED,
    MONEY,
    PERCENT,
    INTEGER,
    FLOAT,
    DECIMAL,
    STRING,
    BOOLEAN,
    TIMESTAMP,
    MINUTE_TIMESTAMP,
    HOUR_TIMESTAMP,
    DAY_TIMESTAMP,
    WEEK_TIMESTAMP,
    MONTH_TIMESTAMP,
    QUARTER_TIMESTAMP,
    YEAR_TIMESTAMP,
    DAY_OF_WEEK,
    HOUR_OF_DAY,
    IDENTITY,
    MONTH_OF_YEAR,
    WEEK_OF_YEAR,
    SECOND_TIMESTAMP,
    ARRAY,
    MILLISECOND_DURATION,
    SECOND_DURATION,
    MINUTE_DURATION,
    HOUR_DURATION,
    DAY_DURATION,
}