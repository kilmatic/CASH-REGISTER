<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstReg = New System.Windows.Forms.ListBox()
        Me.lstKid = New System.Windows.Forms.ListBox()
        Me.lstOrd = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnKid = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnQiut = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstReg
        '
        Me.lstReg.FormattingEnabled = True
        Me.lstReg.ItemHeight = 20
        Me.lstReg.Location = New System.Drawing.Point(14, 133)
        Me.lstReg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstReg.Name = "lstReg"
        Me.lstReg.Size = New System.Drawing.Size(202, 124)
        Me.lstReg.TabIndex = 0
        '
        'lstKid
        '
        Me.lstKid.FormattingEnabled = True
        Me.lstKid.ItemHeight = 20
        Me.lstKid.Location = New System.Drawing.Point(697, 133)
        Me.lstKid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstKid.Name = "lstKid"
        Me.lstKid.Size = New System.Drawing.Size(202, 124)
        Me.lstKid.TabIndex = 1
        '
        'lstOrd
        '
        Me.lstOrd.FormattingEnabled = True
        Me.lstOrd.ItemHeight = 20
        Me.lstOrd.Location = New System.Drawing.Point(345, 133)
        Me.lstOrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstOrd.Name = "lstOrd"
        Me.lstOrd.Size = New System.Drawing.Size(202, 224)
        Me.lstOrd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(63, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Regular Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(386, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(761, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kids Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(651, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(254, 181)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(57, 31)
        Me.btnReg.TabIndex = 7
        Me.btnReg.Text = ">>"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnKid
        '
        Me.btnKid.Location = New System.Drawing.Point(595, 181)
        Me.btnKid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnKid.Name = "btnKid"
        Me.btnKid.Size = New System.Drawing.Size(57, 31)
        Me.btnKid.TabIndex = 8
        Me.btnKid.Text = "<<"
        Me.btnKid.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(14, 309)
        Me.btnClr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(86, 31)
        Me.btnClr.TabIndex = 9
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnQiut
        '
        Me.btnQiut.Location = New System.Drawing.Point(130, 309)
        Me.btnQiut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQiut.Name = "btnQiut"
        Me.btnQiut.Size = New System.Drawing.Size(86, 31)
        Me.btnQiut.TabIndex = 10
        Me.btnQiut.Text = "Quit"
        Me.btnQiut.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(738, 316)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(161, 27)
        Me.txtTotal.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 425)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnQiut)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnKid)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstOrd)
        Me.Controls.Add(Me.lstKid)
        Me.Controls.Add(Me.lstReg)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstReg As ListBox
    Friend WithEvents lstKid As ListBox
    Friend WithEvents lstOrd As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReg As Button
    Friend WithEvents btnKid As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnQiut As Button
    Friend WithEvents txtTotal As TextBox
End Class
