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
    public sealed class DraftOrderWarningInterfaceCasesBuilder : InterfaceCasesBuilderBase<IDraftOrderWarning, DraftOrderWarningInterfaceCasesBuilder>
    {
        protected override DraftOrderWarningInterfaceCasesBuilder Self => this;

        public DraftOrderWarningInterfaceCasesBuilder(string fieldName = "draftOrderWarning") : this(new Query<IDraftOrderWarning>(fieldName))
        {
        }

        public DraftOrderWarningInterfaceCasesBuilder(IQuery<IDraftOrderWarning> query) : base(query)
        {
        }

        public DraftOrderWarningInterfaceCasesBuilder OnDraftOrderBundleAddedWarning(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderBundleAddedWarningQueryBuilder> build)
        {
            var query = new Query<DraftOrderBundleAddedWarning>("... on DraftOrderBundleAddedWarning");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderBundleAddedWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DraftOrderWarningInterfaceCasesBuilder OnDraftOrderDiscountNotAppliedWarning(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderDiscountNotAppliedWarningQueryBuilder> build)
        {
            var query = new Query<DraftOrderDiscountNotAppliedWarning>("... on DraftOrderDiscountNotAppliedWarning");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderDiscountNotAppliedWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DraftOrderWarningInterfaceCasesBuilder OnDraftOrderMarketRegionCountryCodeNotSupportedWarning(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder> build)
        {
            var query = new Query<DraftOrderMarketRegionCountryCodeNotSupportedWarning>("... on DraftOrderMarketRegionCountryCodeNotSupportedWarning");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderMarketRegionCountryCodeNotSupportedWarningQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}