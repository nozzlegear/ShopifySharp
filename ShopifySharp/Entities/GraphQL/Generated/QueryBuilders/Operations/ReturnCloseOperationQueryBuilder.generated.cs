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
    public sealed class ReturnCloseOperationQueryBuilder : FieldsQueryBuilderBase<ReturnClosePayload, ReturnCloseOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnClosePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnCloseArgumentsBuilder Arguments { get; }
        protected override ReturnCloseOperationQueryBuilder Self => this;

        public ReturnCloseOperationQueryBuilder() : this("returnClose")
        {
        }

        public ReturnCloseOperationQueryBuilder(string name) : base(new Query<ReturnClosePayload>(name))
        {
            Arguments = new ReturnCloseArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCloseOperationQueryBuilder(IQuery<ReturnClosePayload> query) : base(query)
        {
            Arguments = new ReturnCloseArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCloseOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnCloseOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}