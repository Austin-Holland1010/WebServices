using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CSE445_Project3_Assignment5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string WordFilter(string s);

        [OperationContract]
        string Stemming(string s);

        //Elective services

        [OperationContract]
        string String_Sort(string s, int sortingMethod);

        [OperationContract]
        int CharacterCounter(string s);

        [OperationContract]
        bool Password(string s);
        [OperationContract]
        string Upper_Lower_DoubleSpace(string s, int action);
    }
}
