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
    public sealed class MarketingActivitiesDeleteAllExternalOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivitiesDeleteAllExternalPayload, MarketingActivitiesDeleteAllExternalOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivitiesDeleteAllExternalPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        protected override MarketingActivitiesDeleteAllExternalOperationQueryBuilder Self => this;

        public MarketingActivitiesDeleteAllExternalOperationQueryBuilder() : this("marketingActivitiesDeleteAllExternal")
        {
        }

        public MarketingActivitiesDeleteAllExternalOperationQueryBuilder(string name) : base(new Query<MarketingActivitiesDeleteAllExternalPayload>(name))
        {
        }

        public MarketingActivitiesDeleteAllExternalOperationQueryBuilder(IQuery<MarketingActivitiesDeleteAllExternalPayload> query) : base(query)
        {
        }

        public MarketingActivitiesDeleteAllExternalOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public MarketingActivitiesDeleteAllExternalOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}