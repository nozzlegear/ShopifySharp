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
    public sealed class DeliveryCustomizationUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationUpdatePayload, DeliveryCustomizationUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCustomizationUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryCustomizationUpdateArgumentsBuilder Arguments { get; }
        protected override DeliveryCustomizationUpdateOperationQueryBuilder Self => this;

        public DeliveryCustomizationUpdateOperationQueryBuilder() : this("deliveryCustomizationUpdate")
        {
        }

        public DeliveryCustomizationUpdateOperationQueryBuilder(string name) : base(new Query<DeliveryCustomizationUpdatePayload>(name))
        {
            Arguments = new DeliveryCustomizationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationUpdateOperationQueryBuilder(IQuery<DeliveryCustomizationUpdatePayload> query) : base(query)
        {
            Arguments = new DeliveryCustomizationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationUpdateOperationQueryBuilder DeliveryCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("deliveryCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public DeliveryCustomizationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}