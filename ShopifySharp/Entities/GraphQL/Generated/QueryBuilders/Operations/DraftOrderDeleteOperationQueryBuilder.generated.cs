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
    public sealed class DraftOrderDeleteOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderDeletePayload, DraftOrderDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderDeleteArgumentsBuilder Arguments { get; }
        protected override DraftOrderDeleteOperationQueryBuilder Self => this;

        public DraftOrderDeleteOperationQueryBuilder() : this("draftOrderDelete")
        {
        }

        public DraftOrderDeleteOperationQueryBuilder(string name) : base(new Query<DraftOrderDeletePayload>(name))
        {
            Arguments = new DraftOrderDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderDeleteOperationQueryBuilder(IQuery<DraftOrderDeletePayload> query) : base(query)
        {
            Arguments = new DraftOrderDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public DraftOrderDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}