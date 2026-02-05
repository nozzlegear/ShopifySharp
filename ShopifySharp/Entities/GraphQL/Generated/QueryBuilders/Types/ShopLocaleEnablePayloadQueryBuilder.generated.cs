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
    public sealed class ShopLocaleEnablePayloadQueryBuilder : FieldsQueryBuilderBase<ShopLocaleEnablePayload, ShopLocaleEnablePayloadQueryBuilder>
    {
        protected override ShopLocaleEnablePayloadQueryBuilder Self => this;

        public ShopLocaleEnablePayloadQueryBuilder() : this("shopLocaleEnablePayload")
        {
        }

        public ShopLocaleEnablePayloadQueryBuilder(string name) : base(new Query<ShopLocaleEnablePayload>(name))
        {
        }

        public ShopLocaleEnablePayloadQueryBuilder(IQuery<ShopLocaleEnablePayload> query) : base(query)
        {
        }

        public ShopLocaleEnablePayloadQueryBuilder ShopLocale(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder> build)
        {
            var query = new Query<ShopLocale>("shopLocale");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopLocale>(query);
            return this;
        }

        public ShopLocaleEnablePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}