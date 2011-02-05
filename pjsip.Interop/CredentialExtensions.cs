using System.Net;

namespace pjsip.Interop
{
    public static class CredentialsExtensions
    {
        public static pjsip_cred_info ToPjsipCredentialsInfo(this NetworkCredential credential)
        {
            return new pjsip_cred_info
            {
                scheme = new pj_str_t("Digest"),
                data_type = 0,
                realm = new pj_str_t(credential.Domain),
                username = new pj_str_t(credential.UserName),
                data = new pj_str_t(credential.Password)
            };
        }

        public static NetworkCredential ToNetworkCredential(this pjsip_cred_info info)
        {
            return new NetworkCredential(info.username, info.data, info.realm);
        }

        public static pj_stun_auth_cred ToStunAuthCredential(this NetworkCredential credential)
        {
            return new pj_stun_auth_cred
            {
                data = new Anonymous_5d329b9d_5b05_4095_9710_1f4fa75f6b7a
                {
                    static_cred = new Anonymous_d82988bb_a2f4_4f34_99ca_ff1053e56d6b
                    {
                        username = new pj_str_t(credential.UserName),
                        data = new pj_str_t(credential.Password),
                        realm = new pj_str_t(credential.Domain),
                        data_type = pj_stun_passwd_type.PJ_STUN_PASSWD_PLAIN
                    }
                }
            };
        }

        public static NetworkCredential ToNetworkCredential(this pj_stun_auth_cred cred)
        {
            return new NetworkCredential(cred.data.static_cred.username, cred.data.static_cred.data,
                                         cred.data.static_cred.realm);
        }
    }
}