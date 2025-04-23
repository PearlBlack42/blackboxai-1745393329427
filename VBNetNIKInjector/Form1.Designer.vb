Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.txtDatabasePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtOldNIK = New System.Windows.Forms.TextBox()
        Me.txtNewNIK = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.lblOldNIK = New System.Windows.Forms.Label()
        Me.lblNewNIK = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDatabasePath
        '
        Me.txtDatabasePath.Location = New System.Drawing.Point(120, 20)
        Me.txtDatabasePath.Name = "txtDatabasePath"
        Me.txtDatabasePath.Size = New System.Drawing.Size(300, 22)
        Me.txtDatabasePath.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(430, 18)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 25)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtOldNIK
        '
        Me.txtOldNIK.Location = New System.Drawing.Point(120, 60)
        Me.txtOldNIK.Name = "txtOldNIK"
        Me.txtOldNIK.Size = New System.Drawing.Size(200, 22)
        Me.txtOldNIK.TabIndex = 2
        '
        'txtNewNIK
        '
        Me.txtNewNIK.Location = New System.Drawing.Point(120, 100)
        Me.txtNewNIK.Name = "txtNewNIK"
        Me.txtNewNIK.Size = New System.Drawing.Size(200, 22)
        Me.txtNewNIK.TabIndex = 3
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(120, 140)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update NIK"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(20, 23)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(94, 17)
        Me.lblDatabase.TabIndex = 5
        Me.lblDatabase.Text = "Database File"
        '
        'lblOldNIK
        '
        Me.lblOldNIK.AutoSize = True
        Me.lblOldNIK.Location = New System.Drawing.Point(20, 63)
        Me.lblOldNIK.Name = "lblOldNIK"
        Me.lblOldNIK.Size = New System.Drawing.Size(57, 17)
        Me.lblOldNIK.TabIndex = 6
        Me.lblOldNIK.Text = "Old NIK"
        '
        'lblNewNIK
        '
        Me.lblNewNIK.AutoSize = True
        Me.lblNewNIK.Location = New System.Drawing.Point(20, 103)
        Me.lblNewNIK.Name = "lblNewNIK"
        Me.lblNewNIK.Size = New System.Drawing.Size(63, 17)
        Me.lblNewNIK.TabIndex = 7
        Me.lblNewNIK.Text = "New NIK"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(530, 200)
        Me.Controls.Add(Me.lblNewNIK)
        Me.Controls.Add(Me.lblOldNIK)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNewNIK)
        Me.Controls.Add(Me.txtOldNIK)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtDatabasePath)
        Me.Name = "Form1"
        Me.Text = "NIK Injector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDatabasePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtOldNIK As TextBox
    Friend WithEvents txtNewNIK As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblDatabase As Label
    Friend WithEvents lblOldNIK As Label
    Friend WithEvents lblNewNIK As Label
End Class
