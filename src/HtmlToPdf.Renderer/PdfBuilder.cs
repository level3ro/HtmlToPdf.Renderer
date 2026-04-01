using PdfSharp.Drawing;
using PdfSharp.Pdf;
using HtmlToPdf.Renderer.Adapters;

namespace HtmlToPdf.Renderer;

public sealed class PdfBuilder
{
    private readonly PdfOptions _options = new();

    internal PdfBuilder() { }

    public PdfBuilder WithPageSize(XSize pageSize)
    {
        _options.PageSize = pageSize;
        return this;
    }

    public PdfBuilder WithOrientation(PageOrientation orientation)
    {
        _options.PageOrientation = orientation;
        return this;
    }

    public PdfBuilder WithMargin(double all)
    {
        _options.SetMargins(all);
        return this;
    }

    public PdfBuilder WithMargin(double vertical, double horizontal)
    {
        _options.SetMargins(vertical, horizontal);
        return this;
    }

    public PdfBuilder WithMargin(double top, double right, double bottom, double left)
    {
        _options.MarginTop = top;
        _options.MarginRight = right;
        _options.MarginBottom = bottom;
        _options.MarginLeft = left;
        return this;
    }

    public PdfDocument GeneratePdf(string html)
    {
        return PdfGenerator.GeneratePdf(html, _options);
    }

    public Task<byte[]> GeneratePdfAsync(string html)
    {
        return PdfGenerator.GeneratePdfAsync(html, _options);
    }
}
