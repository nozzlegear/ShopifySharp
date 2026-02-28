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
    public sealed class DiscountAutomaticBxgyQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticBxgy, DiscountAutomaticBxgyQueryBuilder>
    {
        protected override DiscountAutomaticBxgyQueryBuilder Self => this;

        public DiscountAutomaticBxgyQueryBuilder() : this("discountAutomaticBxgy")
        {
        }

        public DiscountAutomaticBxgyQueryBuilder(string name) : base(new Query<DiscountAutomaticBxgy>(name))
        {
        }

        public DiscountAutomaticBxgyQueryBuilder(IQuery<DiscountAutomaticBxgy> query) : base(query)
        {
        }

        public DiscountAutomaticBxgyQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder CustomerBuys(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerBuysQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerBuys>("customerBuys");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerBuysQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCustomerBuys>(query);
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder CustomerGets(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerGets>("customerGets");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCustomerGets>(query);
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountAutomaticBxgyQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        [Obsolete("Use DiscountAutomaticNode.id instead.")]
        public DiscountAutomaticBxgyQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        [Obsolete("Use `asyncUsageCount` instead.")]
        public DiscountAutomaticBxgyQueryBuilder UsageCount()
        {
            base.InnerQuery.AddField("usageCount");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder UsesPerOrderLimit()
        {
            base.InnerQuery.AddField("usesPerOrderLimit");
            return this;
        }

        public DiscountAutomaticBxgyQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}