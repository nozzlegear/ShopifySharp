#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class MetaobjectThumbnailQueryBuilder() : GraphQueryBuilder<MetaobjectThumbnail>("metaobjectThumbnail")
{
    public MetaobjectThumbnailQueryBuilder AddFieldFile(Func<FileQueryBuilder, FileQueryBuilder> build)
    {
        AddField<IFile, FileQueryBuilder>("file", build);
        return this;
    }

    public MetaobjectThumbnailQueryBuilder AddFieldHex()
    {
        AddField("hex");
        return this;
    }
}