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
    public sealed class ShopPolicyUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ShopPolicyUpdatePayload, ShopPolicyUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopPolicyUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShopPolicyUpdateArgumentsBuilder Arguments { get; }
        protected override ShopPolicyUpdateOperationQueryBuilder Self => this;

        public ShopPolicyUpdateOperationQueryBuilder() : this("shopPolicyUpdate")
        {
        }

        public ShopPolicyUpdateOperationQueryBuilder(string name) : base(new Query<ShopPolicyUpdatePayload>(name))
        {
            Arguments = new ShopPolicyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ShopPolicyUpdateOperationQueryBuilder(IQuery<ShopPolicyUpdatePayload> query) : base(query)
        {
            Arguments = new ShopPolicyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ShopPolicyUpdateOperationQueryBuilder ShopPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyQueryBuilder> build)
        {
            var query = new Query<ShopPolicy>("shopPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPolicy>(query);
            return this;
        }

        public ShopPolicyUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyUserErrorQueryBuilder> build)
        {
            var query = new Query<ShopPolicyUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPolicyUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPolicyUserError>(query);
            return this;
        }
    }
}