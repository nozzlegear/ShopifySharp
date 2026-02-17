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