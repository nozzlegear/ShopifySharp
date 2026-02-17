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
    public sealed class ReturnDeclineRequestOperationQueryBuilder : FieldsQueryBuilderBase<ReturnDeclineRequestPayload, ReturnDeclineRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnDeclineRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnDeclineRequestArgumentsBuilder Arguments { get; }
        protected override ReturnDeclineRequestOperationQueryBuilder Self => this;

        public ReturnDeclineRequestOperationQueryBuilder() : this("returnDeclineRequest")
        {
        }

        public ReturnDeclineRequestOperationQueryBuilder(string name) : base(new Query<ReturnDeclineRequestPayload>(name))
        {
            Arguments = new ReturnDeclineRequestArgumentsBuilder(base.InnerQuery);
        }

        public ReturnDeclineRequestOperationQueryBuilder(IQuery<ReturnDeclineRequestPayload> query) : base(query)
        {
            Arguments = new ReturnDeclineRequestArgumentsBuilder(base.InnerQuery);
        }

        public ReturnDeclineRequestOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnDeclineRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}