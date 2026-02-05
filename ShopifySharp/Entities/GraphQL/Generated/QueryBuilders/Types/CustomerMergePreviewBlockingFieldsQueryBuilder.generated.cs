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
    public sealed class CustomerMergePreviewBlockingFieldsQueryBuilder : FieldsQueryBuilderBase<CustomerMergePreviewBlockingFields, CustomerMergePreviewBlockingFieldsQueryBuilder>
    {
        protected override CustomerMergePreviewBlockingFieldsQueryBuilder Self => this;

        public CustomerMergePreviewBlockingFieldsQueryBuilder() : this("customerMergePreviewBlockingFields")
        {
        }

        public CustomerMergePreviewBlockingFieldsQueryBuilder(string name) : base(new Query<CustomerMergePreviewBlockingFields>(name))
        {
        }

        public CustomerMergePreviewBlockingFieldsQueryBuilder(IQuery<CustomerMergePreviewBlockingFields> query) : base(query)
        {
        }

        public CustomerMergePreviewBlockingFieldsQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CustomerMergePreviewBlockingFieldsQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }
    }
}