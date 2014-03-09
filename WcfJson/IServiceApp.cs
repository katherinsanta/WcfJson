using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfJson
{   
    [ServiceContract]
    public interface IServiceApp
    {
        [WebInvoke(Method = "GET",UriTemplate = "/ObtenerPersonas",
            ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<Persona> ObtenerPersonas();

        [WebInvoke(Method = "GET", UriTemplate = "/ObtenerPersona?id={id}", 
            ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        Persona ObtenerPersona(int id);

        [WebInvoke(UriTemplate = "ActualizarPersona", 
            BodyStyle = WebMessageBodyStyle.WrappedRequest, 
            ResponseFormat = WebMessageFormat.Json, 
            RequestFormat = WebMessageFormat.Json, 
            Method = "POST")]
        [OperationContract]
        bool ActualizarPersona(Persona dto);

    }
}
