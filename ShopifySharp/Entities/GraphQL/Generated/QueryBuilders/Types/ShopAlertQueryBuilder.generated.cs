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
    public sealed class ShopAlertQueryBuilder : FieldsQueryBuilderBase<ShopAlert, ShopAlertQueryBuilder>
    {
        protected override ShopAlertQueryBuilder Self => this;

        public ShopAlertQueryBuilder() : this("shopAlert")
        {
        }

        public ShopAlertQueryBuilder(string name) : base(new Query<ShopAlert>(name))
        {
        }

        public ShopAlertQueryBuilder(IQuery<ShopAlert> query) : base(query)
        {
        }

        public ShopAlertQueryBuilder Action(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopAlertActionQueryBuilder> build)
        {
            var query = new Query<ShopAlertAction>("action");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopAlertActionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopAlertAction>(query);
            return this;
        }

        public ShopAlertQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }
    }
}