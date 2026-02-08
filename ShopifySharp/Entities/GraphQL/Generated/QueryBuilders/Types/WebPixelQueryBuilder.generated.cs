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
    public sealed class WebPixelQueryBuilder : FieldsQueryBuilderBase<WebPixel, WebPixelQueryBuilder>
    {
        protected override WebPixelQueryBuilder Self => this;

        public WebPixelQueryBuilder() : this("webPixel")
        {
        }

        public WebPixelQueryBuilder(string name) : base(new Query<WebPixel>(name))
        {
        }

        public WebPixelQueryBuilder(IQuery<WebPixel> query) : base(query)
        {
        }

        public WebPixelQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public WebPixelQueryBuilder Settings()
        {
            base.InnerQuery.AddField("settings");
            return this;
        }
    }
}