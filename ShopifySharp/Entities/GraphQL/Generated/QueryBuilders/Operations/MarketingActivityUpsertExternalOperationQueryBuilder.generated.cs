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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MarketingActivityUpsertExternalOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivityUpsertExternalPayload, MarketingActivityUpsertExternalOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivityUpsertExternalPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingActivityUpsertExternalArgumentsBuilder Arguments { get; }
        protected override MarketingActivityUpsertExternalOperationQueryBuilder Self => this;

        public MarketingActivityUpsertExternalOperationQueryBuilder() : this("marketingActivityUpsertExternal")
        {
        }

        public MarketingActivityUpsertExternalOperationQueryBuilder(string name) : base(new Query<MarketingActivityUpsertExternalPayload>(name))
        {
            Arguments = new MarketingActivityUpsertExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityUpsertExternalOperationQueryBuilder(IQuery<MarketingActivityUpsertExternalPayload> query) : base(query)
        {
            Arguments = new MarketingActivityUpsertExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityUpsertExternalOperationQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityUpsertExternalOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}