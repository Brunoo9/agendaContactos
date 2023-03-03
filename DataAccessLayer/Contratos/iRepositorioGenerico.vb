Public Interface iRepositorioGenerico(Of Entity As Class)
    Function Add(ByVal Entidad As Entity) As Int16
    Function Edit(ByVal Entidad As Entity) As Int16
    Function Remove(ByVal CP As Int16) As Int16
    Function GetAll() As IEnumerable(Of Entity)
End Interface
