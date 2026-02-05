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
    public sealed class CustomerMergePreviewQueryBuilder : FieldsQueryBuilderBase<CustomerMergePreview, CustomerMergePreviewQueryBuilder>
    {
        protected override CustomerMergePreviewQueryBuilder Self => this;

        public CustomerMergePreviewQueryBuilder() : this("customerMergePreview")
        {
        }

        public CustomerMergePreviewQueryBuilder(string name) : base(new Query<CustomerMergePreview>(name))
        {
        }

        public CustomerMergePreviewQueryBuilder(IQuery<CustomerMergePreview> query) : base(query)
        {
        }

        public CustomerMergePreviewQueryBuilder AlternateFields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewAlternateFieldsQueryBuilder> build)
        {
            var query = new Query<CustomerMergePreviewAlternateFields>("alternateFields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewAlternateFieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergePreviewAlternateFields>(query);
            return this;
        }

        public CustomerMergePreviewQueryBuilder BlockingFields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewBlockingFieldsQueryBuilder> build)
        {
            var query = new Query<CustomerMergePreviewBlockingFields>("blockingFields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewBlockingFieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergePreviewBlockingFields>(query);
            return this;
        }

        public CustomerMergePreviewQueryBuilder CustomerMergeErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMergeError>("customerMergeErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergeErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeError>(query);
            return this;
        }

        public CustomerMergePreviewQueryBuilder DefaultFields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewDefaultFieldsQueryBuilder> build)
        {
            var query = new Query<CustomerMergePreviewDefaultFields>("defaultFields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMergePreviewDefaultFieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergePreviewDefaultFields>(query);
            return this;
        }

        public CustomerMergePreviewQueryBuilder ResultingCustomerId()
        {
            base.InnerQuery.AddField("resultingCustomerId");
            return this;
        }
    }
}