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
    public sealed class GiftCardExpirationConfigurationQueryBuilder : FieldsQueryBuilderBase<GiftCardExpirationConfiguration, GiftCardExpirationConfigurationQueryBuilder>
    {
        protected override GiftCardExpirationConfigurationQueryBuilder Self => this;

        public GiftCardExpirationConfigurationQueryBuilder() : this("giftCardExpirationConfiguration")
        {
        }

        public GiftCardExpirationConfigurationQueryBuilder(string name) : base(new Query<GiftCardExpirationConfiguration>(name))
        {
        }

        public GiftCardExpirationConfigurationQueryBuilder(IQuery<GiftCardExpirationConfiguration> query) : base(query)
        {
        }

        public GiftCardExpirationConfigurationQueryBuilder ExpirationUnit()
        {
            base.InnerQuery.AddField("expirationUnit");
            return this;
        }

        public GiftCardExpirationConfigurationQueryBuilder ExpirationValue()
        {
            base.InnerQuery.AddField("expirationValue");
            return this;
        }
    }
}