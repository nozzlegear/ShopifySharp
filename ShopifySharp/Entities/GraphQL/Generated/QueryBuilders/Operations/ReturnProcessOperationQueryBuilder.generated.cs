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
    public sealed class ReturnProcessOperationQueryBuilder : FieldsQueryBuilderBase<ReturnProcessPayload, ReturnProcessOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnProcessPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnProcessArgumentsBuilder Arguments { get; }
        protected override ReturnProcessOperationQueryBuilder Self => this;

        public ReturnProcessOperationQueryBuilder() : this("returnProcess")
        {
        }

        public ReturnProcessOperationQueryBuilder(string name) : base(new Query<ReturnProcessPayload>(name))
        {
            Arguments = new ReturnProcessArgumentsBuilder(base.InnerQuery);
        }

        public ReturnProcessOperationQueryBuilder(IQuery<ReturnProcessPayload> query) : base(query)
        {
            Arguments = new ReturnProcessArgumentsBuilder(base.InnerQuery);
        }

        public ReturnProcessOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnProcessOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}