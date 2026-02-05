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
    public sealed class MarketingActivityCreateExternalPayloadQueryBuilder : FieldsQueryBuilderBase<MarketingActivityCreateExternalPayload, MarketingActivityCreateExternalPayloadQueryBuilder>
    {
        protected override MarketingActivityCreateExternalPayloadQueryBuilder Self => this;

        public MarketingActivityCreateExternalPayloadQueryBuilder() : this("marketingActivityCreateExternalPayload")
        {
        }

        public MarketingActivityCreateExternalPayloadQueryBuilder(string name) : base(new Query<MarketingActivityCreateExternalPayload>(name))
        {
        }

        public MarketingActivityCreateExternalPayloadQueryBuilder(IQuery<MarketingActivityCreateExternalPayload> query) : base(query)
        {
        }

        public MarketingActivityCreateExternalPayloadQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityCreateExternalPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}