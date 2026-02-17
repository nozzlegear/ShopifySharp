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