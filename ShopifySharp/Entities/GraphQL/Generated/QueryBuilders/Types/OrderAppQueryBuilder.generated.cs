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
    public sealed class OrderAppQueryBuilder : FieldsQueryBuilderBase<OrderApp, OrderAppQueryBuilder>
    {
        protected override OrderAppQueryBuilder Self => this;

        public OrderAppQueryBuilder() : this("orderApp")
        {
        }

        public OrderAppQueryBuilder(string name) : base(new Query<OrderApp>(name))
        {
        }

        public OrderAppQueryBuilder(IQuery<OrderApp> query) : base(query)
        {
        }

        public OrderAppQueryBuilder Icon(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public OrderAppQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OrderAppQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}