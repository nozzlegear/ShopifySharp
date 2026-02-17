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
    public sealed class DraftOrderCreateFromOrderOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderCreateFromOrderPayload, DraftOrderCreateFromOrderOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderCreateFromOrderPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderCreateFromOrderArgumentsBuilder Arguments { get; }
        protected override DraftOrderCreateFromOrderOperationQueryBuilder Self => this;

        public DraftOrderCreateFromOrderOperationQueryBuilder() : this("draftOrderCreateFromOrder")
        {
        }

        public DraftOrderCreateFromOrderOperationQueryBuilder(string name) : base(new Query<DraftOrderCreateFromOrderPayload>(name))
        {
            Arguments = new DraftOrderCreateFromOrderArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCreateFromOrderOperationQueryBuilder(IQuery<DraftOrderCreateFromOrderPayload> query) : base(query)
        {
            Arguments = new DraftOrderCreateFromOrderArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderCreateFromOrderOperationQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderCreateFromOrderOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}