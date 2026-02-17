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
    public sealed class MarketUserErrorQueryBuilder : FieldsQueryBuilderBase<MarketUserError, MarketUserErrorQueryBuilder>
    {
        protected override MarketUserErrorQueryBuilder Self => this;

        public MarketUserErrorQueryBuilder() : this("marketUserError")
        {
        }

        public MarketUserErrorQueryBuilder(string name) : base(new Query<MarketUserError>(name))
        {
        }

        public MarketUserErrorQueryBuilder(IQuery<MarketUserError> query) : base(query)
        {
        }

        public MarketUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MarketUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MarketUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}