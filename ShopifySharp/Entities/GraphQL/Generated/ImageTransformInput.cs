#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The available options for transforming an image.
/// All transformation options are considered best effort. Any transformation that
/// the original image type doesn't support will be ignored.
/// </summary>
public record ImageTransformInput : GraphQLInputObject<ImageTransformInput>
{
    /// <summary>
    /// The region of the image to remain after cropping.
    /// Must be used in conjunction with the `maxWidth` and/or `maxHeight` fields,
    /// where the `maxWidth` and `maxHeight` aren't equal.
    /// The `crop` argument should coincide with the smaller value. A smaller `maxWidth` indicates a `LEFT` or `RIGHT` crop, while
    /// a smaller `maxHeight` indicates a `TOP` or `BOTTOM` crop. For example, `{
    /// maxWidth: 5, maxHeight: 10, crop: LEFT }` will result
    /// in an image with a width of 5 and height of 10, where the right side of the image is removed.
    /// </summary>
    [JsonPropertyName("crop")]
    public CropRegion? crop { get; set; } = null;

    /// <summary>
    /// Image height in pixels between 1 and 5760.
    /// </summary>
    [JsonPropertyName("maxHeight")]
    public int? maxHeight { get; set; } = null;

    /// <summary>
    /// Image width in pixels between 1 and 5760.
    /// </summary>
    [JsonPropertyName("maxWidth")]
    public int? maxWidth { get; set; } = null;

    /// <summary>
    /// Convert the source image into the preferred content type.
    /// Supported conversions: `.svg` to `.png`, any file type to `.jpg`, and any file type to `.webp`.
    /// </summary>
    [JsonPropertyName("preferredContentType")]
    public ImageContentType? preferredContentType { get; set; } = null;

    /// <summary>
    /// Image size multiplier for high-resolution retina displays. Must be within 1..3.
    /// </summary>
    [JsonPropertyName("scale")]
    public int? scale { get; set; } = null;
}