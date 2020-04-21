using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Covid19Feeds.Models;
using Covid19Feeds.Services;
using WantToWork.Helpers;
using Xamarin.Forms;
using System.Linq;
using Covid19Feeds.Views;
using Covid19Feeds.Helpers;
using Xamarin.Essentials;

namespace Covid19Feeds.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {

        #region Field Variables

        public string Longitude { get; private set; }
        public string Latitude { get; private set; }


        public Command FoodShelterCommand { get; set; }

        public Command AboutMeCommand { get; set; }
        public Command<string> ChangeTabCommand { get; set; }
        public Command MyCountryDetailsCommand { get; set; }
        public Command<string> SendMailCommand { get; set; }
        public Command<string> ShareAppCommand { get; set; }
        public Command ViewAllCommand { get; set; }
        public Command CVSelectionCommand { get; set; }
        public Command SettingTappedCommand { get; set; }
        public event EventHandler ItemSelectionHandler;
        #endregion


        #region Constructors

        public DashboardViewModel()
        {
            FoodShelterCommand = new Command(()=> { DependencyService.Get<IOpenMap>().OpenMap(); });
               //AboutMeCommand = new Command(async () => await NavigateToAboutMePage());
               SendMailCommand = new Command<string>(async (input) => await SendEmailAboutFeedback(input));
            ShareAppCommand = new Command<string>(async (input) => await ShareAppLink(input));
            ChangeTabCommand = new Command<string>((input) => ChangeTabs(input));
            CVSelectionCommand = new Command(async () => await CVSelection());
            SettingTappedCommand = new Command(async () => await SettingTapped());
            ViewAllCommand = new Command(() => ViewAllCountries());
            MyCountryDetailsCommand = new Command(async () => await NavigateToMyCovidDetailsPage());
            IsHeaderImageVisible = true;
        }

        private async Task SendEmailAboutFeedback(string input)
        {
            await SendEmail("COVID-19 Feeds Feedback", "", new List<string>() { "reachkirankumarb@gmail.com" });
        }
        #endregion



        #region Getter Setters

        private string tabIcon1
        { get; set; } = "ic_tab1unselected.png";
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

