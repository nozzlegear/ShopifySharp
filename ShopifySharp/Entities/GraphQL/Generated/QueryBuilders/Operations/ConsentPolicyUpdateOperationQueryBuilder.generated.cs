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

        public ConsentPolicyUpdateOperationQueryBuilder UpdatedPolicies(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ConsentPolicyQueryBuilder> build)
        {
            var query = new Query<ConsentPolicy>("updatedPolicies");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ConsentPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ConsentPolicy>(query);
            return this;
        }

        public ConsentPolicyUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ConsentPolicyErrorQueryBuilder> build)
        {
            var query = new Query<ConsentPolicyError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ConsentPolicyErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ConsentPolicyError>(query);
            return this;
        }
    }
}