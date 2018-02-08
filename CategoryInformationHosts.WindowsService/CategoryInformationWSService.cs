namespace CategoryInformationHosts.WindowsService
{
    using System.ServiceProcess;
    using System.ServiceModel;
    using CategoryInformationService.ServiceImplementations;
    using CategoryInformationService.ServiceContracts;

    public partial class CategoryInformationWSService : ServiceBase
    {
        public CategoryInformationWSService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args) => RunHost();

        protected override void OnStop()
        {
            if (_host != null)
            {
                _host.Close();
                _host = null;
            }
        }

        private void RunHost()
        {
            _host = new ServiceHost(typeof(InMemoryCategoryInformationService));
            _host.Open();
        }

        private void RunInlineConfiguredHost()
        {
            var baseAddr = @"http://localhost:8733/Design_Time_Addresses/CategoryInformationService/InMemoryCategoryInformationService/";
            _host = new ServiceHost(typeof(InMemoryCategoryInformationService));

            //Add endpoint
            _host.AddServiceEndpoint(typeof(ICategoryInformationService),
                new BasicHttpBinding(),
                baseAddr);

            _host.Open();
        }
    }
}