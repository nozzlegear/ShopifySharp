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
    public sealed class DraftOrderInvoiceSendOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderInvoiceSendPayload, DraftOrderInvoiceSendOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderInvoiceSendPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderInvoiceSendArgumentsBuilder Arguments { get; }
        protected override DraftOrderInvoiceSendOperationQueryBuilder Self => this;

        public DraftOrderInvoiceSendOperationQueryBuilder() : this("draftOrderInvoiceSend")
        {
        }

        public DraftOrderInvoiceSendOperationQueryBuilder(string name) : base(new Query<DraftOrderInvoiceSendPayload>(name))
        {
            Arguments = new DraftOrderInvoiceSendArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderInvoiceSendOperationQueryBuilder(IQuery<DraftOrderInvoiceSendPayload> query) : base(query)
        {
            Arguments = new DraftOrderInvoiceSendArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderInvoiceSendOperationQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderInvoiceSendOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}