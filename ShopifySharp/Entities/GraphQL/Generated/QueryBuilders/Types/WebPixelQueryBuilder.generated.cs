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
    public sealed class WebPixelQueryBuilder : FieldsQueryBuilderBase<WebPixel, WebPixelQueryBuilder>, IHasArguments<WebPixelArgumentsBuilder>
    {
        public WebPixelArgumentsBuilder Arguments { get; }
        protected override WebPixelQueryBuilder Self => this;

        public WebPixelQueryBuilder() : this("webPixel")
        {
        }

        public WebPixelQueryBuilder(string name) : base(new Query<WebPixel>(name))
        {
            Arguments = new WebPixelArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelQueryBuilder(IQuery<WebPixel> query) : base(query)
        {
            Arguments = new WebPixelArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelQueryBuilder SetArguments(Action<WebPixelArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
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