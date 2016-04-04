' For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
Private Class HandleMergeField
    Implements IFieldMergingCallback
    ''' <summary>
    ''' This handler is called for every mail merge field found in the document,
    '''  for every record found in the data source.
    ''' </summary>
    Private Sub IFieldMergingCallback_FieldMerging(ByVal e As FieldMergingArgs) Implements IFieldMergingCallback.FieldMerging
        If mBuilder Is Nothing Then
            mBuilder = New DocumentBuilder(e.Document)
        End If

        ' We decided that we want all boolean values to be output as check box form fields.
        If TypeOf e.FieldValue Is Boolean Then
            ' Move the "cursor" to the current merge field.
            mBuilder.MoveToMergeField(e.FieldName)

            ' It is nice to give names to check boxes. Lets generate a name such as MyField21 or so.
            Dim checkBoxName As String = String.Format("{0}{1}", e.FieldName, e.RecordIndex)

            ' Insert a check box.
            mBuilder.InsertCheckBox(checkBoxName, CBool(e.FieldValue), 0)

            ' Nothing else to do for this field.
            Return
        End If

        ' We want to insert html during mail merge.
        If e.FieldName = "Body" Then
            mBuilder.MoveToMergeField(e.FieldName)
            mBuilder.InsertHtml(DirectCast(e.FieldValue, String))
        End If

        ' Another example, we want the Subject field to come out as text input form field.
        If e.FieldName = "Subject" Then
            mBuilder.MoveToMergeField(e.FieldName)
            Dim textInputName As String = String.Format("{0}{1}", e.FieldName, e.RecordIndex)
            mBuilder.InsertTextInput(textInputName, TextFormFieldType.Regular, "", CStr(e.FieldValue), 0)
        End If
    End Sub

    Private Sub ImageFieldMerging(ByVal args As ImageFieldMergingArgs) Implements IFieldMergingCallback.ImageFieldMerging
        ' Do nothing.
    End Sub

    Private mBuilder As DocumentBuilder
End Class
