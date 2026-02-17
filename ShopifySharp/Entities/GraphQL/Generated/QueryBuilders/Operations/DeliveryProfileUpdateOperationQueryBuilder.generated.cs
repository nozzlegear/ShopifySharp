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
    public sealed class DeliveryProfileUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileUpdatePayload, DeliveryProfileUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryProfileUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryProfileUpdateArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileUpdateOperationQueryBuilder Self => this;

        public DeliveryProfileUpdateOperationQueryBuilder() : this("deliveryProfileUpdate")
        {
        }

        public DeliveryProfileUpdateOperationQueryBuilder(string name) : base(new Query<DeliveryProfileUpdatePayload>(name))
        {
            Arguments = new DeliveryProfileUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileUpdateOperationQueryBuilder(IQuery<DeliveryProfileUpdatePayload> query) : base(query)
        {
            Arguments = new DeliveryProfileUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileUpdateOperationQueryBuilder Profile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("profile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public DeliveryProfileUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}