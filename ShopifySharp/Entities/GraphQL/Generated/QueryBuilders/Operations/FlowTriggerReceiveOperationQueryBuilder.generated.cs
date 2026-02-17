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
    public sealed class FlowTriggerReceiveOperationQueryBuilder : FieldsQueryBuilderBase<FlowTriggerReceivePayload, FlowTriggerReceiveOperationQueryBuilder>, IGraphOperationQueryBuilder<FlowTriggerReceivePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FlowTriggerReceiveArgumentsBuilder Arguments { get; }
        protected override FlowTriggerReceiveOperationQueryBuilder Self => this;

        public FlowTriggerReceiveOperationQueryBuilder() : this("flowTriggerReceive")
        {
        }

        public FlowTriggerReceiveOperationQueryBuilder(string name) : base(new Query<FlowTriggerReceivePayload>(name))
        {
            Arguments = new FlowTriggerReceiveArgumentsBuilder(base.InnerQuery);
        }

        public FlowTriggerReceiveOperationQueryBuilder(IQuery<FlowTriggerReceivePayload> query) : base(query)
        {
            Arguments = new FlowTriggerReceiveArgumentsBuilder(base.InnerQuery);
        }

        public FlowTriggerReceiveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}