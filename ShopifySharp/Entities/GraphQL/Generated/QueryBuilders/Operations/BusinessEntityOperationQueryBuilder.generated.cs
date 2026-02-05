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
    public sealed class BusinessEntityOperationQueryBuilder : FieldsQueryBuilderBase<BusinessEntity, BusinessEntityOperationQueryBuilder>, IGraphOperationQueryBuilder<BusinessEntity>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public BusinessEntityArgumentsBuilder Arguments { get; }
        protected override BusinessEntityOperationQueryBuilder Self => this;

        public BusinessEntityOperationQueryBuilder() : this("businessEntity")
        {
        }

        public BusinessEntityOperationQueryBuilder(string name) : base(new Query<BusinessEntity>(name))
        {
            Arguments = new BusinessEntityArgumentsBuilder(base.InnerQuery);
        }

        public BusinessEntityOperationQueryBuilder(IQuery<BusinessEntity> query) : base(query)
        {
            Arguments = new BusinessEntityArgumentsBuilder(base.InnerQuery);
        }

        public BusinessEntityOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityAddressQueryBuilder> build)
        {
            var query = new Query<BusinessEntityAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessEntityAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntityAddress>(query);
            return this;
        }

        public BusinessEntityOperationQueryBuilder Archived()
        {
            base.InnerQuery.AddField("archived");
            return this;
        }

        public BusinessEntityOperationQueryBuilder CompanyName()
        {
            base.InnerQuery.AddField("companyName");
            return this;
        }

        public BusinessEntityOperationQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public BusinessEntityOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BusinessEntityOperationQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public BusinessEntityOperationQueryBuilder ShopifyPaymentsAccount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAccount>("shopifyPaymentsAccount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAccount>(query);
            return this;
        }
    }
}