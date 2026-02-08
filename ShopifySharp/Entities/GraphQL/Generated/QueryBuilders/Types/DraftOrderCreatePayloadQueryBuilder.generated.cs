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
    public sealed class DraftOrderCreatePayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderCreatePayload, DraftOrderCreatePayloadQueryBuilder>
    {
        protected override DraftOrderCreatePayloadQueryBuilder Self => this;

        public DraftOrderCreatePayloadQueryBuilder() : this("draftOrderCreatePayload")
        {
        }

        public DraftOrderCreatePayloadQueryBuilder(string name) : base(new Query<DraftOrderCreatePayload>(name))
        {
        }

        public DraftOrderCreatePayloadQueryBuilder(IQuery<DraftOrderCreatePayload> query) : base(query)
        {
        }

        public DraftOrderCreatePayloadQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}