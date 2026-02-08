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
    public sealed class MarketingEngagementsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MarketingEngagementsDeletePayload, MarketingEngagementsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingEngagementsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingEngagementsDeleteArgumentsBuilder Arguments { get; }
        protected override MarketingEngagementsDeleteOperationQueryBuilder Self => this;

        public MarketingEngagementsDeleteOperationQueryBuilder() : this("marketingEngagementsDelete")
        {
        }

        public MarketingEngagementsDeleteOperationQueryBuilder(string name) : base(new Query<MarketingEngagementsDeletePayload>(name))
        {
            Arguments = new MarketingEngagementsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEngagementsDeleteOperationQueryBuilder(IQuery<MarketingEngagementsDeletePayload> query) : base(query)
        {
            Arguments = new MarketingEngagementsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketingEngagementsDeleteOperationQueryBuilder Result()
        {
            base.InnerQuery.AddField("result");
            return this;
        }

        public MarketingEngagementsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketingActivityUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityUserError>(query);
            return this;
        }
    }
}