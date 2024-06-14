﻿using System.Diagnostics.CodeAnalysis;
using Contentful.Core.Models;

namespace Dfe.ContentSupport.Web.Models;

[ExcludeFromCodeCoverage]
public class Target: Entry
{
    public Fields Fields { get; set; } = null!;
    public Sys Sys { get; set; } = null!;
    public string Title { get; set; } = null!;
    public Asset Asset { get; set; } = null!;
    public ContentType ContentType { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Meta { get; set; } = null!;
    public string ImageAlt { get; set; } = null!;
    public string Uri { get; set; } = null!;
    public Image Image { get; set; } = null!;
    public List<Target> Content { get; init; } = [];
}