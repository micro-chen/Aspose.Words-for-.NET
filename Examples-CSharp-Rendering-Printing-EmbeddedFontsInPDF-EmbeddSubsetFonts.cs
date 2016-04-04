// For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
// To subset fonts in the output PDF document, simply create new PdfSaveOptions and set EmbedFullFonts to false.
PdfSaveOptions options = new PdfSaveOptions();
options.EmbedFullFonts = false;
dataDir = dataDir + "Rendering.SubsetFonts_out_.pdf";
// The output PDF will contain subsets of the fonts in the document. Only the glyphs used
// in the document are included in the PDF fonts.
doc.Save(dataDir, options);
