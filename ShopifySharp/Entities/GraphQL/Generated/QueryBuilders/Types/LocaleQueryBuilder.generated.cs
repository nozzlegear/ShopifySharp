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
    public sealed class LocaleQueryBuilder : FieldsQueryBuilderBase<Locale, LocaleQueryBuilder>
    {
        protected override LocaleQueryBuilder Self => this;

        public LocaleQueryBuilder() : this("locale")
        {
        }

        public LocaleQueryBuilder(string name) : base(new Query<Locale>(name))
        {
        }

        public LocaleQueryBuilder(IQuery<Locale> query) : base(query)
        {
        }

        public LocaleQueryBuilder IsoCode()
        {
            base.InnerQuery.AddField("isoCode");
            return this;
        }

        public LocaleQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}