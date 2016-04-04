// For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
// The path to the documents directory.
string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

// Create a simple document from scratch.
Document doc = new Document();
DocumentBuilder builder = new DocumentBuilder(doc);
builder.Writeln("Test Signed PDF.");

// Load the certificate from disk.
// The other constructor overloads can be used to load certificates from different locations.
X509Certificate2 cert = new X509Certificate2(
    dataDir + "signature.pfx", "signature");

// Pass the certificate and details to the save options class to sign with.
PdfSaveOptions options = new PdfSaveOptions();
options.DigitalSignatureDetails = new PdfDigitalSignatureDetails(
    cert,
    "Test Signing",
    "Aspose Office",
    DateTime.Now);
            
dataDir = dataDir + "Document.Signed_out_.pdf";
// Save the document as PDF with the digital signature set.
doc.Save(dataDir, options);

