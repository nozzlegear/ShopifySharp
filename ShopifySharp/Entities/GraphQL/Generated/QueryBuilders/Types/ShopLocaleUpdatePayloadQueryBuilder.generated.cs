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
    public sealed class ShopLocaleUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ShopLocaleUpdatePayload, ShopLocaleUpdatePayloadQueryBuilder>
    {
        protected override ShopLocaleUpdatePayloadQueryBuilder Self => this;

        public ShopLocaleUpdatePayloadQueryBuilder() : this("shopLocaleUpdatePayload")
        {
        }

        public ShopLocaleUpdatePayloadQueryBuilder(string name) : base(new Query<ShopLocaleUpdatePayload>(name))
        {
        }

        public ShopLocaleUpdatePayloadQueryBuilder(IQuery<ShopLocaleUpdatePayload> query) : base(query)
        {
        }

        public ShopLocaleUpdatePayloadQueryBuilder ShopLocale(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder> build)
        {
            var query = new Query<ShopLocale>("shopLocale");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopLocale>(query);
            return this;
        }

        public ShopLocaleUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}