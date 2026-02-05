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
    public sealed class CurrencyFormatsQueryBuilder : FieldsQueryBuilderBase<CurrencyFormats, CurrencyFormatsQueryBuilder>
    {
        protected override CurrencyFormatsQueryBuilder Self => this;

        public CurrencyFormatsQueryBuilder() : this("currencyFormats")
        {
        }

        public CurrencyFormatsQueryBuilder(string name) : base(new Query<CurrencyFormats>(name))
        {
        }

        public CurrencyFormatsQueryBuilder(IQuery<CurrencyFormats> query) : base(query)
        {
        }

        public CurrencyFormatsQueryBuilder MoneyFormat()
        {
            base.InnerQuery.AddField("moneyFormat");
            return this;
        }

        public CurrencyFormatsQueryBuilder MoneyInEmailsFormat()
        {
            base.InnerQuery.AddField("moneyInEmailsFormat");
            return this;
        }

        public CurrencyFormatsQueryBuilder MoneyWithCurrencyFormat()
        {
            base.InnerQuery.AddField("moneyWithCurrencyFormat");
            return this;
        }

        public CurrencyFormatsQueryBuilder MoneyWithCurrencyInEmailsFormat()
        {
            base.InnerQuery.AddField("moneyWithCurrencyInEmailsFormat");
            return this;
        }
    }
}