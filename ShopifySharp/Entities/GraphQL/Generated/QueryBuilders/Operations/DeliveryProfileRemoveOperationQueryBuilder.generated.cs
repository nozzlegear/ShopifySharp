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
    public sealed class DeliveryProfileRemoveOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileRemovePayload, DeliveryProfileRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryProfileRemovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryProfileRemoveArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileRemoveOperationQueryBuilder Self => this;

        public DeliveryProfileRemoveOperationQueryBuilder() : this("deliveryProfileRemove")
        {
        }

        public DeliveryProfileRemoveOperationQueryBuilder(string name) : base(new Query<DeliveryProfileRemovePayload>(name))
        {
            Arguments = new DeliveryProfileRemoveArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileRemoveOperationQueryBuilder(IQuery<DeliveryProfileRemovePayload> query) : base(query)
        {
            Arguments = new DeliveryProfileRemoveArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileRemoveOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DeliveryProfileRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}