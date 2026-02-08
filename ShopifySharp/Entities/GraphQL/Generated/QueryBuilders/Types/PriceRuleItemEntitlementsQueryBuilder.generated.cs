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
    public sealed class PriceRuleItemEntitlementsQueryBuilder : FieldsQueryBuilderBase<PriceRuleItemEntitlements, PriceRuleItemEntitlementsQueryBuilder>
    {
        protected override PriceRuleItemEntitlementsQueryBuilder Self => this;

        public PriceRuleItemEntitlementsQueryBuilder() : this("priceRuleItemEntitlements")
        {
        }

        public PriceRuleItemEntitlementsQueryBuilder(string name) : base(new Query<PriceRuleItemEntitlements>(name))
        {
        }

        public PriceRuleItemEntitlementsQueryBuilder(IQuery<PriceRuleItemEntitlements> query) : base(query)
        {
        }

        public PriceRuleItemEntitlementsQueryBuilder Collections(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public PriceRuleItemEntitlementsQueryBuilder Products(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public PriceRuleItemEntitlementsQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public PriceRuleItemEntitlementsQueryBuilder TargetAllLineItems()
        {
            base.InnerQuery.AddField("targetAllLineItems");
            return this;
        }
    }
}