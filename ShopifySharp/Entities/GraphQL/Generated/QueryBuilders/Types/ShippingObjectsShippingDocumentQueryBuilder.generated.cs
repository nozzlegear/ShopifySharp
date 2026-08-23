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
    public sealed class ShippingObjectsShippingDocumentQueryBuilder : FieldsQueryBuilderBase<ShippingObjectsShippingDocument, ShippingObjectsShippingDocumentQueryBuilder>
    {
        protected override ShippingObjectsShippingDocumentQueryBuilder Self => this;

        public ShippingObjectsShippingDocumentQueryBuilder() : this("shippingObjectsShippingDocument")
        {
        }

        public ShippingObjectsShippingDocumentQueryBuilder(string name) : base(new Query<ShippingObjectsShippingDocument>(name))
        {
        }

        public ShippingObjectsShippingDocumentQueryBuilder(IQuery<ShippingObjectsShippingDocument> query) : base(query)
        {
        }

        public ShippingObjectsShippingDocumentQueryBuilder DocumentType()
        {
            base.InnerQuery.AddField("documentType");
            return this;
        }

        public ShippingObjectsShippingDocumentQueryBuilder Format()
        {
            base.InnerQuery.AddField("format");
            return this;
        }

        public ShippingObjectsShippingDocumentQueryBuilder PrintedAt()
        {
            base.InnerQuery.AddField("printedAt");
            return this;
        }

        public ShippingObjectsShippingDocumentQueryBuilder ShippingLabelId()
        {
            base.InnerQuery.AddField("shippingLabelId");
            return this;
        }

        public ShippingObjectsShippingDocumentQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}