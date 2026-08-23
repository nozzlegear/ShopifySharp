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
    public sealed class CheckoutAndAccountsConfigurationUpdateArgumentsBuilder : ArgumentsBuilderBase<CheckoutAndAccountsConfigurationUpdatePayload, CheckoutAndAccountsConfigurationUpdateArgumentsBuilder>
    {
        protected override CheckoutAndAccountsConfigurationUpdateArgumentsBuilder Self => this;

        public CheckoutAndAccountsConfigurationUpdateArgumentsBuilder(IQuery<CheckoutAndAccountsConfigurationUpdatePayload> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationUpdateArgumentsBuilder Configuration(CheckoutAndAccountsConfigurationInput? configuration)
        {
            base.InnerQuery.AddArgument("configuration", configuration);
            return this;
        }

        public CheckoutAndAccountsConfigurationUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}