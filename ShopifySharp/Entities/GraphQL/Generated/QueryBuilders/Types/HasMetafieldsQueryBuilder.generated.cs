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
    public sealed class HasMetafieldsQueryBuilder : FieldsQueryBuilderBase<IHasMetafields, HasMetafieldsQueryBuilder>
    {
        protected override HasMetafieldsQueryBuilder Self => this;

        public HasMetafieldsQueryBuilder() : this("hasMetafields")
        {
        }

        public HasMetafieldsQueryBuilder(string name) : base(new Query<IHasMetafields>(name))
        {
        }

        public HasMetafieldsQueryBuilder(IQuery<IHasMetafields> query) : base(query)
        {
        }

        public HasMetafieldsQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public HasMetafieldsQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnAppInstallation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder> build)
        {
            var query = new Query<AppInstallation>("... on AppInstallation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppInstallationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnArticle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("... on Article");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnBlog(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("... on Blog");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnCartTransform(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformQueryBuilder> build)
        {
            var query = new Query<CartTransform>("... on CartTransform");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnCollection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("... on Collection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnCompany(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("... on Company");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnCompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("... on CompanyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnCustomer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnCustomerSegmentMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMemberQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMember>("... on CustomerSegmentMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnDeliveryCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("... on DeliveryCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnDiscountAutomaticNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("... on DiscountAutomaticNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnDiscountCodeNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("... on DiscountCodeNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder> build)
        {
            var query = new Query<DiscountNode>("... on DiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnDraftOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("... on DraftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnFulfillmentConstraintRule(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder> build)
        {
            var query = new Query<FulfillmentConstraintRule>("... on FulfillmentConstraintRule");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConstraintRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnGiftCardCashOutTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCashOutTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardCashOutTransaction>("... on GiftCardCashOutTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCashOutTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnGiftCardCreditTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardCreditTransaction>("... on GiftCardCreditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnGiftCardDebitTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardDebitTransaction>("... on GiftCardDebitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("... on Image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnInventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("... on InventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("... on Location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnMarket(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("... on Market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnMediaImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder> build)
        {
            var query = new Query<MediaImage>("... on MediaImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("... on Order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnPage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("... on Page");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnPaymentCustomization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("... on PaymentCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnProduct(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("... on Product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnProductVariant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("... on ProductVariant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnSellingPlan(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder> build)
        {
            var query = new Query<SellingPlan>("... on SellingPlan");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnShop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("... on Shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder OnValidation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("... on Validation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public HasMetafieldsQueryBuilder HasMetafields(Action<HasMetafieldsInterfaceCasesBuilder> build)
        {
            var query = new Query<IHasMetafields>("hasMetafields");
            var unionBuilder = new HasMetafieldsInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}