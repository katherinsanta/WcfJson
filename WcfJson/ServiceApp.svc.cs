using System.Collections.Generic;

namespace WcfJson
{
    public class ServiceApp : IServiceApp
    {        
        List<Persona> personas = new List<Persona>(){ 
                new Persona(){ 
                    Id=1, 
                    Apellidos="Sanchez",  
                    Nombres="Luis", 
                    Identificacion=12345},

                new Persona(){ 
                    Id=2, 
                    Apellidos="Martinez",  
                    Nombres="Carlos", 
                    Identificacion=2345}
        };

        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

        public Persona ObtenerPersona(int id)
        {
            // Simulamos la consulta a la base de datos
            return personas.Find(x => x.Id == id);
        }

        public bool ActualizarPersona(Persona dto)
        {
            /*Aquí tus operaciones crud*/
            return true;
        }
    }
}
