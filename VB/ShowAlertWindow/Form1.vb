Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ShowAlertWindow
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Dim msg As New Message()
            alertControl1.Show(Me, msg.Caption, msg.Text, "", msg.Image, msg)
        End Sub

        Private Sub alertControl1_BeforeFormShow(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Alerter.AlertFormEventArgs) Handles alertControl1.BeforeFormShow
            'Make the Alert Window opaque
            e.AlertForm.OpacityLevel = 1
        End Sub

        Private Sub alertControl1_AlertClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles alertControl1.AlertClick
            'Process Alert Window click
            Dim msg As Message = TryCast(e.Info.Tag, Message)
            XtraMessageBox.Show(msg.Text, msg.Caption)
        End Sub
    End Class

    Public Class Message
        Public Sub New()
            Me.Caption = "LILA-Supermercado"
            Me.Text = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo"
            Me.Image = My.Resources.opportunities_32x32
        End Sub
        Public Property Caption() As String
        Public Property Text() As String
        Public Property Image() As Image
    End Class
End Namespace
