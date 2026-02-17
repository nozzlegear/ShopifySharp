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
    public sealed class ReturnCalculateOperationQueryBuilder : FieldsQueryBuilderBase<CalculatedReturn, ReturnCalculateOperationQueryBuilder>, IGraphOperationQueryBuilder<CalculatedReturn>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ReturnCalculateArgumentsBuilder Arguments { get; }
        protected override ReturnCalculateOperationQueryBuilder Self => this;

        public ReturnCalculateOperationQueryBuilder() : this("returnCalculate")
        {
        }

        public ReturnCalculateOperationQueryBuilder(string name) : base(new Query<CalculatedReturn>(name))
        {
            Arguments = new ReturnCalculateArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCalculateOperationQueryBuilder(IQuery<CalculatedReturn> query) : base(query)
        {
            Arguments = new ReturnCalculateArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCalculateOperationQueryBuilder ExchangeLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedExchangeLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedExchangeLineItem>("exchangeLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedExchangeLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedExchangeLineItem>(query);
            return this;
        }

        public ReturnCalculateOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnCalculateOperationQueryBuilder ReturnLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedReturnLineItem>("returnLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedReturnLineItem>(query);
            return this;
        }

        public ReturnCalculateOperationQueryBuilder ReturnShippingFee(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnShippingFeeQueryBuilder> build)
        {
            var query = new Query<CalculatedReturnShippingFee>("returnShippingFee");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedReturnShippingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedReturnShippingFee>(query);
            return this;
        }
    }
}