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
    public sealed class ReverseDeliveryShippingUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryShippingUpdatePayload, ReverseDeliveryShippingUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ReverseDeliveryShippingUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReverseDeliveryShippingUpdateArgumentsBuilder Arguments { get; }
        protected override ReverseDeliveryShippingUpdateOperationQueryBuilder Self => this;

        public ReverseDeliveryShippingUpdateOperationQueryBuilder() : this("reverseDeliveryShippingUpdate")
        {
        }

        public ReverseDeliveryShippingUpdateOperationQueryBuilder(string name) : base(new Query<ReverseDeliveryShippingUpdatePayload>(name))
        {
            Arguments = new ReverseDeliveryShippingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryShippingUpdateOperationQueryBuilder(IQuery<ReverseDeliveryShippingUpdatePayload> query) : base(query)
        {
            Arguments = new ReverseDeliveryShippingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryShippingUpdateOperationQueryBuilder ReverseDelivery(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("reverseDelivery");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDelivery>(query);
            return this;
        }

        public ReverseDeliveryShippingUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}