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

        public MarketingActivityCreateExternalOperationQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityCreateExternalOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}