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
    public sealed class PriceListFixedPricesDeletePayloadQueryBuilder : FieldsQueryBuilderBase<PriceListFixedPricesDeletePayload, PriceListFixedPricesDeletePayloadQueryBuilder>
    {
        protected override PriceListFixedPricesDeletePayloadQueryBuilder Self => this;

        public PriceListFixedPricesDeletePayloadQueryBuilder() : this("priceListFixedPricesDeletePayload")
        {
        }

        public PriceListFixedPricesDeletePayloadQueryBuilder(string name) : base(new Query<PriceListFixedPricesDeletePayload>(name))
        {
        }

        public PriceListFixedPricesDeletePayloadQueryBuilder(IQuery<PriceListFixedPricesDeletePayload> query) : base(query)
        {
        }

        public PriceListFixedPricesDeletePayloadQueryBuilder DeletedFixedPriceVariantIds()
        {
            base.InnerQuery.AddField("deletedFixedPriceVariantIds");
            return this;
        }

        public PriceListFixedPricesDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder> build)
        {
            var query = new Query<PriceListPriceUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceListPriceUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListPriceUserError>(query);
            return this;
        }
    }
}