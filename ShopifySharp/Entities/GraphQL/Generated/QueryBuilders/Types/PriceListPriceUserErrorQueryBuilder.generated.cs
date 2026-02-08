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
    public sealed class PriceListPriceUserErrorQueryBuilder : FieldsQueryBuilderBase<PriceListPriceUserError, PriceListPriceUserErrorQueryBuilder>
    {
        protected override PriceListPriceUserErrorQueryBuilder Self => this;

        public PriceListPriceUserErrorQueryBuilder() : this("priceListPriceUserError")
        {
        }

        public PriceListPriceUserErrorQueryBuilder(string name) : base(new Query<PriceListPriceUserError>(name))
        {
        }

        public PriceListPriceUserErrorQueryBuilder(IQuery<PriceListPriceUserError> query) : base(query)
        {
        }

        public PriceListPriceUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PriceListPriceUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PriceListPriceUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}