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
    public sealed class MetaobjectByHandleArgumentsBuilder : ArgumentsBuilderBase<Metaobject, MetaobjectByHandleArgumentsBuilder>
    {
        protected override MetaobjectByHandleArgumentsBuilder Self => this;

        public MetaobjectByHandleArgumentsBuilder(IQuery<Metaobject> query) : base(query)
        {
        }

        public MetaobjectByHandleArgumentsBuilder Handle(MetaobjectHandleInput? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }
    }
}