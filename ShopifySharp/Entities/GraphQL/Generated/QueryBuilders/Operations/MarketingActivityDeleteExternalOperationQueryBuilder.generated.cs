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
    public sealed class MarketingActivityDeleteExternalOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivityDeleteExternalPayload, MarketingActivityDeleteExternalOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivityDeleteExternalPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingActivityDeleteExternalArgumentsBuilder Arguments { get; }
        protected override MarketingActivityDeleteExternalOperationQueryBuilder Self => this;

        public MarketingActivityDeleteExternalOperationQueryBuilder() : this("marketingActivityDeleteExternal")
        {
        }

        public MarketingActivityDeleteExternalOperationQueryBuilder(string name) : base(new Query<MarketingActivityDeleteExternalPayload>(name))
        {
            Arguments = new MarketingActivityDeleteExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityDeleteExternalOperationQueryBuilder(IQuery<MarketingActivityDeleteExternalPayload> query) : base(query)
        {
            Arguments = new MarketingActivityDeleteExternalArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityDeleteExternalOperationQueryBuilder DeletedMarketingActivityId()
        {
            base.InnerQuery.AddField("deletedMarketingActivityId");
            return this;
        }

        public MarketingActivityDeleteExternalOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}