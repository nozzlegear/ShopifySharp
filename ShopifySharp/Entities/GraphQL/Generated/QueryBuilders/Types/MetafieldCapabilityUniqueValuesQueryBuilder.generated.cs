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
    public sealed class MetafieldCapabilityUniqueValuesQueryBuilder : FieldsQueryBuilderBase<MetafieldCapabilityUniqueValues, MetafieldCapabilityUniqueValuesQueryBuilder>
    {
        protected override MetafieldCapabilityUniqueValuesQueryBuilder Self => this;

        public MetafieldCapabilityUniqueValuesQueryBuilder() : this("metafieldCapabilityUniqueValues")
        {
        }

        public MetafieldCapabilityUniqueValuesQueryBuilder(string name) : base(new Query<MetafieldCapabilityUniqueValues>(name))
        {
        }

        public MetafieldCapabilityUniqueValuesQueryBuilder(IQuery<MetafieldCapabilityUniqueValues> query) : base(query)
        {
        }

        public MetafieldCapabilityUniqueValuesQueryBuilder Eligible()
        {
            base.InnerQuery.AddField("eligible");
            return this;
        }

        public MetafieldCapabilityUniqueValuesQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}