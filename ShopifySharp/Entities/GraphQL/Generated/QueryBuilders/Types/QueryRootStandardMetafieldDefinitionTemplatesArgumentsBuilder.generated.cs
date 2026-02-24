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
    public sealed class QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder : ArgumentsBuilderBase<StandardMetafieldDefinitionTemplateConnection?, QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder>
    {
        protected override QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder Self => this;

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder(IQuery<StandardMetafieldDefinitionTemplateConnection?> query) : base(query)
        {
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder ConstraintStatus(MetafieldDefinitionConstraintStatus? constraintStatus)
        {
            base.InnerQuery.AddArgument("constraintStatus", constraintStatus);
            return this;
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder ConstraintSubtype(MetafieldDefinitionConstraintSubtypeIdentifier? constraintSubtype)
        {
            base.InnerQuery.AddArgument("constraintSubtype", constraintSubtype);
            return this;
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder ExcludeActivated(bool? excludeActivated)
        {
            base.InnerQuery.AddArgument("excludeActivated", excludeActivated);
            return this;
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootStandardMetafieldDefinitionTemplatesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}