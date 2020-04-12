using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Covid19Feeds.Models;
using Covid19Feeds.Services;
using WantToWork.Helpers;
using Xamarin.Forms;
using System.Linq;

namespace Covid19Feeds.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public Command<string> ChangeTabCommand { get; set; }
        public Command CVSelectionCommand { get; set; }
        public DashboardViewModel()
        {
            ChangeTabCommand = new Command<string>((input) => ChangeTabs(input));
            CVSelectionCommand = new Command(()=>CVSelection());
            IsHeaderImageVisible = true;
        }

        private void CVSelection()
        {
            //var x = input;
        }

        private string tabIcon1 { get; set; } = "ic_tab1unselected.png";
        public string TabIcon1
        {
            get { return tabIcon1; }
            set
            {
                tabIcon1 = value;
                NotifyChage();
            }
        }


        private string tabIcon2 { get; set; } = "ic_tab2unselected.png";
        public string TabIcon2
        {
            get { return tabIcon2; }
            set
            {
                tabIcon2 = value;
                NotifyChage();
            }
        }



        private string tabIcon3 { get; set; } = "ic_tab3unselected.png";
        public string TabIcon3
        {
            get { return tabIcon3; }
            set
            {
                tabIcon3 = value;
                NotifyChage();
            }
        }

        private double scalevalue { get; set; } = 0.8;
        public double Scalevalue
        {
            get { return scalevalue; }
            set
            {
                scalevalue = value;
                NotifyChage();
            }
        }

        private double scalevalue1 { get; set; } = 0.8;
        public double Scalevalue1
        {
            get { return scalevalue1; }
            set
            {
                scalevalue1 = value;
                NotifyChage();
            }
        }


        private double scalevalue2 { get; set; } = 0.8;
        public double Scalevalue2
        {
            get { return scalevalue2; }
            set
            {
                scalevalue2 = value;
                NotifyChage();
            }
        }



        private bool isDashboardVisible { get; set; } = true;
        public bool IsDashboardVisible
        {
            get { return isDashboardVisible; }
            set
            {
                isDashboardVisible = value;
                NotifyChage();
            }
        }

        private bool isCountriesVisible { get; set; }
        public bool IsCountriesVisible
        {
            get { return isCountriesVisible; }
            set
            {
                isCountriesVisible = value;
                NotifyChage();
            }
        }


        private bool isAboutVisible { get; set; }
        public bool IsAboutVisible
        {
            get { return isAboutVisible; }
            set
            {
                isAboutVisible = value;
                NotifyChage();
            }
        }

        private string pageTitle { get; set; } = "Covid-19 Feeds";
        public string PageTitle
        {
            get { return pageTitle; }
            set
            {
                pageTitle = value;
                NotifyChage();
            }
        }

        private string headerImage { get; set; }
        public string HeaderImage
        {
            get { return headerImage; }
            set
            {
                headerImage = value;
                NotifyChage();
            }
        }

        private bool isHeaderImageVisible { get; set; }
        public bool IsHeaderImageVisible
        {
            get { return isHeaderImageVisible; }
            set
            {
                isHeaderImageVisible = value;
                NotifyChage();
            }
        }


        private bool shouldMoveTitleToLeft { get; set; } = false;
        public bool ShouldMoveTitleToLeft
        {
            get { return shouldMoveTitleToLeft; }
            set
            {
                shouldMoveTitleToLeft = value;
                NotifyChage();
            }
        }

        private void ChangeTabs(string CommandParam)
        {
            switch (CommandParam)
            {
                case "dashboard":
                    TabIcon1 = "ic_tab1selected.png";
                    TabIcon2 = "ic_tab2unselected.png";
                    TabIcon3 = "ic_tab3unselected.png";
                    Scalevalue = 1;
                    Scalevalue1 = 0.8;
                    Scalevalue2 = 0.8;
                    IsDashboardVisible = true;
                    IsAboutVisible = false;
                    IsCountriesVisible = false;
                    HeaderImage = "https://cdn2.iconfinder.com/data/icons/covid-19-solid/64/virus-06-512.png";
                    PageTitle = "Covid-19 Feeds";
                    ShouldMoveTitleToLeft = false;
                    IsHeaderImageVisible = true;
                    break;
                case "countires":
                    TabIcon1 = "ic_tab1unselected.png";
                    TabIcon2 = "ic_tab2selected.png";
                    TabIcon3 = "ic_tab3unselected.png";
                    IsDashboardVisible = false;
                    IsAboutVisible = false;
                    IsCountriesVisible = true;
                    Scalevalue = 0.8;
                    Scalevalue1 = 1;
                    Scalevalue2 = 0.8;
                    HeaderImage = "https://cdn0.iconfinder.com/data/icons/small-n-flat/24/678111-map-marker-512.png";
                    PageTitle = "Countries";
                    ShouldMoveTitleToLeft = false;
                    IsHeaderImageVisible = false;
                    break;
                case "about":
                    TabIcon1 = "ic_tab1unselected.png";
                    TabIcon2 = "ic_tab2unselected.png";
                    TabIcon3 = "ic_tab3selected.png";
                    IsDashboardVisible = false;
                    IsAboutVisible = true;
                    IsCountriesVisible = false;
                    Scalevalue = 0.8;
                    Scalevalue1 = 0.8;
                    Scalevalue2 = 1;
                    PageTitle = "About";
                    HeaderImage = "http://files.softicons.com/download/system-icons/phuzion-icons-by-kyo-tux/png/256/Info.png";
                    ShouldMoveTitleToLeft = false;
                    IsHeaderImageVisible = false;
                    break;


            }
        }




        private GlobalCaseModel _globalCaseDataModel { get; set; }
        public GlobalCaseModel GlobalCaseDataModel
        {
            get { return _globalCaseDataModel; }
            set
            {
                _globalCaseDataModel = value;
                NotifyChage();
            }
        }

        public async Task LoadGlobalCases()
        {
            try
            {
                IsBusy = true;
                var res = await RestClient.RestClientInstance.GetAsync<GlobalCaseModel>(AppConstants.LoadGlobalCasesAPi);
                if (res != null)
                {
                    GlobalCaseDataModel = res;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                IsBusy = false;

            }
        }



        private List<AllCountriesCasesModel> _globalCountryCaseDataModel { get; set; }
        public List<AllCountriesCasesModel> GlobalCountryCaseDataModel
        {
            get { return _globalCountryCaseDataModel; }
            set
            {
                _globalCountryCaseDataModel = value;
                NotifyChage();
            }
        }


        private List<AllCountriesCasesModel> _topInfectedCountries { get; set; }
        public List<AllCountriesCasesModel> TopInfectedCountries
        {
            get { return _topInfectedCountries; }
            set
            {
                _topInfectedCountries = value;
                NotifyChage();
            }
        }


        private List<AllCountriesCasesModel> _seletedItem { get; set; }
        public List<AllCountriesCasesModel> SeletedItem
        {
            get { return _seletedItem; }
            set
            {
                _seletedItem = value;
                NotifyChage();
            }
        }

        public async Task LoadAllCountryCases()
        {
            try
            {
                IsBusy = true;
                var res = await RestClient.RestClientInstance.GetAsync<List<AllCountriesCasesModel>>(AppConstants.LoadAllCountryCasesAPi);
                if (res != null)
                {
                    GlobalCountryCaseDataModel = res;
                    TopInfectedCountries= res.OrderByDescending(x=>x.cases).Take(5).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                IsBusy = false;

            }
        }
    }
}
