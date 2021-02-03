using Psychostasia.Web.ElementSearch;
using System.Collections.ObjectModel;

namespace Psychostasia.Web.DriverClasses
{
    public interface IDriver : IFinder
    {
        public string Url { get; }

        public string Title { get; }

        public string PageSource { get; }

        public string CurrentWindowHandle { get; }

        public ReadOnlyCollection<string> WindowHandles { get; }

        public void Close();


        public void Dispose();

        public void GoTo(string url);







        public void Quit();



    }
}
