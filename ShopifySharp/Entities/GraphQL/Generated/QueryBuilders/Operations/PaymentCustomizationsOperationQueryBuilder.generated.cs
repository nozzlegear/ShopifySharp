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
    public sealed class PaymentCustomizationsOperationQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationConnection, PaymentCustomizationsOperationQueryBuilder>, IGraphOperationQueryBuilder<PaymentCustomizationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PaymentCustomizationsArgumentsBuilder Arguments { get; }
        protected override PaymentCustomizationsOperationQueryBuilder Self => this;

        public PaymentCustomizationsOperationQueryBuilder() : this("paymentCustomizations")
        {
        }

        public PaymentCustomizationsOperationQueryBuilder(string name) : base(new Query<PaymentCustomizationConnection>(name))
        {
            Arguments = new PaymentCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationsOperationQueryBuilder(IQuery<PaymentCustomizationConnection> query) : base(query)
        {
            Arguments = new PaymentCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public PaymentCustomizationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationEdgeQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationEdge>(query);
            return this;
        }

        public PaymentCustomizationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public PaymentCustomizationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}