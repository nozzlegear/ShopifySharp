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
    public sealed class QueryRootCustomerMergePreviewQueryBuilder : FieldsQueryBuilderBase<CustomerMergePreview, QueryRootCustomerMergePreviewQueryBuilder>, IHasArguments<QueryRootCustomerMergePreviewArgumentsBuilder>
    {
        public QueryRootCustomerMergePreviewArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerMergePreviewQueryBuilder Self => this;

        public QueryRootCustomerMergePreviewQueryBuilder(string name) : base(new Query<CustomerMergePreview>(name))
        {
            Arguments = new QueryRootCustomerMergePreviewArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerMergePreviewQueryBuilder(IQuery<CustomerMergePreview> query) : base(query)
        {
            Arguments = new QueryRootCustomerMergePreviewArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerMergePreviewQueryBuilder SetArguments(Action<QueryRootCustomerMergePreviewArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerMergePreviewQueryBuilder AlternateFields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergePreviewAlternateFieldsQueryBuilder> build)
        {
            var query = new Query<CustomerMergePreviewAlternateFields>("alternateFields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergePreviewAlternateFieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergePreviewAlternateFields>(query);
            return this;
        }

        public QueryRootCustomerMergePreviewQueryBuilder BlockingFields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergePreviewBlockingFieldsQueryBuilder> build)
        {
            var query = new Query<CustomerMergePreviewBlockingFields>("blockingFields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergePreviewBlockingFieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergePreviewBlockingFields>(query);
            return this;
        }

        public QueryRootCustomerMergePreviewQueryBuilder CustomerMergeErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMergeError>("customerMergeErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergeErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergeError>(query);
            return this;
        }

        public QueryRootCustomerMergePreviewQueryBuilder DefaultFields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergePreviewDefaultFieldsQueryBuilder> build)
        {
            var query = new Query<CustomerMergePreviewDefaultFields>("defaultFields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMergePreviewDefaultFieldsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMergePreviewDefaultFields>(query);
            return this;
        }

        public QueryRootCustomerMergePreviewQueryBuilder ResultingCustomerId()
        {
            base.InnerQuery.AddField("resultingCustomerId");
            return this;
        }
    }
}