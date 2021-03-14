////////////////////////////////////////////////////////////////////////////
// Date             Developer          
// 2021-03-12      Yahya Mirzaei 


using System;

namespace ContosoUniversity.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); 
        //tinfo200:[2021-03-13-yahyam2-dykstra1] - verify ID
    }
}
