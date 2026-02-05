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
    public sealed class DraftOrderCalculatePayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderCalculatePayload, DraftOrderCalculatePayloadQueryBuilder>
    {
        protected override DraftOrderCalculatePayloadQueryBuilder Self => this;

        public DraftOrderCalculatePayloadQueryBuilder() : this("draftOrderCalculatePayload")
        {
        }

        public DraftOrderCalculatePayloadQueryBuilder(string name) : base(new Query<DraftOrderCalculatePayload>(name))
        {
        }

        public DraftOrderCalculatePayloadQueryBuilder(IQuery<DraftOrderCalculatePayload> query) : base(query)
        {
        }

        public DraftOrderCalculatePayloadQueryBuilder CalculatedDraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDraftOrderQueryBuilder> build)
        {
            var query = new Query<CalculatedDraftOrder>("calculatedDraftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedDraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedDraftOrder>(query);
            return this;
        }

        public DraftOrderCalculatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}