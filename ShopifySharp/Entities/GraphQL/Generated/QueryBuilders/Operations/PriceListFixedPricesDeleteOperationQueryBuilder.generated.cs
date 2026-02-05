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
    public sealed class PriceListFixedPricesDeleteOperationQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesDeletePayload, PriceListFixedPricesDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListFixedPricesDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListFixedPricesDeleteArgumentsBuilder Arguments { get; }
        protected override PriceListFixedPricesDeleteOperationQueryBuilder Self => this;

        public PriceListFixedPricesDeleteOperationQueryBuilder() : this("priceListFixedPricesDelete")
        {
        }

        public PriceListFixedPricesDeleteOperationQueryBuilder(string name) : base(new Query<PriceListFixedPricesDeletePayload>(name))
        {
            Arguments = new PriceListFixedPricesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesDeleteOperationQueryBuilder(IQuery<PriceListFixedPricesDeletePayload> query) : base(query)
        {
            Arguments = new PriceListFixedPricesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesDeleteOperationQueryBuilder DeletedFixedPriceVariantIds()
        {
            base.InnerQuery.AddField("deletedFixedPriceVariantIds");
            return this;
        }

        public PriceListFixedPricesDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListPriceUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceUserError>(query);
            return this;
        }
    }
}