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
    public sealed class DiscountCollectionsQueryBuilder : FieldsQueryBuilderBase<DiscountCollections, DiscountCollectionsQueryBuilder>
    {
        protected override DiscountCollectionsQueryBuilder Self => this;

        public DiscountCollectionsQueryBuilder() : this("discountCollections")
        {
        }

        public DiscountCollectionsQueryBuilder(string name) : base(new Query<DiscountCollections>(name))
        {
        }

        public DiscountCollectionsQueryBuilder(IQuery<DiscountCollections> query) : base(query)
        {
        }

        public DiscountCollectionsQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }
    }
}