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
    public sealed class ShippingLabelPurchaseOperationQueryBuilder : FieldsQueryBuilderBase<ShippingLabelPurchasePayload, ShippingLabelPurchaseOperationQueryBuilder>, IGraphOperationQueryBuilder<ShippingLabelPurchasePayload>, IHasArguments<ShippingLabelPurchaseArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShippingLabelPurchaseArgumentsBuilder Arguments { get; }
        protected override ShippingLabelPurchaseOperationQueryBuilder Self => this;

        public ShippingLabelPurchaseOperationQueryBuilder() : this("shippingLabelPurchase")
        {
        }

        public ShippingLabelPurchaseOperationQueryBuilder(string name) : base(new Query<ShippingLabelPurchasePayload>(name))
        {
            Arguments = new ShippingLabelPurchaseArgumentsBuilder(base.InnerQuery);
        }

        public ShippingLabelPurchaseOperationQueryBuilder(IQuery<ShippingLabelPurchasePayload> query) : base(query)
        {
            Arguments = new ShippingLabelPurchaseArgumentsBuilder(base.InnerQuery);
        }

        public ShippingLabelPurchaseOperationQueryBuilder SetArguments(Action<ShippingLabelPurchaseArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShippingLabelPurchaseOperationQueryBuilder ShippingLabelPurchaseResult(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseResultQueryBuilder> build)
        {
            var query = new Query<ShippingLabelPurchaseResult>("shippingLabelPurchaseResult");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLabelPurchaseResult>(query);
            return this;
        }

        public ShippingLabelPurchaseOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseUserErrorQueryBuilder> build)
        {
            var query = new Query<ShippingLabelPurchaseUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelPurchaseUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLabelPurchaseUserError>(query);
            return this;
        }
    }
}