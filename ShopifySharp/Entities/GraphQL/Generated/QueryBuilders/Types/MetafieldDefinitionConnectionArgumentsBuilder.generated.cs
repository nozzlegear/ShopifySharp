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
    public sealed class MetafieldDefinitionConnectionArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionConnection, MetafieldDefinitionConnectionArgumentsBuilder>
    {
        protected override MetafieldDefinitionConnectionArgumentsBuilder Self => this;

        public MetafieldDefinitionConnectionArgumentsBuilder(IQuery<MetafieldDefinitionConnection> query) : base(query)
        {
        }

        public MetafieldDefinitionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder PinnedStatus(MetafieldDefinitionPinnedStatus? pinnedStatus)
        {
            base.InnerQuery.AddArgument("pinnedStatus", pinnedStatus);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder SortKey(MetafieldDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder ConstraintStatus(MetafieldDefinitionConstraintStatus? constraintStatus)
        {
            base.InnerQuery.AddArgument("constraintStatus", constraintStatus);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder ConstraintSubtype(MetafieldDefinitionConstraintSubtypeIdentifier? constraintSubtype)
        {
            base.InnerQuery.AddArgument("constraintSubtype", constraintSubtype);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public MetafieldDefinitionConnectionArgumentsBuilder OwnerType(MetafieldOwnerType? ownerType)
        {
            base.InnerQuery.AddArgument("ownerType", ownerType);
            return this;
        }
    }
}