Public Class SortVisualiser
    Dim array() As PictureBox
    Dim height() As Integer
    Dim sorted As Boolean
    Private Sub SortVisualiser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
        sorted = False
        ReDim array(Me.ClientRectangle.Width / 8 - 1)
        ReDim height(Me.ClientRectangle.Width / 8 - 1)

        For counter = 0 To UBound(array)
            height(counter) = Math.Floor(Rnd() * (Me.ClientRectangle.Height - 100) + 20)
            array(counter) = New PictureBox
            With array(counter)
                .BackColor = Color.White
                .Size = New Size(4, height(counter))
                .Location = New Point(counter * 8, Me.ClientRectangle.Bottom - height(counter))
            End With
            Me.Controls.Add(array(counter))
        Next
    End Sub
    Private Sub ResetHeight()
        For counter = 0 To UBound(array)
            height(counter) = Rnd() * (Me.ClientRectangle.Height - 100) + 20
            array(counter).BackColor = Color.White
        Next
        sorted = False
    End Sub
    Private Sub DisplayBars()
        Me.Refresh()
        For counter = 0 To UBound(array)
            array(counter).Size = New Size(4, height(counter))
            array(counter).Location = New Point(counter * 8, Me.ClientRectangle.Bottom - height(counter))
        Next
    End Sub
    Private Sub BubbleSort()
        For x = 0 To UBound(array)
            For y = 0 To UBound(array) - x - 1
                If Not y = 0 Then
                    array(y - 1).BackColor = Color.White
                Else
                    array(0).BackColor = Color.White
                End If
                array(y).BackColor = Color.Red
                array(y + 1).BackColor = Color.Red
                If height(y) > height(y + 1) Then
                    Dim temp As Integer = height(y)
                    height(y) = height(y + 1)
                    height(y + 1) = temp
                    DisplayBars()
                    array(y).BackColor = Color.White
                End If
            Next
            array(UBound(array) - x).BackColor = Color.Green
        Next
    End Sub
    Private Sub SelectionSort()
        Dim minpos As Integer
        For x = 0 To UBound(height)
            minpos = x
            For y = x + 1 To UBound(height)
                If height(y) < height(minpos) Then
                    array(minpos).BackColor = Color.Yellow
                    minpos = y
                    array(minpos).BackColor = Color.Red
                End If
            Next
            Dim temp As Integer = height(x)
            height(x) = height(minpos)
            height(minpos) = temp
            array(x).BackColor = Color.Green
            DisplayBars()
        Next
    End Sub
    Private Sub InsertionSort()
        Dim current As Integer
        Dim position As Integer
        For x = 1 To UBound(array)
            current = height(x)
            position = x
            While position > 0 AndAlso height(position - 1) > current
                height(position) = height(position - 1)
                position -= 1
            End While
            height(position) = current
            DisplayBars()
        Next
    End Sub
    Private Sub BinarySearch(data As Integer)
        Dim first As Integer = 0
        Dim last As Integer = UBound(height)
        Dim mid As Integer
        While first <= last
            mid = Math.Floor((first + last) / 2)
            If height(mid) = data Then
                MsgBox("Found" & data)
                array(mid).BackColor = Color.Green
                Exit Sub
            ElseIf height(mid) > data Then
                last = mid - 1
            Else
                first = mid + 1
            End If
        End While
        MsgBox("Not found" & data)
    End Sub
    Private Sub LinearSearch(data As Integer)
        For counter = 0 To UBound(height)
            If data = height(counter) Then
                array(counter).BackColor = Color.Green
                MsgBox("Found " & data)
                Exit Sub
            End If
        Next
        MsgBox("Not Found " & data)
    End Sub
