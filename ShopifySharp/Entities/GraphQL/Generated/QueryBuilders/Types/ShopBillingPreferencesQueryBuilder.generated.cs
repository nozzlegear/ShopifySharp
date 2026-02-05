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