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
    public sealed class CustomerMergeErrorQueryBuilder : FieldsQueryBuilderBase<CustomerMergeError, CustomerMergeErrorQueryBuilder>
    {
        protected override CustomerMergeErrorQueryBuilder Self => this;

        public CustomerMergeErrorQueryBuilder() : this("customerMergeError")
        {
        }

        public CustomerMergeErrorQueryBuilder(string name) : base(new Query<CustomerMergeError>(name))
        {
        }

        public CustomerMergeErrorQueryBuilder(IQuery<CustomerMergeError> query) : base(query)
        {
        }

        public CustomerMergeErrorQueryBuilder ErrorFields()
        {
            base.InnerQuery.AddField("errorFields");
            return this;
        }

        public CustomerMergeErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}