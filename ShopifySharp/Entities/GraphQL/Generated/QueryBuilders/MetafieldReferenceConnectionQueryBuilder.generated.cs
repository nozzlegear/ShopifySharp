#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class MetafieldReferenceConnectionQueryBuilder() : GraphQueryBuilder<MetafieldReferenceConnection>("metafieldReferenceConnection")
{
    public MetafieldReferenceConnectionQueryBuilder AddFieldEdges(Func<MetafieldReferenceEdgeQueryBuilder, MetafieldReferenceEdgeQueryBuilder> build)
    {
        AddField<MetafieldReferenceEdge, MetafieldReferenceEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddUnion<Collection, CollectionQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddUnion<Company, CompanyQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<GenericFileQueryBuilder, GenericFileQueryBuilder> build)
    {
        AddUnion<GenericFile, GenericFileQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<MediaImageQueryBuilder, MediaImageQueryBuilder> build)
    {
        AddUnion<MediaImage, MediaImageQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddUnion<Metaobject, MetaobjectQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<Model3dQueryBuilder, Model3dQueryBuilder> build)
    {
        AddUnion<Model3d, Model3dQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddUnion<Order, OrderQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddUnion<Page, PageQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddUnion<Product, ProductQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<TaxonomyValueQueryBuilder, TaxonomyValueQueryBuilder> build)
    {
        AddUnion<TaxonomyValue, TaxonomyValueQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddUnionCaseNodes(Func<VideoQueryBuilder, VideoQueryBuilder> build)
    {
        AddUnion<Video, VideoQueryBuilder>("nodes", build);
        return this;
    }

    public MetafieldReferenceConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}