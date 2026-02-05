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
    public sealed class ReturnCancelOperationQueryBuilder : FieldsQueryBuilderBase<ReturnCancelPayload, ReturnCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnCancelArgumentsBuilder Arguments { get; }
        protected override ReturnCancelOperationQueryBuilder Self => this;

        public ReturnCancelOperationQueryBuilder() : this("returnCancel")
        {
        }

        public ReturnCancelOperationQueryBuilder(string name) : base(new Query<ReturnCancelPayload>(name))
        {
            Arguments = new ReturnCancelArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCancelOperationQueryBuilder(IQuery<ReturnCancelPayload> query) : base(query)
        {
            Arguments = new ReturnCancelArgumentsBuilder(base.InnerQuery);
        }

        public ReturnCancelOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}