#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class FileErrorQueryBuilder : FieldsQueryBuilderBase<FileError, FileErrorQueryBuilder>
    {
        protected override FileErrorQueryBuilder Self => this;

        public FileErrorQueryBuilder() : this("fileError")
        {
        }

        public FileErrorQueryBuilder(string name) : base(new Query<FileError>(name))
        {
        }

        public FileErrorQueryBuilder(IQuery<FileError> query) : base(query)
        {
        }

        public FileErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FileErrorQueryBuilder Details()
        {
            base.InnerQuery.AddField("details");
            return this;
        }

        public FileErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}