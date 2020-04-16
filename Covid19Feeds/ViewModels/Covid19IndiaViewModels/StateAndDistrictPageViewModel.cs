using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Covid19Feeds.Models;
using Covid19Feeds.Services;
using System.Linq;


namespace Covid19Feeds.ViewModels.Covid19IndiaViewModels
{
    public class StateAndDistrictPageViewModel : BaseViewModel
    {


        private List<StateDistrictDataModel> _stateDistrictList
        { get; set; }
        public List<StateDistrictDataModel> StateDistrictList
        {
            get { return _stateDistrictList; }
            set
            {
                _stateDistrictList = value;
                NotifyChage();
            }
        }


        private IndiaStateDataModel _stateDataModel { get; set; }

        public IndiaStateDataModel StateDataModel
        {
            get { return _stateDataModel; }
            set
            {
                _stateDataModel = value;
                NotifyChage();
            }
        }

        private Statewise _total { get; set; }

        public Statewise Total
        {
            get { return _total; }
            set
            {
                _total = value;
                NotifyChage();
            }
        }



        public StateAndDistrictPageViewModel()
        {

        }

        public async Task GetStateDataAsync()
        {
            try
            {
                IsBusy = true;
                var res = await RestClient.RestClientInstance.GetAsync<IndiaStateDataModel>("https://api.covid19india.org/data.json");
                if (res != null)
                {
                    StateDataModel = res;
                    Total = StateDataModel.statewise.Where(x => x.state.ToLower() == "total").FirstOrDefault();
                    StateDataModel.statewise= StateDataModel.statewise.Where(y => y.state.ToLower() != "total").ToList();
                 //var x=   StateDataModel.statewise.RemoveAll(x => x.state.ToLower() == "total");



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



        public async Task GetStateAndDistrictDataAsync()
        {
            try
            {
                IsBusy = true;
                var res = await RestClient.RestClientInstance.GetAsync<List<StateDistrictDataModel>>("https://api.covid19india.org/v2/state_district_wise.json");
                if (res != null)
                {
                    StateDistrictList = res;

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
