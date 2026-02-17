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
    public sealed class ProductFeedQueryBuilder : FieldsQueryBuilderBase<ProductFeed, ProductFeedQueryBuilder>
    {
        protected override ProductFeedQueryBuilder Self => this;

        public ProductFeedQueryBuilder() : this("productFeed")
        {
        }

        public ProductFeedQueryBuilder(string name) : base(new Query<ProductFeed>(name))
        {
        }

        public ProductFeedQueryBuilder(IQuery<ProductFeed> query) : base(query)
        {
        }

        public ProductFeedQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public ProductFeedQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductFeedQueryBuilder Language()
        {
            base.InnerQuery.AddField("language");
            return this;
        }

        public ProductFeedQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}