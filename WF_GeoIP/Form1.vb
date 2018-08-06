Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCep.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblResultado.Click

    End Sub

    Private Sub btnInformacoesIP_Click(sender As Object, e As EventArgs) Handles btnConsultaCep.Click

        'Dim correios = New CorreioService.AtendeClienteClient()
        Dim resultado As Endereco = Nothing

        If Not String.IsNullOrEmpty(txtCep.Text) Then

            Try

                Using correios = New CorreioService.AtendeClienteClient()
                    Dim consulta = correios.consultaCEP(txtCep.Text.Replace("-", ""))


                    If consulta IsNot Nothing Then
                        resultado = New Endereco
                        resultado.Descricao = consulta.end
                        resultado.Complemento = consulta.complemento
                        resultado.Complemento2 = consulta.complemento2
                        resultado.Bairro = consulta.bairro
                        resultado.Cidade = consulta.cidade
                        resultado.EstadoUF = consulta.uf

                    End If

                End Using

                lbResultado.Items.Clear()
                lbResultado.Items.Add(resultado.Descricao)
                ' lbResultado.Items.Add(resultado.Complemento)
                lbResultado.Items.Add(resultado.Complemento2)
                lbResultado.Items.Add(resultado.Bairro)
                lbResultado.Items.Add(resultado.Cidade)
                lbResultado.Items.Add(resultado.EstadoUF)
            Catch ex As Exception

            End Try
        End If



    End Sub
End Class
