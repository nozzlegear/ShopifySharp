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
    public sealed class GiftCardProductSettingsQueryBuilder : FieldsQueryBuilderBase<GiftCardProductSettings, GiftCardProductSettingsQueryBuilder>
    {
        protected override GiftCardProductSettingsQueryBuilder Self => this;

        public GiftCardProductSettingsQueryBuilder() : this("giftCardProductSettings")
        {
        }

        public GiftCardProductSettingsQueryBuilder(string name) : base(new Query<GiftCardProductSettings>(name))
        {
        }

        public GiftCardProductSettingsQueryBuilder(IQuery<GiftCardProductSettings> query) : base(query)
        {
        }

        public GiftCardProductSettingsQueryBuilder CrossCurrencyRedeemable()
        {
            base.InnerQuery.AddField("crossCurrencyRedeemable");
            return this;
        }

        public GiftCardProductSettingsQueryBuilder IssuanceCurrency()
        {
            base.InnerQuery.AddField("issuanceCurrency");
            return this;
        }
    }
}