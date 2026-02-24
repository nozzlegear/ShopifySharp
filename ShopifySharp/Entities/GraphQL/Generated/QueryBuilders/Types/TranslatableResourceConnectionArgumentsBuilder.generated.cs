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
    public sealed class TranslatableResourceConnectionArgumentsBuilder : ArgumentsBuilderBase<TranslatableResourceConnection, TranslatableResourceConnectionArgumentsBuilder>
    {
        protected override TranslatableResourceConnectionArgumentsBuilder Self => this;

        public TranslatableResourceConnectionArgumentsBuilder(IQuery<TranslatableResourceConnection> query) : base(query)
        {
        }

        public TranslatableResourceConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TranslatableResourceConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TranslatableResourceConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TranslatableResourceConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public TranslatableResourceConnectionArgumentsBuilder ResourceType(TranslatableResourceType? resourceType)
        {
            base.InnerQuery.AddArgument("resourceType", resourceType);
            return this;
        }

        public TranslatableResourceConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public TranslatableResourceConnectionArgumentsBuilder ResourceIds(ICollection<string>? resourceIds)
        {
            base.InnerQuery.AddArgument("resourceIds", resourceIds);
            return this;
        }
    }
}