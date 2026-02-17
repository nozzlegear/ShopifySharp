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
    public sealed class DeliveryCustomizationCreateOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationCreatePayload, DeliveryCustomizationCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCustomizationCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryCustomizationCreateArgumentsBuilder Arguments { get; }
        protected override DeliveryCustomizationCreateOperationQueryBuilder Self => this;

        public DeliveryCustomizationCreateOperationQueryBuilder() : this("deliveryCustomizationCreate")
        {
        }

        public DeliveryCustomizationCreateOperationQueryBuilder(string name) : base(new Query<DeliveryCustomizationCreatePayload>(name))
        {
            Arguments = new DeliveryCustomizationCreateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationCreateOperationQueryBuilder(IQuery<DeliveryCustomizationCreatePayload> query) : base(query)
        {
            Arguments = new DeliveryCustomizationCreateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationCreateOperationQueryBuilder DeliveryCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("deliveryCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public DeliveryCustomizationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}