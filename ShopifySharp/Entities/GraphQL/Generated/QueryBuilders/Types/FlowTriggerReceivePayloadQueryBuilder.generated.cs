#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class FlowTriggerReceivePayloadQueryBuilder : FieldsQueryBuilderBase<FlowTriggerReceivePayload, FlowTriggerReceivePayloadQueryBuilder>
    {
        protected override FlowTriggerReceivePayloadQueryBuilder Self => this;

        public FlowTriggerReceivePayloadQueryBuilder() : this("flowTriggerReceivePayload")
        {
        }

        public FlowTriggerReceivePayloadQueryBuilder(string name) : base(new Query<FlowTriggerReceivePayload>(name))
        {
        }

        public FlowTriggerReceivePayloadQueryBuilder(IQuery<FlowTriggerReceivePayload> query) : base(query)
        {
        }

        public FlowTriggerReceivePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}