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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class FinanceKycInformationOperationQueryBuilder : FieldsQueryBuilderBase<FinanceKycInformation, FinanceKycInformationOperationQueryBuilder>, IGraphOperationQueryBuilder<FinanceKycInformation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override FinanceKycInformationOperationQueryBuilder Self => this;

        public FinanceKycInformationOperationQueryBuilder() : this("financeKycInformation")
        {
        }

        public FinanceKycInformationOperationQueryBuilder(string name) : base(new Query<FinanceKycInformation>(name))
        {
        }

        public FinanceKycInformationOperationQueryBuilder(IQuery<FinanceKycInformation> query) : base(query)
        {
        }

        public FinanceKycInformationOperationQueryBuilder BusinessAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAddressBasicQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAddressBasic>("businessAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAddressBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAddressBasic>(query);
            return this;
        }

        public FinanceKycInformationOperationQueryBuilder BusinessType()
        {
            base.InnerQuery.AddField("businessType");
            return this;
        }

        public FinanceKycInformationOperationQueryBuilder Industry(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsMerchantCategoryCodeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsMerchantCategoryCode>("industry");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsMerchantCategoryCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsMerchantCategoryCode>(query);
            return this;
        }

        public FinanceKycInformationOperationQueryBuilder LegalName()
        {
            base.InnerQuery.AddField("legalName");
            return this;
        }

        public FinanceKycInformationOperationQueryBuilder ShopOwner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialKycShopOwnerQueryBuilder> build)
        {
            var query = new Query<FinancialKycShopOwner>("shopOwner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialKycShopOwnerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FinancialKycShopOwner>(query);
            return this;
        }

        public FinanceKycInformationOperationQueryBuilder TaxIdentification(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsTaxIdentificationQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsTaxIdentification>("taxIdentification");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsTaxIdentificationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsTaxIdentification>(query);
            return this;
        }
    }
}