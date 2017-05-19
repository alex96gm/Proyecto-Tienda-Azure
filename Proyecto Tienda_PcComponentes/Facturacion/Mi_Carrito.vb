Public Class Mi_Carrito
    Dim sumTotal As Integer
    Public Sub Mi_Carrito_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim x As Integer = 0
        Do
            If listProductos.Count > 0 Then
                pagar.Enabled = True
                ListBox1.Items.Add(listProductos.ElementAt(x).nomLargoProducto)
                sumTotal = sumTotal + listProductos.ElementAt(x).totalProducto
                x = x + 1
            Else
                pagar.Enabled = False
            End If
        Loop Until x = listProductos.Count

        total.Text = sumTotal



    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If Not ListBox1.SelectedItem Is Nothing Then



            Dim x As Integer = 0
            Do
                If ListBox1.SelectedItem.ToString = listProductos.ElementAt(x).nomLargoProducto Then
                    sumTotal = sumTotal - listProductos.ElementAt(x).totalProducto
                    listProductos.RemoveAt(x)
                    Exit Do
                End If
                x = x + 1

            Loop Until x = listProductos.Count
            total.Text = sumTotal
            ListBox1.Items.Remove(ListBox1.SelectedItem)


        End If

        If listProductos.Count = 0 Then
            pagar.Enabled = False
        End If
    End Sub



    Private Sub Subir_Click(sender As Object, e As EventArgs) Handles Subir.Click

        Dim NumItems As Integer
        Dim ItemNum As Integer
        Dim TempItem As String
        If ListBox1.SelectedIndex <= 0 Then Exit Sub
        NumItems = ListBox1.Items.Count
        Dim TempList()
        ReDim TempList(0 To NumItems - 1)
        'rellenar temp, con elementos de la lista
        For i = 0 To NumItems - 1
            TempList(i) = ListBox1.Items(i)
        Next i
        'elemento seleccionado
        ItemNum = ListBox1.SelectedIndex
        'elementos intercambiados
        TempItem = TempList(ItemNum)
        TempList(ItemNum) = TempList(ItemNum - 1)
        TempList(ItemNum - 1) = TempItem
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TempList)
        'Cambiar el índice de lista
        ListBox1.SelectedIndex = ItemNum - 1

    End Sub

    Private Sub Bajar_Click(sender As Object, e As EventArgs) Handles Bajar.Click
        Dim NumItems As Integer
        Dim ItemNum As Integer
        Dim TempItem As String
        If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
            Exit Sub
        End If
        NumItems = ListBox1.Items.Count
        Dim TempList()
        ReDim TempList(0 To NumItems - 1)
        'Rellenar la serie con elementos del cuadro de lista
        For i = 0 To NumItems - 1
            TempList(i) = ListBox1.Items(i)
        Next i
        'Elemento seleccionado
        ItemNum = ListBox1.SelectedIndex
        'elementos intercambiados
        TempItem = TempList(ItemNum)
        TempList(ItemNum) = TempList(ItemNum + 1)
        TempList(ItemNum + 1) = TempItem
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(TempList)
        'Cambiar el índice de lista
        ListBox1.SelectedIndex = ItemNum + 1
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
    End Sub

    Private Sub pagar_Click(sender As Object, e As EventArgs) Handles pagar.Click
        Dim form As New facturacion
        form.ShowDialog()
        Me.Close()
    End Sub


End Class