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
    public sealed class CombinedListingQueryBuilder : FieldsQueryBuilderBase<CombinedListing, CombinedListingQueryBuilder>
    {
        protected override CombinedListingQueryBuilder Self => this;

        public CombinedListingQueryBuilder() : this("combinedListing")
        {
        }

        public CombinedListingQueryBuilder(string name) : base(new Query<CombinedListing>(name))
        {
        }

        public CombinedListingQueryBuilder(IQuery<CombinedListing> query) : base(query)
        {
        }

        public CombinedListingQueryBuilder CombinedListingChildren(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CombinedListingChildConnectionQueryBuilder> build)
        {
            var query = new Query<CombinedListingChildConnection>("combinedListingChildren");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CombinedListingChildConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListingChildConnection>(query);
            return this;
        }

        public CombinedListingQueryBuilder ParentProduct(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("parentProduct");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }
    }
}