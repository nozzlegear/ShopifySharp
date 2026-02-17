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
    public sealed class ReverseDeliveryCreateWithShippingOperationQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryCreateWithShippingPayload, ReverseDeliveryCreateWithShippingOperationQueryBuilder>, IGraphOperationQueryBuilder<ReverseDeliveryCreateWithShippingPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReverseDeliveryCreateWithShippingArgumentsBuilder Arguments { get; }
        protected override ReverseDeliveryCreateWithShippingOperationQueryBuilder Self => this;

        public ReverseDeliveryCreateWithShippingOperationQueryBuilder() : this("reverseDeliveryCreateWithShipping")
        {
        }

        public ReverseDeliveryCreateWithShippingOperationQueryBuilder(string name) : base(new Query<ReverseDeliveryCreateWithShippingPayload>(name))
        {
            Arguments = new ReverseDeliveryCreateWithShippingArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryCreateWithShippingOperationQueryBuilder(IQuery<ReverseDeliveryCreateWithShippingPayload> query) : base(query)
        {
            Arguments = new ReverseDeliveryCreateWithShippingArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryCreateWithShippingOperationQueryBuilder ReverseDelivery(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("reverseDelivery");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDelivery>(query);
            return this;
        }

        public ReverseDeliveryCreateWithShippingOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}