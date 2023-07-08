using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class HttpPost
{
    private static string url= "https://aweme.snssdk.com/aweme/v2/user/recommend/?iid=33626&device_id=121162311&ac=wifi&channel=update&aid=1128&app_name=aweme&version_code=250000&version_name=25.0.0&device_platform=android&os=android&ssmix=a&device_type=SKW-A0&device_brand=blackshark&language=zh&os_api=28&os_version=9&manifest_version_code=250001&resolution=1080*1920&dpi=480&update_version_code=25009900&_rticket=1685717536837&package=com.ss.android.ugc.aweme&mcc_mnc=46000&cpu_support64=true&host_abi=arm64-v8a&is_guest_mode=0&app_type=normal&minor_status=0&appTheme=light&need_personal_recommend=1&is_android_pad=0&ts=1685717535&cdid=534972bb-1dfb-4989-afc5-9a4d168b8e49&md=0";
    public static string headss = "x-ss-req-ticket: 1685717536840"+"\r\n"+ "sdk-version: 2"+ "\r\n"+ "x-tt-token:00b855323856ba5a259dd54dd87b3536570122a92b1a270196efd4712157a0a1adfa4dc0ac67fc0a49eee3e38b3b051e378e6118124380216b45f71de4c53af90d22b8d485b7202835159a95e801c02fb4d7a6b2dfc9c377e16b78d45d059345f099a-1.0.1";
    public static string requestParamss = "count=10&cursor=0&recommend_type=31&target_user_id=58527368040&sec_target_user_id=MS4wLjABAAAAlsmfAL5n6mJKLJfX_U_Vg9FjlCGbYo3AUhhiKx5POfk&yellow_point_count=0&address_book_access=2&gps_access=2&rec_impr_users=&show_super_account_when_follow_empty=0&mutual_friend_count=-1";

    public static void Ss(string uid1, string uid2)
    {
        //58527368040  MS4wLjABAAAAlsmfAL5n6mJKLJfX_U_Vg9FjlCGbYo3AUhhiKx5POfk
        string requestParamss = $"count=10&cursor=0&recommend_type=31&target_user_id={uid1}&sec_target_user_id={uid2}&yellow_point_count=0&address_book_access=2&gps_access=2&rec_impr_users=&show_super_account_when_follow_empty=0&mutual_friend_count=-1";
        string response = "";
        while (response == "")
        {
            Console.WriteLine("进入SS 获取相关人");
            response = SendPostRequest(requestParamss, headss);
        }

        Root person = JsonConvert.DeserializeObject<Root>(response);
        foreach (var item in person.user_list)
        {
            sqlbd.sqls(item);
        }
    }


    public static string SendPostRequest(string requestParams, string headers)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(requestParams);

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "com.ss.android.ugc.aweme/250001 (Linux; U; Android 9; zh_CN; SKW-A0; Build/PQ3A.190705.003;tt-ok/3.12.13.1)");
        //client.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");

        if (!string.IsNullOrEmpty(headers))
        {
            string[] lines = headers.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (var item in lines)
            {
                string[] keyValue = item.Split(':');
                if (keyValue.Length == 2)
                {
                    string key = keyValue[0].Trim();
                    string value = keyValue[1].Trim();
                    client.DefaultRequestHeaders.Add(key, value);
                }
            }
        }

        using (HttpContent content = new ByteArrayContent(bytes))
        {
            HttpResponseMessage response =  client.PostAsync(url, content).Result;
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }
    }

    //public static async Task<string> SendPostRequest(string requestParams, string headers)
    //{
    //    byte[] bytes = Encoding.UTF8.GetBytes(requestParams);

    //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    //    request.Method = "POST";
    //    request.UserAgent = "com.ss.android.ugc.aweme/250001 (Linux; U; Android 9; zh_CN; SKW-A0; Build/PQ3A.190705.003;tt-ok/3.12.13.1) ";
    //    request.ContentType = "application/x-www-form-urlencoded";
    //    request.ContentLength = bytes.Length;

    //    if (!string.IsNullOrEmpty(headers))
    //    {
    //        string[] lines = headers.Split(new string[] { "\r\n" }, StringSplitOptions.None);
    //        foreach (var item in lines)
    //        {
    //            request.Headers.Add(item);
    //        }

    //    }

    //    using (Stream requestStream = request.GetRequestStream())
    //    {
    //        requestStream.Write(bytes, 0, bytes.Length);
    //    }

    //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
    //    {
    //        using (Stream responseStream = response.GetResponseStream())
    //        {
    //            using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
    //            {
    //                return await reader.ReadToEndAsync();
    //            }
    //        }
    //    }
    //}


    public static List<string> goaweme(string sid)
    {
        string sia = "";
        List<string> li = new List<string>();
        List<josns.Aweme_listItem> al = new List<josns.Aweme_listItem>();
        string con = "0";
        for (int i = 0; i < 10; i++)
        {
            josns.Root2 r = null;
            for (int i1 = 0; i1 < 3; i1++)
            {
                r = postaweme(sid, con).Result;
                if (r != null)
                {
                    break;
                }
            }
            if (r == null)
            {
                return null;
            }
            if (r.aweme_list == null)
            {
                return null;
            }
            if (r.aweme_list.Count == 0)
            {
                return null;
            }
            foreach (var item in r.aweme_list)
            {
                if (al.Count < 10)
                {
                    if (item.video.dynamic_cover != null)
                    {
                        sia += item.video.dynamic_cover.url_list[0] + "\r\n";
                        al.Add(item);
                        li.Add(item.video.dynamic_cover.url_list[0]);
                    }

                }
                else
                {
                    return li;
                }

            }
            con = r.max_cursor;
        }

        return li;
    }

    //public static josns.Root2 postaweme(string sid, string cursor)
    //{
    //    string url = $"https://www.douyin.com/aweme/v1/web/aweme/post/?device_platform=webapp&aid=6383&channel=channel_pc_web&sec_user_id={sid}&count=18&max_cursor={cursor}";
    //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    //    request.Method = "GET";
    //    request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36";
    //    request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
    //    request.Referer = $"https://www.douyin.com/user/{sid}";
    //    request.ContentType = "application/x-www-form-urlencoded";
    //    string cookieValue = "__live_version__=%221.1.0.9449%22; passport_assist_user=CkHGkIA6_w3POUIVJTBZ_Jd_i2caTLfNt3JVkN2_IlrO5YQNE03jD7PNgy4fQ7DnCKV0UapefXjk4dXik4KfxoCwcBpICjypcaUBKhkkC2Li6Cd02kY142UQ3N2873Bw3HNJnJFAg7YMn-3NSoqtHoJlIc867L2BSiFVCLup_5kP8akQ1vyxDRiJr9ZUIgEDMi3srg%3D%3D; n_mh=RcS9dWHJKKZmfc_iJBR9tw-Z73WpX2FnLYylCjO_WNA; sso_uid_tt=412698ba44053e74ec90e2f126b2d93a; sso_uid_tt_ss=412698ba44053e74ec90e2f126b2d93a; toutiao_sso_user=84ef4fb47c46a5043123091c8136e9bc; toutiao_sso_user_ss=84ef4fb47c46a5043123091c8136e9bc; sid_ucp_sso_v1=1.0.0-KDlkOTNhOTk5ODdhNTFiYmE2YWUwOGM4ZmIwZGQ0MDA2NGE5ZTAyMzcKHwiM_KDo9Iy-BRCL97ajBhjvMSAMMPDL04sGOAZA9AcaAmxmIiA4NGVmNGZiNDdjNDZhNTA0MzEyMzA5MWM4MTM2ZTliYw; ssid_ucp_sso_v1=1.0.0-KDlkOTNhOTk5ODdhNTFiYmE2YWUwOGM4ZmIwZGQ0MDA2NGE5ZTAyMzcKHwiM_KDo9Iy-BRCL97ajBhjvMSAMMPDL04sGOAZA9AcaAmxmIiA4NGVmNGZiNDdjNDZhNTA0MzEyMzA5MWM4MTM2ZTliYw; passport_auth_status=3a2439094e06ac4783153a88e7a434f1%2C; passport_auth_status_ss=3a2439094e06ac4783153a88e7a434f1%2C; uid_tt=04627e6a93e31169e1411679aa9bf4b3; uid_tt_ss=04627e6a93e31169e1411679aa9bf4b3; sid_tt=4316b7ea67d4e2b6e240b69c1033789b; sessionid=4316b7ea67d4e2b6e240b69c1033789b; sessionid_ss=4316b7ea67d4e2b6e240b69c1033789b; LOGIN_STATUS=1; store-region=cn-gd; store-region-src=uid; sid_guard=4316b7ea67d4e2b6e240b69c1033789b%7C1684913041%7C5183997%7CSun%2C+23-Jul-2023+07%3A23%3A58+GMT; sid_ucp_v1=1.0.0-KGUzODEwNDRiMTgzZTEzNjhmZDgyMzU2MzQxOTIxZWNmOGU3YmQ5MjUKGwiM_KDo9Iy-BRCR97ajBhjvMSAMOAZA9AdIBBoCaGwiIDQzMTZiN2VhNjdkNGUyYjZlMjQwYjY5YzEwMzM3ODli; ssid_ucp_v1=1.0.0-KGUzODEwNDRiMTgzZTEzNjhmZDgyMzU2MzQxOTIxZWNmOGU3YmQ5MjUKGwiM_KDo9Iy-BRCR97ajBhjvMSAMOAZA9AdIBBoCaGwiIDQzMTZiN2VhNjdkNGUyYjZlMjQwYjY5YzEwMzM3ODli; d_ticket=f5ce5eb09c51ecb3b463e5b8619fc103c8971; my_rd=1; pwa2=%223%7C1%22; s_v_web_id=verify_lih6yb83_W3Fb6iWG_i289_4b4U_8GK4_yXvjy9wCFb1H; passport_csrf_token=8124d099c8e12db47149e27950de19ac; passport_csrf_token_default=8124d099c8e12db47149e27950de19ac; bd_ticket_guard_client_data=eyJiZC10aWNrZXQtZ3VhcmQtdmVyc2lvbiI6MiwiYmQtdGlja2V0LWd1YXJkLWl0ZXJhdGlvbi12ZXJzaW9uIjoxLCJiZC10aWNrZXQtZ3VhcmQtY2xpZW50LWNlcnQiOiItLS0tLUJFR0lOIENFUlRJRklDQVRFLS0tLS1cbk1JSUNGRENDQWJ1Z0F3SUJBZ0lWQUl4bG1qSFFpN2Q1bURDdm1oZGlBM3JhQWw4eE1Bb0dDQ3FHU000OUJBTUNcbk1ERXhDekFKQmdOVkJBWVRBa05PTVNJd0lBWURWUVFEREJsMGFXTnJaWFJmWjNWaGNtUmZZMkZmWldOa2MyRmZcbk1qVTJNQjRYRFRJek1EVXlOREEzTWpNMU5sb1hEVE16TURVeU5ERTFNak0xTmxvd0p6RUxNQWtHQTFVRUJoTUNcblEwNHhHREFXQmdOVkJBTU1EMkprWDNScFkydGxkRjluZFdGeVpEQlpNQk1HQnlxR1NNNDlBZ0VHQ0NxR1NNNDlcbkF3RUhBMElBQlBBZFdCT25pSFQrZG9EUEpLTnBpZUphWnNTYVk4TnlKR2p2NUY5NEpCS3BHUnpKV0NzN0hLRnRcbjhjY1g2akY4VDFEY0N3MU00VERHd21ZSC9sWEkvUFdqZ2Jrd2diWXdEZ1lEVlIwUEFRSC9CQVFEQWdXZ01ERUdcbkExVWRKUVFxTUNnR0NDc0dBUVVGQndNQkJnZ3JCZ0VGQlFjREFnWUlLd1lCQlFVSEF3TUdDQ3NHQVFVRkJ3TUVcbk1Da0dBMVVkRGdRaUJDQ2FXQVo3QU5oaUZoQXhRVFRHTkpZRjRmUlV4WktHaXh2RmQ3eXgxa3BPVFRBckJnTlZcbkhTTUVKREFpZ0NBeXBXZnFqbVJJRW8zTVRrMUFlM01VbTBkdFUzcWswWURYZVpTWGV5SkhnekFaQmdOVkhSRUVcbkVqQVFnZzUzZDNjdVpHOTFlV2x1TG1OdmJUQUtCZ2dxaGtqT1BRUURBZ05IQURCRUFpQm1HcWQwVWJNcWV3cVlcbmZ6OFYvR3o4eHdicWhETS9UK01hMHhmSCsrcFg1QUlnV0liVmtBbTVEZzVRV1hkZkl3YWUvZHFLOTBJbzFCRnFcbmxFSS9NM2FhUHdFPVxuLS0tLS1FTkQgQ0VSVElGSUNBVEUtLS0tLVxuIn0=; ttwid=1%7CWotF8lJnFAb32bpclNXUqbUszFYwapzsk55t26GisyM%7C1686540613%7C80359705e8b4c52619d90269bd5bd4b80c6a596a6af70c0202d87c323865b87c; odin_tt=a1aef9c57d7f5c9219ef0175ec720f2ce38eaf8fa31b86afb4e73315f844168364e4db24a49cb31ff03842f68e49edfd; SEARCH_RESULT_LIST_TYPE=%22single%22; __ac_nonce=0648a813100cca38df1b0; __ac_signature=_02B4Z6wo00f01pNM7JAAAIDD8EYs-mLQ6RaTbOgAAMBlwwnKpT.uWTteBGhQQHyY3OWzXhMKX9qgobbaepYkhfmBS0T3qMMd6fHeClyxriAmjwuSY6TU.tTsSsqFP.EwFWDwkg8rx4C1mOGq6d; strategyABtestKey=%221686798643.701%22; douyin.com; device_web_cpu_core=4; device_web_memory_size=8; webcast_local_quality=null; VIDEO_FILTER_MEMO_SELECT=%7B%22expireTime%22%3A1687403645804%2C%22type%22%3A1%7D; FOLLOW_LIVE_POINT_INFO=%22MS4wLjABAAAAx_KlGEDysM8mMKWw-o8Qeh7hMoOhNHlm3Vb1rpLkZuNZ7A4wOjUzoBwu6C_SxFHU%2F1686844800000%2F0%2F0%2F1686799446257%22; FOLLOW_NUMBER_YELLOW_POINT_INFO=%22MS4wLjABAAAAx_KlGEDysM8mMKWw-o8Qeh7hMoOhNHlm3Vb1rpLkZuNZ7A4wOjUzoBwu6C_SxFHU%2F1686844800000%2F0%2F1686798846258%2F0%22; home_can_add_dy_2_desktop=%221%22; passport_fe_beating_status=true; csrf_session_id=9cc0fa182395ecc6cf0d89de2e61781d; tt_scid=L2xmKUXFn1Qs4OkPvJoUojCH5IJ4b4Af1.ciGIaSssIlIZ5RVZqOD7HRGT7giS1v6b34; download_guide=%221%2F20230615%2F0%22; publish_badge_show_info=%221%2C0%2C0%2C1686798846555%22; msToken=fMVoKDIG88LQkkhpkzZxR7VZ2yEPuIvitb5M7wdQYPmWtSvRY267HsgS07yiEBHpGIfsw9Zb1xlGtNJqbvmWNk0fjt9fWqvxdj5HbhiJEpEHFEELmFTjnp0=; msToken=Ls_W4ziz36MbI8YU2MmTe_xqBXGnV3gYIJfQlE-YH3IrSBWl-g5GLK45D6v0aJgU0Sdze4eXtHtnJF9NtOxFgk1o7djeCi6yTm06PrZkzc-lHg20G3fddTY=";
    //  //  string cookieValue = "sid_guard=4316b7ea67d4e2b6e240b69c1033789b%7C1684913041%7C5183997%7CSun%2C+23-Jul-2023+07%3A23%3A58+GMT; sid_ucp_v1=1.0.0-KGUzODEwNDRiMTgzZTEzNjhmZDgyMzU2MzQxOTIxZWNmOGU3YmQ5MjUKGwiM_KDo9Iy-BRCR97ajBhjvMSAMOAZA9AdIBBoCaGwiIDQzMTZiN2VhNjdkNGUyYjZlMjQwYjY5YzEwMzM3ODli; uid_tt=04627e6a93e31169e1411679aa9bf4b3";
    //    request.Headers.Add(HttpRequestHeader.Cookie, cookieValue);
    //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
    //    {
    //        using (Stream responseStream = response.GetResponseStream())
    //        {
    //            using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
    //            {

    //                string aasx = reader.ReadToEnd();
    //                return JsonConvert.DeserializeObject<josns.Root2>(aasx);
    //            }
    //        }
    //    }

    public static async Task<josns.Root2> postaweme(string sid, string cursor)
    {
        string url = $"https://www.douyin.com/aweme/v1/web/aweme/post/?device_platform=webapp&aid=6383&channel=channel_pc_web&sec_user_id={sid}&count=18&max_cursor={cursor}";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36");
        client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
        client.DefaultRequestHeaders.Add("Referer", $"https://www.douyin.com/user/{sid}");
        client.DefaultRequestHeaders.Add("Cookie", "__live_version__=%221.1.0.9449%22; passport_assist_user=CkHGkIA6_w3POUIVJTBZ_Jd_i2caTLfNt3JVkN2_IlrO5YQNE03jD7PNgy4fQ7DnCKV0UapefXjk4dXik4KfxoCwcBpICjypcaUBKhkkC2Li6Cd02kY142UQ3N2873Bw3HNJnJFAg7YMn-3NSoqtHoJlIc867L2BSiFVCLup_5kP8akQ1vyxDRiJr9ZUIgEDMi3srg%3D%3D; n_mh=RcS9dWHJKKZmfc_iJBR9tw-Z73WpX2FnLYylCjO_WNA; sso_uid_tt=412698ba44053e74ec90e2f126b2d93a; sso_uid_tt_ss=412698ba44053e74ec90e2f126b2d93a; toutiao_sso_user=84ef4fb47c46a5043123091c8136e9bc; toutiao_sso_user_ss=84ef4fb47c46a5043123091c8136e9bc; sid_ucp_sso_v1=1.0.0-KDlkOTNhOTk5ODdhNTFiYmE2YWUwOGM4ZmIwZGQ0MDA2NGE5ZTAyMzcKHwiM_KDo9Iy-BRCL97ajBhjvMSAMMPDL04sGOAZA9AcaAmxmIiA4NGVmNGZiNDdjNDZhNTA0MzEyMzA5MWM4MTM2ZTliYw; ssid_ucp_sso_v1=1.0.0-KDlkOTNhOTk5ODdhNTFiYmE2YWUwOGM4ZmIwZGQ0MDA2NGE5ZTAyMzcKHwiM_KDo9Iy-BRCL97ajBhjvMSAMMPDL04sGOAZA9AcaAmxmIiA4NGVmNGZiNDdjNDZhNTA0MzEyMzA5MWM4MTM2ZTliYw; passport_auth_status=3a2439094e06ac4783153a88e7a434f1%2C; passport_auth_status_ss=3a2439094e06ac4783153a88e7a434f1%2C; uid_tt=04627e6a93e31169e1411679aa9bf4b3; uid_tt_ss=04627e6a93e31169e1411679aa9bf4b3; sid_tt=4316b7ea67d4e2b6e240b69c1033789b; sessionid=4316b7ea67d4e2b6e240b69c1033789b; sessionid_ss=4316b7ea67d4e2b6e240b69c1033789b; LOGIN_STATUS=1; store-region=cn-gd; store-region-src=uid; sid_guard=4316b7ea67d4e2b6e240b69c1033789b%7C1684913041%7C5183997%7CSun%2C+23-Jul-2023+07%3A23%3A58+GMT; sid_ucp_v1=1.0.0-KGUzODEwNDRiMTgzZTEzNjhmZDgyMzU2MzQxOTIxZWNmOGU3YmQ5MjUKGwiM_KDo9Iy-BRCR97ajBhjvMSAMOAZA9AdIBBoCaGwiIDQzMTZiN2VhNjdkNGUyYjZlMjQwYjY5YzEwMzM3ODli; ssid_ucp_v1=1.0.0-KGUzODEwNDRiMTgzZTEzNjhmZDgyMzU2MzQxOTIxZWNmOGU3YmQ5MjUKGwiM_KDo9Iy-BRCR97ajBhjvMSAMOAZA9AdIBBoCaGwiIDQzMTZiN2VhNjdkNGUyYjZlMjQwYjY5YzEwMzM3ODli; d_ticket=f5ce5eb09c51ecb3b463e5b8619fc103c8971; my_rd=1; pwa2=%223%7C1%22; s_v_web_id=verify_lih6yb83_W3Fb6iWG_i289_4b4U_8GK4_yXvjy9wCFb1H; passport_csrf_token=8124d099c8e12db47149e27950de19ac; passport_csrf_token_default=8124d099c8e12db47149e27950de19ac; bd_ticket_guard_client_data=eyJiZC10aWNrZXQtZ3VhcmQtdmVyc2lvbiI6MiwiYmQtdGlja2V0LWd1YXJkLWl0ZXJhdGlvbi12ZXJzaW9uIjoxLCJiZC10aWNrZXQtZ3VhcmQtY2xpZW50LWNlcnQiOiItLS0tLUJFR0lOIENFUlRJRklDQVRFLS0tLS1cbk1JSUNGRENDQWJ1Z0F3SUJBZ0lWQUl4bG1qSFFpN2Q1bURDdm1oZGlBM3JhQWw4eE1Bb0dDQ3FHU000OUJBTUNcbk1ERXhDekFKQmdOVkJBWVRBa05PTVNJd0lBWURWUVFEREJsMGFXTnJaWFJmWjNWaGNtUmZZMkZmWldOa2MyRmZcbk1qVTJNQjRYRFRJek1EVXlOREEzTWpNMU5sb1hEVE16TURVeU5ERTFNak0xTmxvd0p6RUxNQWtHQTFVRUJoTUNcblEwNHhHREFXQmdOVkJBTU1EMkprWDNScFkydGxkRjluZFdGeVpEQlpNQk1HQnlxR1NNNDlBZ0VHQ0NxR1NNNDlcbkF3RUhBMElBQlBBZFdCT25pSFQrZG9EUEpLTnBpZUphWnNTYVk4TnlKR2p2NUY5NEpCS3BHUnpKV0NzN0hLRnRcbjhjY1g2akY4VDFEY0N3MU00VERHd21ZSC9sWEkvUFdqZ2Jrd2diWXdEZ1lEVlIwUEFRSC9CQVFEQWdXZ01ERUdcbkExVWRKUVFxTUNnR0NDc0dBUVVGQndNQkJnZ3JCZ0VGQlFjREFnWUlLd1lCQlFVSEF3TUdDQ3NHQVFVRkJ3TUVcbk1Da0dBMVVkRGdRaUJDQ2FXQVo3QU5oaUZoQXhRVFRHTkpZRjRmUlV4WktHaXh2RmQ3eXgxa3BPVFRBckJnTlZcbkhTTUVKREFpZ0NBeXBXZnFqbVJJRW8zTVRrMUFlM01VbTBkdFUzcWswWURYZVpTWGV5SkhnekFaQmdOVkhSRUVcbkVqQVFnZzUzZDNjdVpHOTFlV2x1TG1OdmJUQUtCZ2dxaGtqT1BRUURBZ05IQURCRUFpQm1HcWQwVWJNcWV3cVlcbmZ6OFYvR3o4eHdicWhETS9UK01hMHhmSCsrcFg1QUlnV0liVmtBbTVEZzVRV1hkZkl3YWUvZHFLOTBJbzFCRnFcbmxFSS9NM2FhUHdFPVxuLS0tLS1FTkQgQ0VSVElGSUNBVEUtLS0tLVxuIn0=; ttwid=1%7CWotF8lJnFAb32bpclNXUqbUszFYwapzsk55t26GisyM%7C1686540613%7C80359705e8b4c52619d90269bd5bd4b80c6a596a6af70c0202d87c323865b87c; odin_tt=a1aef9c57d7f5c9219ef0175ec720f2ce38eaf8fa31b86afb4e73315f844168364e4db24a49cb31ff03842f68e49edfd; SEARCH_RESULT_LIST_TYPE=%22single%22; __ac_nonce=0648a813100cca38df1b0; __ac_signature=_02B4Z6wo00f01pNM7JAAAIDD8EYs-mLQ6RaTbOgAAMBlwwnKpT.uWTteBGhQQHyY3OWzXhMKX9qgobbaepYkhfmBS0T3qMMd6fHeClyxriAmjwuSY6TU.tTsSsqFP.EwFWDwkg8rx4C1mOGq6d; strategyABtestKey=%221686798643.701%22; douyin.com; device_web_cpu_core=4; device_web_memory_size=8; webcast_local_quality=null; VIDEO_FILTER_MEMO_SELECT=%7B%22expireTime%22%3A1687403645804%2C%22type%22%3A1%7D; FOLLOW_LIVE_POINT_INFO=%22MS4wLjABAAAAx_KlGEDysM8mMKWw-o8Qeh7hMoOhNHlm3Vb1rpLkZuNZ7A4wOjUzoBwu6C_SxFHU%2F1686844800000%2F0%2F0%2F1686799446257%22; FOLLOW_NUMBER_YELLOW_POINT_INFO=%22MS4wLjABAAAAx_KlGEDysM8mMKWw-o8Qeh7hMoOhNHlm3Vb1rpLkZuNZ7A4wOjUzoBwu6C_SxFHU%2F1686844800000%2F0%2F1686798846258%2F0%22; home_can_add_dy_2_desktop=%221%22; passport_fe_beating_status=true; csrf_session_id=9cc0fa182395ecc6cf0d89de2e61781d; tt_scid=L2xmKUXFn1Qs4OkPvJoUojCH5IJ4b4Af1.ciGIaSssIlIZ5RVZqOD7HRGT7giS1v6b34; download_guide=%221%2F20230615%2F0%22; publish_badge_show_info=%221%2C0%2C0%2C1686798846555%22; msToken=fMVoKDIG88LQkkhpkzZxR7VZ2yEPuIvitb5M7wdQYPmWtSvRY267HsgS07yiEBHpGIfsw9Zb1xlGtNJqbvmWNk0fjt9fWqvxdj5HbhiJEpEHFEELmFTjnp0=; msToken=Ls_W4ziz36MbI8YU2MmTe_xqBXGnV3gYIJfQlE-YH3IrSBWl-g5GLK45D6v0aJgU0Sdze4eXtHtnJF9NtOxFgk1o7djeCi6yTm06PrZkzc-lHg20G3fddTY=");

        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseContent = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<josns.Root2>(responseContent);
    }









    //}



}