<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NorthWest = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.North = New System.Windows.Forms.Button()
        Me.NorthEast = New System.Windows.Forms.Button()
        Me.West = New System.Windows.Forms.Button()
        Me.Center = New System.Windows.Forms.Button()
        Me.East = New System.Windows.Forms.Button()
        Me.SouthWest = New System.Windows.Forms.Button()
        Me.South = New System.Windows.Forms.Button()
        Me.SouthEast = New System.Windows.Forms.Button()
        Me.turnLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NorthWest
        '
        Me.NorthWest.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NorthWest.Location = New System.Drawing.Point(57, 103)
        Me.NorthWest.Name = "NorthWest"
        Me.NorthWest.Size = New System.Drawing.Size(177, 160)
        Me.NorthWest.TabIndex = 0
        Me.NorthWest.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(281, 612)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(104, 38)
        Me.resetButton.TabIndex = 1
        Me.resetButton.Text = "RESET"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'North
        '
        Me.North.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.North.Location = New System.Drawing.Point(240, 103)
        Me.North.Name = "North"
        Me.North.Size = New System.Drawing.Size(177, 160)
        Me.North.TabIndex = 2
        Me.North.UseVisualStyleBackColor = True
        '
        'NorthEast
        '
        Me.NorthEast.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NorthEast.Location = New System.Drawing.Point(423, 103)
        Me.NorthEast.Name = "NorthEast"
        Me.NorthEast.Size = New System.Drawing.Size(177, 160)
        Me.NorthEast.TabIndex = 3
        Me.NorthEast.UseVisualStyleBackColor = True
        '
        'West
        '
        Me.West.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.West.Location = New System.Drawing.Point(57, 269)
        Me.West.Name = "West"
        Me.West.Size = New System.Drawing.Size(177, 160)
        Me.West.TabIndex = 4
        Me.West.UseVisualStyleBackColor = True
        '
        'Center
        '
        Me.Center.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Center.Location = New System.Drawing.Point(240, 269)
        Me.Center.Name = "Center"
        Me.Center.Size = New System.Drawing.Size(177, 160)
        Me.Center.TabIndex = 5
        Me.Center.UseVisualStyleBackColor = True
        '
        'East
        '
        Me.East.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.East.Location = New System.Drawing.Point(423, 269)
        Me.East.Name = "East"
        Me.East.Size = New System.Drawing.Size(177, 160)
        Me.East.TabIndex = 6
        Me.East.UseVisualStyleBackColor = True
        '
        'SouthWest
        '
        Me.SouthWest.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SouthWest.Location = New System.Drawing.Point(57, 435)
        Me.SouthWest.Name = "SouthWest"
        Me.SouthWest.Size = New System.Drawing.Size(177, 160)
        Me.SouthWest.TabIndex = 7
        Me.SouthWest.UseVisualStyleBackColor = True
        '
        'South
        '
        Me.South.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.South.Location = New System.Drawing.Point(240, 435)
        Me.South.Name = "South"
        Me.South.Size = New System.Drawing.Size(177, 160)
        Me.South.TabIndex = 8
        Me.South.UseVisualStyleBackColor = True
        '
        'SouthEast
        '
        Me.SouthEast.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SouthEast.Location = New System.Drawing.Point(423, 435)
        Me.SouthEast.Name = "SouthEast"
        Me.SouthEast.Size = New System.Drawing.Size(177, 160)
        Me.SouthEast.TabIndex = 9
        Me.SouthEast.UseVisualStyleBackColor = True
        '
        'turnLabel
        '
        Me.turnLabel.AutoSize = True
        Me.turnLabel.Location = New System.Drawing.Point(297, 38)
        Me.turnLabel.Name = "turnLabel"
        Me.turnLabel.Size = New System.Drawing.Size(0, 15)
        Me.turnLabel.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 679)
        Me.Controls.Add(Me.turnLabel)
        Me.Controls.Add(Me.SouthEast)
        Me.Controls.Add(Me.South)
        Me.Controls.Add(Me.SouthWest)
        Me.Controls.Add(Me.East)
        Me.Controls.Add(Me.Center)
        Me.Controls.Add(Me.West)
        Me.Controls.Add(Me.NorthEast)
        Me.Controls.Add(Me.North)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.NorthWest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NorthWest As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents North As Button
    Friend WithEvents NorthEast As Button
    Friend WithEvents West As Button
    Friend WithEvents Center As Button
    Friend WithEvents East As Button
    Friend WithEvents SouthWest As Button
    Friend WithEvents South As Button
    Friend WithEvents SouthEast As Button
    Friend WithEvents turnLabel As Label
End Class
