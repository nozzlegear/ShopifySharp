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
    public sealed class ImageArgumentsBuilder : ArgumentsBuilderBase<Image, ImageArgumentsBuilder>
    {
        protected override ImageArgumentsBuilder Self => this;

        public ImageArgumentsBuilder(IQuery<Image> query) : base(query)
        {
        }

        public ImageArgumentsBuilder Fallback(StaffMemberDefaultImage? fallback)
        {
            base.InnerQuery.AddArgument("fallback", fallback);
            return this;
        }
    }
}