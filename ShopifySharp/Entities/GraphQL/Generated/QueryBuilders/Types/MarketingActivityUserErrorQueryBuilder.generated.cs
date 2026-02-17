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
    public sealed class MarketingActivityUserErrorQueryBuilder : FieldsQueryBuilderBase<MarketingActivityUserError, MarketingActivityUserErrorQueryBuilder>
    {
        protected override MarketingActivityUserErrorQueryBuilder Self => this;

        public MarketingActivityUserErrorQueryBuilder() : this("marketingActivityUserError")
        {
        }

        public MarketingActivityUserErrorQueryBuilder(string name) : base(new Query<MarketingActivityUserError>(name))
        {
        }

        public MarketingActivityUserErrorQueryBuilder(IQuery<MarketingActivityUserError> query) : base(query)
        {
        }

        public MarketingActivityUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MarketingActivityUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MarketingActivityUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}