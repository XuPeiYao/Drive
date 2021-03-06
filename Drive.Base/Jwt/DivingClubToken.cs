﻿using System;
using System.Collections.Generic;
using System.Text;
using XWidget.Web.Jwt;

namespace Drive.Base.Jwt {
    public class DriveToken : IJwtToken<DefaultJwtHeader, MvcIdentityPayload> {
        /// <summary>
        /// 主題
        /// </summary>
        public static class Subjects {
            /// <summary>
            /// 管理介面登入
            /// </summary>
            public const string ConsoleLogin = "ConsoleLogin";

            /// <summary>
            /// Download
            /// </summary>
            public const string Download = "Download";
        }

        /// <summary>
        /// 角色
        /// </summary>
        public static class Roles {
            /// <summary>
            /// 系統管理員
            /// </summary>
            public const string Administrator = "Administrator";

            /// <summary>
            /// Download
            /// </summary>
            public const string Download = "Download";

            /// <summary>
            /// 預設
            /// </summary>
            public const string Default = "Default";
        }

        public DefaultJwtHeader Header { get; set; }
        public MvcIdentityPayload Payload { get; set; }
    }
}
