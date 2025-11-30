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

public class MetaobjectThumbnailQueryBuilder() : GraphQueryBuilder<MetaobjectThumbnail>("query metaobjectThumbnail")
{
    public MetaobjectThumbnailQueryBuilder AddFieldFile()
    {
        AddField("file");
        return this;
    }

    public MetaobjectThumbnailQueryBuilder AddFieldHex()
    {
        AddField("hex");
        return this;
    }
}