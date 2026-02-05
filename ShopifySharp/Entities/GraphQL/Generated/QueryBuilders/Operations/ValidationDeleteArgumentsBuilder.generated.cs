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
    public sealed class ValidationDeleteArgumentsBuilder : ArgumentsBuilderBase<ValidationDeletePayload, ValidationDeleteArgumentsBuilder>
    {
        protected override ValidationDeleteArgumentsBuilder Self => this;

        public ValidationDeleteArgumentsBuilder(IQuery<ValidationDeletePayload> query) : base(query)
        {
        }

        public ValidationDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}