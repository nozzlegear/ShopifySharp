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
    public sealed class PrivacySettingsOperationQueryBuilder : FieldsQueryBuilderBase<PrivacySettings, PrivacySettingsOperationQueryBuilder>, IGraphOperationQueryBuilder<PrivacySettings>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override PrivacySettingsOperationQueryBuilder Self => this;

        public PrivacySettingsOperationQueryBuilder() : this("privacySettings")
        {
        }

        public PrivacySettingsOperationQueryBuilder(string name) : base(new Query<PrivacySettings>(name))
        {
        }

        public PrivacySettingsOperationQueryBuilder(IQuery<PrivacySettings> query) : base(query)
        {
        }

        public PrivacySettingsOperationQueryBuilder Banner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CookieBannerQueryBuilder> build)
        {
            var query = new Query<CookieBanner>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CookieBannerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CookieBanner>(query);
            return this;
        }

        public PrivacySettingsOperationQueryBuilder DataSaleOptOutPage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutPageQueryBuilder> build)
        {
            var query = new Query<DataSaleOptOutPage>("dataSaleOptOutPage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DataSaleOptOutPage>(query);
            return this;
        }

        public PrivacySettingsOperationQueryBuilder PrivacyPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyPolicyQueryBuilder> build)
        {
            var query = new Query<PrivacyPolicy>("privacyPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PrivacyPolicy>(query);
            return this;
        }
    }
}