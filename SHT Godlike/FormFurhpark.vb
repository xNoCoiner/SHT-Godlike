Public Class FormFurhpark
    Private Sub FormFurhpark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "SH_TransporteDataSet1._WW_SH_540". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.WW_SH_540TableAdapter.Fill(Me.SH_TransporteDataSet1._WW_SH_540)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "SH_TransporteDataSet.Fahrzeuge". Sie können sie bei Bedarf verschieben oder entfernen.


    End Sub

    Private Sub ComboBoxKennzeichen_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class