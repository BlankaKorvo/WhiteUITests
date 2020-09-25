using System;
namespace AddressBookTestsWhite.appmanager
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected HelperBase(ApplicationManager manager)
        {
            this.manager = manager;      
        }        
    }
}