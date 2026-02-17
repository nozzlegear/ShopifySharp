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
    public sealed class ReturnApproveRequestOperationQueryBuilder : FieldsQueryBuilderBase<ReturnApproveRequestPayload, ReturnApproveRequestOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnApproveRequestPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnApproveRequestArgumentsBuilder Arguments { get; }
        protected override ReturnApproveRequestOperationQueryBuilder Self => this;

        public ReturnApproveRequestOperationQueryBuilder() : this("returnApproveRequest")
        {
        }

        public ReturnApproveRequestOperationQueryBuilder(string name) : base(new Query<ReturnApproveRequestPayload>(name))
        {
            Arguments = new ReturnApproveRequestArgumentsBuilder(base.InnerQuery);
        }

        public ReturnApproveRequestOperationQueryBuilder(IQuery<ReturnApproveRequestPayload> query) : base(query)
        {
            Arguments = new ReturnApproveRequestArgumentsBuilder(base.InnerQuery);
        }

        public ReturnApproveRequestOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnApproveRequestOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}