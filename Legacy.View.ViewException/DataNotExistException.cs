using System;

namespace Legacy.View.ViewException
{
    [Serializable()]
    public class DataNotExistException : Exception
    {
        public DataNotExistException()
        {
            this.Data["Message"] = "Data Not Found";
            this.Data["StatusCode"] = "400";
        }
    }
}