        private string tabIcon4 { get; set; } = "ic_tab4unselected.png";
        public string TabIcon4
        {
            get { return tabIcon4; }
            set
            {
                tabIcon4 = value;
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


        private double scalevalue3 { get; set; } = 0.8;
        public double Scalevalue3
        {
            get { return scalevalue3; }
            set
            {
                scalevalue3 = value;
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

        private bool isMapsVisible { get; set; }
        public bool IsMapsVisible
        {
            get { return isMapsVisible; }
            set
            {
                isMapsVisible = value;
                NotifyChage();
            }
        }

        private string mapUrl { get; set; }
        public string MapUrl
        {
            get { return mapUrl; }
            set
            {
                mapUrl = value;
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

        private AllCountriesCasesModel _seletedItem { get; set; }
        public AllCountriesCasesModel SeletedItem
        {
            get { return _seletedItem; }
            set
            {
                _seletedItem = value;
                NotifyChage();
            }
        }


        private AllCountriesCasesModel currentDefaultCountry { get; set; }
        public AllCountriesCasesModel CurrentDefaultCountry
        {
            get { return currentDefaultCountry; }
            set
            {
                currentDefaultCountry = value;
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


        private List<AllCountriesCasesModel> _searchedList { get; set; }
        public List<AllCountriesCasesModel> SearchedList
        {
            get { return _searchedList; }
            set
            {
                _searchedList = value;
                NotifyChage();
            }
        }

        private bool isNoResultLabelVisilbe { get; set; }
        public bool IsNoResultLabelVisilbe
        {
            get { return isNoResultLabelVisilbe; }
            set
            {
                isNoResultLabelVisilbe = value;
                NotifyChage();
            }
        }





        #endregion




        #region Functions

        private void ViewAllCountries()
        {
            TabIcon1 = "ic_tab1unselected.png";
            TabIcon2 = "ic_tab2selected.png";
            TabIcon3 = "ic_tab3unselected.png";
            TabIcon4 = "ic_tab4unselected.png";
            IsDashboardVisible = false;
            IsAboutVisible = false;
            IsCountriesVisible = true;
            IsMapsVisible = false;
            Scalevalue = 0.8;
            Scalevalue1 = 1;
            Scalevalue2 = 0.8;
            Scalevalue2 = 0.8;
            // HeaderImage = "https://cdn0.iconfinder.com/data/icons/small-n-flat/24/678111-map-marker-512.png";
            // headerImage = "https://cdn3.iconfinder.com/data/icons/coronavirus-12/64/coronavirus-virus-pandemic-disease-infection-covid19-512.png";
            HeaderImage = "ic_nwvirus";
            PageTitle = "Countries";
            ShouldMoveTitleToLeft = false;
            IsHeaderImageVisible = false;
        }


        private async void ChangeTabs(string CommandParam)
        {
            try
            {
                /**/
                switch (CommandParam)
                {
                    case "dashboard":
                        TabIcon1 = "ic_tab1selected.png";
                        TabIcon2 = "ic_tab2unselected.png";
                        TabIcon3 = "ic_tab3unselected.png";
                        TabIcon4 = "ic_tab4unselected.png";
                        Scalevalue = 1;
                        Scalevalue1 = 0.8;
                        Scalevalue2 = 0.8;
                        IsDashboardVisible = true;
                        IsAboutVisible = false;
                        IsCountriesVisible = false;
                        IsMapsVisible = false;
                        //HeaderImage = "https://cdn2.iconfinder.com/data/icons/covid-19-solid/64/virus-06-512.png";
                        //headerImage = "https://cdn3.iconfinder.com/data/icons/coronavirus-12/64/coronavirus-virus-pandemic-disease-infection-covid19-512.png";
                        HeaderImage = "ic_nwvirus";
                        PageTitle = "Covid-19 Feeds";
                        ShouldMoveTitleToLeft = false;
                        IsHeaderImageVisible = true;
                        break;
                    case "countires":
                        TabIcon1 = "ic_tab1unselected.png";
                        TabIcon2 = "ic_tab2selected.png";
                        TabIcon3 = "ic_tab3unselected.png";
                        TabIcon4 = "ic_tab4unselected.png";
                        IsDashboardVisible = false;
                        IsAboutVisible = false;
                        IsCountriesVisible = true;
                        IsMapsVisible = false;
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
                        TabIcon4 = "ic_tab4unselected.png";
                        IsDashboardVisible = false;
                        IsAboutVisible = true;
                        IsCountriesVisible = false;
                        IsMapsVisible = false;
                        Scalevalue = 0.8;
                        Scalevalue1 = 0.8;
                        Scalevalue2 = 1;
                        PageTitle = "About";
                        HeaderImage = "http://files.softicons.com/download/system-icons/phuzion-icons-by-kyo-tux/png/256/Info.png";
                        ShouldMoveTitleToLeft = false;
                        IsHeaderImageVisible = false;
                        break;
                        // as of not in use
                    case "foodshelter":
                        TabIcon1 = "ic_tab1unselected.png";
                        TabIcon2 = "ic_tab2unselected.png";
                        TabIcon3 = "ic_tab3unselected.png";
                        TabIcon4 = "ic_tab4selected.png";
                        IsDashboardVisible = false;
                        IsAboutVisible = true;
                        IsCountriesVisible = false;
                        IsMapsVisible = true;
                        Scalevalue = 0.8;
                        Scalevalue1 = 0.8;
                        Scalevalue2 = 0.8;
                        Scalevalue3 = 1;
                        await LoadCurrentLocation();

                        //string url = string.Format("https://www.google.co.in/maps/search/food+shelters+near+me/@{0},{1},11z/data=!3m1!4b1", Longitude, Latitude);
                        //MapUrl = url;

                        await OpenMapAsync(Latitude, Longitude);
                        PageTitle = "Food Shelter Near Me";
                        HeaderImage = "ic_circlemap";
                        ShouldMoveTitleToLeft = false;
                        IsHeaderImageVisible = false;
                        break;


                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
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


        private async Task SettingTapped()
        {
            MessagingCenter.Send<object>(this, "PopupEvent");
            // await Application.Current.MainPage.Navigation.PushPopupAsync(new ChangeCountryPopup.xa());
        }

        public async Task LoadAllCountryCases()
        {
            TabIcon1 = "ic_tab1selected.png";
            TabIcon2 = "ic_tab2unselected.png";
            TabIcon3 = "ic_tab3unselected.png";
            TabIcon4 = "ic_tab4unselected.png";
            Scalevalue = 1;
            Scalevalue1 = 0.8;
            Scalevalue2 = 0.8;
            Scalevalue3 = 0.8;
            IsDashboardVisible = true;
            IsAboutVisible = false;
            IsCountriesVisible = false;
            // HeaderImage = "https://cdn2.iconfinder.com/data/icons/covid-19-solid/64/virus-06-512.png";
            // headerImage = "https://cdn3.iconfinder.com/data/icons/coronavirus-12/64/coronavirus-virus-pandemic-disease-infection-covid19-512.png";
            HeaderImage = "ic_nwvirus";
            PageTitle = "Covid-19 Feeds";
            ShouldMoveTitleToLeft = false;
            IsHeaderImageVisible = true;
            try
            {
                IsBusy = true;
                var res = await RestClient.RestClientInstance.GetAsync<List<AllCountriesCasesModel>>(AppConstants.LoadAllCountryCasesAPi);
                if (res != null)
                {
                    SearchedList = GlobalCountryCaseDataModel = res;
                    RefreshCV();
                    await ChooseDEaflutCountry();

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

        public void RefreshCV()
        {
            TopInfectedCountries = GlobalCountryCaseDataModel.OrderByDescending(x => x.cases).Take(5).ToList();
        }


        public async Task ChooseDEaflutCountry()
        {
            try
            {

                if (Setting.SelectedCountry != string.Empty)
                {

                    CurrentDefaultCountry = GlobalCountryCaseDataModel?.Where(x => x.country.ToUpper() == Setting.SelectedCountry.ToUpper()).FirstOrDefault();
                }
                else
                {
                    await SettingTapped();
                }
            }
            catch (Exception ex)
            {

            }

        }


        private async Task CVSelection()
        {

            // await Application.Current.MainPage.Navigation.PushModalAsync(new CovidDetailsPage(SeletedItem));


        }

        private async Task NavigateToMyCovidDetailsPage()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CovidDetailsPage(CurrentDefaultCountry));
        }


        public void SearchCountries(string SearchKey)
        {
            try
            {

                //SearchedList.Clear();
                var list = GlobalCountryCaseDataModel.Where(x => x.country.ToUpper().StartsWith(SearchKey.ToUpper())).ToList();
                if (list.Count > 0)
                {
                    SearchedList = list;
                    IsNoResultLabelVisilbe = false;
                }
                else
                {
                    SearchedList.Clear();
                    NotifyChage("SearchedList");
                    IsNoResultLabelVisilbe = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }

        }








        //="Feedback COVID-19 Android Application"

        public async Task SendEmail(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients,
                    //Cc = ccRecipients,
                    //Bcc = bccRecipients
                };
                await Email.ComposeAsync(message);

            }
            catch (FeatureNotSupportedException fns)
            {
                Debug.WriteLine(fns.StackTrace);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }


        public async Task ShareAppLink(string uri)
        {
            try
            {

                await Share.RequestAsync(new ShareTextRequest
                {
                    Uri = "https://install.appcenter.ms/users/kiran.kumarb/apps/covid-19-feeds-android/distribution_groups/public",
                    Title = "Covid-19 Feeds Android Apk Link"
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);

            }
        }
        #endregion


        public async Task LoadCurrentLocation()
        {
            try
            {
                IsBusy = true;
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Longitude = location.Longitude.ToString();
                    Latitude = location.Latitude.ToString();

                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
            finally
            {
                IsBusy = false;
            }
        }


        public async Task OpenMapAsync(string lat, string longi)
        {

            DependencyService.Get<IOpenMap>().OpenMap();
            //var supportsUri = await Launcher.CanOpenAsync("comgooglemaps://");

            //if (supportsUri)
            //    await Launcher.OpenAsync($"comgooglemaps://?q={lat},{longi}({"Home"})");

            //else

            // await Map.OpenAsync(new Location() { ad});//.OpenAsync(Double.Parse(Latitude),Double.Parse(Longitude) ,new MapLaunchOptions {Name = "Food Shelter Near Me" });
        }

    }
}
