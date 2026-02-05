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
    public sealed class DraftOrderCreateOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderCreatePayload, DraftOrderCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderCreateArgumentsBuilder Arguments { get; }
        protected override DraftOrderCreateOperationQueryBuilder Self => this;

        public DraftOrderCreateOperationQueryBuilder() : this("draftOrderCreate")
        {
        }

        public DraftOrderCreateOperationQueryBuilder(string name) : base(new Query<DraftOrderCreatePayload>(name))
        {
            Arguments = new DraftOrderCreateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCreateOperationQueryBuilder(IQuery<DraftOrderCreatePayload> query) : base(query)
        {
            Arguments = new DraftOrderCreateArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCreateOperationQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}