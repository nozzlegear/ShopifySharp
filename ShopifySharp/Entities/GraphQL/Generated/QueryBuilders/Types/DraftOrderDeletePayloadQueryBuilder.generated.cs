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
    public sealed class DraftOrderDeletePayloadQueryBuilder : FieldsQueryBuilderBase<DraftOrderDeletePayload, DraftOrderDeletePayloadQueryBuilder>
    {
        protected override DraftOrderDeletePayloadQueryBuilder Self => this;

        public DraftOrderDeletePayloadQueryBuilder() : this("draftOrderDeletePayload")
        {
        }

        public DraftOrderDeletePayloadQueryBuilder(string name) : base(new Query<DraftOrderDeletePayload>(name))
        {
        }

        public DraftOrderDeletePayloadQueryBuilder(IQuery<DraftOrderDeletePayload> query) : base(query)
        {
        }

        public DraftOrderDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public DraftOrderDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}