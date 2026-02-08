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
    public sealed class PrivacySettingsQueryBuilder : FieldsQueryBuilderBase<PrivacySettings, PrivacySettingsQueryBuilder>
    {
        protected override PrivacySettingsQueryBuilder Self => this;

        public PrivacySettingsQueryBuilder() : this("privacySettings")
        {
        }

        public PrivacySettingsQueryBuilder(string name) : base(new Query<PrivacySettings>(name))
        {
        }

        public PrivacySettingsQueryBuilder(IQuery<PrivacySettings> query) : base(query)
        {
        }

        public PrivacySettingsQueryBuilder Banner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CookieBannerQueryBuilder> build)
        {
            var query = new Query<CookieBanner>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CookieBannerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CookieBanner>(query);
            return this;
        }

        public PrivacySettingsQueryBuilder DataSaleOptOutPage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutPageQueryBuilder> build)
        {
            var query = new Query<DataSaleOptOutPage>("dataSaleOptOutPage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutPageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DataSaleOptOutPage>(query);
            return this;
        }

        public PrivacySettingsQueryBuilder PrivacyPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyPolicyQueryBuilder> build)
        {
            var query = new Query<PrivacyPolicy>("privacyPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PrivacyPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PrivacyPolicy>(query);
            return this;
        }
    }
}