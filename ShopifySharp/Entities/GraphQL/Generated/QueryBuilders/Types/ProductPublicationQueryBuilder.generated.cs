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
    public sealed class ProductPublicationQueryBuilder : FieldsQueryBuilderBase<ProductPublication, ProductPublicationQueryBuilder>
    {
        protected override ProductPublicationQueryBuilder Self => this;

        public ProductPublicationQueryBuilder() : this("productPublication")
        {
        }

        public ProductPublicationQueryBuilder(string name) : base(new Query<ProductPublication>(name))
        {
        }

        public ProductPublicationQueryBuilder(IQuery<ProductPublication> query) : base(query)
        {
        }

        public ProductPublicationQueryBuilder Channel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public ProductPublicationQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public ProductPublicationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductPublicationQueryBuilder PublishDate()
        {
            base.InnerQuery.AddField("publishDate");
            return this;
        }
    }
}