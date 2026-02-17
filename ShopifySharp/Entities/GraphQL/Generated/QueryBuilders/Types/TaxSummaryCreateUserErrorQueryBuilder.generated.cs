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
    public sealed class TaxSummaryCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<TaxSummaryCreateUserError, TaxSummaryCreateUserErrorQueryBuilder>
    {
        protected override TaxSummaryCreateUserErrorQueryBuilder Self => this;

        public TaxSummaryCreateUserErrorQueryBuilder() : this("taxSummaryCreateUserError")
        {
        }

        public TaxSummaryCreateUserErrorQueryBuilder(string name) : base(new Query<TaxSummaryCreateUserError>(name))
        {
        }

        public TaxSummaryCreateUserErrorQueryBuilder(IQuery<TaxSummaryCreateUserError> query) : base(query)
        {
        }

        public TaxSummaryCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public TaxSummaryCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public TaxSummaryCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}