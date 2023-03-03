Public Interface iRepositorioCiudades : Inherits iRepositorioGenerico(Of Ciudades)
    Function ObtenerCiudad(ByVal CP As Int16) As Ciudades
    Function GetAllByProvincia(pkProvincia As Integer) As IEnumerable(Of Ciudades)

End Interface
