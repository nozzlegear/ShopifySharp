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
    public sealed class CatalogOperationQueryBuilder : FieldsQueryBuilderBase<ICatalog, CatalogOperationQueryBuilder>, IGraphOperationQueryBuilder<ICatalog>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CatalogArgumentsBuilder Arguments { get; }
        protected override CatalogOperationQueryBuilder Self => this;

        public CatalogOperationQueryBuilder() : this("catalog")
        {
        }

        public CatalogOperationQueryBuilder(string name) : base(new Query<ICatalog>(name))
        {
            Arguments = new CatalogArgumentsBuilder(base.InnerQuery);
        }

        public CatalogOperationQueryBuilder(IQuery<ICatalog> query) : base(query)
        {
            Arguments = new CatalogArgumentsBuilder(base.InnerQuery);
        }

        public CatalogOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CatalogOperationQueryBuilder Operations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourceOperationQueryBuilder> build)
        {
            var query = new Query<IResourceOperation>("operations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IResourceOperation>(query);
            return this;
        }

        public CatalogOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public CatalogOperationQueryBuilder Publication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder> build)
        {
            var query = new Query<Publication>("publication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Publication>(query);
            return this;
        }

        public CatalogOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CatalogOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}