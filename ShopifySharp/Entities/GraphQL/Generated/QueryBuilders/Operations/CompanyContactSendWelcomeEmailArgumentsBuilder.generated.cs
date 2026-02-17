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
    public sealed class CompanyContactSendWelcomeEmailArgumentsBuilder : ArgumentsBuilderBase<CompanyContactSendWelcomeEmailPayload, CompanyContactSendWelcomeEmailArgumentsBuilder>
    {
        protected override CompanyContactSendWelcomeEmailArgumentsBuilder Self => this;

        public CompanyContactSendWelcomeEmailArgumentsBuilder(IQuery<CompanyContactSendWelcomeEmailPayload> query) : base(query)
        {
        }

        public CompanyContactSendWelcomeEmailArgumentsBuilder CompanyContactId(string? companyContactId)
        {
            base.InnerQuery.AddArgument("companyContactId", companyContactId);
            return this;
        }

        public CompanyContactSendWelcomeEmailArgumentsBuilder Email(EmailInput? email)
        {
            base.InnerQuery.AddArgument("email", email);
            return this;
        }
    }
}