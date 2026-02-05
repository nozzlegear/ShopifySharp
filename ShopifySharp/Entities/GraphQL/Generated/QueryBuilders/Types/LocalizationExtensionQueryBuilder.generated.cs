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
    public sealed class LocalizationExtensionQueryBuilder : FieldsQueryBuilderBase<LocalizationExtension, LocalizationExtensionQueryBuilder>
    {
        protected override LocalizationExtensionQueryBuilder Self => this;

        public LocalizationExtensionQueryBuilder() : this("localizationExtension")
        {
        }

        public LocalizationExtensionQueryBuilder(string name) : base(new Query<LocalizationExtension>(name))
        {
        }

        public LocalizationExtensionQueryBuilder(IQuery<LocalizationExtension> query) : base(query)
        {
        }

        public LocalizationExtensionQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public LocalizationExtensionQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public LocalizationExtensionQueryBuilder Purpose()
        {
            base.InnerQuery.AddField("purpose");
            return this;
        }

        public LocalizationExtensionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public LocalizationExtensionQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}