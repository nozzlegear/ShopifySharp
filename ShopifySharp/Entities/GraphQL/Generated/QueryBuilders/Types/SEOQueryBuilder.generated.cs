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
    public sealed class SEOQueryBuilder : FieldsQueryBuilderBase<SEO, SEOQueryBuilder>
    {
        protected override SEOQueryBuilder Self => this;

        public SEOQueryBuilder() : this("sEO")
        {
        }

        public SEOQueryBuilder(string name) : base(new Query<SEO>(name))
        {
        }

        public SEOQueryBuilder(IQuery<SEO> query) : base(query)
        {
        }

        public SEOQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SEOQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}