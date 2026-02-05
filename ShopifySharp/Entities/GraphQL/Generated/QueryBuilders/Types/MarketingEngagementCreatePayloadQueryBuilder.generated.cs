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
    public sealed class MarketingEngagementCreatePayloadQueryBuilder : FieldsQueryBuilderBase<MarketingEngagementCreatePayload, MarketingEngagementCreatePayloadQueryBuilder>
    {
        protected override MarketingEngagementCreatePayloadQueryBuilder Self => this;

        public MarketingEngagementCreatePayloadQueryBuilder() : this("marketingEngagementCreatePayload")
        {
        }

        public MarketingEngagementCreatePayloadQueryBuilder(string name) : base(new Query<MarketingEngagementCreatePayload>(name))
        {
        }

        public MarketingEngagementCreatePayloadQueryBuilder(IQuery<MarketingEngagementCreatePayload> query) : base(query)
        {
        }

        public MarketingEngagementCreatePayloadQueryBuilder MarketingEngagement(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEngagementQueryBuilder> build)
        {
            var query = new Query<MarketingEngagement>("marketingEngagement");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEngagementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEngagement>(query);
            return this;
        }

        public MarketingEngagementCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}