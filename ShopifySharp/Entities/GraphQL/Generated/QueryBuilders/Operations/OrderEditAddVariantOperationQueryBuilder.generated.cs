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
    public sealed class OrderEditAddVariantOperationQueryBuilder : FieldsQueryBuilderBase<OrderEditAddVariantPayload, OrderEditAddVariantOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderEditAddVariantPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderEditAddVariantArgumentsBuilder Arguments { get; }
        protected override OrderEditAddVariantOperationQueryBuilder Self => this;

        public OrderEditAddVariantOperationQueryBuilder() : this("orderEditAddVariant")
        {
        }

        public OrderEditAddVariantOperationQueryBuilder(string name) : base(new Query<OrderEditAddVariantPayload>(name))
        {
            Arguments = new OrderEditAddVariantArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddVariantOperationQueryBuilder(IQuery<OrderEditAddVariantPayload> query) : base(query)
        {
            Arguments = new OrderEditAddVariantArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAddVariantOperationQueryBuilder CalculatedLineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("calculatedLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public OrderEditAddVariantOperationQueryBuilder CalculatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedOrder>("calculatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedOrder>(query);
            return this;
        }

        public OrderEditAddVariantOperationQueryBuilder OrderEditSession(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder> build)
        {
            var query = new Query<OrderEditSession>("orderEditSession");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderEditSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEditSession>(query);
            return this;
        }

        public OrderEditAddVariantOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}