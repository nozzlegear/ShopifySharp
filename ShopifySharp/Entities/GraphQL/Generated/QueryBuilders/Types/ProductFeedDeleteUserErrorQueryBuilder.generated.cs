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
    public sealed class ProductFeedDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<ProductFeedDeleteUserError, ProductFeedDeleteUserErrorQueryBuilder>
    {
        protected override ProductFeedDeleteUserErrorQueryBuilder Self => this;

        public ProductFeedDeleteUserErrorQueryBuilder() : this("productFeedDeleteUserError")
        {
        }

        public ProductFeedDeleteUserErrorQueryBuilder(string name) : base(new Query<ProductFeedDeleteUserError>(name))
        {
        }

        public ProductFeedDeleteUserErrorQueryBuilder(IQuery<ProductFeedDeleteUserError> query) : base(query)
        {
        }

        public ProductFeedDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ProductFeedDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ProductFeedDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}