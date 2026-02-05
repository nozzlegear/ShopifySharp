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
    public sealed class MarketingActivitiesDeleteAllExternalPayloadQueryBuilder : FieldsQueryBuilderBase<MarketingActivitiesDeleteAllExternalPayload, MarketingActivitiesDeleteAllExternalPayloadQueryBuilder>
    {
        protected override MarketingActivitiesDeleteAllExternalPayloadQueryBuilder Self => this;

        public MarketingActivitiesDeleteAllExternalPayloadQueryBuilder() : this("marketingActivitiesDeleteAllExternalPayload")
        {
        }

        public MarketingActivitiesDeleteAllExternalPayloadQueryBuilder(string name) : base(new Query<MarketingActivitiesDeleteAllExternalPayload>(name))
        {
        }

        public MarketingActivitiesDeleteAllExternalPayloadQueryBuilder(IQuery<MarketingActivitiesDeleteAllExternalPayload> query) : base(query)
        {
        }

        public MarketingActivitiesDeleteAllExternalPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public MarketingActivitiesDeleteAllExternalPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}