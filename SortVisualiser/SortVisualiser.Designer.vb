<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SortVisualiser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnVBSort = New System.Windows.Forms.Button()
        Me.btnBSort = New System.Windows.Forms.Button()
        Me.btnSSort = New System.Windows.Forms.Button()
        Me.btnISort = New System.Windows.Forms.Button()
        Me.btnBinSearch = New System.Windows.Forms.Button()
        Me.btnLinSearch = New System.Windows.Forms.Button()
        Me.btnMSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 52)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnVBSort
        '
        Me.btnVBSort.Location = New System.Drawing.Point(145, 12)
        Me.btnVBSort.Name = "btnVBSort"
        Me.btnVBSort.Size = New System.Drawing.Size(127, 52)
        Me.btnVBSort.TabIndex = 1
        Me.btnVBSort.Text = "VB Sort"
        Me.btnVBSort.UseVisualStyleBackColor = True
        '
        'btnBSort
        '
        Me.btnBSort.Location = New System.Drawing.Point(278, 12)
        Me.btnBSort.Name = "btnBSort"
        Me.btnBSort.Size = New System.Drawing.Size(127, 52)
        Me.btnBSort.TabIndex = 2
        Me.btnBSort.Text = "Bubble Sort"
        Me.btnBSort.UseVisualStyleBackColor = True
        '
        'btnSSort
        '
        Me.btnSSort.Location = New System.Drawing.Point(411, 12)
        Me.btnSSort.Name = "btnSSort"
        Me.btnSSort.Size = New System.Drawing.Size(127, 52)
        Me.btnSSort.TabIndex = 3
        Me.btnSSort.Text = "Selection Sort"
        Me.btnSSort.UseVisualStyleBackColor = True
        '
        'btnISort
        '
        Me.btnISort.Location = New System.Drawing.Point(544, 12)
        Me.btnISort.Name = "btnISort"
        Me.btnISort.Size = New System.Drawing.Size(127, 52)
        Me.btnISort.TabIndex = 4
        Me.btnISort.Text = "Insertion Sort"
        Me.btnISort.UseVisualStyleBackColor = True
        '
        'btnBinSearch
        '
        Me.btnBinSearch.Location = New System.Drawing.Point(943, 12)
        Me.btnBinSearch.Name = "btnBinSearch"
        Me.btnBinSearch.Size = New System.Drawing.Size(127, 52)
        Me.btnBinSearch.TabIndex = 6
        Me.btnBinSearch.Text = "Binary Search"
        Me.btnBinSearch.UseVisualStyleBackColor = True
        '
        'btnLinSearch
        '
        Me.btnLinSearch.Location = New System.Drawing.Point(810, 12)
        Me.btnLinSearch.Name = "btnLinSearch"
        Me.btnLinSearch.Size = New System.Drawing.Size(127, 52)
        Me.btnLinSearch.TabIndex = 8
        Me.btnLinSearch.Text = "Linear Search"
        Me.btnLinSearch.UseVisualStyleBackColor = True
        '
        'btnMSort
        '
        Me.btnMSort.Location = New System.Drawing.Point(677, 12)
        Me.btnMSort.Name = "btnMSort"
        Me.btnMSort.Size = New System.Drawing.Size(127, 52)
        Me.btnMSort.TabIndex = 9
        Me.btnMSort.Text = "Merge Sort"
        Me.btnMSort.UseVisualStyleBackColor = True
        '
        'SortVisualiser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 651)
        Me.Controls.Add(Me.btnMSort)
        Me.Controls.Add(Me.btnLinSearch)
        Me.Controls.Add(Me.btnBinSearch)
        Me.Controls.Add(Me.btnISort)
        Me.Controls.Add(Me.btnSSort)
        Me.Controls.Add(Me.btnBSort)
        Me.Controls.Add(Me.btnVBSort)
        Me.Controls.Add(Me.btnReset)
        Me.Name = "SortVisualiser"
        Me.Text = "Sort Visualiser"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents btnVBSort As Button
    Friend WithEvents btnBSort As Button
    Friend WithEvents btnSSort As Button
    Friend WithEvents btnISort As Button
    Friend WithEvents btnBinSearch As Button
    Friend WithEvents btnLinSearch As Button
    Friend WithEvents btnMSort As Button
End Class
