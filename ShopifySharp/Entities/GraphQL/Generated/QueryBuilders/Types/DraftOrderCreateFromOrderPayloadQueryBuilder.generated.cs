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
    public sealed class DraftOrderCreateFromOrderPayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderCreateFromOrderPayload, DraftOrderCreateFromOrderPayloadQueryBuilder>
    {
        protected override DraftOrderCreateFromOrderPayloadQueryBuilder Self => this;

        public DraftOrderCreateFromOrderPayloadQueryBuilder() : this("draftOrderCreateFromOrderPayload")
        {
        }

        public DraftOrderCreateFromOrderPayloadQueryBuilder(string name) : base(new Query<DraftOrderCreateFromOrderPayload>(name))
        {
        }

        public DraftOrderCreateFromOrderPayloadQueryBuilder(IQuery<DraftOrderCreateFromOrderPayload> query) : base(query)
        {
        }

        public DraftOrderCreateFromOrderPayloadQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderCreateFromOrderPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}