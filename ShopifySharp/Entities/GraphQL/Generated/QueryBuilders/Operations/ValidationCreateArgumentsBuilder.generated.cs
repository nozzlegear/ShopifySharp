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
    public sealed class ValidationCreateArgumentsBuilder : ArgumentsBuilderBase<ValidationCreatePayload, ValidationCreateArgumentsBuilder>
    {
        protected override ValidationCreateArgumentsBuilder Self => this;

        public ValidationCreateArgumentsBuilder(IQuery<ValidationCreatePayload> query) : base(query)
        {
        }

        public ValidationCreateArgumentsBuilder Validation(ValidationCreateInput? validation)
        {
            base.InnerQuery.AddArgument("validation", validation);
            return this;
        }
    }
}