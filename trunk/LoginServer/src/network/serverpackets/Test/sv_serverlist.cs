//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Net;
////using tera.commons.network;


//namespace tera.loginserver.packets.server
//{
//    class sv_serverlist
//    {
//        public byte[] buildPacket(byte[] buf)
//        {
//            PackageBuilder msg = new PackageBuilder();

//            msg.appendHex("08d1a6da")
//                .appendHex(Functions.BytesToHex(buf).Substring(16, 8))
//                .appendInt(0)
//                .appendInt(13)
//                .appendStringValue("serverId")
//                .appendStringValue("serverName")
//                .appendStringValue("serverIP")
//                .appendStringValue("serverPort")
//                .appendStringValue("sortOrder")
//                .appendStringValue("serverType")
//                .appendStringValue("connectionState")
//                .appendStringValue("accountState")
//                .appendStringValue("serverTypeCode")
//                .appendStringValue("connectionStateCode")
//                .appendStringValue("accountStateCode")
//                .appendStringValue("serverState")
//                .appendStringValue("reasonDetail")

//                .appendInt(1) //Servers count
//                ;

//            //Add local server
//            msg.appendInt(13) //Rows num
//                .appendIntValue(1) //Server ID
//                .appendStringValue("TeraEmu local") //Server name
//                .appendStringValue(Functions.IPAddressToNumber("127.0.0.1").ToString()) //Server IP
//                .appendStringValue("11101") //Server port
//                .appendStringValue("-1") // Как сортировать сервера по умолчанию
//                .appendStringValue("::") // Тип сервера
//                .appendStringValue("<font color=\"#00FF00\">ON</font>") //Server status
//                .appendStringValue("<font color=\"#CCFF33\">Yes</font>") //Character creation
//                .appendStringValue("3") //server type code
//                .appendStringValue("2") //connection state code
//                .appendStringValue("2") //account state code
//                .appendStringValue("0") //server state
//                .appendStringValue("Comment") // Описание сервера
//                ;

//            return msg.Build();
//        }
//    }
//}