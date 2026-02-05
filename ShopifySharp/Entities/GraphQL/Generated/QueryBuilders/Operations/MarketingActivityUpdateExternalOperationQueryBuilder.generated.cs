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
    public sealed class MarketingActivityUpdateExternalOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivityUpdateExternalPayload, MarketingActivityUpdateExternalOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivityUpdateExternalPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingActivityUpdateExternalArgumentsBuilder Arguments { get; }
        protected override MarketingActivityUpdateExternalOperationQueryBuilder Self => this;

        public MarketingActivityUpdateExternalOperationQueryBuilder() : this("marketingActivityUpdateExternal")
        {
        }

        public MarketingActivityUpdateExternalOperationQueryBuilder(string name) : base(new Query<MarketingActivityUpdateExternalPayload>(name))
        {
            Arguments = new MarketingActivityUpdateExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityUpdateExternalOperationQueryBuilder(IQuery<MarketingActivityUpdateExternalPayload> query) : base(query)
        {
            Arguments = new MarketingActivityUpdateExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityUpdateExternalOperationQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityUpdateExternalOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}