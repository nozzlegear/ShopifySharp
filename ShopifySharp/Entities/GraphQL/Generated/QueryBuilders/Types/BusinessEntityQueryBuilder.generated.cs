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
    public sealed class BusinessEntityQueryBuilder : FieldsQueryBuilderBase<BusinessEntity, BusinessEntityQueryBuilder>
    {
        protected override BusinessEntityQueryBuilder Self => this;

        public BusinessEntityQueryBuilder() : this("businessEntity")
        {
        }

        public BusinessEntityQueryBuilder(string name) : base(new Query<BusinessEntity>(name))
        {
        }

        public BusinessEntityQueryBuilder(IQuery<BusinessEntity> query) : base(query)
        {
        }

        public BusinessEntityQueryBuilder Address(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityAddressQueryBuilder> build)
        {
            var query = new Query<BusinessEntityAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntityAddress>(query);
            return this;
        }

        public BusinessEntityQueryBuilder Archived()
        {
            base.InnerQuery.AddField("archived");
            return this;
        }

        public BusinessEntityQueryBuilder CompanyName()
        {
            base.InnerQuery.AddField("companyName");
            return this;
        }

        public BusinessEntityQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public BusinessEntityQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BusinessEntityQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public BusinessEntityQueryBuilder ShopifyPaymentsAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAccount>("shopifyPaymentsAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAccount>(query);
            return this;
        }
    }
}