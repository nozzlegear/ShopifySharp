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
    public sealed class MetafieldDefinitionConstraintsValuesArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionConstraintValueConnection?, MetafieldDefinitionConstraintsValuesArgumentsBuilder>
    {
        protected override MetafieldDefinitionConstraintsValuesArgumentsBuilder Self => this;

        public MetafieldDefinitionConstraintsValuesArgumentsBuilder(IQuery<MetafieldDefinitionConstraintValueConnection?> query) : base(query)
        {
        }

        public MetafieldDefinitionConstraintsValuesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldDefinitionConstraintsValuesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldDefinitionConstraintsValuesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldDefinitionConstraintsValuesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldDefinitionConstraintsValuesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}