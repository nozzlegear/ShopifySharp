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
    public sealed class ShopBillingPreferencesQueryBuilder : FieldsQueryBuilderBase<ShopBillingPreferences, ShopBillingPreferencesQueryBuilder>
    {
        protected override ShopBillingPreferencesQueryBuilder Self => this;

        public ShopBillingPreferencesQueryBuilder() : this("shopBillingPreferences")
        {
        }

        public ShopBillingPreferencesQueryBuilder(string name) : base(new Query<ShopBillingPreferences>(name))
        {
        }

        public ShopBillingPreferencesQueryBuilder(IQuery<ShopBillingPreferences> query) : base(query)
        {
        }

        public ShopBillingPreferencesQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }
    }
}