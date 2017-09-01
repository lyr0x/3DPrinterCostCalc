<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostCalc
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NUDMaterialMeter = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPrinterName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NUDMaterialCost = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUDEnergyCost = New System.Windows.Forms.NumericUpDown()
        Me.NUDEnergyKWH = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NUDWearCost = New System.Windows.Forms.NumericUpDown()
        Me.NUDWearH = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NUDWorkTimeCost = New System.Windows.Forms.NumericUpDown()
        Me.NUDWorkTimeH = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NUDMaterialMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUDMaterialCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUDEnergyCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDEnergyKWH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUDWearCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDWearH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NUDWorkTimeCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDWorkTimeH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(483, 403)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(475, 377)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.tbPrinterName)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(475, 377)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NUDMaterialMeter
        '
        Me.NUDMaterialMeter.Location = New System.Drawing.Point(49, 19)
        Me.NUDMaterialMeter.Name = "NUDMaterialMeter"
        Me.NUDMaterialMeter.Size = New System.Drawing.Size(52, 20)
        Me.NUDMaterialMeter.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NUDMaterialCost)
        Me.GroupBox1.Controls.Add(Me.NUDMaterialMeter)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 51)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material"
        '
        'tbPrinterName
        '
        Me.tbPrinterName.Location = New System.Drawing.Point(88, 13)
        Me.tbPrinterName.Name = "tbPrinterName"
        Me.tbPrinterName.Size = New System.Drawing.Size(161, 20)
        Me.tbPrinterName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Druckername:"
        '
        'NUDMaterialCost
        '
        Me.NUDMaterialCost.Location = New System.Drawing.Point(155, 19)
        Me.NUDMaterialCost.Name = "NUDMaterialCost"
        Me.NUDMaterialCost.Size = New System.Drawing.Size(49, 20)
        Me.NUDMaterialCost.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Meter:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kosten:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NUDEnergyCost)
        Me.GroupBox2.Controls.Add(Me.NUDEnergyKWH)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 51)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Strom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kosten:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "KwH:"
        '
        'NUDEnergyCost
        '
        Me.NUDEnergyCost.Location = New System.Drawing.Point(155, 19)
        Me.NUDEnergyCost.Name = "NUDEnergyCost"
        Me.NUDEnergyCost.Size = New System.Drawing.Size(49, 20)
        Me.NUDEnergyCost.TabIndex = 4
        '
        'NUDEnergyKWH
        '
        Me.NUDEnergyKWH.Location = New System.Drawing.Point(49, 19)
        Me.NUDEnergyKWH.Name = "NUDEnergyKWH"
        Me.NUDEnergyKWH.Size = New System.Drawing.Size(52, 20)
        Me.NUDEnergyKWH.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.NUDWearCost)
        Me.GroupBox3.Controls.Add(Me.NUDWearH)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 51)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Abnutzung"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kosten:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-1, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Stunde:"
        '
        'NUDWearCost
        '
        Me.NUDWearCost.Location = New System.Drawing.Point(155, 19)
        Me.NUDWearCost.Name = "NUDWearCost"
        Me.NUDWearCost.Size = New System.Drawing.Size(49, 20)
        Me.NUDWearCost.TabIndex = 4
        '
        'NUDWearH
        '
        Me.NUDWearH.Location = New System.Drawing.Point(49, 19)
        Me.NUDWearH.Name = "NUDWearH"
        Me.NUDWearH.Size = New System.Drawing.Size(52, 20)
        Me.NUDWearH.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.NUDWorkTimeCost)
        Me.GroupBox4.Controls.Add(Me.NUDWorkTimeH)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 51)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Arbeitszeit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Kosten:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-1, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Stunde:"
        '
        'NUDWorkTimeCost
        '
        Me.NUDWorkTimeCost.Location = New System.Drawing.Point(155, 19)
        Me.NUDWorkTimeCost.Name = "NUDWorkTimeCost"
        Me.NUDWorkTimeCost.Size = New System.Drawing.Size(49, 20)
        Me.NUDWorkTimeCost.TabIndex = 4
        '
        'NUDWorkTimeH
        '
        Me.NUDWorkTimeH.Location = New System.Drawing.Point(49, 19)
        Me.NUDWorkTimeH.Name = "NUDWorkTimeH"
        Me.NUDWorkTimeH.Size = New System.Drawing.Size(52, 20)
        Me.NUDWorkTimeH.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CostCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 415)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CostCalc"
        Me.Text = "3D Printer Cost Calculator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NUDMaterialMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUDMaterialCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUDEnergyCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDEnergyKWH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUDWearCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDWearH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NUDWorkTimeCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDWorkTimeH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents NUDMaterialMeter As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbPrinterName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NUDWorkTimeCost As NumericUpDown
    Friend WithEvents NUDWorkTimeH As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NUDWearCost As NumericUpDown
    Friend WithEvents NUDWearH As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NUDEnergyCost As NumericUpDown
    Friend WithEvents NUDEnergyKWH As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NUDMaterialCost As NumericUpDown
End Class
