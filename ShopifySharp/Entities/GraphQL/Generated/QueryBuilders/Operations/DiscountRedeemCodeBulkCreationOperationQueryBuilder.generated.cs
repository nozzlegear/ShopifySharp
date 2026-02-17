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
    public sealed class DiscountRedeemCodeBulkCreationOperationQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkCreation, DiscountRedeemCodeBulkCreationOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountRedeemCodeBulkCreation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DiscountRedeemCodeBulkCreationArgumentsBuilder Arguments { get; }
        protected override DiscountRedeemCodeBulkCreationOperationQueryBuilder Self => this;

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder() : this("discountRedeemCodeBulkCreation")
        {
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkCreation>(name))
        {
            Arguments = new DiscountRedeemCodeBulkCreationArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder(IQuery<DiscountRedeemCodeBulkCreation> query) : base(query)
        {
            Arguments = new DiscountRedeemCodeBulkCreationArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder Codes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCodeConnection>("codes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCodeConnection>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder CodesCount()
        {
            base.InnerQuery.AddField("codesCount");
            return this;
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder DiscountCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("discountCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder FailedCount()
        {
            base.InnerQuery.AddField("failedCount");
            return this;
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DiscountRedeemCodeBulkCreationOperationQueryBuilder ImportedCount()
        {
            base.InnerQuery.AddField("importedCount");
            return this;
        }
    }
}