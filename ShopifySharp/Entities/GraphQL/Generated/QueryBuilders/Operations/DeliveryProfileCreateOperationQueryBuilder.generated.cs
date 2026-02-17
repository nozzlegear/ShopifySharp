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
    public sealed class DeliveryProfileCreateOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileCreatePayload, DeliveryProfileCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryProfileCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryProfileCreateArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileCreateOperationQueryBuilder Self => this;

        public DeliveryProfileCreateOperationQueryBuilder() : this("deliveryProfileCreate")
        {
        }

        public DeliveryProfileCreateOperationQueryBuilder(string name) : base(new Query<DeliveryProfileCreatePayload>(name))
        {
            Arguments = new DeliveryProfileCreateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileCreateOperationQueryBuilder(IQuery<DeliveryProfileCreatePayload> query) : base(query)
        {
            Arguments = new DeliveryProfileCreateArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileCreateOperationQueryBuilder Profile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("profile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public DeliveryProfileCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}