Public Class MainForm
    Dim Hombre As Boolean = True
    Dim Mujer As Boolean = True
    Dim Calzado As Boolean = True
    Dim Accesorio As Boolean = True
    Dim C1, C2, C3, C4, Total As Integer
    Dim M1, M2, M3, M4 As Integer
    Dim Z1, Z2, Z3, Z4 As Integer
    Dim A1, A2, A3, A4 As Integer
    Private Sub btnFlecha11_Click(sender As Object, e As EventArgs) Handles btnFlecha11.Click
        If CInt(lblCant1.Text) > 0 Then
            If Hombre Then
                C1 = C1 - 1
                lblCant1.Text = CStr(C1)
                Total = Total - 120
            ElseIf Mujer Then
                M1 = M1 - 1
                lblCant1.Text = CStr(M1)
                Total = Total - 80
            ElseIf Calzado Then
                Z1 = Z1 - 1
                lblCant1.Text = CStr(Z1)
                Total = Total - 120
            ElseIf Accesorio Then
                A1 = A1 - 1
                lblCant1.Text = CStr(A1)
                Total = Total - 380
            End If
            lblTotal.Text = "$" & CStr(Total)
        Else
            If Hombre Then
                If C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso M1 = 0 AndAlso M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    C1 = C1
                    lblCant1.Text = CStr(C1)
                    lblTotal.Text = "$ 0"
                Else
                    C1 = C1
                    lblCant1.Text = CStr(C1)
                End If
            ElseIf Mujer Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    M1 = M1
                    lblCant1.Text = CStr(M1)
                    lblTotal.Text = "$ 0"
                Else
                    M1 = M1
                    lblCant1.Text = CStr(M1)
                End If
            ElseIf Calzado Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso M1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    Z1 = Z1
                    lblCant1.Text = CStr(Z1)
                    lblTotal.Text = "$ 0"
                Else
                    Z1 = Z1
                    lblCant1.Text = CStr(Z1)
                End If
            ElseIf Accesorio Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso M1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    A1 = A1
                    lblCant1.Text = CStr(A1)
                    lblTotal.Text = "$ 0"
                Else
                    A1 = A1
                    lblCant1.Text = CStr(A1)
                End If
            End If
        End If
    End Sub

    Private Sub btnFlecha21_Click(sender As Object, e As EventArgs) Handles btnFlecha21.Click
        If CInt(lblCant2.Text) > 0 Then
            If Hombre Then
                C2 = C2 - 1
                lblCant2.Text = CStr(C2)
                Total = Total - 240
            ElseIf Mujer Then
                M2 = M2 - 1
                lblCant2.Text = CStr(M2)
                Total = Total - 150
            ElseIf Calzado Then
                Z2 = Z2 - 1
                lblCant2.Text = CStr(Z2)
                Total = Total - 140
            ElseIf Accesorio Then
                A2 = A2 - 1
                lblCant2.Text = CStr(A2)
                Total = Total - 70
            End If
            lblTotal.Text = "$" & CStr(Total)
        Else
            If Hombre Then
                If C1 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso M1 = 0 AndAlso M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    C2 = C2
                    lblCant2.Text = CStr(C2)
                    lblTotal.Text = "$ 0"
                Else
                    C2 = C2
                    lblCant2.Text = CStr(C2)
                End If
            ElseIf Mujer Then
                If M1 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    M2 = M2
                    lblCant2.Text = CStr(M2)
                    lblTotal.Text = "$ 0"
                Else
                    M2 = M2
                    lblCant2.Text = CStr(M2)
                End If
            ElseIf Calzado Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso M1 = 0 AndAlso Z1 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    Z2 = Z2
                    lblCant2.Text = CStr(Z2)
                    lblTotal.Text = "$ 0"
                Else
                    Z2 = Z2
                    lblCant2.Text = CStr(Z2)
                End If
            ElseIf Accesorio Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso M1 = 0 AndAlso A1 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    A2 = A2
                    lblCant2.Text = CStr(A2)
                    lblTotal.Text = "$ 0"
                Else
                    A2 = A2
                    lblCant2.Text = CStr(A2)
                End If
            End If
        End If
    End Sub

    Private Sub btnFlecha22_Click(sender As Object, e As EventArgs) Handles btnFlecha22.Click
        If CInt(lblCant2.Text) >= 0 Then
            If CInt(lblCant2.Text) <= 8 Then
                If Hombre Then
                    C2 = C2 + 1
                    lblCant2.Text = CStr(C2)
                    Total = Total + 240
                ElseIf Mujer Then
                    M2 = M2 + 1
                    lblCant2.Text = CStr(M2)
                    Total = Total + 150
                ElseIf Calzado Then
                    Z2 = Z2 + 1
                    lblCant2.Text = CStr(Z2)
                    Total = Total + 140
                ElseIf Accesorio Then
                    A2 = A2 + 1
                    lblCant2.Text = CStr(A2)
                    Total = Total + 70
                End If
            Else
                Total = Total
            End If
            lblTotal.Text = "$" & CStr(Total)
            End If
    End Sub

    Private Sub btnFlecha31_Click(sender As Object, e As EventArgs) Handles btnFlecha31.Click
        If CInt(lblCant3.Text) > 0 Then
            If Hombre Then
                C3 = C3 - 1
                lblCant3.Text = CStr(C3)
                Total = Total - 160
            ElseIf Mujer Then
                M3 = M3 - 1
                lblCant3.Text = CStr(M3)
                Total = Total - 220
            ElseIf Calzado Then
                Z3 = Z3 - 1
                lblCant3.Text = CStr(Z3)
                Total = Total - 160
            ElseIf Accesorio Then
                A3 = A3 - 1
                lblCant3.Text = CStr(A3)
                Total = Total - 190
            End If
            lblTotal.Text = "$" & CStr(Total)
        Else
            If Hombre Then
                If C2 = 0 AndAlso C1 = 0 AndAlso C4 = 0 AndAlso M1 = 0 AndAlso M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    C3 = C3
                    lblCant3.Text = CStr(C3)
                    lblTotal.Text = "$ 0"
                Else
                    C3 = C3
                    lblCant3.Text = CStr(C3)
                End If
            ElseIf Mujer Then
                If M2 = 0 AndAlso M1 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    M3 = M3
                    lblCant3.Text = CStr(M3)
                    lblTotal.Text = "$ 0"
                Else
                    M3 = M3
                    lblCant3.Text = CStr(M3)
                End If
            ElseIf Calzado Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso M1 = 0 AndAlso Z2 = 0 AndAlso Z1 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    Z3 = Z3
                    lblCant3.Text = CStr(Z3)
                    lblTotal.Text = "$ 0"
                Else
                    Z3 = Z3
                    lblCant3.Text = CStr(Z3)
                End If
            ElseIf Accesorio Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso M1 = 0 AndAlso A2 = 0 AndAlso A1 = 0 AndAlso A4 = 0 Then
                    A3 = A3
                    lblCant3.Text = CStr(A3)
                    lblTotal.Text = "$ 0"
                Else
                    A3 = A3
                    lblCant3.Text = CStr(A3)
                End If
            End If
        End If
    End Sub

    Private Sub btnComprar1_Click(sender As Object, e As EventArgs) Handles btnComprar1.Click
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(0)
            lblPrecio.Text = "$ 120"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(0)
            lblPrecio.Text = "$ 80"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(0)
            lblPrecio.Text = "$ 120"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(0)
            lblPrecio.Text = "$ 380"
        End If
    End Sub

    Private Sub btnComprar2_Click(sender As Object, e As EventArgs) Handles btnComprar2.Click
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(1)
            lblPrecio.Text = "$ 240"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(1)
            lblPrecio.Text = "$ 150"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(1)
            lblPrecio.Text = "$ 140"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(1)
            lblPrecio.Text = "$ 70"
        End If

    End Sub

    Private Sub btnComprar3_Click(sender As Object, e As EventArgs) Handles btnComprar3.Click
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(2)
            lblPrecio.Text = "$ 160"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(2)
            lblPrecio.Text = "$ 220"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(2)
            lblPrecio.Text = "$ 160"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(2)
            lblPrecio.Text = "$ 190"
        End If

    End Sub

    Private Sub btnComprar4_Click(sender As Object, e As EventArgs) Handles btnComprar4.Click
        If Hombre Then
            PictureBox1.Image = ilHombres.Images.Item(3)
            lblPrecio.Text = "$ 70"
        ElseIf Mujer Then
            PictureBox1.Image = ilMujeres.Images.Item(3)
            lblPrecio.Text = "$ 270"
        ElseIf Calzado Then
            PictureBox1.Image = ilCalzado.Images.Item(3)
            lblPrecio.Text = "$ 80"
        ElseIf Accesorio Then
            PictureBox1.Image = ilAccesorio.Images.Item(3)
            lblPrecio.Text = "$ 50"
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim Mensaje As New MensajeDeCompra
        Mensaje.Show()
    End Sub

    Private Sub btnFlecha32_Click(sender As Object, e As EventArgs) Handles btnFlecha32.Click
        If CInt(lblCant3.Text) >= 0 Then
            If CInt(lblCant3.Text) <= 8 Then
                If Hombre Then
                    C3 = C3 + 1
                    lblCant3.Text = CStr(C3)
                    Total = Total + 160
                ElseIf Mujer Then
                    M3 = M3 + 1
                    lblCant3.Text = CStr(M3)
                    Total = Total + 220
                ElseIf Calzado Then
                    Z3 = Z3 + 1
                    lblCant3.Text = CStr(Z3)
                    Total = Total + 160
                ElseIf Accesorio Then
                    A3 = A3 + 1
                    lblCant3.Text = CStr(A3)
                    Total = Total + 190
                End If
            Else
                Total = Total
            End If
            lblTotal.Text = "$" & CStr(Total)
            End If
    End Sub

    Private Sub btnFlecha41_Click(sender As Object, e As EventArgs) Handles btnFlecha41.Click
        If CInt(lblCant4.Text) > 0 Then
            If Hombre Then
                C4 = C4 - 1
                lblCant4.Text = CStr(C4)
                Total = Total - 70
            ElseIf Mujer Then
                M4 = M4 - 1
                lblCant4.Text = CStr(M4)
                Total = Total - 270
            ElseIf Calzado Then
                Z4 = Z4 - 1
                lblCant4.Text = CStr(Z4)
                Total = Total - 80
            ElseIf Accesorio Then
                A4 = A4 - 1
                lblCant4.Text = CStr(A4)
                Total = Total - 50
            End If
            lblTotal.Text = "$" & CStr(Total)
        Else
            If Hombre Then
                If C2 = 0 AndAlso C3 = 0 AndAlso C1 = 0 AndAlso M1 = 0 AndAlso M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    C4 = C4
                    lblCant4.Text = CStr(C4)
                    lblTotal.Text = "$ 0"
                Else
                    C4 = C4
                    lblCant4.Text = CStr(C4)
                End If
            ElseIf Mujer Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M1 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    M4 = M4
                    lblCant4.Text = CStr(M4)
                    lblTotal.Text = "$ 0"
                Else
                    M4 = M4
                    lblCant4.Text = CStr(M4)
                End If
            ElseIf Calzado Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso M1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z1 = 0 AndAlso A1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A4 = 0 Then
                    Z4 = Z4
                    lblCant4.Text = CStr(Z4)
                    lblTotal.Text = "$ 0"
                Else
                    Z4 = Z4
                    lblCant4.Text = CStr(Z4)
                End If
            ElseIf Accesorio Then
                If M2 = 0 AndAlso M3 = 0 AndAlso M4 = 0 AndAlso C1 = 0 AndAlso C2 = 0 AndAlso C3 = 0 AndAlso C4 = 0 AndAlso Z1 = 0 AndAlso Z2 = 0 AndAlso Z3 = 0 AndAlso Z4 = 0 AndAlso M1 = 0 AndAlso A2 = 0 AndAlso A3 = 0 AndAlso A1 = 0 Then
                    A4 = A4
                    lblCant4.Text = CStr(A4)
                    lblTotal.Text = "$ 0"
                Else
                    A4 = A4
                    lblCant4.Text = CStr(A4)
                End If
            End If
        End If
    End Sub

    Private Sub btnFlecha42_Click(sender As Object, e As EventArgs) Handles btnFlecha42.Click
        If CInt(lblCant4.Text) >= 0 Then
            If CInt(lblCant4.Text) <= 8 Then
                If Hombre Then
                    C4 = C4 + 1
                    lblCant4.Text = CStr(C4)
                    Total = Total + 70
                ElseIf Mujer Then
                    M4 = M4 + 1
                    lblCant4.Text = CStr(M4)
                    Total = Total + 270
                ElseIf Calzado Then
                    Z4 = Z4 + 1
                    lblCant4.Text = CStr(Z4)
                    Total = Total + 80
                ElseIf Accesorio Then
                    A4 = A4 + 1
                    lblCant4.Text = CStr(A4)
                    Total = Total + 50
                End If
            Else
                Total = Total
            End If
            lblTotal.Text = "$" & CStr(Total)
            End If
    End Sub

    Private Sub btnFlecha12_Click(sender As Object, e As EventArgs) Handles btnFlecha12.Click
        If CInt(lblCant1.Text) >= 0 Then
            If CInt(lblCant1.Text) <= 8 Then
                If Hombre Then
                    C1 = C1 + 1
                    lblCant1.Text = CStr(C1)
                    Total = Total + 120
                ElseIf Mujer Then
                    M1 = M1 + 1
                    lblCant1.Text = CStr(M1)
                    Total = Total + 80
                ElseIf Calzado Then
                    Z1 = Z1 + 1
                    lblCant1.Text = CStr(Z1)
                    Total = Total + 120
                ElseIf Accesorio Then
                    A1 = A1 + 1
                    lblCant1.Text = CStr(A1)
                    Total = Total + 380
                End If
            Else
                Total = Total
            End If
            lblTotal.Text = "$" & CStr(Total)
        End If
    End Sub
    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click
        Hombre = True
        Mujer = False
        Calzado = False
        Accesorio = False
        'CAMBIAMOS A COLOR NEGRO SOLO LA CATEGORIA EN LA QUE SE ENCUENTRA
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.SteelBlue
        'HACEMOS  QUE SOLO SE MUESTRE LAS UNIDADES DE ESTA CATEGORIA PERO EL TOTAL
        'SIGUE ACUMULANDOSE
        lblCant1.Text = CStr(C1)
        lblCant2.Text = CStr(C2)
        lblCant3.Text = CStr(C3)
        lblCant4.Text = CStr(C4)
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA HOMBRES, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilHombres.Images.Item(0)
        'COLOR DE LAS TALLAS 
        lblTalla1.Text = "XS"
        lblTalla1.ForeColor = Color.Black
        lblTalla2.Text = "S"
        lblTalla2.ForeColor = Color.Black
        lblTalla3.Text = "M"
        lblTalla3.ForeColor = Color.Black
        lblTalla4.Text = "L"
        lblTalla4.ForeColor = Color.Black
        lblTalla5.Text = "XL"
        lblTalla5.ForeColor = Color.Black
        'INFORMACION DE LOS ARTICULOS
        lblPrecio.Text = "$ 120"
        lblCamisaDeAlgodon.Text = "Camisa de Algodón"
        lblPrecioCamisaAlgodon.Text = "$ 120"

        lblBlazer.Text = "Blazer Mezcla de Lana"
        lblPrecioBlazer.Text = "$ 240"

        lblJersey.Text = "Jersey Cuello Pico"
        lblPrecioJersey.Text = "$ 160"

        lblPolo.Text = "Polo Cuello Redondo"
        lblPrecioPolo.Text = "$ 70"
    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        Hombre = False
        Mujer = True
        Calzado = False
        Accesorio = False
        'CAMBIAMOS A COLOR NEGRO SOLO LA CATEGORIA EN LA QUE SE ENCUENTRA
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.SteelBlue
        'HACEMOS  QUE SOLO SE MUESTRE LAS UNIDADES DE ESTA CATEGORIA PERO EL TOTAL
        'SIGUE ACUMULANDOSE
        lblCant1.Text = CStr(M1)
        lblCant2.Text = CStr(M2)
        lblCant3.Text = CStr(M3)
        lblCant4.Text = CStr(M4)
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA MUJERES, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilMujeres.Images.Item(0)
        'COLOR DE LAS TALLAS 
        lblTalla1.Text = "XS"
        lblTalla1.ForeColor = Color.Gray
        lblTalla2.Text = "S"
        lblTalla2.ForeColor = Color.Black
        lblTalla3.Text = "M"
        lblTalla3.ForeColor = Color.Black
        lblTalla4.Text = "L"
        lblTalla4.ForeColor = Color.Black
        lblTalla5.Text = "XL"
        lblTalla5.ForeColor = Color.Gray
        'INFORMACION DE LOS ARTICULOS
        lblPrecio.Text = "$ 80"
        lblCamisaDeAlgodon.Text = "Polo Rayas Cuello Redondo"
        lblPrecioCamisaAlgodon.Text = "$ 80"

        lblBlazer.Text = "Chompa Lana Cuello Redondo"
        lblPrecioBlazer.Text = "$ 150"

        lblJersey.Text = "Casaca de Jean"
        lblPrecioJersey.Text = "$ 220"

        lblPolo.Text = "Abrigo Mezcla Lana"
        lblPrecioPolo.Text = "$ 270"
    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click
        Hombre = False
        Mujer = False
        Calzado = True
        Accesorio = False
        'CAMBIAMOS A COLOR NEGRO SOLO LA CATEGORIA EN LA QUE SE ENCUENTRA
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.SteelBlue
        'HACEMOS  QUE SOLO SE MUESTRE LAS UNIDADES DE ESTA CATEGORIA PERO EL TOTAL
        'SIGUE ACUMULANDOSE
        lblCant1.Text = CStr(Z1)
        lblCant2.Text = CStr(Z2)
        lblCant3.Text = CStr(Z3)
        lblCant4.Text = CStr(Z4)
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA CALZADOS, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilCalzado.Images.Item(0)
        'COLOR DE LAS TALLAS 
        lblTalla1.Text = "38"
        lblTalla1.ForeColor = Color.Black
        lblTalla2.Text = "39"
        lblTalla2.ForeColor = Color.Black
        lblTalla3.Text = "40"
        lblTalla3.ForeColor = Color.Black
        lblTalla4.Text = "42"
        lblTalla4.ForeColor = Color.Black
        lblTalla5.Text = "44"
        lblTalla5.ForeColor = Color.Black
        'INFORMACION DE LOS ARTICULOS
        lblPrecio.Text = "$ 120"
        lblCamisaDeAlgodon.Text = "Zapatos Oxfords"
        lblPrecioCamisaAlgodon.Text = "$ 120"

        lblBlazer.Text = "Zapatos Derby"
        lblPrecioBlazer.Text = "$ 140"

        lblJersey.Text = "Botines"
        lblPrecioJersey.Text = "$ 160"

        lblPolo.Text = "Loafers"
        lblPrecioPolo.Text = "$ 80"
    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        Hombre = False
        Mujer = False
        Calzado = False
        Accesorio = True
        'CAMBIAMOS A COLOR NEGRO SOLO LA CATEGORIA EN LA QUE SE ENCUENTRA
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black
        'HACEMOS  QUE SOLO SE MUESTRE LAS UNIDADES DE ESTA CATEGORIA PERO EL TOTAL
        'SIGUE ACUMULANDOSE
        lblCant1.Text = CStr(A1)
        lblCant2.Text = CStr(A2)
        lblCant3.Text = CStr(A3)
        lblCant4.Text = CStr(A4)
        'MOSTRAMOS LA PRIMERA IMAGEN DE LA CATEGORIA CALZADOS, EL RESTO SOLO CAMBIARÁ
        'LA INFORMACIÓN
        PictureBox1.Image = ilAccesorio.Images.Item(0)
        'COLOR DE LAS TALLAS 
        lblTalla1.Text = "XS"
        lblTalla1.ForeColor = Color.Black
        lblTalla2.Text = "S"
        lblTalla2.ForeColor = Color.Gray
        lblTalla3.Text = "M"
        lblTalla3.ForeColor = Color.Black
        lblTalla4.Text = "L"
        lblTalla4.ForeColor = Color.Black
        lblTalla5.Text = "XL"
        lblTalla5.ForeColor = Color.Gray
        'INFORMACION DE LOS ARTICULOS
        lblPrecio.Text = "$ 380"
        lblCamisaDeAlgodon.Text = "Reloj de Acero"
        lblPrecioCamisaAlgodon.Text = "$ 380"

        lblBlazer.Text = "Cinturon de Cuero"
        lblPrecioBlazer.Text = "$ 70"

        lblJersey.Text = "Billetera de Cuero"
        lblPrecioJersey.Text = "$ 190"

        lblPolo.Text = "Gorra Clasica"
        lblPrecioPolo.Text = "$ 50"
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnHombres.ForeColor = Color.Black
        'Musica()
        ttCategorias.SetToolTip(Me.btnHombres, "Categoría de Artículos para Hombres")
        ttCategorias.SetToolTip(Me.btnMujeres, "Categoría de Artículos para Mujeres")
        ttCategorias.SetToolTip(Me.btnCalzado, "Categoría de Artículos para Calzados")
        ttCategorias.SetToolTip(Me.btnAccesorios, "Categoría de Artículos para Accesorios")
        'COLOR DE LAS TALLAS 
        lblTalla1.Text = "XS"
        lblTalla1.ForeColor = Color.Black
        lblTalla2.Text = "S"
        lblTalla2.ForeColor = Color.Black
        lblTalla3.Text = "M"
        lblTalla3.ForeColor = Color.Black
        lblTalla4.Text = "L"
        lblTalla4.ForeColor = Color.Black
        lblTalla5.Text = "XL"
        lblTalla5.ForeColor = Color.Black

    End Sub
    'Private Sub Musica()
    '    My.Computer.Audio.Play("K:\.Trashes\Cursos\VisualBasic\visual162-p01shoppingcart-start-master\p01shoppingcart\MusicaFondo\The_Scientist.wav",
    '    AudioPlayMode.WaitToComplete)
    '    My.Computer.Audio.Play("K:\.Trashes\Cursos\VisualBasic\visual162-p01shoppingcart-start-master\p01shoppingcart\MusicaFondo\Like_A_Stone.wav",
    '    AudioPlayMode.WaitToComplete)
    'End Sub
End Class