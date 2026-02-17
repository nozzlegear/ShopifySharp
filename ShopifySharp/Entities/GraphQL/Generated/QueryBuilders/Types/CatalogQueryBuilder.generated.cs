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
    public sealed class CatalogQueryBuilder : FieldsQueryBuilderBase<ICatalog, CatalogQueryBuilder>
    {
        protected override CatalogQueryBuilder Self => this;

        public CatalogQueryBuilder() : this("catalog")
        {
        }

        public CatalogQueryBuilder(string name) : base(new Query<ICatalog>(name))
        {
        }

        public CatalogQueryBuilder(IQuery<ICatalog> query) : base(query)
        {
        }

        public CatalogQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CatalogQueryBuilder Operations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourceOperationQueryBuilder> build)
        {
            var query = new Query<IResourceOperation>("operations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IResourceOperation>(query);
            return this;
        }

        public CatalogQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public CatalogQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public CatalogQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CatalogQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}