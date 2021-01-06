using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Connection : IConnection
    {
        private string _password="Kek";
        public  bool Status;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public Connection(string password)
        {
            this._password = password;
        }
        public void Open(string password)
        {
            if (this.Status == false)
            {
                this.Status = true;
                Console.WriteLine("Connection is open");
            }
            else if (this.Status == true)
            {
                Console.WriteLine("The connection is already open!");
            }
        }
        public void Close(string password)
        {
            if (this.Status == true)
            {
                this.Status = false;
                Console.WriteLine("Connection is close");
            }
            else if (this.Status == false)
            {

                throw new AnAttemptToCloseAnUnopenedConnectionException();
            }
        }
      
    }
}
