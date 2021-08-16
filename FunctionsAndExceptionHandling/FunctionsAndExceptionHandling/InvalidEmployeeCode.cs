using System;


namespace FunctionsAndExceptionHandling
{
    //  This program demo. how to create User defined Exception
    class InvalidEmployeeCode:Exception
    {
        //  Created Constructor by invoking base class constructor
        public InvalidEmployeeCode():base ("Invalid Employee Code")
        {

        }
    }
}
