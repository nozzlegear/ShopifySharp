#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class FileDeletePayloadQueryBuilder : FieldsQueryBuilderBase<FileDeletePayload, FileDeletePayloadQueryBuilder>
    {
        protected override FileDeletePayloadQueryBuilder Self => this;

        public FileDeletePayloadQueryBuilder() : this("fileDeletePayload")
        {
        }

        public FileDeletePayloadQueryBuilder(string name) : base(new Query<FileDeletePayload>(name))
        {
        }

        public FileDeletePayloadQueryBuilder(IQuery<FileDeletePayload> query) : base(query)
        {
        }

        public FileDeletePayloadQueryBuilder DeletedFileIds()
        {
            base.InnerQuery.AddField("deletedFileIds");
            return this;
        }

        public FileDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder> build)
        {
            var query = new Query<FilesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilesUserError>(query);
            return this;
        }
    }
}