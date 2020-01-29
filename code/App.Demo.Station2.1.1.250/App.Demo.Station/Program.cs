using Sers.ServiceStation;
using Vit.Extensions;

namespace App.Demo.Station
{
    public class Program
    {

        public static void Main(string[] args)
        {

            //ServiceStation.AutoRun();


            ////手动指定Station版本号
            //Sers.Core.Module.App.SersApplication.serviceStationInfo.stationVersion = "2.1.1";

            //(x.1) Init
            ServiceStation.Init();


            #region (x.2)加载api
            //(x.x.1)加载api
            //ServiceStation.Instance.LoadSsApi(typeof(Program).Assembly);
            ServiceStation.Instance.LoadSsApi(typeof(Program).Assembly, new Sers.Core.Module.ApiLoader.ApiLoaderConfig { apiStationName = "demo" });
            ServiceStation.Instance.LoadApi();

            //(x.x.2)加载在线升级api（从appsettings.json中读取配置。如不需要在线升级，可以不加载，在线升级地址为 /demo/onlineupgrade/index.html ）
            ServiceStation.Instance.localApiService.LoadApi_OnlineUpgrade();
            #endregion

    
      


            //(x.3) Start
            ServiceStation.Start();


            //(x.4) RunAwait
            ServiceStation.RunAwait();

        }
    }
}
