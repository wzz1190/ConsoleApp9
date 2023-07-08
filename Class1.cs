using System.Collections.Generic;


namespace josns
{

    //如果好用，请收藏地址，帮忙分享。
    

    public class Avatar_thumb
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Aweme_control
    {
        /// <summary>
        /// 
        /// </summary>
        public string can_comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_forward { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_share { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_show_comment { get; set; }
    }

    public class Cover_urlItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Search_impr2
    {
        /// <summary>
        /// 
        /// </summary>
        public string entity_id { get; set; }
    }

    public class Share_qrcode_url
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Share_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string share_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_desc_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Share_qrcode_url share_qrcode_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_title_myself { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_title_other { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_weibo_desc { get; set; }
    }

    public class Author
    {
        /// <summary>
        /// 
        /// </summary>
        public string accept_private_policy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string account_region { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string apple_account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Avatar_thumb avatar_thumb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar_uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Aweme_control aweme_control { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aweme_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aweme_hotsoon_auth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aweme_hotsoon_auth_relation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> ban_user_functions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string youtube_channel_title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_set_geofencing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string card_entries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string card_entries_not_display { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string card_sort_priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cf_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string with_fusion_shop_entry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string close_friend_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string constellation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contacts_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contrail_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Cover_urlItem> cover_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string custom_verify { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cv_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string data_label_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string display_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string download_prompt_ts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string enable_nearby_visible { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string endorsement_info_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string enterprise_verify_reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string familiar_visitor_user { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string favoriting_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fb_expire_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string follow_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string follower_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string follower_list_secondary_information_struct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string follower_request_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string follower_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string following_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string with_dou_entry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string google_account { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_facebook_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_insights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_orders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_twitter_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_youtube_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hide_search { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string homepage_bottom_toast { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string im_role_ids { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ins_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stringerest_tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_binded_weibo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_blocked_v2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_blocking_v2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_cf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_not_show { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_phone_binded { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string white_cover_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ky_only_predict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string link_item_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string live_agreement { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string live_agreement_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string live_commerce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string live_high_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string live_verify { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string max_follower_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string need_postrings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string need_recommend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string neiguang_shield { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weibo_verify { get; set; }
        /// <summary>
        /// 每天影视解说
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string not_seen_item_id_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string not_seen_item_id_list_v2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string offline_info_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string personal_tag_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weibo_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string prevent_download { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string react_setting { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reflow_page_gid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reflow_page_uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string risk_notice_text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string with_shop_entry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string youtube_channel_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Search_impr search_impr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sec_uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weibo_schema { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Share_info share_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_qrcode_uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shield_comment_notice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shield_digg_notice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shield_follow_notice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weibo_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string show_image_bubble { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string show_nearby_active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_period { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string signature_extra { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string special_follow_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string special_lock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string special_people_labels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string story_open { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string text_extra { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string total_favorited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tw_expire_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string twitter_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string twitter_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_permissions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unique_id_modify_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string youtube_expire_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_canceled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_not_see { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_not_show { get; set; }
    }

    public class Aweme_control2
    {
        /// <summary>
        /// 
        /// </summary>
        public string can_comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_forward { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_share { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_show_comment { get; set; }
    }

    public class Book_bar
    {
    }

    public class Comment_permission_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string can_comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comment_permission_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_detail_entry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string press_entry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string toast_guide { get; set; }
    }

    public class Comment_words_recommend
    {
        /// <summary>
        /// 
        /// </summary>
        public string zero_comment { get; set; }
    }

    public class Danmaku_control
    {
        /// <summary>
        /// 
        /// </summary>
        public string danmaku_cnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string enable_danmaku { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_post_denied { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string post_denied_reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string post_privilege_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string skip_danmaku { get; set; }
    }

    public class Digg_lottie
    {
        /// <summary>
        /// 
        /// </summary>
        public string can_bomb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lottie_id { get; set; }
    }

    public class Distribute_circle
    {
        /// <summary>
        /// 
        /// </summary>
        public string campus_block_stringeraction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string distribute_type { get; set; }
    }

    public class Guide_scene_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string diamond_expose_info_str { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string feed_origin_gid_info_str { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string guide_scene_type { get; set; }
    }

    public class Image_album_music_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string begin_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string end_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string volume { get; set; }
    }

    public class Image_comment
    {
    }

    public class Impression_data
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> group_id_list_a { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> group_id_list_b { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> group_id_list_c { get; set; }
        /// <summary>
        /// 
        /// </summary>
       // public string similar_id_list_a { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> similar_id_list_b { get; set; }
    }

    public class Item_warn_notification
    {
        /// <summary>
        /// 
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string show { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class Avatar_large
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Avatar_medium
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Avatar_thumb2
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Cover_hd
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Cover_large
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Cover_medium
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Cover_thumb
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Luna_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string is_luna_user { get; set; }
    }

    public class Play_url
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url_key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> url_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string width { get; set; }
    }

    public class Search_impr3
    {
        /// <summary>
        /// 
        /// </summary>
        public string entity_id { get; set; }
    }

    public class Music
    {
        /// <summary>
        /// 
        /// </summary>
        public string album { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string artist_user_infos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> artists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string audition_duration { get; set; }
        /// <summary>
        /// 每天影视解说
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string author_deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string author_position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string author_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Avatar_large avatar_large { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Avatar_medium avatar_medium { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Avatar_thumb avatar_thumb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string binded_challenge_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string can_background_play { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collect_stat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cover_hd cover_hd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cover_large cover_large { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cover_medium cover_medium { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cover_thumb cover_thumb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dmv_auto_show { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dsp_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string end_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> external_song_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string extra { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id_str { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_audio_url_with_cookie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_commerce_music { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_del_video { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_matched_metadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_original { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_original_sound { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_pgc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_restricted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_video_self_see { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Luna_info luna_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lyric_short_position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string music_chart_ranks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string music_collect_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string music_cover_atmosphere_color_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string music_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string musician_user_infos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mute_share { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string offline_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string owner_handle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string owner_id { get; set; }
        /// <summary>
        /// 每天影视解说
        /// </summary>
        public string owner_nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pgc_music_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Play_url play_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string prevent_download { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string prevent_item_download_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string preview_end_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string preview_start_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reason_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string redirect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string schema_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Search_impr search_impr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sec_uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shoot_duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string source_platform { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string start_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tag_list { get; set; }
        /// <summary>
        /// @每天影视解说创作的原声
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unshelve_countries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string video_duration { get; set; }
    }

    public class Photo_search_entrance
    {
        /// <summary>
        /// 
        /// </summary>
        public string ecom_type { get; set; }
    }

    public class Search_impr
    {
        /// <summary>
        /// 
        /// </summary>
        public string entity_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string entity_type { get; set; }
    }

    public class Seo_info
    {
    }

    public class Series_paid_info
    {
        /// <summary>
        /// 
        /// </summary>
        public string item_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string series_paid_status { get; set; }
    }

    public class Share_info2
    {
        /// <summary>
        /// 5.35 Uyg:/ 上集# 经典港片 # 影视解说 # 成龙# 吴彦祖  %s 复制此链接，打开Dou音搜索，直接观看视频！
        /// </summary>
        public string share_link_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_url { get; set; }
    }

    public class Show_follow_button
    {
    }

    public class Statistics
    {
        /// <summary>
        /// 
        /// </summary>
        public string admire_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collect_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comment_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string digg_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string play_count { get; set; }
    }

    public class Review_result
    {
        /// <summary>
        /// 
        /// </summary>
        public string review_status { get; set; }
    }

    public class Status
    {
        /// <summary>
        /// 
        /// </summary>
        public string allow_share { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Review_result review_result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string in_reviewing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_delete { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_prohibited { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string listen_video_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string part_see { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string private_status { get; set; }
    }

    public class Text_extraItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hashtag_id { get; set; }
        /// <summary>
        /// 经典港片
        /// </summary>
        public string hashtag_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_commerce { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string start { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class Big_thumbsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public double duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fext { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_x_len { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_x_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_y_len { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_y_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stringerval { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uri { get; set; }
    }

    public class Play_addr
    {
        /// <summary>
        /// 
        /// </summary>
        public string data_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string file_cs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string file_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url_key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> url_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string width { get; set; }
    }

    public class Bit_rateItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string FPS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HDR_bit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HDR_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bit_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gear_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_bytevc1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_h265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Play_addr play_addr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string quality_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string video_extra { get; set; }
    }

    public class Cover
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Dynamic_cover
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Origin_cover
    {
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
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
    }

    public class Play_addr2
    {
        /// <summary>
        /// 
        /// </summary>
        public string data_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string file_cs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string file_hash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url_key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> url_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string width { get; set; }
    }

    public class Video
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Big_thumbsItem> big_thumbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Bit_rateItem> bit_rate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bit_rate_audio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cover cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dynamic_cover dynamic_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string horizontal_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string video_model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_long_video { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_source_HDR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string meta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Origin_cover origin_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Play_addr play_addr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ratio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string use_static_cover { get; set; }
    }

    public class Video_game_data_channel_config
    {
    }

    public class Video_tagItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tag_id { get; set; }
        /// <summary>
        /// 影视
        /// </summary>
        public string tag_name { get; set; }
    }

    public class Aweme_listItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string anchors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string authentication_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Author author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string author_mask_tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string author_user_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Aweme_control aweme_control { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aweme_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aweme_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Book_bar book_bar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string challenge_position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string chapter_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collect_stat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collection_corner_mark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comment_gid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comment_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Comment_permission_info comment_permission_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Comment_words_recommend comment_words_recommend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commerce_config_data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string common_bar_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string component_info_v2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cover_labels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Danmaku_control danmaku_control { get; set; }
        /// <summary>
        /// 上集#经典港片 #影视解说 #成龙#吴彦祖
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Digg_lottie digg_lottie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string disable_relation_bar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dislike_dimension_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dislike_dimension_list_v2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Distribute_circle distribute_circle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string duet_aggregate_in_music_tab { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> geofencing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string geofencing_regions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string group_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string guide_btn_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guide_scene_info guide_scene_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string horizontal_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hybrid_label { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Image_album_music_info image_album_music_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
   //     public Image_comment image_comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string image_infos { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string image_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
      //  public string images { get; set; }
        /// <summary>
        /// 
        /// </summary>
 //       public string img_bitrate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Impression_data impression_data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stringeraction_stickers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_collects_selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_duet_sing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_image_beat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_life_item { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_share_post { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_story { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_top { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Item_warn_notification item_warn_notification { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string label_top_text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string long_video { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Music music { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nickname_position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string origin_comment_ids { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> origin_text_extra { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_images { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string packed_clips { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Photo_search_entrance photo_search_entrance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string prevent_download { get; set; }
        /// <summary>
        /// 上集#经典港片 #影视解说 #成龙#吴彦祖
        /// </summary>
        public string preview_title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string preview_video_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> promotions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ref_tts_id_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ref_voice_modify_id_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string region { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string relation_labels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string report_action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Search_impr search_impr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Seo_info seo_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Series_paid_info series_paid_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Share_info share_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string should_open_ad_report { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Show_follow_button show_follow_button { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string social_tag_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string standard_bar_info_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Statistics statistics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Status status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Text_extraItem> text_extra { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tts_id_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uniqid_position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_digged { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_recommend_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Video video { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Video_game_data_channel_config video_game_data_channel_config { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> video_labels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Video_tagItem> video_tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> video_text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string voice_modify_id_list { get; set; }
    }

    public class Log_pb
    {
        /// <summary>
        /// 
        /// </summary>
        public string impr_id { get; set; }
    }

    public class Root2
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Aweme_listItem> aweme_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_more { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Log_pb log_pb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string max_cursor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string min_cursor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string post_serial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string replace_series_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string request_item_cursor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string status_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string time_list { get; set; }
    }

}