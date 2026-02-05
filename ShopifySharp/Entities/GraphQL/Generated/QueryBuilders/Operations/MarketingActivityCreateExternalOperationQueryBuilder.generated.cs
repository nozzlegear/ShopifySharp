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
    public sealed class MarketingActivityCreateExternalOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivityCreateExternalPayload, MarketingActivityCreateExternalOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivityCreateExternalPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingActivityCreateExternalArgumentsBuilder Arguments { get; }
        protected override MarketingActivityCreateExternalOperationQueryBuilder Self => this;

        public MarketingActivityCreateExternalOperationQueryBuilder() : this("marketingActivityCreateExternal")
        {
        }

        public MarketingActivityCreateExternalOperationQueryBuilder(string name) : base(new Query<MarketingActivityCreateExternalPayload>(name))
        {
            Arguments = new MarketingActivityCreateExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityCreateExternalOperationQueryBuilder(IQuery<MarketingActivityCreateExternalPayload> query) : base(query)
        {
            Arguments = new MarketingActivityCreateExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityCreateExternalOperationQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityCreateExternalOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}