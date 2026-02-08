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
    public sealed class TaxSummaryCreateOperationQueryBuilder : FieldsQueryBuilderBase<TaxSummaryCreatePayload, TaxSummaryCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<TaxSummaryCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public TaxSummaryCreateArgumentsBuilder Arguments { get; }
        protected override TaxSummaryCreateOperationQueryBuilder Self => this;

        public TaxSummaryCreateOperationQueryBuilder() : this("taxSummaryCreate")
        {
        }

        public TaxSummaryCreateOperationQueryBuilder(string name) : base(new Query<TaxSummaryCreatePayload>(name))
        {
            Arguments = new TaxSummaryCreateArgumentsBuilder(base.InnerQuery);
        }

        public TaxSummaryCreateOperationQueryBuilder(IQuery<TaxSummaryCreatePayload> query) : base(query)
        {
            Arguments = new TaxSummaryCreateArgumentsBuilder(base.InnerQuery);
        }

        public TaxSummaryCreateOperationQueryBuilder EnqueuedOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("enqueuedOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public TaxSummaryCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxSummaryCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<TaxSummaryCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxSummaryCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxSummaryCreateUserError>(query);
            return this;
        }
    }
}