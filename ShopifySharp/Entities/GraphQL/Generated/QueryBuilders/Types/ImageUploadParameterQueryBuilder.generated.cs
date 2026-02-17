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
    public sealed class ImageUploadParameterQueryBuilder : FieldsQueryBuilderBase<ImageUploadParameter, ImageUploadParameterQueryBuilder>
    {
        protected override ImageUploadParameterQueryBuilder Self => this;

        public ImageUploadParameterQueryBuilder() : this("imageUploadParameter")
        {
        }

        public ImageUploadParameterQueryBuilder(string name) : base(new Query<ImageUploadParameter>(name))
        {
        }

        public ImageUploadParameterQueryBuilder(IQuery<ImageUploadParameter> query) : base(query)
        {
        }

        public ImageUploadParameterQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ImageUploadParameterQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}