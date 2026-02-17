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