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
    public sealed class DeliveryCustomizationDeleteOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationDeletePayload, DeliveryCustomizationDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCustomizationDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryCustomizationDeleteArgumentsBuilder Arguments { get; }
        protected override DeliveryCustomizationDeleteOperationQueryBuilder Self => this;

        public DeliveryCustomizationDeleteOperationQueryBuilder() : this("deliveryCustomizationDelete")
        {
        }

        public DeliveryCustomizationDeleteOperationQueryBuilder(string name) : base(new Query<DeliveryCustomizationDeletePayload>(name))
        {
            Arguments = new DeliveryCustomizationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationDeleteOperationQueryBuilder(IQuery<DeliveryCustomizationDeletePayload> query) : base(query)
        {
            Arguments = new DeliveryCustomizationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public DeliveryCustomizationDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}