#Region "Button Procedures"
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetHeight()
        DisplayBars()
    End Sub
    Private Sub btnVBSort_Click(sender As Object, e As EventArgs) Handles btnVBSort.Click
        System.Array.Sort(height)
        DisplayBars()
        sorted = True
    End Sub
    Private Sub btnBSort_Click(sender As Object, e As EventArgs) Handles btnBSort.Click
        BubbleSort()
        sorted = True
    End Sub
    Private Sub btnSSort_Click(sender As Object, e As EventArgs) Handles btnSSort.Click
        SelectionSort()
        sorted = True
    End Sub
    Private Sub btnISort_Click(sender As Object, e As EventArgs) Handles btnISort.Click
        InsertionSort()
        sorted = True
    End Sub
    Private Sub btnLinSearch_Click(sender As Object, e As EventArgs) Handles btnLinSearch.Click
        Dim item As Integer = CInt(InputBox("Enter a number"))
        LinearSearch(item)
    End Sub
    Private Sub btnBinSearch_Click(sender As Object, e As EventArgs) Handles btnBinSearch.Click

        If sorted = True Then
            Dim item As Integer = CInt(InputBox("Enter a number"))
            BinarySearch(item)
        Else
            MsgBox("The bars must be sorted in order to carry out binary search")
        End If
    End Sub
#Region "Button Decoration"
    Private Sub btnBinSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnBinSearch.MouseEnter
        btnBinSearch.ForeColor = Color.White
    End Sub
    Private Sub btnBSort_MouseEnter(sender As Object, e As EventArgs) Handles btnBSort.MouseEnter
        btnBSort.ForeColor = Color.White
    End Sub
    Private Sub btnISort_MouseEnter(sender As Object, e As EventArgs) Handles btnISort.MouseEnter
        btnISort.ForeColor = Color.White
    End Sub
    Private Sub btnLinSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnLinSearch.MouseEnter
        btnLinSearch.ForeColor = Color.White
    End Sub
    Private Sub btnMSort_MouseEnter(sender As Object, e As EventArgs) Handles btnMSort.MouseEnter
        btnMSort.ForeColor = Color.White
    End Sub
    Private Sub btnReset_MouseEnter(sender As Object, e As EventArgs) Handles btnReset.MouseEnter
        btnReset.ForeColor = Color.White
    End Sub
    Private Sub btnSSort_MouseEnter(sender As Object, e As EventArgs) Handles btnSSort.MouseEnter
        btnSSort.ForeColor = Color.White
    End Sub
    Private Sub btnVBSort_MouseEnter(sender As Object, e As EventArgs) Handles btnVBSort.MouseEnter
        btnVBSort.ForeColor = Color.White
    End Sub
    Private Sub btnBinSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnBinSearch.MouseLeave
        btnBinSearch.ForeColor = Color.Black
    End Sub
    Private Sub btnBSort_MouseLeave(sender As Object, e As EventArgs) Handles btnBSort.MouseLeave
        btnBSort.ForeColor = Color.Black
    End Sub
    Private Sub btnISort_MouseLeave(sender As Object, e As EventArgs) Handles btnISort.MouseLeave
        btnISort.ForeColor = Color.Black
    End Sub
    Private Sub btnLinSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnLinSearch.MouseLeave
        btnLinSearch.ForeColor = Color.Black
    End Sub
    Private Sub btnMSort_MouseLeave(sender As Object, e As EventArgs) Handles btnMSort.MouseLeave
        btnMSort.ForeColor = Color.Black
    End Sub
    Private Sub btnReset_MouseLeave(sender As Object, e As EventArgs) Handles btnReset.MouseLeave
        btnReset.ForeColor = Color.Black
    End Sub
    Private Sub btnSSort_MouseLeave(sender As Object, e As EventArgs) Handles btnSSort.MouseLeave
        btnSSort.ForeColor = Color.Black
    End Sub
    Private Sub btnVBSort_MouseLeave(sender As Object, e As EventArgs) Handles btnVBSort.MouseLeave
        btnVBSort.ForeColor = Color.Black
    End Sub
#End Region
#End Region
End Class
