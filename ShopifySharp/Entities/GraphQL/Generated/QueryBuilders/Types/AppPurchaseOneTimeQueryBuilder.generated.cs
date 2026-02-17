#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class AppPurchaseOneTimeQueryBuilder : FieldsQueryBuilderBase<AppPurchaseOneTime, AppPurchaseOneTimeQueryBuilder>
    {
        protected override AppPurchaseOneTimeQueryBuilder Self => this;

        public AppPurchaseOneTimeQueryBuilder() : this("appPurchaseOneTime")
        {
        }

        public AppPurchaseOneTimeQueryBuilder(string name) : base(new Query<AppPurchaseOneTime>(name))
        {
        }

        public AppPurchaseOneTimeQueryBuilder(IQuery<AppPurchaseOneTime> query) : base(query)
        {
        }

        public AppPurchaseOneTimeQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AppPurchaseOneTimeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppPurchaseOneTimeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public AppPurchaseOneTimeQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppPurchaseOneTimeQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public AppPurchaseOneTimeQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }
    }
}