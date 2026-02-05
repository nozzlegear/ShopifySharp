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
    public sealed class AppPurchaseQueryBuilder : FieldsQueryBuilderBase<IAppPurchase, AppPurchaseQueryBuilder>
    {
        protected override AppPurchaseQueryBuilder Self => this;

        public AppPurchaseQueryBuilder() : this("appPurchase")
        {
        }

        public AppPurchaseQueryBuilder(string name) : base(new Query<IAppPurchase>(name))
        {
        }

        public AppPurchaseQueryBuilder(IQuery<IAppPurchase> query) : base(query)
        {
        }

        public AppPurchaseQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AppPurchaseQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public AppPurchaseQueryBuilder Price(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppPurchaseQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public AppPurchaseQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }
    }
}