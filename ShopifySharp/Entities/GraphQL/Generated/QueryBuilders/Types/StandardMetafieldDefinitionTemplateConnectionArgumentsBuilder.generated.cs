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
    public sealed class StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder : ArgumentsBuilderBase<StandardMetafieldDefinitionTemplateConnection, StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder>
    {
        protected override StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder Self => this;

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder(IQuery<StandardMetafieldDefinitionTemplateConnection> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder ConstraintStatus(MetafieldDefinitionConstraintStatus? constraintStatus)
        {
            base.InnerQuery.AddArgument("constraintStatus", constraintStatus);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder ConstraintSubtype(MetafieldDefinitionConstraintSubtypeIdentifier? constraintSubtype)
        {
            base.InnerQuery.AddArgument("constraintSubtype", constraintSubtype);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder ExcludeActivated(bool? excludeActivated)
        {
            base.InnerQuery.AddArgument("excludeActivated", excludeActivated);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public StandardMetafieldDefinitionTemplateConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}