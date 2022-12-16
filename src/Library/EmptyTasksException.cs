namespace System;
/// <summary>
/// Clase que representa una excepción de tareas vacías.
/// </summary>
public class EmptyTasksException : Exception
{
    /// <summary>
    /// Constructor de la clase EmptyTasksException.
    /// </summary>
    public EmptyTasksException(string mensaje) : base (mensaje)
    {
        
    }
}