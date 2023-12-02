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
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        CheckBox1 = New CheckBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        closeBtn = New Button()
        backgroundBtn = New Button()
        clearBtn = New Button()
        showBtn = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        ColorDialog1 = New ColorDialog()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.048933F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 86.9510651F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(CheckBox1, 0, 1)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 1, 1)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(797, 453)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        TableLayoutPanel1.SetColumnSpan(PictureBox1, 2)
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(791, 401)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(3, 410)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(63, 19)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Stretch"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(closeBtn)
        FlowLayoutPanel1.Controls.Add(backgroundBtn)
        FlowLayoutPanel1.Controls.Add(clearBtn)
        FlowLayoutPanel1.Controls.Add(showBtn)
        FlowLayoutPanel1.Location = New Point(107, 410)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(687, 40)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' closeBtn
        ' 
        closeBtn.Location = New Point(3, 3)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(75, 23)
        closeBtn.TabIndex = 0
        closeBtn.Text = "Close"
        closeBtn.UseVisualStyleBackColor = True
        ' 
        ' backgroundBtn
        ' 
        backgroundBtn.Location = New Point(84, 3)
        backgroundBtn.Name = "backgroundBtn"
        backgroundBtn.Size = New Size(159, 23)
        backgroundBtn.TabIndex = 1
        backgroundBtn.TabStop = False
        backgroundBtn.Text = "Set background colour"
        backgroundBtn.UseVisualStyleBackColor = True
        ' 
        ' clearBtn
        ' 
        clearBtn.Location = New Point(249, 3)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(92, 23)
        clearBtn.TabIndex = 2
        clearBtn.TabStop = False
        clearBtn.Text = "Clear Picture "
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' showBtn
        ' 
        showBtn.Location = New Point(347, 3)
        showBtn.Name = "showBtn"
        showBtn.Size = New Size(92, 23)
        showBtn.TabIndex = 3
        showBtn.TabStop = False
        showBtn.Text = "Show Picture "
        showBtn.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg"
        OpenFileDialog1.Title = "Select a picure file"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents backgroundBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents showBtn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
