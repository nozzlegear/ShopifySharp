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
    public sealed class AppPurchaseOneTimeCreatePayloadQueryBuilder : FieldsQueryBuilderBase<AppPurchaseOneTimeCreatePayload, AppPurchaseOneTimeCreatePayloadQueryBuilder>
    {
        protected override AppPurchaseOneTimeCreatePayloadQueryBuilder Self => this;

        public AppPurchaseOneTimeCreatePayloadQueryBuilder() : this("appPurchaseOneTimeCreatePayload")
        {
        }

        public AppPurchaseOneTimeCreatePayloadQueryBuilder(string name) : base(new Query<AppPurchaseOneTimeCreatePayload>(name))
        {
        }

        public AppPurchaseOneTimeCreatePayloadQueryBuilder(IQuery<AppPurchaseOneTimeCreatePayload> query) : base(query)
        {
        }

        public AppPurchaseOneTimeCreatePayloadQueryBuilder AppPurchaseOneTime(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTime>("appPurchaseOneTime");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTime>(query);
            return this;
        }

        public AppPurchaseOneTimeCreatePayloadQueryBuilder ConfirmationUrl()
        {
            base.InnerQuery.AddField("confirmationUrl");
            return this;
        }

        public AppPurchaseOneTimeCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}