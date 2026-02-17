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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class WebPixelOperationQueryBuilder : FieldsQueryBuilderBase<WebPixel, WebPixelOperationQueryBuilder>, IGraphOperationQueryBuilder<WebPixel>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public WebPixelArgumentsBuilder Arguments { get; }
        protected override WebPixelOperationQueryBuilder Self => this;

        public WebPixelOperationQueryBuilder() : this("webPixel")
        {
        }

        public WebPixelOperationQueryBuilder(string name) : base(new Query<WebPixel>(name))
        {
            Arguments = new WebPixelArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelOperationQueryBuilder(IQuery<WebPixel> query) : base(query)
        {
            Arguments = new WebPixelArgumentsBuilder(base.InnerQuery);
        }

        public WebPixelOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public WebPixelOperationQueryBuilder Settings()
        {
            base.InnerQuery.AddField("settings");
            return this;
        }
    }
}