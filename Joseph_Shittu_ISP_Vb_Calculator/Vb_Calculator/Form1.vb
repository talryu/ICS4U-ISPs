Public Class Form1
	'For temperature menustrip
	Dim iCelsius, iFahrenheit, iKelvinC, ikelvinF As Double
	Dim iOperation As String
	'For multiplication table menustrip
	Dim NumToMultiply As Integer = 0

	Dim firstnum As Double
	Dim secondnum As Double
	Dim amswer As Double
	Dim Opera As String
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Width = 263
		Txtdisplay.Width = 230
		Me.Text = "Standard Calculator"

		'For the conversion menu
		cmbconUnit.Text = "Choose One ...."
		cmbconUnit.Items.Add("Miles to Kilometres")
		cmbconUnit.Items.Add("Metre to Kilometres")
		cmbconUnit.Items.Add("Metres to Centimetres")
		cmbconUnit.Items.Add("Metres to Millimetre")
		'cmbconUnit.Items.Add("Kilometres to Metre")
		'cmbconUnit.Items.Add("Kilometres to Miles")
		'cmbconUnit.Items.Add("Centimetres to Metres")
		'cmbconUnit.Items.Add("Millimetre to Metres")
		'For switching the three group box
		GroupBox1.Visible = False
		GroupBox3.Visible = False
		GroupBox4.Visible = False
	End Sub

	Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
		Me.Width = 520
		Txtdisplay.Width = 473
		Me.Text = "Scientific Calculator"
	End Sub

	Private Sub TemperatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemperatureToolStripMenuItem.Click
		Me.Width = 841
		Txtdisplay.Width = 473
		Me.Text = "Temperature Conversion"
		GroupBox1.Location = New Point(507, 30)
		GroupBox1.Width = 300
		GroupBox1.Height = 277

		'For switching the three group box
		GroupBox1.Visible = True
		GroupBox3.Visible = False
		GroupBox4.Visible = False
	End Sub
	Private Sub Radceltofah_CheckedChanged(sender As Object, e As EventArgs) Handles Radceltofah.CheckedChanged
		iOperation = "C"
	End Sub

	Private Sub Radfahtocel_CheckedChanged(sender As Object, e As EventArgs) Handles Radfahtocel.CheckedChanged
		iOperation = "F"
	End Sub

	Private Sub Radceltokel_CheckedChanged(sender As Object, e As EventArgs) Handles Radceltokel.CheckedChanged
		iOperation = "CK"
	End Sub
	Private Sub Radfahtokel_Click(sender As Object, e As EventArgs) Handles Radfahtokel.Click
		iOperation = "FK"
	End Sub

	Private Sub Btnconvert_Click(sender As Object, e As EventArgs) Handles Btntempconvert.Click

		Select Case (iOperation)
			Case "C"
				'Celsius to Fahrenheit
				iCelsius = Double.Parse(textvalueconvert.Text)
				lbltempresult.Text = ((9 * iCelsius / 5) + 32).ToString() & " " & "F"

			Case "F"
				'Fahrenheit to Celsius
				iFahrenheit = Double.Parse(textvalueconvert.Text)
				lbltempresult.Text = (((iFahrenheit - 32) * 5) / 9).ToString() & " " & "C"

			Case "CK"
				'Convert Celsius to Kelvin
				iKelvinC = Double.Parse(textvalueconvert.Text)
				lbltempresult.Text = (iKelvinC + (271.3)).ToString() & " " & "K"

			Case "FK"
				'Fahrenheit to Kelvin
				ikelvinF = Double.Parse(textvalueconvert.Text)
				lbltempresult.Text = ((ikelvinF - 32) * 5 / 9 + 273.15).ToString() & " " & "K"
		End Select
	End Sub
	Private Sub Btnconvertreset_Click(sender As Object, e As EventArgs) Handles Btnconvertreset.Click
		textvalueconvert.Clear()
		lbltempresult.Text = ""
		Radceltofah.Checked = False
		Radceltokel.Checked = False
		Radfahtocel.Checked = False
		Radfahtokel.Checked = False

	End Sub


	Private Sub MultiplicationTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicationTableToolStripMenuItem.Click
		Me.Width = 841
		Txtdisplay.Width = 473
		Me.Text = "Multiplication Table"
		GroupBox3.Location = New Point(507, 30)
		GroupBox3.Width = 300
		GroupBox3.Height = 277

		'For switching the three group box
		GroupBox1.Visible = False
		GroupBox3.Visible = True
		GroupBox4.Visible = False


	End Sub

	Private Sub Btnmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmultiply.Click
		Do While (NumToMultiply <= 25)
			lstmultiply.Items.Add(NumToMultiply & " * " & Val(Me.txtmultiply.Text) & " = " & NumToMultiply * Val(Me.txtmultiply.Text))
			NumToMultiply += 1
			lstmultiply.Refresh()
		Loop
	End Sub
	Private Sub Btnmultiplyreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmultiplyreset.Click
		lstmultiply.Items.Clear()
		lstmultiply.Refresh()
		txtmultiply.Text = " "
		NumToMultiply = 1
	End Sub



	Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConversionToolStripMenuItem.Click
		Me.Width = 841
		Txtdisplay.Width = 473
		Me.Text = "Unit Conversion"
		GroupBox4.Location = New Point(507, 30)
		GroupBox4.Width = 300
		GroupBox4.Height = 277

		'For switching the three group box
		GroupBox1.Visible = False
		GroupBox3.Visible = False
		GroupBox4.Visible = True

	End Sub




	Private Sub Btnunitconvert_Click(sender As Object, e As EventArgs) Handles Btnunitconvert.Click

		'Code for Unit Conversion
		Dim convt As Double
		If cmbconUnit.Text = "Miles to Kilometres" Then
			convt = (txtconUnit.Text * 1.60934)
			lblconunit.Text = convt & " " & "Kilometres"
		ElseIf cmbconUnit.Text = "Kilometres To Miles" Then
			convt = (txtconUnit.Text / 1.60934)
			lblconunit.Text = convt & " " & "Miles"
		ElseIf cmbconUnit.Text = "Metre to Kilometres" Then
			convt = (txtconUnit.Text * 0.001)
			lblconunit.Text = convt & " " & "Kilometres"
		ElseIf cmbconUnit.Text = "Metres to Centimetres" Then
			convt = (txtconUnit.Text * 100)
			lblconunit.Text = convt & " " & "Centimetres"
		ElseIf cmbconUnit.Text = "Metres to Millimetres" Then
			convt = ((txtconUnit.Text * 10) * 100)
			lblconunit.Text = convt & " " & "Millimetre"
		ElseIf cmbconUnit.Text = "Choose One ...." Or txtconUnit.Text = "" Then
			MessageBox.Show("Select a Unit of Conversion", "Unit Conversion", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If


	End Sub
	Private Sub Btnunitclear_Click(sender As Object, e As EventArgs) Handles Btnunitclear.Click
		txtconUnit.Clear()
		lblconunit.Text = ""
		cmbconUnit.Text = "Choose One ...."

	End Sub

End Class
