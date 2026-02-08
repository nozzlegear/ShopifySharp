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
    public sealed class BusinessEntityArgumentsBuilder : ArgumentsBuilderBase<BusinessEntity, BusinessEntityArgumentsBuilder>
    {
        protected override BusinessEntityArgumentsBuilder Self => this;

        public BusinessEntityArgumentsBuilder(IQuery<BusinessEntity> query) : base(query)
        {
        }

        public BusinessEntityArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}