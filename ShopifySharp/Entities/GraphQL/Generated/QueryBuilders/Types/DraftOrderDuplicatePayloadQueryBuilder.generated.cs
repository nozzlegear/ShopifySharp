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
    public sealed class DraftOrderDuplicatePayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderDuplicatePayload, DraftOrderDuplicatePayloadQueryBuilder>
    {
        protected override DraftOrderDuplicatePayloadQueryBuilder Self => this;

        public DraftOrderDuplicatePayloadQueryBuilder() : this("draftOrderDuplicatePayload")
        {
        }

        public DraftOrderDuplicatePayloadQueryBuilder(string name) : base(new Query<DraftOrderDuplicatePayload>(name))
        {
        }

        public DraftOrderDuplicatePayloadQueryBuilder(IQuery<DraftOrderDuplicatePayload> query) : base(query)
        {
        }

        public DraftOrderDuplicatePayloadQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderDuplicatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}