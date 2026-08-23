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
    public sealed class DiscountCustomerSelectionUnionCasesBuilder : UnionCasesBuilderBase<DiscountCustomerSelection, DiscountCustomerSelectionUnionCasesBuilder>
    {
        protected override DiscountCustomerSelectionUnionCasesBuilder Self => this;

        public DiscountCustomerSelectionUnionCasesBuilder(string fieldName = "discountCustomerSelection") : this(new Query<DiscountCustomerSelection>(fieldName))
        {
        }

        public DiscountCustomerSelectionUnionCasesBuilder(IQuery<DiscountCustomerSelection> query) : base(query)
        {
        }

        public DiscountCustomerSelectionUnionCasesBuilder OnDiscountCustomerAll(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerAllQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerAll>("... on DiscountCustomerAll");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerAllQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerSelectionUnionCasesBuilder OnDiscountCustomerSegments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerSegmentsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerSegments>("... on DiscountCustomerSegments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerSegmentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerSelectionUnionCasesBuilder OnDiscountCustomerSelectionUnknown(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerSelectionUnknownQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerSelectionUnknown>("... on DiscountCustomerSelectionUnknown");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerSelectionUnknownQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerSelectionUnionCasesBuilder OnDiscountCustomers(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomersQueryBuilder> build)
        {
            var query = new Query<DiscountCustomers>("... on DiscountCustomers");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}