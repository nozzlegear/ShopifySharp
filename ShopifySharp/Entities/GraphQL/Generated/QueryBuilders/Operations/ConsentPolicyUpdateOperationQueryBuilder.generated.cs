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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ConsentPolicyUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ConsentPolicyUpdatePayload, ConsentPolicyUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ConsentPolicyUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ConsentPolicyUpdateArgumentsBuilder Arguments { get; }
        protected override ConsentPolicyUpdateOperationQueryBuilder Self => this;

        public ConsentPolicyUpdateOperationQueryBuilder() : this("consentPolicyUpdate")
        {
        }

        public ConsentPolicyUpdateOperationQueryBuilder(string name) : base(new Query<ConsentPolicyUpdatePayload>(name))
        {
            Arguments = new ConsentPolicyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ConsentPolicyUpdateOperationQueryBuilder(IQuery<ConsentPolicyUpdatePayload> query) : base(query)
        {
            Arguments = new ConsentPolicyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ConsentPolicyUpdateOperationQueryBuilder UpdatedPolicies(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyQueryBuilder> build)
        {
            var query = new Query<ConsentPolicy>("updatedPolicies");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ConsentPolicy>(query);
            return this;
        }

        public ConsentPolicyUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyErrorQueryBuilder> build)
        {
            var query = new Query<ConsentPolicyError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ConsentPolicyErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ConsentPolicyError>(query);
            return this;
        }
    }
}