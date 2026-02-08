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
    public sealed class FileCreatePayloadQueryBuilder : FieldsQueryBuilderBase<FileCreatePayload, FileCreatePayloadQueryBuilder>
    {
        protected override FileCreatePayloadQueryBuilder Self => this;

        public FileCreatePayloadQueryBuilder() : this("fileCreatePayload")
        {
        }

        public FileCreatePayloadQueryBuilder(string name) : base(new Query<FileCreatePayload>(name))
        {
        }

        public FileCreatePayloadQueryBuilder(IQuery<FileCreatePayload> query) : base(query)
        {
        }

        public FileCreatePayloadQueryBuilder Files(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder> build)
        {
            var query = new Query<IFile>("files");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IFile>(query);
            return this;
        }

        public FileCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder> build)
        {
            var query = new Query<FilesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FilesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FilesUserError>(query);
            return this;
        }
    }
}