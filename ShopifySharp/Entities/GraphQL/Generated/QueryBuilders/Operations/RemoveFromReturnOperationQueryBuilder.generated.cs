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
    public sealed class RemoveFromReturnOperationQueryBuilder : FieldsQueryBuilderBase<RemoveFromReturnPayload, RemoveFromReturnOperationQueryBuilder>, IGraphOperationQueryBuilder<RemoveFromReturnPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public RemoveFromReturnArgumentsBuilder Arguments { get; }
        protected override RemoveFromReturnOperationQueryBuilder Self => this;

        public RemoveFromReturnOperationQueryBuilder() : this("removeFromReturn")
        {
        }

        public RemoveFromReturnOperationQueryBuilder(string name) : base(new Query<RemoveFromReturnPayload>(name))
        {
            Arguments = new RemoveFromReturnArgumentsBuilder(base.InnerQuery);
        }

        public RemoveFromReturnOperationQueryBuilder(IQuery<RemoveFromReturnPayload> query) : base(query)
        {
            Arguments = new RemoveFromReturnArgumentsBuilder(base.InnerQuery);
        }

        public RemoveFromReturnOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public RemoveFromReturnOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}