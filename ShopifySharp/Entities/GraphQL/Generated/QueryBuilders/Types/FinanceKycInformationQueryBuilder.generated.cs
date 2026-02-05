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
    public sealed class FinanceKycInformationQueryBuilder : FieldsQueryBuilderBase<FinanceKycInformation, FinanceKycInformationQueryBuilder>
    {
        protected override FinanceKycInformationQueryBuilder Self => this;

        public FinanceKycInformationQueryBuilder() : this("financeKycInformation")
        {
        }

        public FinanceKycInformationQueryBuilder(string name) : base(new Query<FinanceKycInformation>(name))
        {
        }

        public FinanceKycInformationQueryBuilder(IQuery<FinanceKycInformation> query) : base(query)
        {
        }

        public FinanceKycInformationQueryBuilder BusinessAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAddressBasicQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAddressBasic>("businessAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAddressBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAddressBasic>(query);
            return this;
        }

        public FinanceKycInformationQueryBuilder BusinessType()
        {
            base.InnerQuery.AddField("businessType");
            return this;
        }

        public FinanceKycInformationQueryBuilder Industry(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsMerchantCategoryCodeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsMerchantCategoryCode>("industry");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsMerchantCategoryCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsMerchantCategoryCode>(query);
            return this;
        }

        public FinanceKycInformationQueryBuilder LegalName()
        {
            base.InnerQuery.AddField("legalName");
            return this;
        }

        public FinanceKycInformationQueryBuilder ShopOwner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialKycShopOwnerQueryBuilder> build)
        {
            var query = new Query<FinancialKycShopOwner>("shopOwner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialKycShopOwnerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FinancialKycShopOwner>(query);
            return this;
        }

        public FinanceKycInformationQueryBuilder TaxIdentification(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsTaxIdentificationQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsTaxIdentification>("taxIdentification");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsTaxIdentificationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsTaxIdentification>(query);
            return this;
        }
    }
}