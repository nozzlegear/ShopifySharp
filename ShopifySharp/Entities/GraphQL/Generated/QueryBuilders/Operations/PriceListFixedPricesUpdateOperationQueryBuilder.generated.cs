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
    public sealed class PriceListFixedPricesUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesUpdatePayload, PriceListFixedPricesUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListFixedPricesUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PriceListFixedPricesUpdateArgumentsBuilder Arguments { get; }
        protected override PriceListFixedPricesUpdateOperationQueryBuilder Self => this;

        public PriceListFixedPricesUpdateOperationQueryBuilder() : this("priceListFixedPricesUpdate")
        {
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder(string name) : base(new Query<PriceListFixedPricesUpdatePayload>(name))
        {
            Arguments = new PriceListFixedPricesUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder(IQuery<PriceListFixedPricesUpdatePayload> query) : base(query)
        {
            Arguments = new PriceListFixedPricesUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder DeletedFixedPriceVariantIds()
        {
            base.InnerQuery.AddField("deletedFixedPriceVariantIds");
            return this;
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder PricesAdded(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceQueryBuilder> build)
        {
            var query = new Query<PriceListPrice>("pricesAdded");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPrice>(query);
            return this;
        }

        public PriceListFixedPricesUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListPriceUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceUserError>(query);
            return this;
        }
    }
}