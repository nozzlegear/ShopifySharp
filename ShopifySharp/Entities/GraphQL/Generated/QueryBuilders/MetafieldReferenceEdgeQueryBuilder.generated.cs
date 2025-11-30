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

public class MetafieldReferenceEdgeQueryBuilder() : GraphQueryBuilder<MetafieldReferenceEdge>("metafieldReferenceEdge")
{
    public MetafieldReferenceEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddUnion<Collection, CollectionQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddUnion<Company, CompanyQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<GenericFileQueryBuilder, GenericFileQueryBuilder> build)
    {
        AddUnion<GenericFile, GenericFileQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<MediaImageQueryBuilder, MediaImageQueryBuilder> build)
    {
        AddUnion<MediaImage, MediaImageQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddUnion<Metaobject, MetaobjectQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<Model3dQueryBuilder, Model3dQueryBuilder> build)
    {
        AddUnion<Model3d, Model3dQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddUnion<Order, OrderQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddUnion<Page, PageQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddUnion<Product, ProductQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<TaxonomyValueQueryBuilder, TaxonomyValueQueryBuilder> build)
    {
        AddUnion<TaxonomyValue, TaxonomyValueQueryBuilder>("node", build);
        return this;
    }

    public MetafieldReferenceEdgeQueryBuilder AddUnionCaseNode(Func<VideoQueryBuilder, VideoQueryBuilder> build)
    {
        AddUnion<Video, VideoQueryBuilder>("node", build);
        return this;
    }
}