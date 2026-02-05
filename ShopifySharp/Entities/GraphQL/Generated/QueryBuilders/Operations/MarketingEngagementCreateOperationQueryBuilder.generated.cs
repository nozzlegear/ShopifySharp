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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class MarketingEngagementCreateOperationQueryBuilder : FieldsQueryBuilderBase<MarketingEngagementCreatePayload, MarketingEngagementCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingEngagementCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingEngagementCreateArgumentsBuilder Arguments { get; }
        protected override MarketingEngagementCreateOperationQueryBuilder Self => this;

        public MarketingEngagementCreateOperationQueryBuilder() : this("marketingEngagementCreate")
        {
        }

        public MarketingEngagementCreateOperationQueryBuilder(string name) : base(new Query<MarketingEngagementCreatePayload>(name))
        {
            Arguments = new MarketingEngagementCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEngagementCreateOperationQueryBuilder(IQuery<MarketingEngagementCreatePayload> query) : base(query)
        {
            Arguments = new MarketingEngagementCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEngagementCreateOperationQueryBuilder MarketingEngagement(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEngagementQueryBuilder> build)
        {
            var query = new Query<MarketingEngagement>("marketingEngagement");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingEngagementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingEngagement>(query);
            return this;
        }

        public MarketingEngagementCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}