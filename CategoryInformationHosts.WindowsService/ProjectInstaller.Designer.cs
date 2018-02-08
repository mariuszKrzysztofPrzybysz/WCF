namespace CategoryInformationHosts.WindowsService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryInformationServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.categoryInformationServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // categoryInformationServiceProcessInstaller
            // 
            this.categoryInformationServiceProcessInstaller.Password = null;
            this.categoryInformationServiceProcessInstaller.Username = null;
            // 
            // categoryInformationServiceInstaller
            // 
            this.categoryInformationServiceInstaller.Description = "CategoryInformationService available via Windows Service. Allows to get some info" +
    "rmation about persons";
            this.categoryInformationServiceInstaller.DisplayName = "CategoryInformationService via Windows Service";
            this.categoryInformationServiceInstaller.ServiceName = "CategoryInformationWSService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.categoryInformationServiceProcessInstaller,
            this.categoryInformationServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller categoryInformationServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller categoryInformationServiceInstaller;
    }
}