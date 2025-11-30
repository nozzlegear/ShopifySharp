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

public class FileAcknowledgeUpdateFailedPayloadQueryBuilder() : GraphQueryBuilder<FileAcknowledgeUpdateFailedPayload>("fileAcknowledgeUpdateFailedPayload")
{
    public FileAcknowledgeUpdateFailedPayloadQueryBuilder AddFieldFiles(Func<FileQueryBuilder, FileQueryBuilder> build)
    {
        AddField<IFile, FileQueryBuilder>("files", build);
        return this;
    }

    public FileAcknowledgeUpdateFailedPayloadQueryBuilder AddFieldUserErrors(Func<FilesUserErrorQueryBuilder, FilesUserErrorQueryBuilder> build)
    {
        AddField<FilesUserError, FilesUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}