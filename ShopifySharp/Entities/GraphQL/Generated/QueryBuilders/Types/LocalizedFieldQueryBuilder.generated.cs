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
    public sealed class LocalizedFieldQueryBuilder : FieldsQueryBuilderBase<LocalizedField, LocalizedFieldQueryBuilder>
    {
        protected override LocalizedFieldQueryBuilder Self => this;

        public LocalizedFieldQueryBuilder() : this("localizedField")
        {
        }

        public LocalizedFieldQueryBuilder(string name) : base(new Query<LocalizedField>(name))
        {
        }

        public LocalizedFieldQueryBuilder(IQuery<LocalizedField> query) : base(query)
        {
        }

        public LocalizedFieldQueryBuilder CountryCode()
        {
            base.InnerQuery.AddField("countryCode");
            return this;
        }

        public LocalizedFieldQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public LocalizedFieldQueryBuilder Purpose()
        {
            base.InnerQuery.AddField("purpose");
            return this;
        }

        public LocalizedFieldQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public LocalizedFieldQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}