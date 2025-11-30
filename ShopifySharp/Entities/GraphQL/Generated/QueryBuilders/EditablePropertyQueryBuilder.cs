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

public class EditablePropertyQueryBuilder() : GraphQueryBuilder<EditableProperty>("query editableProperty")
{
    public EditablePropertyQueryBuilder AddFieldLocked()
    {
        AddField("locked");
        return this;
    }

    public EditablePropertyQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }
}