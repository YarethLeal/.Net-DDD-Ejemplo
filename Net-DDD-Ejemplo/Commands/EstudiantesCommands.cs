namespace Net_DDD_Ejemplo.Commands
{
    public record CreateEstudiantesCommands(Guid estudianteId,string Carnet,string Nombre,string Apellido,int Edad,double Ponderado);
}
