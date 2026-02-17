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
    public sealed class ReturnRequestOperationQueryBuilder : FieldsQueryBuilderBase<ReturnRequestPayload, ReturnRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnRequestArgumentsBuilder Arguments { get; }
        protected override ReturnRequestOperationQueryBuilder Self => this;

        public ReturnRequestOperationQueryBuilder() : this("returnRequest")
        {
        }

        public ReturnRequestOperationQueryBuilder(string name) : base(new Query<ReturnRequestPayload>(name))
        {
            Arguments = new ReturnRequestArgumentsBuilder(base.InnerQuery);
        }

        public ReturnRequestOperationQueryBuilder(IQuery<ReturnRequestPayload> query) : base(query)
        {
            Arguments = new ReturnRequestArgumentsBuilder(base.InnerQuery);
        }

        public ReturnRequestOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}