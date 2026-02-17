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
    [Obsolete("Single origin shipping mode is no longer supported.")]
    public sealed class DeliveryShippingOriginAssignOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryShippingOriginAssignPayload, DeliveryShippingOriginAssignOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryShippingOriginAssignPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryShippingOriginAssignArgumentsBuilder Arguments { get; }
        protected override DeliveryShippingOriginAssignOperationQueryBuilder Self => this;

        public DeliveryShippingOriginAssignOperationQueryBuilder() : this("deliveryShippingOriginAssign")
        {
        }

        public DeliveryShippingOriginAssignOperationQueryBuilder(string name) : base(new Query<DeliveryShippingOriginAssignPayload>(name))
        {
            Arguments = new DeliveryShippingOriginAssignArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryShippingOriginAssignOperationQueryBuilder(IQuery<DeliveryShippingOriginAssignPayload> query) : base(query)
        {
            Arguments = new DeliveryShippingOriginAssignArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryShippingOriginAssignOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}