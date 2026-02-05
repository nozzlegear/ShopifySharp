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
    public sealed class FilesUserErrorQueryBuilder : FieldsQueryBuilderBase<FilesUserError, FilesUserErrorQueryBuilder>
    {
        protected override FilesUserErrorQueryBuilder Self => this;

        public FilesUserErrorQueryBuilder() : this("filesUserError")
        {
        }

        public FilesUserErrorQueryBuilder(string name) : base(new Query<FilesUserError>(name))
        {
        }

        public FilesUserErrorQueryBuilder(IQuery<FilesUserError> query) : base(query)
        {
        }

        public FilesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FilesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FilesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}