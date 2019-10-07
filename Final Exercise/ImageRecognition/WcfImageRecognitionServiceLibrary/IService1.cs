using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfImageRecognitionServiceLibrary
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IRecognitor
    {
        [OperationContract]
        int GetTriangles(byte[] img);

        [OperationContract]
        int GetBlobs(byte[] img);

        [OperationContract]
        int GetCircles(byte[] img);

        [OperationContract]
        int GetQuadrilaterals(byte[] img);
    }
}
