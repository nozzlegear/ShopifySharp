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
    public sealed class DraftOrderWarningQueryBuilder : FieldsQueryBuilderBase<IDraftOrderWarning, DraftOrderWarningQueryBuilder>
    {
        protected override DraftOrderWarningQueryBuilder Self => this;

        public DraftOrderWarningQueryBuilder() : this("draftOrderWarning")
        {
        }

        public DraftOrderWarningQueryBuilder(string name) : base(new Query<IDraftOrderWarning>(name))
        {
        }

        public DraftOrderWarningQueryBuilder(IQuery<IDraftOrderWarning> query) : base(query)
        {
        }

        public DraftOrderWarningQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public DraftOrderWarningQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DraftOrderWarningQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public DraftOrderWarningQueryBuilder OnDraftOrderBundleAddedWarning(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderBundleAddedWarningQueryBuilder> build)
        {
            var query = new Query<DraftOrderBundleAddedWarning>("... on DraftOrderBundleAddedWarning");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderBundleAddedWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DraftOrderWarningQueryBuilder OnDraftOrderDiscountNotAppliedWarning(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderDiscountNotAppliedWarningQueryBuilder> build)
        {
            var query = new Query<DraftOrderDiscountNotAppliedWarning>("... on DraftOrderDiscountNotAppliedWarning");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderDiscountNotAppliedWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DraftOrderWarningQueryBuilder OnDraftOrderMarketRegionCountryCodeNotSupportedWarning(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder> build)
        {
            var query = new Query<DraftOrderMarketRegionCountryCodeNotSupportedWarning>("... on DraftOrderMarketRegionCountryCodeNotSupportedWarning");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DraftOrderWarningQueryBuilder DraftOrderWarning(Action<DraftOrderWarningInterfaceCasesBuilder> build)
        {
            var query = new Query<IDraftOrderWarning>("draftOrderWarning");
            var unionBuilder = new DraftOrderWarningInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}