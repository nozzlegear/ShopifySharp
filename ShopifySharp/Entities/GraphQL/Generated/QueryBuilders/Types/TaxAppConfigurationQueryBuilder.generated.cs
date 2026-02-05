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
    public sealed class TaxAppConfigurationQueryBuilder : FieldsQueryBuilderBase<TaxAppConfiguration, TaxAppConfigurationQueryBuilder>
    {
        protected override TaxAppConfigurationQueryBuilder Self => this;

        public TaxAppConfigurationQueryBuilder() : this("taxAppConfiguration")
        {
        }

        public TaxAppConfigurationQueryBuilder(string name) : base(new Query<TaxAppConfiguration>(name))
        {
        }

        public TaxAppConfigurationQueryBuilder(IQuery<TaxAppConfiguration> query) : base(query)
        {
        }

        public TaxAppConfigurationQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }
    }
}