Public Module Program
    Public Sub Main(args() As String)
        Dim perrito As Perro = New Perro()
        perrito.nombre = "chizu"
        perrito.raza = "Pastor Alem�n"
        perrito.altura = "0.70cm"
        Console.WriteLine(perrito.comer("carne"))

        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "Lasy"
        perrito2.altura = "0.60cm"
        Console.WriteLine(perrito2.comer("pollo"))

        Dim perrito3 As Perro = New Perro("Peluchin", "Poodle", "0.50")
        Console.WriteLine(perrito3.comer("Pan"))
    End Sub
End Module
