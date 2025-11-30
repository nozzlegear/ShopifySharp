#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SelectedOptionQueryBuilder() : GraphQueryBuilder<SelectedOption>("query selectedOption")
{
    public SelectedOptionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public SelectedOptionQueryBuilder AddFieldOptionValue()
    {
        AddField("optionValue");
        return this;
    }

    public SelectedOptionQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}