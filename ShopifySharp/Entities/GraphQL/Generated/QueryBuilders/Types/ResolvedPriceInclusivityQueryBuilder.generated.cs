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
    public sealed class ResolvedPriceInclusivityQueryBuilder : FieldsQueryBuilderBase<ResolvedPriceInclusivity, ResolvedPriceInclusivityQueryBuilder>
    {
        protected override ResolvedPriceInclusivityQueryBuilder Self => this;

        public ResolvedPriceInclusivityQueryBuilder() : this("resolvedPriceInclusivity")
        {
        }

        public ResolvedPriceInclusivityQueryBuilder(string name) : base(new Query<ResolvedPriceInclusivity>(name))
        {
        }

        public ResolvedPriceInclusivityQueryBuilder(IQuery<ResolvedPriceInclusivity> query) : base(query)
        {
        }

        public ResolvedPriceInclusivityQueryBuilder DutiesIncluded()
        {
            base.InnerQuery.AddField("dutiesIncluded");
            return this;
        }

        public ResolvedPriceInclusivityQueryBuilder TaxesIncluded()
        {
            base.InnerQuery.AddField("taxesIncluded");
            return this;
        }
    }
}