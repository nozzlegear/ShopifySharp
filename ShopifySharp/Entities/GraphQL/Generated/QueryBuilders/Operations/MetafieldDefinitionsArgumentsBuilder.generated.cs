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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MetafieldDefinitionsArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionConnection, MetafieldDefinitionsArgumentsBuilder>
    {
        protected override MetafieldDefinitionsArgumentsBuilder Self => this;

        public MetafieldDefinitionsArgumentsBuilder(IQuery<MetafieldDefinitionConnection> query) : base(query)
        {
        }

        public MetafieldDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder ConstraintStatus(MetafieldDefinitionConstraintStatus? constraintStatus)
        {
            base.InnerQuery.AddArgument("constraintStatus", constraintStatus);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder ConstraintSubtype(MetafieldDefinitionConstraintSubtypeIdentifier? constraintSubtype)
        {
            base.InnerQuery.AddArgument("constraintSubtype", constraintSubtype);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder OwnerType(MetafieldOwnerType? ownerType)
        {
            base.InnerQuery.AddArgument("ownerType", ownerType);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder PinnedStatus(MetafieldDefinitionPinnedStatus? pinnedStatus)
        {
            base.InnerQuery.AddArgument("pinnedStatus", pinnedStatus);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MetafieldDefinitionsArgumentsBuilder SortKey(MetafieldDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}