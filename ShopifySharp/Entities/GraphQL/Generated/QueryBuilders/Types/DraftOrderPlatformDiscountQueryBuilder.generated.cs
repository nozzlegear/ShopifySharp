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
    public sealed class DraftOrderPlatformDiscountQueryBuilder : FieldsQueryBuilderBase<DraftOrderPlatformDiscount, DraftOrderPlatformDiscountQueryBuilder>
    {
        protected override DraftOrderPlatformDiscountQueryBuilder Self => this;

        public DraftOrderPlatformDiscountQueryBuilder() : this("draftOrderPlatformDiscount")
        {
        }

        public DraftOrderPlatformDiscountQueryBuilder(string name) : base(new Query<DraftOrderPlatformDiscount>(name))
        {
        }

        public DraftOrderPlatformDiscountQueryBuilder(IQuery<DraftOrderPlatformDiscount> query) : base(query)
        {
        }

        public DraftOrderPlatformDiscountQueryBuilder Allocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountAllocationQueryBuilder> build)
        {
            var query = new Query<DraftOrderPlatformDiscountAllocation>("allocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderPlatformDiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderPlatformDiscountAllocation>(query);
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder AutomaticDiscount()
        {
            base.InnerQuery.AddField("automaticDiscount");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder BxgyDiscount()
        {
            base.InnerQuery.AddField("bxgyDiscount");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DraftOrderPlatformDiscountQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder DiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder> build)
        {
            var query = new Query<DiscountNode>("discountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountNode>(query);
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder PresentationLevel()
        {
            base.InnerQuery.AddField("presentationLevel");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder ShortSummary()
        {
            base.InnerQuery.AddField("shortSummary");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder TotalAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DraftOrderPlatformDiscountQueryBuilder TotalAmountPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAmountPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}