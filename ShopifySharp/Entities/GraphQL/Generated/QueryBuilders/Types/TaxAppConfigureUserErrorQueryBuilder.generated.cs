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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class TaxAppConfigureUserErrorQueryBuilder : FieldsQueryBuilderBase<TaxAppConfigureUserError, TaxAppConfigureUserErrorQueryBuilder>
    {
        protected override TaxAppConfigureUserErrorQueryBuilder Self => this;

        public TaxAppConfigureUserErrorQueryBuilder() : this("taxAppConfigureUserError")
        {
        }

        public TaxAppConfigureUserErrorQueryBuilder(string name) : base(new Query<TaxAppConfigureUserError>(name))
        {
        }

        public TaxAppConfigureUserErrorQueryBuilder(IQuery<TaxAppConfigureUserError> query) : base(query)
        {
        }

        public TaxAppConfigureUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public TaxAppConfigureUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public TaxAppConfigureUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}