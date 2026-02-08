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
    public sealed class ShopLocaleDisablePayloadQueryBuilder : FieldsQueryBuilderBase<ShopLocaleDisablePayload, ShopLocaleDisablePayloadQueryBuilder>
    {
        protected override ShopLocaleDisablePayloadQueryBuilder Self => this;

        public ShopLocaleDisablePayloadQueryBuilder() : this("shopLocaleDisablePayload")
        {
        }

        public ShopLocaleDisablePayloadQueryBuilder(string name) : base(new Query<ShopLocaleDisablePayload>(name))
        {
        }

        public ShopLocaleDisablePayloadQueryBuilder(IQuery<ShopLocaleDisablePayload> query) : base(query)
        {
        }

        public ShopLocaleDisablePayloadQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ShopLocaleDisablePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}