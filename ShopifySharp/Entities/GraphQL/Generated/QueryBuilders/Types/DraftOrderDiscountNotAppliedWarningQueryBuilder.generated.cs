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
    public sealed class DraftOrderDiscountNotAppliedWarningQueryBuilder : FieldsQueryBuilderBase<DraftOrderDiscountNotAppliedWarning, DraftOrderDiscountNotAppliedWarningQueryBuilder>
    {
        protected override DraftOrderDiscountNotAppliedWarningQueryBuilder Self => this;

        public DraftOrderDiscountNotAppliedWarningQueryBuilder() : this("draftOrderDiscountNotAppliedWarning")
        {
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder(string name) : base(new Query<DraftOrderDiscountNotAppliedWarning>(name))
        {
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder(IQuery<DraftOrderDiscountNotAppliedWarning> query) : base(query)
        {
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder DiscountCode()
        {
            base.InnerQuery.AddField("discountCode");
            return this;
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder DiscountTitle()
        {
            base.InnerQuery.AddField("discountTitle");
            return this;
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public DraftOrderDiscountNotAppliedWarningQueryBuilder PriceRule(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleQueryBuilder> build)
        {
            var query = new Query<PriceRule>("priceRule");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRule>(query);
            return this;
        }
    }
}