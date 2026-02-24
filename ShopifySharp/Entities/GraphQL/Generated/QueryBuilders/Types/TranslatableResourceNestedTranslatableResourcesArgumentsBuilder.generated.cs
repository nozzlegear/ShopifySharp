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
    public sealed class TranslatableResourceNestedTranslatableResourcesArgumentsBuilder : ArgumentsBuilderBase<TranslatableResourceConnection?, TranslatableResourceNestedTranslatableResourcesArgumentsBuilder>
    {
        protected override TranslatableResourceNestedTranslatableResourcesArgumentsBuilder Self => this;

        public TranslatableResourceNestedTranslatableResourcesArgumentsBuilder(IQuery<TranslatableResourceConnection?> query) : base(query)
        {
        }

        public TranslatableResourceNestedTranslatableResourcesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TranslatableResourceNestedTranslatableResourcesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TranslatableResourceNestedTranslatableResourcesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TranslatableResourceNestedTranslatableResourcesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public TranslatableResourceNestedTranslatableResourcesArgumentsBuilder ResourceType(TranslatableResourceType? resourceType)
        {
            base.InnerQuery.AddArgument("resourceType", resourceType);
            return this;
        }

        public TranslatableResourceNestedTranslatableResourcesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}