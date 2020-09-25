using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace AddressBookTestsWhite.appmanager
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";
    
        private GroupHelper groupHelper;

        public Window MainWindow { get; private set; }
        public ApplicationManager()
        {
            Application app = Application.Launch(@"e:\lern\C#_For_Toster\Distr\FreeAddressBookPortable\AddressBook.exe");
            MainWindow = app.GetWindow(WINTITLE);
            groupHelper = new GroupHelper(this);
        }

        public void Stop()
        {
            MainWindow.Get<Button>("uxExitAddressButton").Click();
        }
        
        public GroupHelper Groups
        {
            get { return groupHelper; }
        }
    }
}
