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
    public sealed class TaxSettingsQueryBuilder : FieldsQueryBuilderBase<TaxSettings, TaxSettingsQueryBuilder>
    {
        protected override TaxSettingsQueryBuilder Self => this;

        public TaxSettingsQueryBuilder() : this("taxSettings")
        {
        }

        public TaxSettingsQueryBuilder(string name) : base(new Query<TaxSettings>(name))
        {
        }

        public TaxSettingsQueryBuilder(IQuery<TaxSettings> query) : base(query)
        {
        }

        public TaxSettingsQueryBuilder TaxId()
        {
            base.InnerQuery.AddField("taxId");
            return this;
        }
    }
}