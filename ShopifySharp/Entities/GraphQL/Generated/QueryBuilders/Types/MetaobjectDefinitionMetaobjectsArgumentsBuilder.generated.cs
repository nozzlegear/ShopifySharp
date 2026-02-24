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
    public sealed class MetaobjectDefinitionMetaobjectsArgumentsBuilder : ArgumentsBuilderBase<MetaobjectConnection?, MetaobjectDefinitionMetaobjectsArgumentsBuilder>
    {
        protected override MetaobjectDefinitionMetaobjectsArgumentsBuilder Self => this;

        public MetaobjectDefinitionMetaobjectsArgumentsBuilder(IQuery<MetaobjectConnection?> query) : base(query)
        {
        }

        public MetaobjectDefinitionMetaobjectsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetaobjectDefinitionMetaobjectsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetaobjectDefinitionMetaobjectsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetaobjectDefinitionMetaobjectsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetaobjectDefinitionMetaobjectsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}