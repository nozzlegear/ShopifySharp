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
    public sealed class StoreCreditConfigurationQueryBuilder : FieldsQueryBuilderBase<StoreCreditConfiguration, StoreCreditConfigurationQueryBuilder>
    {
        protected override StoreCreditConfigurationQueryBuilder Self => this;

        public StoreCreditConfigurationQueryBuilder() : this("storeCreditConfiguration")
        {
        }

        public StoreCreditConfigurationQueryBuilder(string name) : base(new Query<StoreCreditConfiguration>(name))
        {
        }

        public StoreCreditConfigurationQueryBuilder(IQuery<StoreCreditConfiguration> query) : base(query)
        {
        }

        public StoreCreditConfigurationQueryBuilder StoreCreditEnabled()
        {
            base.InnerQuery.AddField("storeCreditEnabled");
            return this;
        }
    }
}