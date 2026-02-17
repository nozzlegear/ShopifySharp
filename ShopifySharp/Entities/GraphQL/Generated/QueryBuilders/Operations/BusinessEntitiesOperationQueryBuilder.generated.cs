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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class BusinessEntitiesOperationQueryBuilder : FieldsQueryBuilderBase<BusinessEntity, BusinessEntitiesOperationQueryBuilder>, IGraphOperationQueryBuilder<BusinessEntity>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override BusinessEntitiesOperationQueryBuilder Self => this;

        public BusinessEntitiesOperationQueryBuilder() : this("businessEntities")
        {
        }

        public BusinessEntitiesOperationQueryBuilder(string name) : base(new Query<BusinessEntity>(name))
        {
        }

        public BusinessEntitiesOperationQueryBuilder(IQuery<BusinessEntity> query) : base(query)
        {
        }

        public BusinessEntitiesOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityAddressQueryBuilder> build)
        {
            var query = new Query<BusinessEntityAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntityAddress>(query);
            return this;
        }

        public BusinessEntitiesOperationQueryBuilder Archived()
        {
            base.InnerQuery.AddField("archived");
            return this;
        }

        public BusinessEntitiesOperationQueryBuilder CompanyName()
        {
            base.InnerQuery.AddField("companyName");
            return this;
        }

        public BusinessEntitiesOperationQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public BusinessEntitiesOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BusinessEntitiesOperationQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public BusinessEntitiesOperationQueryBuilder ShopifyPaymentsAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAccount>("shopifyPaymentsAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAccount>(query);
            return this;
        }
    }
}