//如果好用，请收藏地址，帮忙分享。
using System.Collections.Generic;

public class Avatar_larger
{
    /// <summary>
    /// 
    /// </summary>
    public string uri { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> url_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string width { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string height { get; set; }
}

public class Avatar_thumb
{
    /// <summary>
    /// 
    /// </summary>
    public string uri { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> url_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string width { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string height { get; set; }
}

public class Avatar_medium
{
    /// <summary>
    /// 
    /// </summary>
    public string uri { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> url_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string width { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string height { get; set; }
}

public class Video_icon
{
    /// <summary>
    /// 
    /// </summary>
    public string uri { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> url_list { get; set; }
}

public class Avatar_168x168
{
    /// <summary>
    /// 
    /// </summary>
    public string uri { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> url_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string width { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string height { get; set; }
}

public class Avatar_300x300
{
    /// <summary>
    /// 
    /// </summary>
    public string uri { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> url_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string width { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string height { get; set; }
}

public class Share_qrcode_url
{
    /// <summary>
    /// 
    /// </summary>
    public string uri { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> url_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string width { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string height { get; set; }
}

public class Share_image_url
{
    /// <summary>
    /// 
    /// </summary>
    public string url_list { get; set; }
}

public class Share_info
{
    /// <summary>
    /// 
    /// </summary>
    public string share_url { get; set; }
    /// <summary>
    /// 长按复制此条消息，打开抖音搜索，查看TA的更多作品。
    /// </summary>
    public string share_weibo_desc { get; set; }
    /// <summary>
    /// 长按复制此条消息，打开抖音搜索，查看TA的更多作品。
    /// </summary>
    public string share_desc { get; set; }
    /// <summary>
    /// 快来加入抖音，让你发现最有趣的我！
    /// </summary>
    public string share_title { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Share_qrcode_url share_qrcode_url { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Share_image_url share_image_url { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string bool_persist { get; set; }
}

public class Recommend_reason_data
{
    /// <summary>
    /// 
    /// </summary>
    public string address_book_permission { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string gps_permission { get; set; }
    /// <summary>
    /// 粉丝61.9w
    /// </summary>
    public string reason { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string style { get; set; }
}

public class User_center_adjustment
{
}

public class User_listItem
{
    /// <summary>
    /// 
    /// </summary>
    public string uid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string short_id { get; set; }
    /// <summary>
    /// 甜进你心
    /// </summary>
    public string nickname { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string gender { get; set; }
    /// <summary>
    /// Vv：kiissy-7
    /// </summary>
    public string signature { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Avatar_larger avatar_larger { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Avatar_thumb avatar_thumb { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Avatar_medium avatar_medium { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string follow_status { get; set; }
    /// <summary>
    /// 厦门
    /// </summary>
    public string location { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string custom_verify { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string unique_id { get; set; }
    /// <summary>
    /// 粉丝61.9w
    /// </summary>
    public string recommend_reason { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string room_id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string verification_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string enterprise_verify_reason { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Video_icon video_icon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string follower_status { get; set; }
    /// <summary>
    /// 中国
    /// </summary>
    public string country { get; set; }
    /// <summary>
    /// 福建
    /// </summary>
    public string province { get; set; }
    /// <summary>
    /// 厦门
    /// </summary>
    public string city { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string iso_country_code { get; set; }
    /// <summary>
    /// 湖里
    /// </summary>
    public string district { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Avatar_168x168 avatar_168x168 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Avatar_300x300 avatar_300x300 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sec_uid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string secret { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string following_count { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string follower_count { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Share_info share_info { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Recommend_reason_data recommend_reason_data { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public User_center_adjustment user_center_adjustment { get; set; }
}

public class Extra
{
    /// <summary>
    /// 
    /// </summary>
    public string now { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string logid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> fatal_item_ids { get; set; }
}

public class Log_pb
{
    /// <summary>
    /// 
    /// </summary>
    public string impr_id { get; set; }
}

public class Root
{
    /// <summary>
    /// 
    /// </summary>
    public string status_code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string status_msg { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<User_listItem> user_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cursor { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string has_more { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string rid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string new_user_count { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> shield_im_user { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> user_extra_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string strategy_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string banners { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Extra extra { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Log_pb log_pb { get; set; }
}