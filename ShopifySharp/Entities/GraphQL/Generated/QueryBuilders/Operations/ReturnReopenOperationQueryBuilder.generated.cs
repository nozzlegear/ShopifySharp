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
    public sealed class ReturnReopenOperationQueryBuilder : FieldsQueryBuilderBase<ReturnReopenPayload, ReturnReopenOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnReopenPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnReopenArgumentsBuilder Arguments { get; }
        protected override ReturnReopenOperationQueryBuilder Self => this;

        public ReturnReopenOperationQueryBuilder() : this("returnReopen")
        {
        }

        public ReturnReopenOperationQueryBuilder(string name) : base(new Query<ReturnReopenPayload>(name))
        {
            Arguments = new ReturnReopenArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReopenOperationQueryBuilder(IQuery<ReturnReopenPayload> query) : base(query)
        {
            Arguments = new ReturnReopenArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReopenOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnReopenOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}