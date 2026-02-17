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
    public sealed class PriceListFixedPricesAddOperationQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesAddPayload, PriceListFixedPricesAddOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListFixedPricesAddPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListFixedPricesAddArgumentsBuilder Arguments { get; }
        protected override PriceListFixedPricesAddOperationQueryBuilder Self => this;

        public PriceListFixedPricesAddOperationQueryBuilder() : this("priceListFixedPricesAdd")
        {
        }

        public PriceListFixedPricesAddOperationQueryBuilder(string name) : base(new Query<PriceListFixedPricesAddPayload>(name))
        {
            Arguments = new PriceListFixedPricesAddArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesAddOperationQueryBuilder(IQuery<PriceListFixedPricesAddPayload> query) : base(query)
        {
            Arguments = new PriceListFixedPricesAddArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesAddOperationQueryBuilder Prices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder> build)
        {
            var query = new Query<PriceListPrice>("prices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPrice>(query);
            return this;
        }

        public PriceListFixedPricesAddOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListPriceUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceUserError>(query);
            return this;
        }
    }
}