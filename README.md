# HtmlToPdf.Renderer

A .NET library that converts HTML/CSS to PDF using [PdfSharp](https://github.com/empira/PDFsharp) and [HtmlRenderer](https://github.com/ArthurHub/HTML-Renderer).

```csharp
var pdf = PdfGenerator.GeneratePdf("<h1>Hello</h1><p>World</p>", new PdfGenerateConfig());
pdf.Save("output.pdf");
```

Licensed under MIT. HTML/CSS parsing by [HtmlRenderer](https://github.com/ArthurHub/HTML-Renderer) (BSD-3, see [NOTICE.txt](NOTICE.txt)).
