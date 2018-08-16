using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BarcodeSystemForPC
{
    static class Program
    {
        public static string strUserName = "KIDI";//全局变量存储登录用户
        public static string strUserNo = "16394";
        public static string strUserID = "16394";
        public static bool bLoginOk;//用户登录是否正确

        public static string strServiceUserName = "sa";
        public static string strServicePwd = "kingdee";
        public static string strLoginEmpNo = "";

        public static string BanChanping = "半成品入库";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string strErrMessage = "";
            bool LoginStatus = StaticData.LoadData(ref strErrMessage);

            if (strErrMessage != "" || !LoginStatus)
            {
                MessageBox.Show(string.Format("加载配置文件错误，请检查App.config文件，具体错误为：{0}", strErrMessage), 
                    "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Logion());
            Application.Run(new FrmMain());
            //Logion.StartPosition = FormStartPosition.CenterScreen;
            //Application.Run(new Logion());
        }
    }
}