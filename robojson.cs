//如果好用，请收藏地址，帮忙分享。
using System.Collections.Generic;

class robojosns
{
    public class Image
    {
        /// <summary>
        /// 
        /// </summary>
        public string width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
    }

    public class PredictionsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string y { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string confidence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @class { get; set; }
    }

    public class roboRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public string time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Image image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PredictionsItem> predictions { get; set; }
    }

}

