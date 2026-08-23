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
    public sealed class PriceRuleLineItemPrerequisitesQueryBuilder : FieldsQueryBuilderBase<PriceRuleLineItemPrerequisites, PriceRuleLineItemPrerequisitesQueryBuilder>
    {
        protected override PriceRuleLineItemPrerequisitesQueryBuilder Self => this;

        public PriceRuleLineItemPrerequisitesQueryBuilder() : this("priceRuleLineItemPrerequisites")
        {
        }

        public PriceRuleLineItemPrerequisitesQueryBuilder(string name) : base(new Query<PriceRuleLineItemPrerequisites>(name))
        {
        }

        public PriceRuleLineItemPrerequisitesQueryBuilder(IQuery<PriceRuleLineItemPrerequisites> query) : base(query)
        {
        }

        public PriceRuleLineItemPrerequisitesQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public PriceRuleLineItemPrerequisitesQueryBuilder Products(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public PriceRuleLineItemPrerequisitesQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }
    }
}