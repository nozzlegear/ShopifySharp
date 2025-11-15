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

public class IMediaQueryBuilder() : GraphQueryBuilder<IMedia>("query iMedia")
{
    public IMediaQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public IMediaQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public IMediaQueryBuilder AddFieldMediaContentType()
    {
        AddField("mediaContentType");
        return this;
    }

    public IMediaQueryBuilder AddFieldMediaErrors()
    {
        AddField("mediaErrors");
        return this;
    }

    public IMediaQueryBuilder AddFieldMediaWarnings()
    {
        AddField("mediaWarnings");
        return this;
    }

    public IMediaQueryBuilder AddFieldPreview()
    {
        AddField("preview");
        return this;
    }

    public IMediaQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}