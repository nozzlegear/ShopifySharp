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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DraftOrderInvoiceSendPayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderInvoiceSendPayload, DraftOrderInvoiceSendPayloadQueryBuilder>
    {
        protected override DraftOrderInvoiceSendPayloadQueryBuilder Self => this;

        public DraftOrderInvoiceSendPayloadQueryBuilder() : this("draftOrderInvoiceSendPayload")
        {
        }

        public DraftOrderInvoiceSendPayloadQueryBuilder(string name) : base(new Query<DraftOrderInvoiceSendPayload>(name))
        {
        }

        public DraftOrderInvoiceSendPayloadQueryBuilder(IQuery<DraftOrderInvoiceSendPayload> query) : base(query)
        {
        }

        public DraftOrderInvoiceSendPayloadQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderInvoiceSendPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}