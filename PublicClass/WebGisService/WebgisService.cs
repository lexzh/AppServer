namespace PublicClass.WebGisService
{
    using PublicClass.Properties;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;

    [WebServiceBinding(Name="WebgisServiceSoap", Namespace="http://tempuri.org/"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053"), DesignerCategory("code")]
    public class WebgisService : SoapHttpClientProtocol
    {
        private SendOrPostCallback CacheGeoCodeAddressOperationCompleted;
        private SendOrPostCallback ClearDisCacheOperationCompleted;
        private SendOrPostCallback CreateMapImgFileOperationCompleted;
        private SendOrPostCallback GetAlarmStateOperationCompleted;
        private SendOrPostCallback GetAlarmStatusOperationCompleted;
        private SendOrPostCallback GetAllMapNamesOperationCompleted;
        private SendOrPostCallback GetCityDistrictInfoOperationCompleted;
        private SendOrPostCallback GetDataFromArrayOperationCompleted;
        private SendOrPostCallback GetDisCacheCountOperationCompleted;
        private SendOrPostCallback GetDistrictInfoByXYOperationCompleted;
        private SendOrPostCallback GetDistrictInfoOperationCompleted;
        private SendOrPostCallback GetRegionNamesOperationCompleted;
        private SendOrPostCallback GetRoadNameOperationCompleted;
        private SendOrPostCallback GetRoadNamesOperationCompleted;
        private SendOrPostCallback GetWeatherIdOperationCompleted;
        private SendOrPostCallback InitialStaticCacheOperationCompleted;
        private SendOrPostCallback IsInRegionOperationCompleted;
        private SendOrPostCallback QueryAllLayerByAttrOperationCompleted;
        private SendOrPostCallback QueryAllLayerByLngLatAttrOperationCompleted;
        private SendOrPostCallback QueryAllLayerByPointOperationCompleted;
        private SendOrPostCallback T_CacheInfoOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event CacheGeoCodeAddressCompletedEventHandler CacheGeoCodeAddressCompleted;

        public event ClearDisCacheCompletedEventHandler ClearDisCacheCompleted;

        public event CreateMapImgFileCompletedEventHandler CreateMapImgFileCompleted;

        public event GetAlarmStateCompletedEventHandler GetAlarmStateCompleted;

        public event GetAlarmStatusCompletedEventHandler GetAlarmStatusCompleted;

        public event GetAllMapNamesCompletedEventHandler GetAllMapNamesCompleted;

        public event GetCityDistrictInfoCompletedEventHandler GetCityDistrictInfoCompleted;

        public event GetDataFromArrayCompletedEventHandler GetDataFromArrayCompleted;

        public event GetDisCacheCountCompletedEventHandler GetDisCacheCountCompleted;

        public event GetDistrictInfoByXYCompletedEventHandler GetDistrictInfoByXYCompleted;

        public event GetDistrictInfoCompletedEventHandler GetDistrictInfoCompleted;

        public event GetRegionNamesCompletedEventHandler GetRegionNamesCompleted;

        public event GetRoadNameCompletedEventHandler GetRoadNameCompleted;

        public event GetRoadNamesCompletedEventHandler GetRoadNamesCompleted;

        public event GetWeatherIdCompletedEventHandler GetWeatherIdCompleted;

        public event InitialStaticCacheCompletedEventHandler InitialStaticCacheCompleted;

        public event IsInRegionCompletedEventHandler IsInRegionCompleted;

        public event QueryAllLayerByAttrCompletedEventHandler QueryAllLayerByAttrCompleted;

        public event QueryAllLayerByLngLatAttrCompletedEventHandler QueryAllLayerByLngLatAttrCompleted;

        public event QueryAllLayerByPointCompletedEventHandler QueryAllLayerByPointCompleted;

        public event T_CacheInfoCompletedEventHandler T_CacheInfoCompleted;

        public WebgisService()
        {
            this.Url = Settings.Default.PublicClass_WebGisService_WebgisService;
            if (this.IsLocalFileSystemWebService(this.Url))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        [SoapDocumentMethod("http://tempuri.org/CacheGeoCodeAddress", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public void CacheGeoCodeAddress(string strlonlat, string cacheAddress)
        {
            base.Invoke("CacheGeoCodeAddress", new object[] { strlonlat, cacheAddress });
        }

        public void CacheGeoCodeAddressAsync(string strlonlat, string cacheAddress)
        {
            this.CacheGeoCodeAddressAsync(strlonlat, cacheAddress, null);
        }

        public void CacheGeoCodeAddressAsync(string strlonlat, string cacheAddress, object userState)
        {
            if (this.CacheGeoCodeAddressOperationCompleted == null)
            {
                this.CacheGeoCodeAddressOperationCompleted = new SendOrPostCallback(this.OnCacheGeoCodeAddressOperationCompleted);
            }
            base.InvokeAsync("CacheGeoCodeAddress", new object[] { strlonlat, cacheAddress }, this.CacheGeoCodeAddressOperationCompleted, userState);
        }

        public void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        [SoapDocumentMethod("http://tempuri.org/ClearDisCache", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool ClearDisCache()
        {
            return (bool) base.Invoke("ClearDisCache", new object[0])[0];
        }

        public void ClearDisCacheAsync()
        {
            this.ClearDisCacheAsync(null);
        }

        public void ClearDisCacheAsync(object userState)
        {
            if (this.ClearDisCacheOperationCompleted == null)
            {
                this.ClearDisCacheOperationCompleted = new SendOrPostCallback(this.OnClearDisCacheOperationCompleted);
            }
            base.InvokeAsync("ClearDisCache", new object[0], this.ClearDisCacheOperationCompleted, userState);
        }

        [return: XmlElement(DataType="base64Binary")]
        [SoapDocumentMethod("http://tempuri.org/CreateMapImgFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public byte[] CreateMapImgFile(int width, int height, int zoom, double lon, double lat, string carnum)
        {
            return (byte[]) base.Invoke("CreateMapImgFile", new object[] { width, height, zoom, lon, lat, carnum })[0];
        }

        public void CreateMapImgFileAsync(int width, int height, int zoom, double lon, double lat, string carnum)
        {
            this.CreateMapImgFileAsync(width, height, zoom, lon, lat, carnum, null);
        }

        public void CreateMapImgFileAsync(int width, int height, int zoom, double lon, double lat, string carnum, object userState)
        {
            if (this.CreateMapImgFileOperationCompleted == null)
            {
                this.CreateMapImgFileOperationCompleted = new SendOrPostCallback(this.OnCreateMapImgFileOperationCompleted);
            }
            base.InvokeAsync("CreateMapImgFile", new object[] { width, height, zoom, lon, lat, carnum }, this.CreateMapImgFileOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetAlarmState", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string GetAlarmState(string strXml)
        {
            return (string) base.Invoke("GetAlarmState", new object[] { strXml })[0];
        }

        public void GetAlarmStateAsync(string strXml)
        {
            this.GetAlarmStateAsync(strXml, null);
        }

        public void GetAlarmStateAsync(string strXml, object userState)
        {
            if (this.GetAlarmStateOperationCompleted == null)
            {
                this.GetAlarmStateOperationCompleted = new SendOrPostCallback(this.OnGetAlarmStateOperationCompleted);
            }
            base.InvokeAsync("GetAlarmState", new object[] { strXml }, this.GetAlarmStateOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetAlarmStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public int GetAlarmStatus(string strInXml, out string strOutXml)
        {
            object[] objArray = base.Invoke("GetAlarmStatus", new object[] { strInXml });
            strOutXml = (string) objArray[1];
            return (int) objArray[0];
        }

        public void GetAlarmStatusAsync(string strInXml)
        {
            this.GetAlarmStatusAsync(strInXml, null);
        }

        public void GetAlarmStatusAsync(string strInXml, object userState)
        {
            if (this.GetAlarmStatusOperationCompleted == null)
            {
                this.GetAlarmStatusOperationCompleted = new SendOrPostCallback(this.OnGetAlarmStatusOperationCompleted);
            }
            base.InvokeAsync("GetAlarmStatus", new object[] { strInXml }, this.GetAlarmStatusOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetAllMapNames", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] GetAllMapNames()
        {
            return (string[]) base.Invoke("GetAllMapNames", new object[0])[0];
        }

        public void GetAllMapNamesAsync()
        {
            this.GetAllMapNamesAsync(null);
        }

        public void GetAllMapNamesAsync(object userState)
        {
            if (this.GetAllMapNamesOperationCompleted == null)
            {
                this.GetAllMapNamesOperationCompleted = new SendOrPostCallback(this.OnGetAllMapNamesOperationCompleted);
            }
            base.InvokeAsync("GetAllMapNames", new object[0], this.GetAllMapNamesOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetCityDistrictInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] GetCityDistrictInfo(string[] idlonlats)
        {
            return (string[]) base.Invoke("GetCityDistrictInfo", new object[] { idlonlats })[0];
        }

        public void GetCityDistrictInfoAsync(string[] idlonlats)
        {
            this.GetCityDistrictInfoAsync(idlonlats, null);
        }

        public void GetCityDistrictInfoAsync(string[] idlonlats, object userState)
        {
            if (this.GetCityDistrictInfoOperationCompleted == null)
            {
                this.GetCityDistrictInfoOperationCompleted = new SendOrPostCallback(this.OnGetCityDistrictInfoOperationCompleted);
            }
            base.InvokeAsync("GetCityDistrictInfo", new object[] { idlonlats }, this.GetCityDistrictInfoOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetDataFromArray", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string GetDataFromArray(int indexFrom, int length, string[] arryResults)
        {
            return (string) base.Invoke("GetDataFromArray", new object[] { indexFrom, length, arryResults })[0];
        }

        public void GetDataFromArrayAsync(int indexFrom, int length, string[] arryResults)
        {
            this.GetDataFromArrayAsync(indexFrom, length, arryResults, null);
        }

        public void GetDataFromArrayAsync(int indexFrom, int length, string[] arryResults, object userState)
        {
            if (this.GetDataFromArrayOperationCompleted == null)
            {
                this.GetDataFromArrayOperationCompleted = new SendOrPostCallback(this.OnGetDataFromArrayOperationCompleted);
            }
            base.InvokeAsync("GetDataFromArray", new object[] { indexFrom, length, arryResults }, this.GetDataFromArrayOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetDisCacheCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public int GetDisCacheCount()
        {
            return (int) base.Invoke("GetDisCacheCount", new object[0])[0];
        }

        public void GetDisCacheCountAsync()
        {
            this.GetDisCacheCountAsync(null);
        }

        public void GetDisCacheCountAsync(object userState)
        {
            if (this.GetDisCacheCountOperationCompleted == null)
            {
                this.GetDisCacheCountOperationCompleted = new SendOrPostCallback(this.OnGetDisCacheCountOperationCompleted);
            }
            base.InvokeAsync("GetDisCacheCount", new object[0], this.GetDisCacheCountOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetDistrictInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] GetDistrictInfo(string[] idlonlats)
        {
            return (string[]) base.Invoke("GetDistrictInfo", new object[] { idlonlats })[0];
        }

        public void GetDistrictInfoAsync(string[] idlonlats)
        {
            this.GetDistrictInfoAsync(idlonlats, null);
        }

        public void GetDistrictInfoAsync(string[] idlonlats, object userState)
        {
            if (this.GetDistrictInfoOperationCompleted == null)
            {
                this.GetDistrictInfoOperationCompleted = new SendOrPostCallback(this.OnGetDistrictInfoOperationCompleted);
            }
            base.InvokeAsync("GetDistrictInfo", new object[] { idlonlats }, this.GetDistrictInfoOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetDistrictInfoByXY", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string GetDistrictInfoByXY(double x, double y)
        {
            return (string) base.Invoke("GetDistrictInfoByXY", new object[] { x, y })[0];
        }

        public void GetDistrictInfoByXYAsync(double x, double y)
        {
            this.GetDistrictInfoByXYAsync(x, y, null);
        }

        public void GetDistrictInfoByXYAsync(double x, double y, object userState)
        {
            if (this.GetDistrictInfoByXYOperationCompleted == null)
            {
                this.GetDistrictInfoByXYOperationCompleted = new SendOrPostCallback(this.OnGetDistrictInfoByXYOperationCompleted);
            }
            base.InvokeAsync("GetDistrictInfoByXY", new object[] { x, y }, this.GetDistrictInfoByXYOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetRegionNames", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] GetRegionNames(string regionID)
        {
            return (string[]) base.Invoke("GetRegionNames", new object[] { regionID })[0];
        }

        public void GetRegionNamesAsync(string regionID)
        {
            this.GetRegionNamesAsync(regionID, null);
        }

        public void GetRegionNamesAsync(string regionID, object userState)
        {
            if (this.GetRegionNamesOperationCompleted == null)
            {
                this.GetRegionNamesOperationCompleted = new SendOrPostCallback(this.OnGetRegionNamesOperationCompleted);
            }
            base.InvokeAsync("GetRegionNames", new object[] { regionID }, this.GetRegionNamesOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetRoadName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string GetRoadName(double lon, double lat)
        {
            return (string) base.Invoke("GetRoadName", new object[] { lon, lat })[0];
        }

        public void GetRoadNameAsync(double lon, double lat)
        {
            this.GetRoadNameAsync(lon, lat, null);
        }

        public void GetRoadNameAsync(double lon, double lat, object userState)
        {
            if (this.GetRoadNameOperationCompleted == null)
            {
                this.GetRoadNameOperationCompleted = new SendOrPostCallback(this.OnGetRoadNameOperationCompleted);
            }
            base.InvokeAsync("GetRoadName", new object[] { lon, lat }, this.GetRoadNameOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetRoadNames", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] GetRoadNames(string[] idlonlats)
        {
            return (string[]) base.Invoke("GetRoadNames", new object[] { idlonlats })[0];
        }

        public void GetRoadNamesAsync(string[] idlonlats)
        {
            this.GetRoadNamesAsync(idlonlats, null);
        }

        public void GetRoadNamesAsync(string[] idlonlats, object userState)
        {
            if (this.GetRoadNamesOperationCompleted == null)
            {
                this.GetRoadNamesOperationCompleted = new SendOrPostCallback(this.OnGetRoadNamesOperationCompleted);
            }
            base.InvokeAsync("GetRoadNames", new object[] { idlonlats }, this.GetRoadNamesOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/GetWeatherId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string GetWeatherId(double x, double y)
        {
            return (string) base.Invoke("GetWeatherId", new object[] { x, y })[0];
        }

        public void GetWeatherIdAsync(double x, double y)
        {
            this.GetWeatherIdAsync(x, y, null);
        }

        public void GetWeatherIdAsync(double x, double y, object userState)
        {
            if (this.GetWeatherIdOperationCompleted == null)
            {
                this.GetWeatherIdOperationCompleted = new SendOrPostCallback(this.OnGetWeatherIdOperationCompleted);
            }
            base.InvokeAsync("GetWeatherId", new object[] { x, y }, this.GetWeatherIdOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/InitialStaticCache", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool InitialStaticCache()
        {
            return (bool) base.Invoke("InitialStaticCache", new object[0])[0];
        }

        public void InitialStaticCacheAsync()
        {
            this.InitialStaticCacheAsync(null);
        }

        public void InitialStaticCacheAsync(object userState)
        {
            if (this.InitialStaticCacheOperationCompleted == null)
            {
                this.InitialStaticCacheOperationCompleted = new SendOrPostCallback(this.OnInitialStaticCacheOperationCompleted);
            }
            base.InvokeAsync("InitialStaticCache", new object[0], this.InitialStaticCacheOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/IsInRegion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool IsInRegion(double lon, double lat, string regionID)
        {
            return (bool) base.Invoke("IsInRegion", new object[] { lon, lat, regionID })[0];
        }

        public void IsInRegionAsync(double lon, double lat, string regionID)
        {
            this.IsInRegionAsync(lon, lat, regionID, null);
        }

        public void IsInRegionAsync(double lon, double lat, string regionID, object userState)
        {
            if (this.IsInRegionOperationCompleted == null)
            {
                this.IsInRegionOperationCompleted = new SendOrPostCallback(this.OnIsInRegionOperationCompleted);
            }
            base.InvokeAsync("IsInRegion", new object[] { lon, lat, regionID }, this.IsInRegionOperationCompleted, userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if ((url == null) || (url == string.Empty))
            {
                return false;
            }
            Uri uri = new Uri(url);
            return ((uri.Port >= 0x400) && (string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0));
        }

        private void OnCacheGeoCodeAddressOperationCompleted(object arg)
        {
            if (this.CacheGeoCodeAddressCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.CacheGeoCodeAddressCompleted(this, new AsyncCompletedEventArgs(args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnClearDisCacheOperationCompleted(object arg)
        {
            if (this.ClearDisCacheCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.ClearDisCacheCompleted(this, new ClearDisCacheCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnCreateMapImgFileOperationCompleted(object arg)
        {
            if (this.CreateMapImgFileCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.CreateMapImgFileCompleted(this, new CreateMapImgFileCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetAlarmStateOperationCompleted(object arg)
        {
            if (this.GetAlarmStateCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetAlarmStateCompleted(this, new GetAlarmStateCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetAlarmStatusOperationCompleted(object arg)
        {
            if (this.GetAlarmStatusCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetAlarmStatusCompleted(this, new GetAlarmStatusCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetAllMapNamesOperationCompleted(object arg)
        {
            if (this.GetAllMapNamesCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetAllMapNamesCompleted(this, new GetAllMapNamesCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetCityDistrictInfoOperationCompleted(object arg)
        {
            if (this.GetCityDistrictInfoCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetCityDistrictInfoCompleted(this, new GetCityDistrictInfoCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetDataFromArrayOperationCompleted(object arg)
        {
            if (this.GetDataFromArrayCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetDataFromArrayCompleted(this, new GetDataFromArrayCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetDisCacheCountOperationCompleted(object arg)
        {
            if (this.GetDisCacheCountCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetDisCacheCountCompleted(this, new GetDisCacheCountCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetDistrictInfoByXYOperationCompleted(object arg)
        {
            if (this.GetDistrictInfoByXYCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetDistrictInfoByXYCompleted(this, new GetDistrictInfoByXYCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetDistrictInfoOperationCompleted(object arg)
        {
            if (this.GetDistrictInfoCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetDistrictInfoCompleted(this, new GetDistrictInfoCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetRegionNamesOperationCompleted(object arg)
        {
            if (this.GetRegionNamesCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetRegionNamesCompleted(this, new GetRegionNamesCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetRoadNameOperationCompleted(object arg)
        {
            if (this.GetRoadNameCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetRoadNameCompleted(this, new GetRoadNameCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetRoadNamesOperationCompleted(object arg)
        {
            if (this.GetRoadNamesCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetRoadNamesCompleted(this, new GetRoadNamesCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnGetWeatherIdOperationCompleted(object arg)
        {
            if (this.GetWeatherIdCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.GetWeatherIdCompleted(this, new GetWeatherIdCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnInitialStaticCacheOperationCompleted(object arg)
        {
            if (this.InitialStaticCacheCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.InitialStaticCacheCompleted(this, new InitialStaticCacheCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnIsInRegionOperationCompleted(object arg)
        {
            if (this.IsInRegionCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.IsInRegionCompleted(this, new IsInRegionCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnQueryAllLayerByAttrOperationCompleted(object arg)
        {
            if (this.QueryAllLayerByAttrCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.QueryAllLayerByAttrCompleted(this, new QueryAllLayerByAttrCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnQueryAllLayerByLngLatAttrOperationCompleted(object arg)
        {
            if (this.QueryAllLayerByLngLatAttrCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.QueryAllLayerByLngLatAttrCompleted(this, new QueryAllLayerByLngLatAttrCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnQueryAllLayerByPointOperationCompleted(object arg)
        {
            if (this.QueryAllLayerByPointCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.QueryAllLayerByPointCompleted(this, new QueryAllLayerByPointCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnT_CacheInfoOperationCompleted(object arg)
        {
            if (this.T_CacheInfoCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.T_CacheInfoCompleted(this, new T_CacheInfoCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        [SoapDocumentMethod("http://tempuri.org/QueryAllLayerByAttr", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string QueryAllLayerByAttr(string pName, string cName, string queryVal)
        {
            return (string) base.Invoke("QueryAllLayerByAttr", new object[] { pName, cName, queryVal })[0];
        }

        public void QueryAllLayerByAttrAsync(string pName, string cName, string queryVal)
        {
            this.QueryAllLayerByAttrAsync(pName, cName, queryVal, null);
        }

        public void QueryAllLayerByAttrAsync(string pName, string cName, string queryVal, object userState)
        {
            if (this.QueryAllLayerByAttrOperationCompleted == null)
            {
                this.QueryAllLayerByAttrOperationCompleted = new SendOrPostCallback(this.OnQueryAllLayerByAttrOperationCompleted);
            }
            base.InvokeAsync("QueryAllLayerByAttr", new object[] { pName, cName, queryVal }, this.QueryAllLayerByAttrOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/QueryAllLayerByLngLatAttr", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string QueryAllLayerByLngLatAttr(double lng, double lat, string queryVal)
        {
            return (string) base.Invoke("QueryAllLayerByLngLatAttr", new object[] { lng, lat, queryVal })[0];
        }

        public void QueryAllLayerByLngLatAttrAsync(double lng, double lat, string queryVal)
        {
            this.QueryAllLayerByLngLatAttrAsync(lng, lat, queryVal, null);
        }

        public void QueryAllLayerByLngLatAttrAsync(double lng, double lat, string queryVal, object userState)
        {
            if (this.QueryAllLayerByLngLatAttrOperationCompleted == null)
            {
                this.QueryAllLayerByLngLatAttrOperationCompleted = new SendOrPostCallback(this.OnQueryAllLayerByLngLatAttrOperationCompleted);
            }
            base.InvokeAsync("QueryAllLayerByLngLatAttr", new object[] { lng, lat, queryVal }, this.QueryAllLayerByLngLatAttrOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/QueryAllLayerByPoint", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string QueryAllLayerByPoint(double x, double y)
        {
            return (string) base.Invoke("QueryAllLayerByPoint", new object[] { x, y })[0];
        }

        public void QueryAllLayerByPointAsync(double x, double y)
        {
            this.QueryAllLayerByPointAsync(x, y, null);
        }

        public void QueryAllLayerByPointAsync(double x, double y, object userState)
        {
            if (this.QueryAllLayerByPointOperationCompleted == null)
            {
                this.QueryAllLayerByPointOperationCompleted = new SendOrPostCallback(this.OnQueryAllLayerByPointOperationCompleted);
            }
            base.InvokeAsync("QueryAllLayerByPoint", new object[] { x, y }, this.QueryAllLayerByPointOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/T_CacheInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string T_CacheInfo()
        {
            return (string) base.Invoke("T_CacheInfo", new object[0])[0];
        }

        public void T_CacheInfoAsync()
        {
            this.T_CacheInfoAsync(null);
        }

        public void T_CacheInfoAsync(object userState)
        {
            if (this.T_CacheInfoOperationCompleted == null)
            {
                this.T_CacheInfoOperationCompleted = new SendOrPostCallback(this.OnT_CacheInfoOperationCompleted);
            }
            base.InvokeAsync("T_CacheInfo", new object[0], this.T_CacheInfoOperationCompleted, userState);
        }

        public string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly) && !this.IsLocalFileSystemWebService(value))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
    }
}

