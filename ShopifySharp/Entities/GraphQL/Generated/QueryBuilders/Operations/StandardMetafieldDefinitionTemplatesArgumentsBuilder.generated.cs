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
    public sealed class StandardMetafieldDefinitionTemplatesArgumentsBuilder : ArgumentsBuilderBase<StandardMetafieldDefinitionTemplateConnection, StandardMetafieldDefinitionTemplatesArgumentsBuilder>
    {
        protected override StandardMetafieldDefinitionTemplatesArgumentsBuilder Self => this;

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder(IQuery<StandardMetafieldDefinitionTemplateConnection> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder ConstraintStatus(MetafieldDefinitionConstraintStatus? constraintStatus)
        {
            base.InnerQuery.AddArgument("constraintStatus", constraintStatus);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder ConstraintSubtype(MetafieldDefinitionConstraintSubtypeIdentifier? constraintSubtype)
        {
            base.InnerQuery.AddArgument("constraintSubtype", constraintSubtype);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder ExcludeActivated(bool? excludeActivated)
        {
            base.InnerQuery.AddArgument("excludeActivated", excludeActivated);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public StandardMetafieldDefinitionTemplatesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}