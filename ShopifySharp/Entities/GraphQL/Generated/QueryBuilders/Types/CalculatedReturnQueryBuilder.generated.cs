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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CalculatedReturnQueryBuilder : FieldsQueryBuilderBase<CalculatedReturn, CalculatedReturnQueryBuilder>
    {
        protected override CalculatedReturnQueryBuilder Self => this;

        public CalculatedReturnQueryBuilder() : this("calculatedReturn")
        {
        }

        public CalculatedReturnQueryBuilder(string name) : base(new Query<CalculatedReturn>(name))
        {
        }

        public CalculatedReturnQueryBuilder(IQuery<CalculatedReturn> query) : base(query)
        {
        }

        public CalculatedReturnQueryBuilder ExchangeLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedExchangeLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedExchangeLineItem>("exchangeLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedExchangeLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedExchangeLineItem>(query);
            return this;
        }

        public CalculatedReturnQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedReturnQueryBuilder ReturnLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedReturnLineItem>("returnLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedReturnLineItem>(query);
            return this;
        }

        public CalculatedReturnQueryBuilder ReturnShippingFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnShippingFeeQueryBuilder> build)
        {
            var query = new Query<CalculatedReturnShippingFee>("returnShippingFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnShippingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedReturnShippingFee>(query);
            return this;
        }
    }
}