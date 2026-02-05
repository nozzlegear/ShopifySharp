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
    public sealed class ShopAlertActionQueryBuilder : FieldsQueryBuilderBase<ShopAlertAction, ShopAlertActionQueryBuilder>
    {
        protected override ShopAlertActionQueryBuilder Self => this;

        public ShopAlertActionQueryBuilder() : this("shopAlertAction")
        {
        }

        public ShopAlertActionQueryBuilder(string name) : base(new Query<ShopAlertAction>(name))
        {
        }

        public ShopAlertActionQueryBuilder(IQuery<ShopAlertAction> query) : base(query)
        {
        }

        public ShopAlertActionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ShopAlertActionQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}