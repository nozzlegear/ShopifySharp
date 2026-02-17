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
    public sealed class DeliveryCustomizationActivationOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationActivationPayload, DeliveryCustomizationActivationOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCustomizationActivationPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryCustomizationActivationArgumentsBuilder Arguments { get; }
        protected override DeliveryCustomizationActivationOperationQueryBuilder Self => this;

        public DeliveryCustomizationActivationOperationQueryBuilder() : this("deliveryCustomizationActivation")
        {
        }

        public DeliveryCustomizationActivationOperationQueryBuilder(string name) : base(new Query<DeliveryCustomizationActivationPayload>(name))
        {
            Arguments = new DeliveryCustomizationActivationArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationActivationOperationQueryBuilder(IQuery<DeliveryCustomizationActivationPayload> query) : base(query)
        {
            Arguments = new DeliveryCustomizationActivationArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCustomizationActivationOperationQueryBuilder Ids()
        {
            base.InnerQuery.AddField("ids");
            return this;
        }

        public DeliveryCustomizationActivationOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}