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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class TranslatableResourcesArgumentsBuilder : ArgumentsBuilderBase<TranslatableResourceConnection, TranslatableResourcesArgumentsBuilder>
    {
        protected override TranslatableResourcesArgumentsBuilder Self => this;

        public TranslatableResourcesArgumentsBuilder(IQuery<TranslatableResourceConnection> query) : base(query)
        {
        }

        public TranslatableResourcesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TranslatableResourcesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TranslatableResourcesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TranslatableResourcesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public TranslatableResourcesArgumentsBuilder ResourceType(TranslatableResourceType? resourceType)
        {
            base.InnerQuery.AddArgument("resourceType", resourceType);
            return this;
        }

        public TranslatableResourcesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}