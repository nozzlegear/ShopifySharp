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