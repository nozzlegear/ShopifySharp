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
    public sealed class DiscountCustomerSelectionUnionCasesBuilder : UnionCasesBuilderBase<DiscountCustomerSelection, DiscountCustomerSelectionUnionCasesBuilder>
    {
        protected override DiscountCustomerSelectionUnionCasesBuilder Self => this;

        public DiscountCustomerSelectionUnionCasesBuilder(string fieldName = "discountCustomerSelection") : this(new Query<DiscountCustomerSelection>(fieldName))
        {
        }

        public DiscountCustomerSelectionUnionCasesBuilder(IQuery<DiscountCustomerSelection> query) : base(query)
        {
        }

        public DiscountCustomerSelectionUnionCasesBuilder OnDiscountCustomerAll(Action<DiscountCustomerAllQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerAll>("... on DiscountCustomerAll");
            var queryBuilder = new DiscountCustomerAllQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerSelectionUnionCasesBuilder OnDiscountCustomerSegments(Action<DiscountCustomerSegmentsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerSegments>("... on DiscountCustomerSegments");
            var queryBuilder = new DiscountCustomerSegmentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerSelectionUnionCasesBuilder OnDiscountCustomers(Action<DiscountCustomersQueryBuilder> build)
        {
            var query = new Query<DiscountCustomers>("... on DiscountCustomers");
            var queryBuilder = new DiscountCustomersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}