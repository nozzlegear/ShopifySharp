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
    public sealed class DraftOrderInvoicePreviewOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderInvoicePreviewPayload, DraftOrderInvoicePreviewOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderInvoicePreviewPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DraftOrderInvoicePreviewArgumentsBuilder Arguments { get; }
        protected override DraftOrderInvoicePreviewOperationQueryBuilder Self => this;

        public DraftOrderInvoicePreviewOperationQueryBuilder() : this("draftOrderInvoicePreview")
        {
        }

        public DraftOrderInvoicePreviewOperationQueryBuilder(string name) : base(new Query<DraftOrderInvoicePreviewPayload>(name))
        {
            Arguments = new DraftOrderInvoicePreviewArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderInvoicePreviewOperationQueryBuilder(IQuery<DraftOrderInvoicePreviewPayload> query) : base(query)
        {
            Arguments = new DraftOrderInvoicePreviewArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrderInvoicePreviewOperationQueryBuilder PreviewHtml()
        {
            base.InnerQuery.AddField("previewHtml");
            return this;
        }

        public DraftOrderInvoicePreviewOperationQueryBuilder PreviewSubject()
        {
            base.InnerQuery.AddField("previewSubject");
            return this;
        }

        public DraftOrderInvoicePreviewOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}