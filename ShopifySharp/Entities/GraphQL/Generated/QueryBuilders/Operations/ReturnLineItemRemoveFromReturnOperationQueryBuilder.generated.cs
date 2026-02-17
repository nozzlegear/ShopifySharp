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
    [Obsolete("Use `removeFromReturn` instead.")]
    public sealed class ReturnLineItemRemoveFromReturnOperationQueryBuilder : FieldsQueryBuilderBase<ReturnLineItemRemoveFromReturnPayload, ReturnLineItemRemoveFromReturnOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnLineItemRemoveFromReturnPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnLineItemRemoveFromReturnArgumentsBuilder Arguments { get; }
        protected override ReturnLineItemRemoveFromReturnOperationQueryBuilder Self => this;

        public ReturnLineItemRemoveFromReturnOperationQueryBuilder() : this("returnLineItemRemoveFromReturn")
        {
        }

        public ReturnLineItemRemoveFromReturnOperationQueryBuilder(string name) : base(new Query<ReturnLineItemRemoveFromReturnPayload>(name))
        {
            Arguments = new ReturnLineItemRemoveFromReturnArgumentsBuilder(base.InnerQuery);
        }

        public ReturnLineItemRemoveFromReturnOperationQueryBuilder(IQuery<ReturnLineItemRemoveFromReturnPayload> query) : base(query)
        {
            Arguments = new ReturnLineItemRemoveFromReturnArgumentsBuilder(base.InnerQuery);
        }

        public ReturnLineItemRemoveFromReturnOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnLineItemRemoveFromReturnOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}