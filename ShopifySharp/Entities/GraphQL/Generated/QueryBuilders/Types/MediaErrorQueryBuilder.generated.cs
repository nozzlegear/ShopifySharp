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
    public sealed class MediaErrorQueryBuilder : FieldsQueryBuilderBase<MediaError, MediaErrorQueryBuilder>
    {
        protected override MediaErrorQueryBuilder Self => this;

        public MediaErrorQueryBuilder() : this("mediaError")
        {
        }

        public MediaErrorQueryBuilder(string name) : base(new Query<MediaError>(name))
        {
        }

        public MediaErrorQueryBuilder(IQuery<MediaError> query) : base(query)
        {
        }

        public MediaErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MediaErrorQueryBuilder Details()
        {
            base.InnerQuery.AddField("details");
            return this;
        }

        public MediaErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}