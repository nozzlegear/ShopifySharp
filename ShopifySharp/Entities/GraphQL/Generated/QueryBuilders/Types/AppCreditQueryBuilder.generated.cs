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
    public sealed class AppCreditQueryBuilder : FieldsQueryBuilderBase<AppCredit, AppCreditQueryBuilder>
    {
        protected override AppCreditQueryBuilder Self => this;

        public AppCreditQueryBuilder() : this("appCredit")
        {
        }

        public AppCreditQueryBuilder(string name) : base(new Query<AppCredit>(name))
        {
        }

        public AppCreditQueryBuilder(IQuery<AppCredit> query) : base(query)
        {
        }

        public AppCreditQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppCreditQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AppCreditQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public AppCreditQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppCreditQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }
    }
}