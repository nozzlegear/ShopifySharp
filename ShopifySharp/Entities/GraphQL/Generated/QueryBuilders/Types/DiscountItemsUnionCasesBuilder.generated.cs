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
    public sealed class DiscountItemsUnionCasesBuilder : UnionCasesBuilderBase<DiscountItems, DiscountItemsUnionCasesBuilder>
    {
        protected override DiscountItemsUnionCasesBuilder Self => this;

        public DiscountItemsUnionCasesBuilder(string fieldName = "discountItems") : this(new Query<DiscountItems>(fieldName))
        {
        }

        public DiscountItemsUnionCasesBuilder(IQuery<DiscountItems> query) : base(query)
        {
        }

        public DiscountItemsUnionCasesBuilder OnAllDiscountItems(Action<AllDiscountItemsQueryBuilder> build)
        {
            var query = new Query<AllDiscountItems>("... on AllDiscountItems");
            var queryBuilder = new AllDiscountItemsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountItemsUnionCasesBuilder OnDiscountCollections(Action<DiscountCollectionsQueryBuilder> build)
        {
            var query = new Query<DiscountCollections>("... on DiscountCollections");
            var queryBuilder = new DiscountCollectionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountItemsUnionCasesBuilder OnDiscountProducts(Action<DiscountProductsQueryBuilder> build)
        {
            var query = new Query<DiscountProducts>("... on DiscountProducts");
            var queryBuilder = new DiscountProductsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}