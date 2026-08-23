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
    public sealed class HasEventsQueryBuilder : FieldsQueryBuilderBase<IHasEvents, HasEventsQueryBuilder>
    {
        protected override HasEventsQueryBuilder Self => this;

        public HasEventsQueryBuilder() : this("hasEvents")
        {
        }

        public HasEventsQueryBuilder(string name) : base(new Query<IHasEvents>(name))
        {
        }

        public HasEventsQueryBuilder(IQuery<IHasEvents> query) : base(query)
        {
        }

        public HasEventsQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public HasEventsQueryBuilder OnArticle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("... on Article");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnBlog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("... on Blog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnCollection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("... on Collection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnComment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder> build)
        {
            var query = new Query<Comment>("... on Comment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnCompany(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("... on Company");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnCompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("... on CompanyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnCustomer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnDiscountAutomaticBxgy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBxgy>("... on DiscountAutomaticBxgy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnDiscountAutomaticNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("... on DiscountAutomaticNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnDiscountCodeNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("... on DiscountCodeNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder> build)
        {
            var query = new Query<DiscountNode>("... on DiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnDraftOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("... on DraftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnInventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("... on InventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("... on Order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnPage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("... on Page");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnPriceRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleQueryBuilder> build)
        {
            var query = new Query<PriceRule>("... on PriceRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnProduct(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("... on Product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder OnProductVariant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("... on ProductVariant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasEventsQueryBuilder HasEvents(Action<HasEventsInterfaceCasesBuilder> build)
        {
            var query = new Query<IHasEvents>("hasEvents");
            var unionBuilder = new HasEventsInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}