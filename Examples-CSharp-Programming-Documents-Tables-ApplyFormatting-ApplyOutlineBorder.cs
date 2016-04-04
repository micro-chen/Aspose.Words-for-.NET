// For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
Document doc = new Document(dataDir + "Table.EmptyTable.doc");
            
Table table = (Table)doc.GetChild(NodeType.Table, 0, true);
// Align the table to the center of the page.
table.Alignment = TableAlignment.Center;
// Clear any existing borders from the table.
table.ClearBorders();

// Set a green border around the table but not inside. 
table.SetBorder(BorderType.Left, LineStyle.Single, 1.5, Color.Green, true);
table.SetBorder(BorderType.Right, LineStyle.Single, 1.5, Color.Green, true);
table.SetBorder(BorderType.Top, LineStyle.Single, 1.5, Color.Green, true);
table.SetBorder(BorderType.Bottom, LineStyle.Single, 1.5, Color.Green, true);

// Fill the cells with a light green solid color.
table.SetShading(TextureIndex.TextureSolid, Color.LightGreen, Color.Empty);
dataDir = dataDir + "Table.SetOutlineBorders_out_.doc";
// Save the document to disk.
doc.Save(dataDir);
