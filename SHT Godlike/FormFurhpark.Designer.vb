<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFurhpark
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SH_TransporteDataSet = New SHT_Godlike.SH_TransporteDataSet()
        Me.FahrzeugeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FahrzeugeTableAdapter = New SHT_Godlike.SH_TransporteDataSetTableAdapters.FahrzeugeTableAdapter()
        Me.SH_TransporteDataSet1 = New SHT_Godlike.SH_TransporteDataSet1()
        Me.WWSH540BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WW_SH_540TableAdapter = New SHT_Godlike.SH_TransporteDataSet1TableAdapters.WW_SH_540TableAdapter()
        CType(Me.SH_TransporteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FahrzeugeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SH_TransporteDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WWSH540BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SH_TransporteDataSet
        '
        Me.SH_TransporteDataSet.DataSetName = "SH_TransporteDataSet"
        Me.SH_TransporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FahrzeugeBindingSource
        '
        Me.FahrzeugeBindingSource.DataMember = "Fahrzeuge"
        Me.FahrzeugeBindingSource.DataSource = Me.SH_TransporteDataSet
        '
        'FahrzeugeTableAdapter
        '
        Me.FahrzeugeTableAdapter.ClearBeforeFill = True
        '
        'SH_TransporteDataSet1
        '
        Me.SH_TransporteDataSet1.DataSetName = "SH_TransporteDataSet1"
        Me.SH_TransporteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WWSH540BindingSource
        '
        Me.WWSH540BindingSource.DataMember = "WW-SH-540"
        Me.WWSH540BindingSource.DataSource = Me.SH_TransporteDataSet1
        '
        'WW_SH_540TableAdapter
        '
        Me.WW_SH_540TableAdapter.ClearBeforeFill = True
        '
        'FormFurhpark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(2448, 873)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "FormFurhpark"
        Me.Text = "Furhpark"
        CType(Me.SH_TransporteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FahrzeugeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SH_TransporteDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WWSH540BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SH_TransporteDataSet As SH_TransporteDataSet
    Friend WithEvents FahrzeugeBindingSource As BindingSource
    Friend WithEvents FahrzeugeTableAdapter As SH_TransporteDataSetTableAdapters.FahrzeugeTableAdapter
    Friend WithEvents SH_TransporteDataSet1 As SH_TransporteDataSet1
    Friend WithEvents WWSH540BindingSource As BindingSource
    Friend WithEvents WW_SH_540TableAdapter As SH_TransporteDataSet1TableAdapters.WW_SH_540TableAdapter
End Class
