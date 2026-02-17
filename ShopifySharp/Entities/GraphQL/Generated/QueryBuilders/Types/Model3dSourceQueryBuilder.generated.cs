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
    public sealed class Model3dSourceQueryBuilder : FieldsQueryBuilderBase<Model3dSource, Model3dSourceQueryBuilder>
    {
        protected override Model3dSourceQueryBuilder Self => this;

        public Model3dSourceQueryBuilder() : this("model3dSource")
        {
        }

        public Model3dSourceQueryBuilder(string name) : base(new Query<Model3dSource>(name))
        {
        }

        public Model3dSourceQueryBuilder(IQuery<Model3dSource> query) : base(query)
        {
        }

        public Model3dSourceQueryBuilder Filesize()
        {
            base.InnerQuery.AddField("filesize");
            return this;
        }

        public Model3dSourceQueryBuilder Format()
        {
            base.InnerQuery.AddField("format");
            return this;
        }

        public Model3dSourceQueryBuilder MimeType()
        {
            base.InnerQuery.AddField("mimeType");
            return this;
        }

        public Model3dSourceQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}